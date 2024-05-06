window.initMap = function (dotNetObjRef) {
    ymaps.ready(function () {
        var myMap = new ymaps.Map('map', {
            center: [55.76, 37.64], // Координаты по умолчанию
            zoom: 9
        });

        var myPlacemark = new ymaps.Placemark([55.76, 37.64], {
            hintContent: 'местоположение метки'
        }, {
            draggable: false
        });

        myMap.geoObjects.add(myPlacemark);

        function setPlacemarkCoords(coords) {
            myPlacemark.geometry.setCoordinates(coords);
            dotNetObjRef.invokeMethodAsync('SetCoordinates', coords[0].toString(), coords[1].toString());
        }

        myPlacemark.events.add('dragend', function (e) {
            var coords = myPlacemark.geometry.getCoordinates();
            setPlacemarkCoords(coords);
        });

        myMap.events.add('click', function (e) {
            var coords = e.get('coords');
            setPlacemarkCoords(coords);
        });
    });
}