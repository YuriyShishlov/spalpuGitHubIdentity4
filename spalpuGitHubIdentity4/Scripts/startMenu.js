﻿//Запуск плагина меню
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