<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="StoreEdit.aspx.cs" Inherits="Inventory.UI.StoreEdit" %>
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
                            <input id="stno" name="stno" minlength="3" maxlength="3" type="text" disabled="disabled" runat="server" class="form-control" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">仓库地址：</label>
                        <div class="col-sm-8">
                            <input id="address" runat="server" type="text" class="form-control" name="address" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">值班电话</label>
                        <div class="col-sm-8">
                            <input id="telephone" runat="server" type="text" class="form-control" name="telephone" required="" aria-required="true">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">容量：</label>
                        <div class="col-sm-8">
                            <input type="number" id="capacity" runat="server" name="capacity" class="form-control"  />
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
