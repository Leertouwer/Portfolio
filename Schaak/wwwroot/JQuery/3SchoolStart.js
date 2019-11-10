
$(window).ready(function () {
    resizetable();
    $("td.zwart").click(function () {
        towit(this);
    });
    $("td.wit").click(function () {
        tozwart(this);
    });

    $("p").click(function () {
        $(this).hide();
    });
});

$(window).resize(function () {
    resizetable();
});

function myFunction() {
    var documentWidth = $(window).width();
    alert(documentwidth);
    $("#mainbord").width(documentWidth - 110);
    $("#mainbord").height(documentWidth - 110);
};

function resizetable() {
    var w = $(window).width();
    var h = $(window).height();
    var s = w > h ? h : w;
    var c = 70;
    s = s - c;
    $("#mainbord").width(s);
    $("#mainbord").height(s);
}

function towit(dit) {
    $(dit).addClass("wit");
    $(dit).removeClass("zwart");
    $(dit).on("click", function () { tozwart(this); });
}
function tozwart(dit) {
    $(dit).addClass("zwart");
    $(dit).removeClass("wit");
    $(dit).on("click", function () { towit(this); });
}