// $('.yes').click(function()
// {
//     var macongchuc=$('.macongchuc').val();
//     var tencongchuc=$('.tencongchuc').val();

//     if($("#radioNam").is(":checked"))
//     var gioiTinh='Nam';
//     else
//     var gioiTinh='Nữ';

//     var trinhdo=$('.trinhDo').val();

//     var chucVu= $('.chucVu').val();

//     regex = /[a-zA-Z]/;
//     if($('.macongchuc').val()==''||$('.macongchuc').val().length!=6)
//     {
//         alert('Mã công chức không được để trống và phải có độ dài 6 ký tự');
//     }

//     if($('.tencongchuc').val()==''||$('.tencongchuc').val().length>50)
//     {
//         alert('Tên công chức không được để trống và không được dài quá 50 ký tự');
//     }

//     var Hien= "Mã công chức: " + macongchuc + "\nTên công chức: " + tencongchuc+ "\nGiới tính: "+ gioiTinh + "\nTrình độ: " +trinhdo+ "\nChức vụ: " +chucVu;
//     alert(Hien);
// })

// // hien thi chuc năng quan ly don hang

// ///

// $('.quanLyThucDon').click(function()
// {
//     $('.congchuc').css('display','block')
//     $('.themThongTin').css('display','none')
//     $('.themNguoiDung').css('display','none')
// })

// --------------------------------------------------
function xoa(phantu)
{
  var listcu=phantu.parent().parent().parent().html()
  var listm=listcu.replace(phantu.parent().html(), "")
  var listmoi=listm.replace('<tr id="sanpham"></tr>', "")
  phantu.parent().remove()
  listThucDonLen=listmoi;
}

function seach() {
    var filter, layMa, a, i, txtValue;
    filter = $("#mySearch").val().toUpperCase();
  
    layMa =$(".ma");
    for (i = 0; i < layMa.length; i++) {
        a = layMa[i];
        txtValue = a.textContent || a.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1)
        {
            layMa[i].parentElement.style.display  = "";
        } 
        else 
        {
            layMa[i].parentElement.style.display = 'none';
        }
    }
  }

function hien(id)
{
    var k= $(".main>div.container-1");
    for(var i=1;i<=k.length;i++)
    {
        $(".main>div.container-1:nth-child("+i+")").addClass("none");
    }
    $("."+id).removeClass("none");
}

$('.them-click').click(function()
{
    $('.them-none.chiThem').addClass('open');
  
    $('.quanLyThucDonThemSuaXoa').addClass('none');
})

$('.close').click(function()
{
    $('.them-none').removeClass('open');
    $('.quanLyThucDonThemSuaXoa').removeClass('none');
})

var listThucDonLen;

$('#file').change(function()
{
    readImgUrlAndPreview(this);
    function readImgUrlAndPreview(input)
    {
        if (input.files) 
        {
            var reader = new FileReader();
            reader.onload = function (e) 
            {			            	
                $('#load').attr('src', e.target.result);
            }
        };
        reader.readAsDataURL(input.files[0]);
    }	
});


$('#sua').change(function()
{		alert("ád")
    readImgUrlAndPreview(this);
    function readImgUrlAndPreview(input)
    {
        if (input.files) 
        {
            var reader = new FileReader();
            reader.onload = function (e) 
            {			            	
                $('#loadsua').attr('src', e.target.result);
            }
        };
        reader.readAsDataURL(input.files[0]);
    }	
});
function themThucDon()
{
    var hang=$("tbody#dstd").html();
    var masp=$("#masp").val();
    var ten=$("#ten").val();
    var gia=$("#gia").val();
    var sl=$("#sl").val();
    var loai=$("#loai").val();
    var size=$("#size").val();
    var anh=$('#load').attr('src');;
    var thanhphan=$("#thanhphan").val();
    
    var html='<tr id="sanpham">\
    <td class="ma maopen sorting_1">'+masp+'</td>\
    <td class="maloaiopen">'+loai+'</td>\
    <td class="sorting_1 imgopen"><img src="'+anh+'" style="width:100%" class="imgtd"></td>\
    <td class="tenopen">'+ten+'</td>\
    <td class="sizeopen">'+size+'</td>\
    <td class="sorting_1 giaopen">'+gia+'</td>\
    <td class="soluongopen">'+sl+'</td>\
    <td class="thanhphanopen">'+thanhphan+'</td>\
    <td onclick="xoa($(this))" class="deletebutton"><i class="fas fa-trash-alt"></i></td>\
    <td onclick="sua($(this))" class="editbutton"><i class="fas fa-edit"></i></td>\
  </tr>';
    $("tbody#dstd").html(hang+html);

}

$("#quanLyThucDon").click(function()
{
  $("#listThucDon").html(listThucDonLen);
  listThucDonLen=$("#listThucDon").html();
})




$('.ChonDaXacThuc').click(function()
{
    $('article.hienChonDaXacThuc').css('display','grid')
    $('article.hienChonChuaXacThuc').css('display','none');
    $('article.hienChonDaThucHien').css('display','none');
})
$('.ChonChuaXacThuc').click(function()
{
    $('article.hienChonChuaXacThuc').css('display','grid')
    $('article.hienChonDaXacThuc').css('display','none');
    $('article.hienChonDaThucHien').css('display','none');
})
$('.chonDaHoanThien').click(function()
{
    $('article.hienChonDaThucHien').css('display','grid')
    $('article.hienChonChuaXacThuc').css('display','none');
    $('article.hienChonDaXacThuc').css('display','none');
})

$(".dieuChinhDonHang").click(function()
{
    $(".chitietdonhang").css("display","none")
    // $(".menu").css("display","none")
    $(".dieuChinhDonHang").css("display","none")
});

