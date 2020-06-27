var gia;
var sl;
function thaysl(elm)
{
   sl= elm.val()
}
function themgio(elm)
{  var html;
       var anh=elm.parent().parent().parent().parent().parent().parent().find(".anhsp1 a img").attr('src')
      var kichco=elm.parent().parent().parent().parent().parent().parent().find("ul.chitiet li:nth-child(3) span").html() 
      var ten=elm.parent().parent().parent().parent().parent().parent().find(".chitietsp.column.col-sm-4 h1").html() 
         sl=elm.parent().parent().parent().parent().parent().parent().find(".input-text.qty.text").val() 
      var price=elm.parent().parent().parent().parent().parent().parent().find("ul.chitiet li:nth-child(4) .giachon").html()
      gia= Number(price)*Number(sl);
      
    var gido=$('#giohang').html()
    if(gido.search('<span class="cart-item-title">'+ten+'</span>')=="-1")
    {
       
        html=' <div class="cart-items">\
        <!--cart-items-->\
        <div class="cart-row">\
            <div class="cart-item cart-column">\
                <img src="'+anh+'" style="width: 40px;height: 50px;">\
                <span class="cart-item-title">'+ten+'</span>\
                <span > - </span>\
                <span >'+kichco+'</span>\
                <span > - </span>\
                <span id="soluonghang">'+sl+'</span>\
            </div>\
            <div class="cart-quantity cart-column">\
                <button class="btn btn-danger" type="button" onclick="xoa($(this))">Xóa</button>\
            </div>\
        </div>\
    </div>'
    $('#giohang').html(gido+html)

    }
    else
    {
        var slmoi=$(".cart-item.cart-column #soluonghang").html();
        var rssl=Number(slmoi)+Number(sl)
        $(".cart-item.cart-column #soluonghang").html(rssl.toString())
    }

capnhatgia();

}
function capnhatgia()
{   var giacu= $(".cart-total-price").html().substr(0,$(".cart-total-price").html().length-2)
    var tien=Number(giacu)+Number(gia)
    $("span.cart-total-price").html(tien.toString()+" đ")
}
function xoa(elm){
    var giacu= $(".cart-total-price").html().substr(0,$(".cart-total-price").html().length-2)
    var tien=Number(giacu)+Number(gia)
    $("span.cart-total-price").html(tien.toString()-" đ")
    elm.parent().parent().parent().remove();
    
}