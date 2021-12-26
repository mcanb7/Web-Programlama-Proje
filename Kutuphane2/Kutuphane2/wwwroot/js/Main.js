$(document).on("click", "#kategoriEkle", function () {
    var secilenKategoriAd = $("#kategoriler").val();
    if (secilenKategoriAd != null && secilenKategoriAd != "") {
        var secilenId = $("#kategoriler option:selected").attr("data-id");
        $("#eklenenKategoriler").append('<div id="' + secilenId + '" class="col-md-1 bg-primary kategoriSil" style="margin-right:2px; margin-bottom:2px;">' + secilenKategoriAd + '</div>');
        $("#kategoriler option:selected").remove();
    }
});

if (formValues) {
    var ktgAd = $("#ktgAd").val();
    $.ajax({
        type: 'Post',
        url: '/Kategori/EkleJson',
        data: { "ktgAd": ktgAd },
        dataType: 'Json',
        success: function (data) {
            var ktgId = '<td>' + data.Result.Id + '</td>';
            var ktgAd = '<td>' + data.Result.KategoriAdi + '</td>';
            var guncelleButon = "<td><button class='guncelle btn btn-custom' value='" + ktgId + "'>Guncelle</button></td>";
            var silButon = "<td><button class='sil btn btn-custom' value='" + ktgId + "'>Sil</button></td>";
            var kitapAdet = "<td>0</td>";
            $("example tbody").prepend('<tr>' + ktgAd + kitapAdet + guncelleButon + silButon + '</tr>');
            Swal.fire({
                type: 'success',
                title: 'Kategori Eklendi',
                text: 'İşlem Başarıyla Gerçekleşti'
            });
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'Kategori Eklenemedi',
                text: 'Bir Sorun ile Karşılaşıldı'
            });

        }
    });

}