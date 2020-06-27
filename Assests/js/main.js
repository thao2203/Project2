
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

function openChiTietSanPham(elm){
var tensp= elm.parent().find('.woocommerce-loop-product__title').html()
var gia= elm.parent().find('#giaSize').html()
var thanhphan= elm.parent().find('.thanhphan').html()
var img =elm.find('img').attr('src')
localStorage.setItem("tenspi4",tensp);
localStorage.setItem("giaspi4",gia);
localStorage.setItem("tpspi4",thanhphan);
localStorage.setItem("imgi4",img);

}

$(".kichco").click(function()
{
    $(".kichco").css("color","#959595")
    $(this).css("color","#c00a27")
    localStorage.setItem("sizei4",$(this).html());
})

$(".kichco").click(function()
{
    localStorage.setItem("sizei4",$(this).html());
})