//Запуск плагина меню
//$(function () {

//    $('#menu').metisMenu();

//    $('#menu2').metisMenu({
//        toggle: false
//    });
//});

//Жизнь - это движение
//Чтобы сворачивалось
$("#life").click(function () {
    $("#menu").slideToggle();
});

//Параметры карусели
$('.carousel').carousel({
    interval: 2000,
    pause: 'hover',
    wrap: false
});

//Чтобы карусель останавливаась при выборе картинки
$(".slade").click(function () {
    $("#my-carousel").carousel('pause');
});