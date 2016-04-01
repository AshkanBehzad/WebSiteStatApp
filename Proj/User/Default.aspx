<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proj.User.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://cdn.webix.com/edge/webix.css" type="text/css"/> 
    <script src="http://cdn.webix.com/edge/webix.js" type="text/javascript"></script>  
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <!-- CSS Files -->
<link type="text/css" href="../Components/Jit/css/base.css" rel="stylesheet" />
<link type="text/css" href="../Components/Jit/css/PieChart.css" rel="stylesheet" />

<!--[if IE]>
    <script language="javascript" type="text/javascript" src="../Components/Jit/excanvas.js">
    </script>
    <![endif]-->

<!-- JIT Library File -->
<script type="text/javascript" src="../Components/Jit/jit.js"></script>
    <script src="../Scripts/jQuery-2.1.4.min.js"></script>
      <script type="text/javascript">
        google.charts.load("current", { packages: ["corechart"] });
       
function CallService()
        {
            $.ajax({
                type: "POST",
                url: "/Services/Retriever.asmx/GetStatsJSArray",
                data: {},
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                error: OnError
            });
        }

        function OnSuccess(data, status) 
        {
            $("#lblResult").html(data.d);
            
            drawChart2(data.d);
        }
 
        function OnError(request, status, error)
        {
            //*******************
            alert("failed");//***
            //*******************
        }
        function drawChart2(chartData) {
            //*******************
            alert(chartData);//**
            //*******************
            var x = $.makeArray(chartData);
            //*******************
            //alert(x);//**********
            //*******************
            var y = $.parseJSON(chartData);
            alert(y);
            var data2 = google.visualization.arrayToDataTable(y);
           
           // var data3 = new google.visualization.DataTable(JSONdata);
            //var index;
            //for (index = 0; index < x.length; index++) {
              //  data3.addRows(x[index].OS, x[index].Count);
                
            //}
            var options2 = {
            };
            var chart2 = new google.visualization.PieChart(document.getElementById('piechart2'));
            chart2.draw(data2, options2);
        }
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label id="lblResult"></label>
            <div id="output"></div>
            <h3 style="text-align: center;">Static Pie Chart</h3>
            <%--Static initialized pie chart--%>
            <div id="piechart1" style="height: 650px;"></div>
            <h3 style="text-align: center;">Dynamic Pie Chart</h3>
            <%--Dynamic pie chart--%>
            <div id="piechart2" style="height: 650px;"></div>
            
            
            
            <script type="text/javascript">
                
                google.charts.setOnLoadCallback(drawChart1);

                //Loads Static PieChart
                function drawChart1() {
                    var data1 = google.visualization.arrayToDataTable([
                     ['OS', 'Count'],
                     ['BSD', 1452],
                     ['Symbian', 1372],
                     ['Symbian', 1757],
                     ['Symbian', 1193],
                     ['BSD', 1230],
                     ['BSD', 552],
                     ['BSD', 529],
                     ['Linux', 834],
                     ['Linux', 1322],
                     ['Linux', 267],
                     ['Symbian', 59],
                     ['Symbian', 965],
                     ['Linux', 1170],
                     ['BSD', 1231],
                     ['Symbian', 754]
                    ]);
                    var options1 = {
                    };
                    var chart1 = new google.visualization.PieChart(document.getElementById('piechart1'));
                    chart1.draw(data1, options1);
                }
                google.charts.setOnLoadCallback(CallService);
                 
            </script>
    </div>
    </form>
</body>
</html>
