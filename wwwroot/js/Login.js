$(document).ready(function () {
    var panelOne = $(".form-panel.one");
    var panelTwo = $(".form-panel.two");
    var formContainer = $(".form");

    var panelOneHeight = panelOne.outerHeight();
    var panelTwoHeight = panelTwo[0].scrollHeight;

    // Evento para abrir el panel de registro
    $(".form-panel.two")
        .not(".form-panel.two.active")
        .on("click", function (e) {
            e.preventDefault();

            $(".form-toggle").addClass("visible");
            panelOne.addClass("hidden");
            panelTwo.addClass("active");

            // Ajusta la altura del contenedor al tamaño del panel two
            formContainer.animate({ height: panelTwoHeight }, 200);
        });

    // Evento para cerrar el panel de registro y volver al login
    $(".form-toggle").on("click", function (e) {
        e.preventDefault();

        $(this).removeClass("visible");
        panelOne.removeClass("hidden");
        panelTwo.removeClass("active");

        // Ajusta la altura del contenedor al tamaño del panel one (restaurarlo)
        formContainer.animate({ height: panelOneHeight }, 200);
    });

    // Asegurarse de que la altura inicial del contenedor sea la correcta
    formContainer.css("height", panelOneHeight);
});
