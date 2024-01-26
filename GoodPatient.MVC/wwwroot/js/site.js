
const RenderGoodPatientServices = (services, container) => {
    container.empty();

    for (const service of services) {
        container.append(
            `<div class="card border-secondary mb-3" style="max-width: 18rem;">
          <div class="card-header">${service.name}</div>
          <div class="card-body">
            <h5 class="card-title">${service.description}</h5> 
          </div>
        </div>`)
    }
}


const LoadGoodPatientServices = () => {
    const container = $("#services")
    const GoodPatientEncodedName = container.data("encodedName");

    $.ajax({
        url: `/GoodPatient/${GoodPatientEncodedName}/GoodPatientService`,
        type: 'get',
        success: function (data) {
            if (!data.length) {
                container.html("Nie masz dodanych dodakowych informacji")
            } else {
                RenderGoodPatientServices(data, container)
            }
        },
        error: function () {
            toastr["error"]("coś poszło nie tak")
        }
    })
}

$(document).ready(function () {
    $(".search").keyup(function () {
        var searchTerm = $(".search").val();
        var listItem = $('.results tbody').children('tr');
        var searchSplit = searchTerm.replace(/ /g, "'):containsi('")

        $.extend($.expr[':'], {
            'containsi': function (elem, i, match, array) {
                return (elem.textContent || elem.innerText || '').toLowerCase().indexOf((match[3] || "").toLowerCase()) >= 0;
            }
        });

        $(".results tbody tr").not(":containsi('" + searchSplit + "')").each(function (e) {
            $(this).attr('visible', 'false');
        });

        $(".results tbody tr:containsi('" + searchSplit + "')").each(function (e) {
            $(this).attr('visible', 'true');
        });

        var patientCount = $('.results tbody tr[visible="true"]').length;
        $('.counter').text(patientCount + ' pacjentów');

        if (patientCount == '0') { $('.no-result').show(); }
        else { $('.no-result').hide(); }
    });
});



// JavaScript for handling dropdown
document.getElementById('userDropdown').addEventListener('click', function () {
    var dropdown = document.getElementById('dropdown-user');
    dropdown.classList.toggle('hidden');
});

// Close dropdown when clicking outside
window.addEventListener('click', function (event) {
    var dropdown = document.getElementById('dropdown-user');
    if (!event.target.closest('#userDropdown') && !event.target.closest('#dropdown-user')) {
        dropdown.classList.add('hidden');
    }
});


