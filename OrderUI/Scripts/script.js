function GetDetails() {
    //call web api for details
    $.ajax({
        type: "post",
        url: "/order/details",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            BindandShowData(data);
            //alert(data["Info1"]);
            //$("#divAllDetails").show();
            /*var DIV = '';
            $.each(data, function (i, item) {
                var rows = "<tr>" +
                    "<td id='RegdNo'>" + item.regNo + "</td>" +
                    "<td id='Name'>" + item.name + "</td>" +
                    "<td id='Address'>" + item.address + "</td>" +
                    "<td id='PhoneNo'>" + item.phoneNo + "</td>" +
                    "<td id='AdmissionDate'>" + Date(item.admissionDate,
                        "dd-MM-yyyy") + "</td>" +
                    "</tr>";
                $('#Table').append(rows);
            }); //End of foreach Loop   
            console.log(data);*/
        }, //End of AJAX Success function  

        failure: function (data) {
            alert(data.responseText);
        }, //End of AJAX failure function  
        error: function (data) {
            alert(data.responseText);
        } //End of AJAX error function  

    });    
};

function BindandShowData(data) {
    //alert(data["Info2"]);
    $("#txtfield1").val(data["OrderInfo1"]);
    $("#txtfield2").val(data["OrderInfo2"]);
    $("#txtfield3").val(data["OrderInfo3"]);
    $("#txtfield4").val(data["OrderInfo4"]);
    $("#txtfield5").val(data["OrderInfo5"]);
    BuildOrderHistory(data.OrderHistory);
    $("#divAllDetails").show();
    $("#divFirstSearch").hide();
    $("#divSecondSearch").show(); 
    $("#divAllDetails").show();
}

function ShowSearch() {
    $("#divFirstSearch").show();
    $("#divSecondSearch").hide(); 
    $("#divAllDetails").hide();

}

function BuildOrderHistory(data)
{
    $('#tblOrderHistorybody tr').remove();
    $.each(data, function (i, item) {
        var rows = "<tr>" +
            "<td id='Status'>" + item.HisoryStatus + "</td>" +
            "<td id='Date'>" + item.HistoryDate + "</td>" +
            "<td id='Info'>" + item.HistoryInfo + "</td>" +
            "</tr>";
        $('#tblOrderHistorybody').append(rows);

    }); //End of foreach Loop   
}

$("form").submit(function (e) {
    e.preventDefault();
});