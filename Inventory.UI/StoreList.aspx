﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="StoreList.aspx.cs" Inherits="Inventory.UI.StoreList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="ibox-content">
            <div class="row row-lg">
                <div class="col-sm-12">
                    <h4 class="example-title">仓库列表</h4>
                    <div class="example">
                        <table  class="table table-striped">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col" >仓库编号</th>
                                    <th  scope="col" >仓库地址</th>
                                    <th scope="col" >值班电话</th>
                                    <th scope="col" >最大容量</th>
                                    <th scope="col">操作</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td scope="row"><%# Eval("stno") %></td>
                                            <td><%# Eval("address") %></td>
                                            <td><%# Eval("telephone") %></td>
                                            <td><%# Eval("capacity") %></td>
                                            <td>
                                                <a class="btn btn-info" href="StoreEdit.aspx?stno=<%# Eval("stno") %>">
                                                    <i class="fa fa-paste"></i> 修改
                                                </a>
                                                |
                                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning" CommandArgument='<%# Eval("stno") %>'  OnClientClick="javascript:return confirm('请再次确认是否要删除该仓库？','系统提示');" OnClick="LinkButton1_OnClick" >
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
