function onReady() {
    $("iframe").height($(window).height() - 100);
    $(window).resize(function () {
        $("iframe").height($(window).height() - 100);
    });
};

function loadInModal(url) {
    $("#iframefooter").attr("src", url);
    $("#FrameModal").modal();
};