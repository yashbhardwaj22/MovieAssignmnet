$('[data-attr="Update_Movie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Update",
            type: "POST",
            data: $('#UpdateMovie').serialize(),
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
