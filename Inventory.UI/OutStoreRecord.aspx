﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="OutStoreRecord.aspx.cs" Inherits="Inventory.UI.OutStoreRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-sm-12">
                <div class="form-horizontal m-t">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">选择仓库：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList runat="server" ID="stno" ClientIDMode="Static" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="stno_OnSelectedIndexChanged"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">选择商品编号：</label>
                        <div class="col-sm-8">
                            <asp:DropDownList runat="server" ID="gno" ClientIDMode="Static" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="gno_OnSelectedIndexChanged"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">出库数量：</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="txtNumber" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-sm-4 col-sm-offset-3">
                            <asp:Button runat="server" ID="btnAdd" Text="提交" CssClass="btn btn-primary" OnClick="btnAdd_OnClick"/>
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
