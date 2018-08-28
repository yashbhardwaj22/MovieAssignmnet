$('[data-attr="Add_Movie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Insert",
            type: "POST",
            data: $('#AddMovie').serialize(),
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