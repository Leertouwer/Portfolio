
$(document).ready(function () {
    $(function () {
        $('[data-toggle="popover"]').popover()
    });
    $("[rel='tooltip']").tooltip();

    //var popper=new Popover
    //var popper = new Popper("table",onPopper, { placement:'right' });
    $(function () {
        $('.example-popover').popover({
            container: 'body'
        });
    });
});

function ChangeLetterType() {
    $("h1").addClass("display-1");
    $("h2").addClass("display-2");
    $("h3").addClass("display-3");
    $("h4").addClass("display-4");
}

function RemoveLetterType() {
    $("h1").removeClass();
    $("h2").removeClass();
    $("h3").removeClass();
    $("h4").removeClass();
}

function MakeTableWhite() {
    $("thead").removeClass();
    $("thead").addClass("thead-dark");
    $("#maintable").removeClass();
    $("#maintable").addClass("table-light table-striped table-hover");
}

function MakeTableBlack() {
    $("thead").removeClass();
    $("thead").addClass("thead-light");
    $("#maintable").removeClass();
    $("#maintable").addClass("table-dark table-striped table-hover");
}
