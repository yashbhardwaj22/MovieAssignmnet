$('[data-attr="Delete_Movie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Delete",
            type: "POST",
            data: $('#DeleteMovie').serialize(),
            success: function (response) {
                // console.log(response)
                $('#PartialView').hide()
                $('#PartialResultView').html(response)

            },
            Error: function (err) {
                // console.log(err)
            }
        });
});