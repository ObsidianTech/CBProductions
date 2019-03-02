$(document).ready(function () {
    var addButton = document.getElementById("AddButton");
    var listButton = document.getElementById("ListButton");
    var hook = document.getElementById("hook");

    $(addButton).on("click", function () {
        $.ajax({
            url: 'AddVideo/',
            type: 'get',
            success: function (data) {
                $(hook).html(data);
            }
        });
    });

});