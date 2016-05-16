define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        search: function () {
            //It's really easy to show a message box.
            //You can add custom options too. Also, it returns a promise for the user's response.
            app.showMessage('Search not yet implemented...');
        },
        activate: function () {
            router.map([
                // empty string adds default
                { route: 'about', title: 'About', moduleId: 'viewmodels/about', nav: true },
                { route: 'catalog', title: 'Catalog', moduleId: 'viewmodels/catalog', nav: true },
                { route: ['', 'transaction'], title: 'Transaction', moduleId: 'viewmodels/transaction', nav: true },
                { route: 'admin', title: 'Admin', moduleId: 'viewmodels/admin', nav: true }
            ]).buildNavigationModel();

            return router.activate();
        }
    };
});