$(".bars-dieuChinh i").click(function()
{
    $(".chitietdonhang").css("display","block")
    // $(".menu").css("display","block")
    // $(".dieuChinhDonHang").css("display","block")
});


// $("button.menu-button.chitiet").click(function()
// {
//     // $(".chitietdonhang").css("display","block")
// })

$(".chitietdonhang").click(function()
{
    $(".chitietdonhang").css("display","none")
})


// sua
function sua(elm){ 
    $('.them-none.sua').addClass('open');
    var matd = elm.parent().find('.maopen').html();
    var maloaitd = elm.parent().find('.maloaiopen').html();
    var imgtd = elm.parent().find('img').attr('src');
    var tentd = elm.parent().find('.tenopen').html();
    var sizetd = elm.parent().find('.sizeopen').html();
    var giatd = elm.parent().find('.giaopen').html();
    var soluongtd = elm.parent().find('.soluongopen').html();
    var thanhphantd = elm.parent().find('.thanhphanopen').html();
    $("#masp").val(matd)
    $("#loai").val(maloaitd)
    $("#ten").val(tentd)
    $("#thanhphan").val(thanhphantd)
    $("#size").val(sizetd)
    $("#sl").val(soluongtd)
    $("#gia").val(giatd)
    $("#load.imgtd").attr("src",imgtd)
}

$(document).ready(function()
{
    var matd = localStorage.getItem("matdi4");
    var maloaitd = localStorage.getItem("maloaitdi4");
    var imgtd = localStorage.getItem("imgtdi4");
    var tentd =localStorage.getItem("tentdi4");
    var giatd = localStorage.getItem("giatdi4");
    var sizetd = localStorage.getItem("sizetdi4");
    var soluongtd = localStorage.getItem("soluongtdi4");
    var thanhphantd = localStorage.getItem("thanhphantdi4");

    var html='<tbody style="text-align: left;">\
                    <tr>\
                        <td>Ảnh :</td>\
                        <td>\
                            <img id="loadsua" class="imgtd" src="'+imgtd+'">\
                        </td>\
                        <td>\
                            <input style="width: 120px!important;" required type="file"  name="filesua" id="sua"  accept="image/*" class="inputfile"/>\
                            <label for="sua">Chọn file ảnh</label>\
                        </td>\
                    </tr>\
                    <tr>\
                        <td style="width: 150px">Mã thực đơn : </td>\
                        <td style="width: 360px">\
                            <input id="masp" value="'+matd+'" required type="text">\
                        </td>\
                    </tr>\
                    <tr>\
                        <td>Mã loại thực đơn :</td>\
                            <td>\
                                <select id="loai" required id="loai" >\
                                <option value="ltd01">'+maloaitd+'</option>\
                                <option value="ltd02">ltd02</option>\
                                <option value="ltd03">ltd03</option>\
                                <option value="ltd04">ltd04</option>\
                                <option value="ltd05">ltd05</option>\
                                <option value="ltd06">ltd06</option>\
                                <option value="ltd07">ltd07</option>\
                            </select>\
                        </td>\
                    </tr>\
                    <tr>\
                        <td>Tên thực đơn : </td>\
                        <td>\
                            <input id="ten" required type="text" value="'+tentd+'">\
                        </td>\
                    </tr>\
                    <tr>\
                        <td>Thành phần :</td>\
                        <td><input value="'+thanhphantd+'" id="thanhphan" required type="text"></td>\
                    </tr>\
                    <tr>\
                        <td>Size :</td>\
                        <td>\
                            <select id="size" required id="size" >\
                                <option value="S">'+sizetd+'</option>\
                                <option value="M">M</option>\
                                <option value="L">L</option>\
                            </select>\
                        </td>\
                    </tr>\
                    <tr>\
                        <td>Giá thực đơn :</td>\
                        <td>\
                            <input id="gia" value="'+giatd+'" required type="number">\
                        </td>\
                    </tr>\
                    <tr>\
                        <td>Số lượng :</td>\
                        <td> <input id="sl" value="'+soluongtd+'" required type="number"></td>\
                    </tr>\
                </tbody>';
          
    $("#i4td").html(html);
})



$('.them-none.sua').click(function()
{
    $('.them-none.sua').addClass('none');
})

function suaThucDon(elm)
{
    var matd = elm.parent().children().children().children().find('input#masp').val();
    var maloaitd = elm.parent().children().children().children().children().find('#loai').val();
    var imgtd = elm.parent().children().children().children().find('img#load').attr('src');
    var tentd = elm.parent().children().children().children().find('input#ten').val();
    var giatd = elm.parent().children().children().children().find('input#gia').val();
    var sizetd = elm.parent().children().children().children().children().find('#size option').val();
    var soluongtd = elm.parent().children().children().children().find('input#sl').val();
    var thanhphantd = elm.parent().children().children().children().find('input#thanhphan').val();

    var html = '<td class="ma maopen sorting_1">'+matd+'</td>\
    <td class="maloaiopen">'+maloaitd+'</td>\
    <td class="sorting_1 imgopen"><img src="'+imgtd+'" style="width:100%" class="imgtd"></td>\
    <td class="tenopen">'+tentd+'</td>\
    <td class="sizeopen">'+sizetd+'</td>\
    <td class="sorting_1 giaopen">'+giatd+'</td>\
    <td class="soluongopen">'+soluongtd+'</td>\
    <td class="thanhphanopen">'+thanhphantd+'</td>\
    <td onclick="xoa($(this))" class="deletebutton"><i class="fas fa-trash-alt"></i></td>\
    <td onclick="sua($(this))" class="editbutton"><i class="fas fa-edit"></i></td>'
    $('#sanpham').html(html);
}




