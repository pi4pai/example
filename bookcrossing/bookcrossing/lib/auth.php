<?php
$login = trim(filter_var($_POST['login'], FILTER_SANITIZE_SPECIAL_CHARS));
$password = trim(filter_var($_POST['password'], FILTER_SANITIZE_SPECIAL_CHARS));

if(strlen($login)<2){
    echo "Login error";
    exit;
}

if(strlen($password)<2){
    echo "Password error";
    exit;
}

require "db.php";

$sql = 'SELECT id FROM users WHERE login = ? AND password = ?';
$query = $pdo->prepare($sql);
$query->execute([$login, $password]);

if ($query->rowCount() == 0) {
    echo "Користувача не існує";
} else {
    $user = $query->fetch();
    $id_user = $user['id'];
    setcookie('login', $login, time() + 3600, "/");
    setcookie('id_user', $id_user, time() + 3600, "/");
    header('Location: /bookcrossing/about.php');
    exit();
}


