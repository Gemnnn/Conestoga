call cordova platform add android

@REM uncomment following comments by removing @REM as necessary
@REM add more plugins if necessary
@REM -----------------------------------------------------
call cordova plugin add cordova-plugin-splashscreen
@REM call cordova plugin add cordova-plugin-geolocation
@REM call cordova plugin add cordova-plugin-camera
@REM -----------------------------------------------------
call cordova run android
call cordova platform rm android
call cordova platform add android
call cordova run android
