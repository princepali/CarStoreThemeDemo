app.controller('productCtrl', ['$scope', '$http', '$cookies', '$location', function ($scope, $http, $cookies) {


    // Use find() function to extract the badge
    // count from '#group' container.
    $(document).ready(function () {
        $(".btn").click(function () {
            var val = parseInt($('#group').find('.badge').text());

            // Check for the button clicked
            if ($(this).hasClass('bgcolor')) {
                $('#group').find('.badge').text(val - 1);
            } else if ($(this).hasClass('bgchu')) {
                $('#group').find('.badge').text(val + 1);
            }
        });
    });


    // Use find() function to extract the badge
    // count from '#group' container.












    $scope.hideregisterbutton = true;
    $scope.hideloginbutton = true;
    $scope.showLogoutButton = false;
    $scope.checkUserCookie = checkUserCookie;

    function checkUserCookie() {
        var user = $cookies.get('currentUser');
        if (user != null && user != undefined) {
            var user = JSON.parse(user);
            $scope.showLogoutButton = true;
            $scope.hideregisterbutton = false;
            $scope.hideloginbutton = false;
            $scope.currentUserName = "Hi,  " + user.Name;
        }
    }
    // Logout Function
    $scope.logoutCurrentUser = function () {
        $scope.hideregisterbutton = true;
        $scope.hideloginbutton = true;
        $scope.currentUserName = ""
        $scope.showLogoutButton = false;
        $cookies.remove("currentUser", { path: '/' });
    }

    // Get Product Data
    $scope.getProductList = function () { 
    $http.get('/Product/GetProducts').then(function (result) {
        $scope.dataList = result.data;      
    });
    }
    
    $scope.getCategories = function () { 
    $http.get('/Product/Getcategory').then(function (result) {
        $scope.datactgy = result.data;
    });
    }
    //Get SortFilter Data
    $scope.sortFilter = function () {
        var SortCriteria = $scope.Sort.select;
        if (SortCriteria != "") {
            $http.post('/Product/GetFilters', { sortCriteria: SortCriteria }).then(function (result) {
                $scope.dataList = result.data;
            });
        }
    }
//set add to cart
    var addtocart;
    $scope.Addtocart = function (ProductId) {
        var existingcookies = $cookies.get('Addtocart');
        if (existingcookies != null && existingcookies != undefined && existingcookies!='') {
            addtocart = existingcookies.split('-');
        }
        else {
            addtocart = [];
        }

        addtocart.push(ProductId);
        var now = new Date(),
            // this will set the expiration to 12 months
            exp = new Date(now.getFullYear() , now.getMonth(), now.getDate() +1);
        $cookies.put('Addtocart', addtocart.join("-"), { expires: exp }, { path: '/' });
        swal("Thanks!", "Product Added To Cart", "success");
    }






    $scope.AddtoProductcart = function () {
        var addcartCookieName = "Addtocart";
        $scope.addtocarts = [];
        $scope.Totalprice = 0;
        $http.post('/Product/AddToCart', { name: addcartCookieName }).then(function (result) {
            $scope.addtocarts = result.data;
            angular.forEach($scope.addtocarts, function (value) {
                $scope.Totalprice = $scope.Totalprice + value.Price;
            });
        });
    }

       // delete

    $scope.removeCart = function (ProductId) {
        var existingcookies = $cookies.get('Addtocart');
        if (existingcookies != null && existingcookies != undefined) {
            addtocart = existingcookies.split('-');
        }
        else {
            addtocart = [];
        }

        addtocart.splice(ProductId, 1);
        var now = new Date(),
            // this will set the expiration to 12 months
            exp = new Date(now.getFullYear(), now.getMonth(), now.getDate() + 1);
        $cookies.put('Addtocart', addtocart.join("-"), { expires: exp }, { path: '/' });


        var addcartCookieName = "Addtocart";
        $scope.addtocarts = [];

        $http.post('/Product/AddToCart', { name: addcartCookieName }).then(function (result) {
            $scope.addtocarts = result.data;
            $scope.Totalprice = 0;
            angular.forEach($scope.addtocarts, function (value) {
                $scope.Totalprice = $scope.Totalprice + value.Price;
            });
        });

    }





      //$(document).ready(function () {
      //    $(".btn").click(function () {
      //        var val = parseInt($('#group').find('.badge').text());

      //        // Check for the button clicked
      //        if ($(ProductId).hasClass('Countericonplus')) {
      //            $('#group').find('.badge').text(val + 1);
      //        } else if ($().hasClass('Counterionplus')) {
      //            $('#group').find('.badge').text(val - 1);
      //        }
      //    });
      //});

    $scope.uploadFile = function (file, id) {
        var fd = new FormData();
        fd.append("file", file[0]);
        var uploadUrl = "/Product/UploadProductList/";
        $http.post(uploadUrl, fd, {
            withCredentials: true,
            headers: { 'Content-Type': undefined },
            transformRequest: angular.identity
        }).then(
            function (resp) {
                if (id == 1) {
                    $scope.FirstImage = resp.data;




                }
                if (id == 2) {
                    $scope.SecondImage = resp.data;
                }
                if (id == 3) {
                    $scope.ThirdImage = resp.data;
                }




            },
            function (error) {
                alert("error");
            }
        );
    };



    $scope.Image = null; // Initialize the Image variable

    $scope.Image = null;

    //$scope.onFileSelect = function () {
    //    // Access the selected file using the file input element
    //    var fileInput = document.getElementById('imageInput');
    //    var file = fileInput.files[0];

    //    // Implement your file selection logic here if needed
    //    console.log('Selected file:', file);

    //    // Update ng-model with the selected file
    //    $scope.Image = file;
    //};
    //$scope.$watch('image', function (newVal, oldVal) {
    //    console.log('Image changed:', newVal);
    //});
    $scope.upload = function () {
        var file = $scope.image;

        // Check if a file is selected
        if (file) {
            var formData = new FormData();
            formData.append('ProductId', $scope.ProductId);
            formData.append('Image', $scope.image); // Use lowercase 'Image' here
            formData.append('ProductName', $scope.name);
            formData.append('Price', $scope.price);
            formData.append('Description', $scope.longDescription);
            formData.append('ShortDescription', $scope.shortDescription);

            $http.post('/Product/uploadProducts', { ProductDetails: formData }, {
                transformRequest: angular.identity,
                headers: { 'Content-Type': undefined }
            }).then(function (response) {
                // Handle success
                console.log(response.data);
            }, function (error) {
                // Handle error
                console.error(error);
            });
        } else {
            // Handle case where no file is selected
            console.error('No file selected.');
        }

        //if ($scope.name && $scope.Image && $scope.price && $scope.shortDescription && $scope.longDescription) {
        //    $http.post('/Product/uploadProducts', { ProductDetails: formData }).then(function (result) {
        //        $scope.uploadProducts = result.data;
        //        alert(result.data.Message);
        //    });
        //}
    };

    $scope.uploadFile = function () {
        var file = $scope.myFile;
        console.log(file); // Check if file is defined here
        var formData = new FormData();
        formData.append('file', file);
        formData.append('ProductId', $scope.ProductId);
        formData.append('ProductName', $scope.name);
        formData.append('Price', $scope.price);
        formData.append('Description', $scope.longDescription);
        formData.append('ShortDescription', $scope.shortDescription);

        $http.post('/product/UploadProducts', formData, {
            transformRequest: angular.identity,
            headers: { 'Content-Type': undefined }
        })
            .success(function () {
                console.log('File upload success');
            })
            .error(function () {
                console.log('File upload error');
            });
    };

    $scope.updateProduct = function (ProductId,Image, Productname, ProductPrice, Productdescription, Shortdescription) {
        $scope.ProductId = ProductId, $scope.Image = Image, $scope.name = Productname, $scope.price = ProductPrice, $scope.longDescription = Productdescription, $scope.shortDescription = Shortdescription
    }
    $scope.deleteProduct = function (ProductId) {
        $http.post('/Product/deleteProducts', { ProductDelete: ProductId }).then(function () {

            window.location.href = "/Product/UploadProductList";
        });
    }


}]);