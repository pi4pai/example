<?php
require "lib/db.php";
$ads = [];
$sql = 'SELECT ads.id, books.title, books.author, copies_of_books.cover, cities.lat, cities.lng, cities.name AS city_name, users.login
        FROM ads
        JOIN copies_of_books ON ads.id_copies_of_books = copies_of_books.id
        JOIN books ON copies_of_books.id_book = books.id
        JOIN cities ON ads.id_city = cities.id
        JOIN users ON ads.id_user = users.id
        WHERE ads.date_deact IS NULL';
$query = $pdo->prepare($sql);
$query->execute();
$ads = $query->fetchAll(PDO::FETCH_ASSOC);

?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Карта оголошень</title>
    <link rel="stylesheet" href="https://unpkg.com/leaflet/dist/leaflet.css" />
    <link rel="stylesheet" href="css/mapa.css">
</head>
<body>
<?php include 'header.php'; ?>
<div class="container">
    <h2>Карта оголошень</h2>

    <div id="map"></div>

    <script src="https://unpkg.com/leaflet/dist/leaflet.js"></script>
    <script>
        const map = L.map('map').setView([48.3794, 31.1656], 5);
        L.tileLayer('https://{s}.basemaps.cartocdn.com/light_all/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '© OpenStreetMap contributors, © CartoDB'
        }).addTo(map);
        const ads = <?php echo json_encode($ads); ?>;

        ads.forEach(ad => {
    if (ad.lat && ad.lng) {
        const offsetLat = (Math.random() - 0.10) * 0.10;
        const offsetLng = (Math.random() - 0.10) * 0.10;
        const marker = L.marker([parseFloat(ad.lat) + offsetLat, parseFloat(ad.lng) + offsetLng], {
            icon: L.icon({
                iconUrl: 'http://localhost/bookcrossing/img/pin.PNG',
                iconSize: [45, 45],
                iconAnchor: [12, 41],
                popupAnchor: [1, -34],
                shadowUrl: 'https://cdnjs.cloudflare.com/ajax/libs/leaflet/1.7.1/images/marker-shadow.png',
                shadowSize: [45, 45],
                shadowAnchor: [5, 41],
            })
        }).addTo(map).bindPopup(`
            <div class="popup-content">
                <img src="http://localhost/bookcrossing/lib/${ad.cover}" alt="Обкладинка книги" class="cover-image">
                <div class="book-details">
                    <b>${ad.title}</b><br>
                    Автор: ${ad.author}<br>
                    Місто: ${ad.city_name}<br>
                    Користувач: ${ad.login}<br> 
                </div>
            </div>
        `);
    }
});

    </script>
    </div>
     <?php include 'footer.php'; ?>
</body>
</html>
