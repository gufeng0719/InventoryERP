﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ManagerEdit.aspx.cs" Inherits="Inventory.UI.ManagerEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
     <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-sm-12">
                <div class="form-horizontal m-t">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">管理员编号：</label>
                        <div class="col-sm-8">
                            <input id="mno" name="mno" minlength="3" maxlength="3" type="text" disabled="disabled" runat="server" class="form-control" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">管理员名称：</label>
                        <div class="col-sm-8">
                            <input id="mname" runat="server" type="text" class="form-control" name="mname" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">性别：</label>
                        <div class="col-sm-8">
                            <select id="sex" name="sex" runat="server" class="form-control" required="" aria-selected="True">
                                <option selected="selected" value="男">男</option>
                                <option value="女"> 女</option>
                            </select>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">生日：</label>
                        <div class="col-sm-8">
                            <input type="date" id="birthday" runat="server" name="birthday" class="form-control"  />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">管理仓库：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList runat="server" ID="stno" ClientIDMode="Static" CssClass="form-control"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-4 col-sm-offset-3">
                            <asp:Button runat="server" ID="btnSave" Text="提交" CssClass="btn btn-primary" OnClick="btnSave_OnClick"/>
                        </div>
                    </div>
                </div>
                

            </div>
        </div>
    </div>

    <script src="js/content.min.js?v=1.0.0"></script>
    <script src="js/plugins/validate/jquery.validate.min.js"></script>
    <script src="js/plugins/validate/messages_zh.min.js"></script>
</asp:Content>
