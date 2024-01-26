$(document).ready(function () {

    LoadGoodPatientServices();


    $("#createGoodPatientServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Add new patient service")
                LoadGoodPatientServices();
            },
            error: function () {
                toastr["error"]("Coœ posz³o Ÿle")
            }
        })
    });