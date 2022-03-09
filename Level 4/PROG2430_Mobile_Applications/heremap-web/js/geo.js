var lat;
var lng;
var alt;

function showMap() {
    // Initialize the platform object:
    var platform = new H.service.Platform({
        'apikey': 'fArIYSjbaYioQOUEd5hZZSanD7xZ3cyhnAbjgNXDTvY'
    });
// Obtain the default map types from the platform object
    var maptypes = platform.createDefaultLayers();
// Instantiate (and display) a map object:
    var map = new H.Map(
        document.getElementById('mapContainer'),
        maptypes.vector.normal.map,
        {zoom: 15,
            center: {
                lng: lng,
                lat: lat
            }
        });
    var icon = new H.map.Icon('img/Thor-icon.png');
    var marker = new H.map.Marker({
        lat: lat, lng: lng
    }, {icon: icon});
// Add the marker to the map and center the map at the location of the marker:
        map.addObject(marker);
}
function getPosition() {
    console.info("getPosition()");
    try {
        if (navigator.geolocation !== null) {
            //for high accuracy
            var options = {
                enableHighAccuracy: true,
                timeout: 60000,
                maximumAge: 0
            };
            function onSuccess(position) {
                var coordinates = position.coords;
                lat = coordinates.latitude;
                lng = coordinates.longitude;
                alt = coordinates.altitude;
                // function showPosition() {
                //     console.info("latitude: " + lat);
                //     console.info("longitude: " + lng);
                //     console.info("altitude: " + alt);
                // }
                // showPosition();
                console.info("latitude: " + lat);
                console.info("longitude: " + lng);
                console.info("altitude: " + alt);
                showMap();
            }
            function onFail(error) {
                var msg = "";
                try {
                    if (error) {
                        switch (error.code) {
                            case error.TIMEOUT:
                                msg = "TIMEOUT: " + error.message;
                                break;
                            case error.PERMISSION_DENIED:
                                msg = "PERMISSION DENIED: " +
                                error.message;
                                break;
                            case error.POSITION_UNAVAILABLE:
                                msg = "POSITION UNAVAILABLE: " + error.message;
                                break;
                            default:
                                msg = "UNHANDLED MESSAGE CODE (" + error.code + "): " + error.message;
                                break;
                        }
                        console.error(msg);
                    }
                }
                catch (e) {
                    console.error("Exception (geolocationError): " +
                        e);
                }
            }
            navigator.geolocation.getCurrentPosition(onSuccess,
                onFail, options);
        }
        else {
            console.error("HTML5 geolocation is not supported.");
        }
    }
    catch (e) {
        console.error("exception (getPosition): " + e);
    }
}