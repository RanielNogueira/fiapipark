var app = angular.module("app", []);

app.controller("loginController", ($scope, $http) => {

    $scope.loading = false;
    $scope.errorLogin = false;

    $scope.auth = (usuario) => {

        $scope.loading = true;

        $http.post("/Login/UserLogin", usuario)
            .then((response) => {
                $scope.loading = false;
                if (response.status === 200) {
                    location.href = "/Home";
                }
            }).catch((response) => {
                $scope.loading = false;
                $scope.errorLogin = true;
            })
    }

});