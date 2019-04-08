<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="StoreAdd.aspx.cs" Inherits="Inventory.UI.StoreAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-sm-12">
                <div class="form-horizontal m-t">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">仓库编号：</label>
                        <div class="col-sm-8">
                            <input id="stno" name="stno" minlength="3" maxlength="3" type="text" class="form-control" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">仓库地址：</label>
                        <div class="col-sm-8">
                            <input id="address" type="text" class="form-control" name="address" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">值班电话：</label>
                        <div class="col-sm-8">
                            <input id="telephone" type="text" class="form-control" name="telephone" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">仓库容量</label>
                        <div class="col-sm-8">
                            <input type="number" id="capacity" name="capacity" class="form-control"/>
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
