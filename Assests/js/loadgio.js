$(document).ready(function()
{
    var ten = localStorage.getItem("tenspi4");
    var gia = localStorage.getItem("giaspi4");
    var i4 = localStorage.getItem("tpspi4");
    var loaitd =localStorage.getItem("loaitdi4");
    var anh = localStorage.getItem("imgi4");
    var size = localStorage.getItem("sizei4");

    var html='  <div class="sanpham col-sm-12" style="margin: 60px 0px;">\
                    <div class="anhsp column col-sm-6">\
                        <div class="anhsp1">\
                            <a href="'+anh+'" data-lightbox="my gallery"><img style="float:right;" src="'+anh+'"></a>\
                        </div>  \
                    </div>\
                    <div class="chitietsp column col-sm-6">\
                        <h1 style="margin-bottom: 10px;">'+ten+'</h1>\
                        <div class="chitietsp1">\
                            <ul class="chitiet">\
                                <li>\
                                    <p>Loại thực đơn</p>:<span>'+loaitd+'</span>\
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
                </div>'
    $("#i4sp").html(html)
})
