<div class="top-bar">
    <div class="date">
        <?php echo date("d.m.Y"); ?>
    </div>
    <?php
    if(isset($_COOKIE['login']))
    echo '<a href="logout.php" class="logout-button">Вийти</a>';
    else
    echo '';
    ?>
</div>
<header>
    <div class="header-image">
        <img src="img/registration2.png" alt="Header Image">
        <div class="container">
            <nav>
                <ul>
                    <li><a href="about.php">Про нас</a></li>

                    <?php
                    if(isset($_COOKIE['login']))
                    echo '<li><a href="mapa2.php">Мапа</a></li>
                          <li><a href="book.php">Пошук</a></li>
                          <li><a href="library.php">Мої оголошення</a></li>';
                    else
                    echo '<li><a href="mapa.php">Мапа</a></li>
                          <li><a href="register.php">Рестрація</a></li>
                          <li><a href="auth.php">Вхід</a></li>';
                    ?>
                </ul>
            </nav>
        </div>
    </div>
</header>
