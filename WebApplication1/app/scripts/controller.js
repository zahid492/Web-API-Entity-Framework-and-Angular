X.controller('EmployeeController',['$scope','Employee', function($scope,Employee) {
    $scope.v = 'test';
    $scope.employees = [];
    Employee.get(function (response) {
        $scope.employees = response.Data;

    });


    }
]);