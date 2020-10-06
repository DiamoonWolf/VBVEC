<?php

	$sessionID = $_GET['sessionID'];
    $actionget = $_GET['action'];
	$email = $_GET['email'];
    $user = $_GET['user'];
    $pass = $_GET['password'];
	$generated = $_GET['generated'];
    $registerKey = $_GET['registerKey'];

	
    if (empty($sessionID)) die ("ERROR:INVALID_SESSION_ID");
    $action = new action;
    if ($actionget == "connect")
        $response = $action->connect($user, $pass);
    elseif ($actionget == "register")
        $response = $action->register($user, $pass, $registerKey, $email);
 	elseif ($actionget == "set")
        $response = $action->setd($user, $generated);
    else
        $response = "ERROR:NO_ACTION";

    echo rc4($sessionID, $response);

    class action {
        
        public $bdd;
        
        public function action()
        {
           try {$this->bdd = new PDO('mysql:host=localhost;dbname=nombdd;', 'root', 'pass');}	
				

           catch (Exception $ex) {die('ERROR:ERROR_BDD_CONNECTION');}
        }
		
		public function setd($user, $generated)
		{
			
			 if (!$this->userExist($user)) return("ERROR:USER_NOT_FOUND");
			 $data = $this->executeQuery("SELECT * FROM users WHERE username = ?;", array($user));
			if ($data['status'] == 1){ //Si il est banni
                return("ERROR:USER_BANNED");
            }else{ //Si il ne l'est pas, on affiche OK: et son statut (Banni/Premium/Normal...)
               
				 $data = $this->executeQuery("UPDATE `users` SET `generated`=`generated`+1 WHERE `username` = ?;", array($user));
				 
				return("OK:");
            }
		}

        public function connect($user, $pass) //Connection
        {
			
			
            if (!$this->userExist($user)) return("ERROR:USER_NOT_FOUND");

            $data = $this->executeQuery("SELECT * FROM users WHERE username = ?;", array($user));
            if ($data['password'] != SHA1($pass)) //CHANGER METHODE DE HASHAGE
            {
                return("ERROR:INCORRECT_PASSWORD");

            }elseif ($data['status'] == 1){ //Si il est banni
                return("ERROR:USER_BANNED");
            }else{ //Si il ne l'est pas, on affiche OK: et son statut (Banni/Premium/Normal...)
                return("OK:"). $data['membership'];
            }


        }
		
		public function exp_test ()
		{
            // Y'a un truc qui va pas
			$data = $this->executeQuery("SELECT * RegistrationDate FROM users;");
										
			$expire = strtotime($ex_date. ' + 2 days');
			$today = strtotime("today midnight");

			if($today >= $expire){
				echo "expired";
			} else {
				echo "active";
			}
			
		}
		
		
        public function register($user, $pass, $registerKey, $email) //Register
        {
			
			$DateExp = new DateTime();
			$DateExp = $DateExp->getTimestamp() + 86400 * 30; 
			
			
            //Vérification de la clé de license
            $data = $this->executeQuery("SELECT * FROM RegisterKeys WHERE R_Key = ?;", array($registerKey));
            if (empty($data['R_Key'])) return ("ERROR:INVALID_KEY");
            if (!empty($data['User'])) return ("ERROR:KEY_ALREADY_USED");
            //Vérification si l'utilisateur existe déjà
            if ($this->userExist($user)) return("ERROR:USER_ALREADY_EXIST");

            $this->executeQuery("INSERT INTO users VALUES ('',?, ?, ?,'0','0','0', ?, ?, '0', NULL);", array($user, SHA1($pass), $email, getTime(), $DateExp)); //CHANGE HASH METHOD 
			
		
			$this->executeQuery("UPDATE RegisterKeys SET User = ? WHERE R_Key = ?;", array($user, $registerKey)); 
			
            return ("OK:REGISTERED");
        }


        private function userExist($user)
        {
            
           $data = $this->executeQuery("SELECT * FROM users WHERE username = ?;", array($user));
			
           if (empty($data['username']))
           {
               return (false);
           }else{
               return (true);
           }
        }
        private function executeQuery($query, $args, $fetch = true)
        {
            $response = $this->bdd->prepare($query);
            $response->execute($args);
			
			
			

            if ($fetch){
                $data = $response->fetch();
                $response->closeCursor();
				
                return ($data);
				
               
            }
			else
				return ($response);
        }

    }


    function rc4($key, $str) {
        $s = array();
        for ($i = 0; $i < 256; $i++) {
        $s[$i] = $i;
        }
        
        $j = 0;
        
        for ($i = 0; $i < 256; $i++) {
        $j = ($j + $s[$i] + ord($key[$i % strlen($key)])) % 256;
        $x = $s[$i];
        $s[$i] = $s[$j];
        $s[$j] = $x;
        }
        
        $i = 0;
        $j = 0;
        $res = '';
        
        for ($y = 0; $y < strlen($str); $y++) {
        $i = ($i + 1) % 256;
        $j = ($j + $s[$i]) % 256;
        $x = $s[$i];
        $s[$i] = $s[$j];
        $s[$j] = $x;
        $res .= $str[$y] ^ chr($s[($s[$i] + $s[$j]) % 256]);
        }
        
        return $res;
        }

    function getTime()
    {
        date_default_timezone_set('Europe/Paris');
        return date("Y-m-d H:i:s");
    }
    ?>
