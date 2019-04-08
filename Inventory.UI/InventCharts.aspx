<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="InventCharts.aspx.cs" Inherits="Inventory.UI.InventCharts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- 为ECharts准备一个具备大小（宽高）的Dom -->
    <div id="main" style="width: 800px;height:600px;"></div>
    <script src="js/plugins/echarts/echarts-all.js"></script>
    <script type="text/javascript">
        //var numArr = [];
        //numArr[0] = Math.floor(Math.random() * 100);
        //numArr[1] = Math.floor(Math.random() * 50);
        //numArr[2] = Math.floor(Math.random() * 80);
        //numArr[3] = Math.floor(Math.random() * 20);
        var numArr = [
            { name: "美菱冰箱", value: 0 },
            { name: "海尔冰箱", value: 19 },
            { name: "雪花冰箱", value: 29 },
            { name: "长虹电视", value: 9 }, 
            { name: "海尔电视", value: 39 },
            { name: "熊猫电视", value: 15 },
            { name: "海尔空调", value: 20 }
        ];
        // 基于准备好的dom，初始化echarts实例
        var myChart = echarts.init(document.getElementById('main'));

        // 指定图表的配置项和数据
       /* var option = {
            title: {
                text: '商品库存信息'
            },
            tooltip: {},
            legend: {
                data:['销量']
            },
            xAxis: {
                data: ["美菱冰箱","海尔冰箱","雪花冰箱","长虹电视","海尔电视","熊猫电视","海尔空调"]
            },
            yAxis: {},
            series: [{
                name: '库存',
                type: 'bar',
                data: []
            }]
        };*/

       option = {
           title : {
               text: '商品库存信息',
               x:'center'
           },
           tooltip : {
               trigger: 'item',
               formatter: "{a} <br/>{b} : {c} ({d}%)"
           },
           legend: {
               type: 'scroll',
               orient: 'vertical',
               right: 10,
               top: 20,
               bottom: 20,
               data: ["美菱冰箱","海尔冰箱","雪花冰箱","长虹电视","海尔电视","熊猫电视","海尔空调"],
               selected: { "美菱冰箱": true, "海尔冰箱":false, "雪花冰箱":true, "长虹电视":true, "海尔电视":true, "熊猫电视":true, "海尔空调":true }
           },
           series : [
               {
                   name: '商品',
                   type: 'pie',
                   radius : '55%',
                   center: ['40%', '50%'],
                   data: [],
                   itemStyle: {
                       emphasis: {
                           shadowBlur: 10,
                           shadowOffsetX: 0,
                           shadowColor: 'rgba(0, 0, 0, 0.5)'
                       }
                   }
               }
           ]
       };
        //console.info(<%=sumNumber %>);
        option.series[0].data = <%=sumNumber %>;
        // 使用刚指定的配置项和数据显示图表。
        myChart.setOption(option,true);
    </script>
</asp:Content>
