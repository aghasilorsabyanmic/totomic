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
            $("#people").append("<li>" + person.Name + "</li>")
        });
    },

    init: function () {
        TotoMIC.showPeople();
    },

};

$(TotoMIC.init);