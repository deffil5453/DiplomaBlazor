function initMap() {
    ymaps.ready(function () {
        var myMap = new ymaps.Map("map", {
            center: [80.76, 80.64], // координаты центра карты
            zoom: 9
        });

        myMap.events.add('click', function (e) {
            var coords = e.get('coords');
            myMap.geoObjects.removeAll();
            var myPlacemark = new ymaps.Placemark(coords);
            myMap.geoObjects.add(myPlacemark);

            DotNet.invokeMethodAsync('YourAppNamespace', 'UpdateCoordinates', coords[0], coords[1]);
        });
    });
}

window.mapFunctions = {
    initMap: initMap
}