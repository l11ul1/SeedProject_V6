$(document).ready(function () {
    $('.customer-logos').slick({
        infinite: true,
        slidesToShow: 6,
        slidesToScroll: 2,
        autoplay: true,
        autoplaySpeed: 1500,
        arrows: false,
        dots: false,
        pauseOnHover: false,
        responsive: [{
            breakpoint: 1000,
            settings: {
                slidesToShow: 4,
                
            }
        }, {
            breakpoint: 770,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1
            }
            }, {
                breakpoint: 450,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }]
    });
});
