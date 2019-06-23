//<script type="text/javascript">
//    $(document).ready(function () {
//            var items = "<option value='0'>Wybierz wydział</option>";
//    $("#IDDepartment").html(items);
//});


//        $("#IDOffice").change(function () {
//            var url = '@Url.Action("GetDepartment", "Employments")';
//            var id = $(this).val();
            
//            $.getJSON(url, {IDOffice: id }, function (response) {
//            $("#IDDepartment").empty();
//            $.each(response, function (index, dep) {
//            $("#IDDepartment")
//                .append($("<option></option>")
//                .text(dep.nameDepartment)
//                .val(dep.idDepartment))
//    }
//    );
//});
//});
//  </script>