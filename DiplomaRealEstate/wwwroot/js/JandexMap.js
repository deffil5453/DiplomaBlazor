// ~/wwwroot/js/YandexMap.js
// В файле `wwwroot/js/mapInteraction.js`

function initMap() {
    ymaps.ready(function () {
        var myMap = new ymaps.Map("map", {
            center: [55.76, 37.64], // замените на желаемые координаты
            zoom: 10
        });

        // Обработчик клика по карте
        myMap.events.add('click', function (e) {
            var coords = e.get('coords');

            // Здесь может быть логика для получения информации о здании по координатам
            // Используйте методы JavaScript API Яндекс.Карт для определения адреса или других данных объекта, если доступны

            // Передача данных в Blazor компонент
            DotNet.invokeMethodAsync('DiplomaRealEstate', 'ReceiveMapData', coords[0], coords[1]);
        });
    });
}

// Используем явный экспорт, чтобы обеспечить доступ глобально
window.startMap = startMap;