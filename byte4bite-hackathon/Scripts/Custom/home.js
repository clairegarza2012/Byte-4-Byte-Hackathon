$(function () {
    alert('im home');

    $("#getdata").click(function () {
        var postObj = {
            ID: $("#datatopost").val()
        };
        $.post("/Home/GetData/", postObj, function (data) {
            alert(data);
        });
    });
        
});