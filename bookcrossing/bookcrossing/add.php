<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Add Book Listing</title>
    <link rel="stylesheet" href="css/style.css">
</head>

<body>
    <?php include 'header.php'; ?>
    <form class="add-book-form" method="POST" action="lib/add.php" enctype="multipart/form-data">
        <label for="title">Назва:</label>
        <input type="text" name="title" id="title" required>
        <label for="author">Автор:</label>
        <input type="text" name="author" id="author" required>
        <label for="annotation">Анотація:</label>
        <textarea name="annotation" id="annotation"></textarea>
        <label for="id_genre">Жанр:</label>
        <select name="id_genre" id="id_genre" required>
            <?php
            require "lib/db.php";
            $genres = $pdo->query('SELECT * FROM genres')->fetchAll();
            foreach ($genres as $genre) {
                echo "<option value='" . $genre['id'] . "'>" . $genre['name'] . "</option>";
            }
            ?>
        </select>
        <label for="id_publish">Видавництво:</label>
        <select name="id_publish" id="id_publish" required>
            <?php
            $publishers = $pdo->query('SELECT * FROM publishers')->fetchAll();
            foreach ($publishers as $publisher) {
                echo "<option value='" . $publisher['id'] . "'>" . $publisher['name'] . "</option>";
            }
            ?>
        </select>
        <label for="id_type">Тип книги:</label>
        <select name="id_type" id="id_type" required>
            <?php
            $types = $pdo->query('SELECT * FROM types')->fetchAll();
            foreach ($types as $type) {
                echo "<option value='" . $type['id'] . "'>" . $type['name'] . "</option>";
            }
            ?>
        </select>
        <label for="id_age_category">Вікова категорія:</label>
        <select name="id_age_category" id="id_age_category" required>
            <?php
            $age_categories = $pdo->query('SELECT * FROM ages')->fetchAll();
            foreach ($age_categories as $age_category) {
                echo "<option value='" . $age_category['id'] . "'>" . $age_category['name'] . "</option>";
            }
            ?>
        </select>
        <label for="id_binding">Тип обкладинки:</label>
        <select name="id_binding" id="id_binding" required>
            <?php
            $bindings = $pdo->query('SELECT * FROM bindings')->fetchAll();
            foreach ($bindings as $binding) {
                echo "<option value='" . $binding['id'] . "'>" . $binding['name'] . "</option>";
            }
            ?>
        </select>
        <label for="pages">Кількість сторінок:</label>
        <input type="number" name="pages" id="pages" required>

        <label for="cover">Фото обкладинки:</label>
        <input type="file" name="cover" id="cover" accept="image/*" required>

        <label for="id_condition">Стан:</label>
        <select name="id_condition" id="id_condition" required>
            <?php
            $conditions = $pdo->query('SELECT * FROM conditions')->fetchAll();
            foreach ($conditions as $condition) {
                echo "<option value='" . $condition['id'] . "'>" . $condition['name'] . "</option>";
            }
            ?>
        </select>
        <label for="social_network">Соціальна мережа (не обов'язково):</label>
        <input type="url" name="social_network" id="social_network" placeholder="Enter social media link">

        <label for="phone_number">Номер телефону (не обов'язково):</label>
        <input type="text" name="phone_number" id="phone_number">

        <label for="id_city">Місто проживання:</label>
        <select name="id_city" id="id_city" required>
            <?php
            $cities = $pdo->query('SELECT * FROM cities')->fetchAll();
            foreach ($cities as $city) {
                echo "<option value='" . $city['id'] . "'>" . $city['name'] . "</option>";
            }
            ?>
        </select>
        <input type="hidden" name="date_act" value="<?php echo date('Y-m-d'); ?>">
        <button type="submit">Опублікувати</button>
    </form>
    <?php include 'footer.php'; ?>
</body>

</html>