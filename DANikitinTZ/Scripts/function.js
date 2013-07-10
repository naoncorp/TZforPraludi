// Очищаем поля формы
function CreateSubmit() {
    $('#form0')[0].reset();
}

// после загрузки страницы, каждые 60 секунд запускаем метод AJAXReload()
$(document).ready(function () {
   
   $( "#OrderDate" ).datetimepicker();
    setInterval('AJAXReload()', 60000);
}
);

// обновляем список заявок
function AJAXReload() {
    $('#bidslist').load(get_hostname(location.href) + "/Home/BidsList");
}

// получаем имя домена
function get_hostname(url) {
    var m = url.match(/^http:\/\/[^/]+/);
    return m ? m[0] : null;
}