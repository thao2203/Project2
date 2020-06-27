$(document).ready(function(){

var ten =localStorage.getItem("tenspi4")
var gia  =localStorage.getItem("giaspi4")
var i4   =localStorage.getItem("tpspi4")
var anh  =localStorage.getItem("imgi4")
var size  =localStorage.getItem("sizei4")

    var html='<div class="sanpham" style="margin: 60px 0px;">\
    <div class="anhsp column col-sm-3">\
        <div class="anhsp1">\
            <a href="'+anh+'" data-lightbox="my gallery"><img src="'+anh+'"></a>\
        </div>  \
    </div>\
    <div class="chitietsp column col-sm-4">\
        <h1 style="margin-bottom: 10px;margin-top: 30px;">'+ten+'</h1>\
        <div class="chitietsp1">\
            <ul class="chitiet">\
                <li>\
                    <p>Loại thực đơn</p>:<span>Pizza</span>\
                </li>\
                <li>\
                    <p>Nguyên liệu</p>:<span>'+i4+'\
                    </span>\
                </li>\
                <li>\
                    <p>Size</p>:<span>'+size+'</span>\
                </li>\
                <li>\
                    <p>Đơn giá</p>:     <b  class="giachon">'+gia+'</b>\
                </li>\
                <li>\
                    <div class="themsp">\
                        <input onchange="thaysl($(this))" style="padding: 9px; font-size: 16px;width: 20%;" type="number" id="quantity_5ed5a6e9b93fc"\
                                             class="input-text qty text" step="1"\
                                             min="1" max name="quantity" value="1" title="SL"\
                                             size="4" pattern="[0-9]*"\
                                             inputmode="numeric"\
                                             aria-labelledby="P1. Beefy Pizza số lượng">\
                        <button type="summit" onclick="themgio($(this))" value="Mua ngay" class="btn-color btn btn-lg btn-style btn-dark">\
                            <h3>Mua ngay</h3>\
                        </button>\
                    </div>\
                </li>\
            </ul>\
        </div>\
    </div>\
    <div class="theodungtich1 column col-sm-5">\
        <h1>P1. Beefy Pizza</h1>\
        <div class="dungtich">\
            <div class="theodungtich">\
                <p>'+ten+'</p>\
            </div>\
            <div class="gia">110000<u>đ</u></div>\
                <button type="summit" value="Mua ngay" class="btn-color btn btn-lg btn-style btn-dark">\
                    <h3>Mua ngay</h3>\
                </button>\
            </div>\
        </div>\
        <div class="dungtich2">\
            <div class="theodungtich">\
                <p>P1. Beefy Pizza - L</p>\
            </div>\
            <div class="gia">150000<u>đ</u></div>\
            <div class="mua">\
                <button type="summit" value="Mua ngay" class="btn-color btn btn-lg btn-style btn-dark">\
                    <h3>Mua ngay</h3>\
                </button>\
            </div>\
        </div>\
    </div>'

    $("#i4sp").html(html)
})