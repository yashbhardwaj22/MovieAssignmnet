$('[data-attr="Movie_Delete"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Delete",
            type: "POST",
            data: $('#DeleteMovie').serialize(),
            success: function (response) {
               
                window.location.href = 'Index' //from stackoverflow
               

            },
            Error: function (err) {
            
            }
        });
});