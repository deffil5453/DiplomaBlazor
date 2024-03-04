function initMap() {
    ymaps.ready(function () {
        var myMap = new ymaps.Map("map", {
            center: [47.516905, 42.209749],
            zoom: 5
        });

        myMap.events.add('click', function (e) {
            var coords = e.get('coords');

            if (window.myPlacemark) {
                myMap.geoObjects.remove(window.myPlacemark);
            }

            window.myPlacemark = new ymaps.Placemark(coords);
            myMap.geoObjects.add(window.myPlacemark);
            
            ymaps.geocode(coords).then(function (res) {
                var firstGeoObject = res.geoObjects.get(0);
                
                var addressComponents = firstGeoObject.properties.get('metaDataProperty.GeocoderMetaData.Address.Components');
                var region = '';
                var city = '';
                
                addressComponents.forEach(function (component) {
                    if (component.kind === 'province') {
                        region = component.name;
                    }
                    if (component.kind === 'locality') {
                        city = component.name;
                    }
                });

                var address = firstGeoObject.getAddressLine();

                // Передача данных в Blazor
                DotNet.invokeMethodAsync('DiplomaRealEstate', 'ReceiveMapData', coords[0].toString(), coords[1].toString(), region, city);
            });
        });
    });
}
window.startMap = startMap;