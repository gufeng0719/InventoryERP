<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="GoodsList.aspx.cs" Inherits="Inventory.UI.GoodsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/plugins/bootstrap-table/bootstrap-table.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="ibox-content">
            <div class="row row-lg">
                <div class="col-sm-12">
                    <h4 class="example-title">商品列表</h4>
                    <div class="example">
                        <table  class="table table-striped">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col" >商品编号</th>
                                    <th  scope="col" >商品名称</th>
                                    <th scope="col" >商品价格</th>
                                    <th scope="col" >商品生产地</th>
                                    <th scope="col">操作</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td scope="row"><%# Eval("gno") %></td>
                                            <td><%# Eval("gname") %></td>
                                            <td><%# Eval("price") %></td>
                                            <td><%# Eval("producer") %></td>
                                            <td>
                                                <a class="btn btn-info" href="GoodEdit.aspx?gno=<%# Eval("gno") %>">
                                                    <i class="fa fa-paste"></i> 修改
                                                </a>
                                                |
                                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning" CommandArgument='<%# Eval("gno") %>' CommandName="Delete" OnClientClick="javascript:return confirm('请再次确认是否要删除该商品','系统提示');" OnClick="LinkButton1_OnClick" >
                                                    <i class="fa fa-times"></i> 
                                                    删除
                                                </asp:LinkButton>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="js/content.min.js?v=1.0.0"></script>
    <script src="js/plugins/bootstrap-table/bootstrap-table.min.js"></script>
    <script src="js/plugins/bootstrap-table/bootstrap-table-mobile.min.js"></script>
    <script src="js/plugins/bootstrap-table/locale/bootstrap-table-zh-CN.min.js"></script>
</asp:Content>
