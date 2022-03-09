function btnCapturePhoto_click() {
    capturePhoto();
}

function btnCapturePhotoEdit_click() {
    captureEditablePhoto();
}

function btnLoadFromLibrary_click() {
    loadFromPhotoLibrary();
}

function init() {
    $("#btnCapturePhoto").on("click", btnCapturePhoto_click);
    $("#btnCapturePhotoEdit").on("click", btnCapturePhotoEdit_click);
    $("#btnLoadFromLibrary").on("click", btnLoadFromLibrary_click);
}

$(document).ready(function () {
    init();
});
