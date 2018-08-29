$('[data-attr="Movie_Add"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Insert",
            type: "POST",
            data: $('#AddMovie').serialize(),
            success: function (response) {
                 console.log(response)
                 window.location.href = 'Index' //from stackoverflow
               

            },
            Error: function (err) {
               
            }
        });
});