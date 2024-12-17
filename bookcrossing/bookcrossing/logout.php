<?php
setcookie('login', '', time() - 3600, "/"); 
header('Location: auth.php');
exit();
?>
