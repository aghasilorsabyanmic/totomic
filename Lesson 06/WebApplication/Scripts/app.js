$(function () {

    var baseUrl = location.origin + "/api/";

    var ajaxSettings = {
        url: baseUrl + "peopleApi",
        method: "GET"
    };

    $.ajax(ajaxSettings)
        .done(getPersons);

    var getPersons = function (data) {
        console.log(data)
        $.each(data, function (index, person) {
            $("#people").append("<li>" + person.Name + "</li>")
        });
    };

    var deletePerson = function (person) {
        console.log(person.Name + " was removed.")
    };
});