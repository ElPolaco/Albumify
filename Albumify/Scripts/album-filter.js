$(document).ready(function () {
    $('.btn').click(function () {
        if ($(this).data("type") == "year") {
            $(".album").hide();
            $(".album").filter($(`*[data-year="${$(this).data("value")}"]`)).show();
        } else if ($(this).data("type") == "year2") {
            $(".album").hide();
            $(".album").filter($(`[data-year^="${$(this).data("value")}"]`)).show();
        }
        else if ($(this).data("type") == "author") {
            $(".album").hide();
            $(".album").filter($(`*[data-author="${$(this).data("value")}"]`)).show();
        } else {
            $(".album").show();
        }
        $('.btn').removeClass('active');
        $(this).addClass('active');
    });
});