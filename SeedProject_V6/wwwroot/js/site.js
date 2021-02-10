var carousel = document.getElementById("main-carousel");
var offers = document.querySelectorAll(".offer");
var navbar = document.getElementById("navbar");

document.addEventListener("DOMContentLoaded", function (event) {
    var carousel_height = carousel.clientHeight;

    if (window.innerWidth < 780) {
        for (var i = 0; i < offers.length; i++) {
            offers[i].style.height = 120 + "px"
        }
    }
    if (window.innerWidth < 400) {
        navbar.classList.remove("sticky-top")
        for (var i = 0; i < offers.length; i++) {
            offers[i].style.height = 145 + "px"
        }
    } else {
        for (var i = 0; i < offers.length; i++) {
            offers[i].style.height = carousel.clientHeight / 4 + "px"
        }
    }


    window.addEventListener('resize', function () {
        if (window.innerWidth > 780) {
            for (var i = 0; i < offers.length; i++) {
                offers[i].style.height = carousel.clientHeight / 4 + "px"
            }
        }
        if (window.innerWidth < 780) {
            for (var i = 0; i < offers.length; i++) {
                offers[i].style.height = 120 + "px"
            }
        }
        if (window.innerWidth < 400) {
            for (var i = 0; i < offers.length; i++) {
                offers[i].style.height = 145 + "px"
            }
        }

    }, true);

});