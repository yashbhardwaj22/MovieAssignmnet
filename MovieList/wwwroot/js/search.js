$('[data-attr="Submit"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Index",
            type: "POST",
            data: $('#MovieSearch').serialize(),
            success: function (response) {
               
                $('#PartialView').hide()
                $('#PartialResultView').html("")
                $('#PartialResultView').html(response)

            },
            error: function (err) {
               
            }
        });
});