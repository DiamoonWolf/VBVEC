<?php
$adminPassword = "Tb6df*apxJN@rjD^";
$getPass = $_GET['adminPassword'];
$user = $_GET['user'];
$value = $_GET['value'];
$newName = $_GET['newName'];
$newPassword = $_GET['newPassword'];
if ($getPass != $adminPassword) die("ERROR:ADMIN_PASSWORD_INCORRECT");

if (empty($_GET['sessionID'])) die("ERROR:INVALID_SESSION_ID");

    $admin = new admin;

if($_GET['action'] == 'ban')
    $response = $admin->ban($user);
elseif($_GET['action'] == 'unban')
    $response = $admin->unban($user);
elseif($_GET['action'] == 'changePremium')
    $response = $admin->changePremium($user, $value);
elseif($_GET['action'] == 'changeUsername')
    $response = $admin->changeUsername($user, $newName);
elseif($_GET['action'] == 'changePassword')
    $response = $admin->changePassword($user, $newPassword);
elseif($_GET['action'] == 'createRegisterKey')
    $response = $admin->createregisterKey();
elseif($_GET['action'] == 'getUsersInfo')
    $response = $admin->getUsersInfo();
elseif($_GET['action'] == 'getKeysInfo')
    $response = $admin->getKeysInfo();
elseif($_GET['action'] == 'removeUser')
    $response = $admin->removeUser($user);
else
    $response = "ERROR:NO_ACTION";

echo rc4($_GET['sessionID'], $response);



    class admin {
        
        public $bdd;
        
        public function admin()
        {
           try {$this->bdd = new PDO('mysql:host=localhost;dbname=nombdd;', 'root', 'pass');}		
           catch (Exception $ex) {die('ERROR:ERROR_BDD_CONNECTION');}
        }

        public function getUsersInfo()
        {
            $json = Array();

            $response = $this->executeQuery("SELECT * FROM users;", NULL, false);
            $json = $response->fetchAll(PDO::FETCH_ASSOC);

            $result = json_encode($json);
            $response->closeCursor();
            return ("OK:". $result);

        }
		
		 public function getKeysInfo()
        {
            $json = Array();

            $response = $this->executeQuery("SELECT * FROM RegisterKeys;", NULL, false);
            $json = $response->fetchAll(PDO::FETCH_ASSOC);

            $result = json_encode($json);
            $response->closeCursor();
            return ("OK:". $result);

        }

        public function createregisterKey()
        {
            $registerKey = "";
            do {
            $registerKey = "2020VEC".$this->randomChar(5);// creation de la clé de license
            $data = $this->executeQuery("SELECT * FROM RegisterKeys WHERE RegisterKey = ?;", array($registerKey));
            }while (!empty($data['RegisterKey']));

            $this->executeQuery("INSERT INTO RegisterKeys VALUES ('', ?, '');", array($registerKey));
            return ("OK:".$registerKey);

        }
        
        public function ban($user)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("UPDATE users SET status = 1 WHERE username = ?;", array($user));
            return "OK:BANNED";
        }

        public function unban($user)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("UPDATE users SET status = 0 WHERE username = ?;", array($user));
            return "OK:UNBANNED";
        }

        public function changePremium($user, $value)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("UPDATE users SET membership = ? WHERE username = ?;", array($value, $user));
            return "OK:CHANGED";
        }

        public function changeUsername($user, $newName)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("UPDATE users SET username = ? WHERE username = ?;", array($newName, $user));
            return "OK:CHANGED";
        }

        public function changePassword($user, $newPass)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("UPDATE users SET password = ? WHERE username = ?;", array(SHA1($newPass), $user)); //CHANGE HASH METHOD
            return "OK:CHANGED";
        }

        public function removeUser($user)
        {
            if (!$this->userExist($user)) return ("ERROR:USER_NOT_FOUND");

            $this->executeQuery("DELETE FROM users WHERE username = ?;", array($user)); 
            return "OK:REMOVED";
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
        Private function randomChar($lenght = 10)
        {
            $characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            $result = '';
            for ($i = 0; $i < $lenght; $i++)
                $result .= $characters[rand(0, strlen($characters) - 1)];
            return($result);

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

    ?>
