<?php
if (!isset($_COOKIE['id_user'])) {
    header('Location: auth.php');
    exit();
}

require "db.php";

$id_user = $_COOKIE['id_user'];
$title = trim(filter_var($_POST['title'], FILTER_SANITIZE_SPECIAL_CHARS));
$author = trim(filter_var($_POST['author'], FILTER_SANITIZE_SPECIAL_CHARS));
$annotation = trim(filter_var($_POST['annotation'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_genre = trim(filter_var($_POST['id_genre'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_publish = trim(filter_var($_POST['id_publish'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_type = trim(filter_var($_POST['id_type'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_age_category = trim(filter_var($_POST['id_age_category'], FILTER_SANITIZE_SPECIAL_CHARS));
$pages = trim(filter_var($_POST['pages'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_binding = trim(filter_var($_POST['id_binding'], FILTER_SANITIZE_SPECIAL_CHARS));
$social_network = trim(filter_var($_POST['social_network'], FILTER_SANITIZE_SPECIAL_CHARS));
$phone_number = trim(filter_var($_POST['phone_number'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_condition = trim(filter_var($_POST['id_condition'], FILTER_SANITIZE_SPECIAL_CHARS));
$id_city = trim(filter_var($_POST['id_city'], FILTER_SANITIZE_SPECIAL_CHARS));
$date_act = $_POST['date_act'];

$cover_path = ''; 
if (isset($_FILES['cover']) && $_FILES['cover']['error'] == 0) {
    $file_tmp_name = $_FILES['cover']['tmp_name'];
    $file_name = $_FILES['cover']['name'];
    $file_extension = strtolower(pathinfo($file_name, PATHINFO_EXTENSION));
    $allowed_extensions = ['jpg', 'jpeg', 'png', 'gif'];

    if (in_array($file_extension, $allowed_extensions)) {
        $new_file_name = uniqid('cover_') . '.' . $file_extension;
        $upload_dir = 'uploads/covers/';
        if (!is_dir($upload_dir)) {
            mkdir($upload_dir, 0777, true); 
        }

        if (move_uploaded_file($file_tmp_name, $upload_dir . $new_file_name)) {
            $cover_path = $upload_dir . $new_file_name; 
        }
    }
}

$sql = 'INSERT INTO books (title, author, annotation, id_genre, id_type) VALUES (?, ?, ?, ?, ?)';
$query = $pdo->prepare($sql);
$query->execute([$title, $author, $annotation, $id_genre,$id_type]);
$book_id = $pdo->lastInsertId();

$sql = 'INSERT INTO copies_of_books (id_book, id_publish, id_age_category, id_binding, pages, cover) 
        VALUES (?, ?, ?, ?, ?, ?)';
$query = $pdo->prepare($sql);
$query->execute([$book_id, $id_publish, $id_age_category, $id_binding, $pages, $cover_path]);

$id_copies_of_books = $pdo->lastInsertId();

$sql = 'INSERT INTO contact_users (social_network, phone_number) VALUES (?, ?)';
$query = $pdo->prepare($sql);
$query->execute([$social_network, $phone_number]);

$id_contact = $pdo->lastInsertId();

$sql = 'INSERT INTO ads (id_user, id_copies_of_books, id_condition, id_city, id_contact, date_act) 
        VALUES (?, ?, ?, ?, ?, ?)';
$query = $pdo->prepare($sql);
$query->execute([$id_user, $id_copies_of_books, $id_condition, $id_city, $id_contact, $date_act]);
header('Location: /bookcrossing/library.php');
exit();
