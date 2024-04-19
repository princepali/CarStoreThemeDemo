app.controller('accountCtrl', ['$scope', '$http', '$cookies', '$timeout', function ($scope, $http, $cookies, $timeout) {
    //registration
      $scope.Registration = function () {
        $scope.Emailformat = /^[a-z]+[a-z0-9._]+@[a-z]+\.[a-z.]{2,5}$/;
        //hobbies validation
        $scope.hobbies = [{ key: "Cricket", isSelected: false },
        { key: "Football", isSelected: false },
        { key: "Singing", isSelected: false },
        { key: "Writing", isSelected: false }
        ]
        $scope.validation = function () {
            var selectedHobbies = [];
            angular.forEach($scope.hobbies, function (val) {
                if (val.isSelected)
                    selectedHobbies.push(val.key);
            });
            if (selectedHobbies.length == 0) {
                return $scope.errormsg = "please select hobbies";
            } else {
                $scope.errormsg = "";
            }
            var hobbydata = selectedHobbies.join(","); //"red,blue,green"
            if (typeof ($scope.user.name) != "undefined" && typeof
                ($scope.user.email) != "undefined" && typeof
                ($scope.user.password) != "undefined" && typeof
                ($scope.user.gender) != "undefined" && typeof
                ($scope.user.deparment) != "undefined") {
                var user = { "name": $scope.user.name, "email": $scope.user.email, "password": $scope.user.password, "gender": $scope.user.gender, "department": $scope.user.deparment, "hobbies": hobbydata };
                $http.post('/Account/InsertUserDetails', { UserInformation: user }).then(function (result) {
                    if (result.data) {
                        alert("You are Registered");

                    }
                    // check Email Exist
                    if (!result.data) {
                        $scope.emailexist = "Email is Already Exist";
                        $timeout(function () {
                            $scope.emailexist = "";
                        }, 1000);
                        return false;
                    }
                    else {
                        window.location.href = "/Account/Login";
                    }
                });
            }
        }
        $scope.checkhobby = function () {
            var selectedHobbies = [];
            angular.forEach($scope.hobbies, function (val) {
                if (val.isSelected)
                    selectedHobbies.push(val.key);
            });
            if (selectedHobbies.length == 0) {
                $scope.errormsg = "please select hobbies";
            }
            else {
                $scope.errormsg = "";
            }
        }
    }



    //login validation
    $scope.Login = function () {
        $scope.Emailformat = /^[a-z]+[a-z0-9._]+@[a-z]+\.[a-z.]{2,5}$/;
        $scope.recollect = false;
        var userData = $cookies.get('currentUser');
        if (userData != null && userData != undefined) {
            var userLoginData = JSON.parse(userData);
            $scope.email = userLoginData.Email;
            $scope.password = userLoginData.Password;
        }
        $scope.loginvalidation = function () {
            /*  $scope.flag = true;*/
            if ($scope.myform.$valid) {
                var isSelected = false;
                var UserLoginInfo = { "Email": $scope.email, "password": $scope.password };
                $http.post('/Account/Access', { UserDetails: UserLoginInfo }).then(function (result) {
                    result.data;
                    if (result.data != "") {
                        isSelected = true;
                        if ($scope.recollect) {
                            var UserData = { "Email": result.data.Email, "Password": result.data.Password, "Name": result.data.Name };
                            var userDetails = JSON.stringify(UserData);
                            //set cookies
                            $cookies.put('currentUser', userDetails, { path: '/' });
                            $scope.loginsuccess = "Login success";
                            window.location.href = "/Home/Index";
                        }
                        else {
                            var UserData = { "Name": result.data.Name };
                            var userDetails = JSON.stringify(UserData);
                            //set cookies
                            $cookies.put('currentUser', userDetails, { path: '/' });
                            $scope.loginsuccess = "Login success";
                            window.location.href = "/Home/Index";
                        }
                    }
                   if (!isSelected) {
                        $scope.loginfaild = "User Not Exists";
                        $timeout(function () {
                            $scope.loginfaild = false;
                        }, 2000);
                        return false;
                    }
                });
            }
        }
        $(".toggle-password").click(function () {
            $(this).toggleClass("fa-eye fa-eye-slash");
            var input = $($(this).attr("toggle"));
            if (input.attr("type") == "password") {
                input.attr("type", "text");
            } else {
                input.attr("type", "password");
            }
        });
    }


    $scope.Validate = function () {
        $scope.passval = /^(?=.*[A-Za-z])(?=.*\d)(?=.*[$!%*#?&])[A-Za-z\d$!%*#?&]{8,}$/;
    }


}]);
