function btnShow_click() {
    getPosition();
}

function init() {
    console.info("init");
    $("#btnShow").on("click", btnShow_click);
}

$(document).ready(function () {
    init();
});