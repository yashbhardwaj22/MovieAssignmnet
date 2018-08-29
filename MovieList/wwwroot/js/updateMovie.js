$('[data-attr="Movie_Update"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Update",
            type: "POST",
            data: $('#UpdateMovie').serialize(),
            success: function (response) {
                // console.log(response)
                window.location.href = 'Index' //from stackoverlow
               

            },
            Error: function (err) {
                // console.log(err)
            }
        });
});
