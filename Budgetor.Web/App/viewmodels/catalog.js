(function() {
    define(['durandal/system'], function(system) {
        var vm = {};

        vm.activate = function() {
            system.log('** activate catalog');
        };

        vm.attached = function() {
            system.log('** attached catalog');
        };

        vm.canDeactivate = function() {
            return true;
        };

        return vm;
    });
})();