//Запуск плагина меню
$(function () {

    //$('#menu').metisMenu();

    $('#menu').metisMenu({ 
        // enabled/disable the auto collapse.
        toggle: false, 
    // prevent default event
    //preventDefault: true,
    // default classes
    //activeClass: 'active',
    //collapseClass: 'collapse',
    //collapseInClass: 'in',
    //collapsingClass: 'collapsing',
    // .nav-link for Bootstrap 4
    //triggerElement: 'a',
    // .nav-item for Bootstrap 4
    //parentTrigger: 'li',
    // .nav.flex-column for Bootstrap 4
    //subMenu: 'ul'
});


    //$('#menu2').metisMenu({
    //    toggle: false
    //});
});

//Жизнь - это движение
//Чтобы сворачивалось
//$("#life").click(function () {
//    $("#menu").slideToggle();
    //$("#menu2").hide();
//});

//СФА
//Чтобы сворачивалось
//$("#spa").click(function () {
//    $("#menu2").slideToggle();
    //$("#menu").hide();
//});

//Параметры карусели
$('.carousel').carousel({
    //интервала времени между переключением слайдов
    interval: 2000,
    //переключение слайдов останавливается, когда мышь находится над слайдером
    pause: 'hover',
    //следует ли возобновить переключение слайдов, если конец списка слайдов будет достигнут
    wrap: false
});

//Чтобы карусель останавливаась при выборе картинки
$(".slade").click(function () {
    $("#my-carousel").carousel('pause');
});