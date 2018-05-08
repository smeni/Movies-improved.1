
    $(function () {

        //dinamic register to the event 'change'.
        $("#usersList").change(function () {

            var select = $("#usersList").find(":selected").val();


            //Alax call.
            if (select == 'הצג רק משתמשים פעילים') {
                $.get("/User/ReturnOnlyActivityUsers", function (response) {

                    $("#container").empty().html(response);

                }).error(function (error) { alert(error = "משתמשים פעילים Ajax שגיאת"); });
            }
            if (select == 'הצג את כל המשתמשים הרשומים') {
                $.get('/User/ReturnAllUsers', function (response) {

                    $("#container").empty().html(response);

                }).error(function (error) { alert(error = "Ajax שגיאת"); });

            }
        });

    });

        //function get() {
        //    $.get("/User/Index", "", function (result) {
        //        $("#container").empty().html(result);
        //    });
        //}
  