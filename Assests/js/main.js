


// Begin scroll
window.onscroll = function() {myFunction()};
        
var navbar = document.getElementById("menu");
var sticky = navbar.offsetTop;
        
function myFunction() {
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky")
    } else {
        navbar.classList.remove("sticky");
    }
}
// End scroll


//begin scroll to top
// BY KAREN GRIGORYAN

$(document).ready(function() {
  
    // declare variable
    var scrollTop = $(".scrollTop");

    $(window).scroll(function() {//sự kiện cuộn chuột
        if ($(window).scrollTop() > 500) {//nếu lướt xa hơn 500px
            scrollTop.css("opacity", "1");
        } else {
            scrollTop.css("opacity", "0");
        }
      });

    //Click event to scroll to top
    $(scrollTop).click(function() {
      $('html, body').animate({
        scrollTop: 0
      }, 500);
      return false;
  
    }); // click() scroll top EMD
})
//end scroll to top

// Khi chuyen vao trang chi tiet san pham
function openChiTietSanPham(elm){
var tensp = elm.parent().find('.woocommerce-loop-product__title').html();
var gia = elm.parent().find('.price').html();
var thanhphan = elm.parent().find('.thanhphan').html();
var loaithucdon = elm.parent().find('.loaithucdon').html();
var img = elm.find('img').attr('src');
localStorage.setItem("tenspi4",tensp);
localStorage.setItem("giaspi4",gia);
localStorage.setItem("tpspi4",thanhphan);
localStorage.setItem("loaitdi4",loaithucdon);
localStorage.setItem("imgi4",img);
}


$(".kichco").click(function()
{
    $(".kichco").css("color","#959595")
    $(this).css("color","#c00a27")
    localStorage.setItem("sizei4",$(this).html());
})

function doimenu(elm)
{
    $('.tabs_nav.ui-tabs-nav.clearfix').removeClass('ui-tabs-active')
    $('.wrapper.ui-tabs.clearfix div').removeClass('ui-tabs-body-active')
    var chon=elm.attr('class')
    $('#'+chon).addClass('ui-tabs-body-active')
    elm.parent().addClass('ui-tabs-active')
}


