'use strict'

var TotoMIC = {

    settings: {
        baseUrl: location.origin + "/api/"
    },

    buildUrl: function (action, id) {
        return this.settings.baseUrl + action + "/" + (typeof id !== 'undefined' ? id : "");
    },

    showPeople: function () {
        var ajaxSettings = {
            url: TotoMIC.buildUrl("peopleApi"),
            method: "GET"
        };

        var deferred = $.ajax(ajaxSettings);

        deferred.done(this.renderPeople);
        deferred.fail(this.showError);
    },

    showError: function (jqXHR, textStatus, errorThrown) {
        console.debug(textStatus);
        console.debug(jqXHR);
        console.debug(errorThrown);
    },

    renderPeople: function (people, textStatus, jqXHR) {
        console.debug(textStatus);
        console.debug(jqXHR);

        $.each(people, function (index, person) {
            $("#people")
                .append(
                '<li id="' + person.Id + '">' +
                person.Name + '<button data-id="' + person.Id + '" type="button" class="btn btn-danger">Remove</button>' +
                "</li>");

            $("#" + person.Id + " button").click(TotoMIC.removePerson);
        });
    },

    removePerson: function(event) {
        event.preventDefault();
        var id = $(this).data("id");

        var ajaxSettings = {
            url: TotoMIC.buildUrl("peopleApi", id),
            type: "DELETE"
        };

        var deferred = $.ajax(ajaxSettings);

        deferred.done(TotoMIC.removePersonDone);
        deferred.fail(TotoMIC.removePersonFail);
    },

    removePersonDone: function (person, textStatus, jqXHR) {
        $("#" + person.Id).slideUp(500, function () {
            $(this).remove();
        });
    },

    removePersonFail: function (jqXHR, textStatus, errorThrown) {

    },

    init: function () {
        TotoMIC.showPeople();
    },

};

$(TotoMIC.init);