$('[data-attr="submit"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Index",
            type: "POST",
            data: $('#MovieSearch').serialize(),
            success: function (response) {
                // console.log(response)
                $('#PartialView').hide()
                $('#PartialResultView').html(response)

            },
            error: function (err) {
                // console.log(err)
            }
        });
});