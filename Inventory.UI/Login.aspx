<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Inventory.UI.Login" %>
<!DOCTYPE html>
<html lang="en">


<!-- Mirrored from www.zi-han.net/theme/hplus/login_v2.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 20 Jan 2016 14:19:49 GMT -->
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0">
    <title>H+ 仓库管理系统 - 登录</title>
    <meta name="keywords" content="淮阴师范学院">
    <meta name="description" content="仓库管理系统是公司内部使用">
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/font-awesome.min93e3.css?v=4.4.0" rel="stylesheet">
    <link href="css/animate.min.css" rel="stylesheet">
    <link href="css/style.min.css" rel="stylesheet">
    <link href="css/login.min.css" rel="stylesheet">
    <!--[if lt IE 9]>
    <meta http-equiv="refresh" content="0;ie.html" />
    <![endif]-->
    <script>
        if(window.top!==window.self){window.top.location=window.location};
    </script>

</head>

<body class="signin">
    <div class="signinpanel">
        <div class="row">
            <div class="col-sm-7">
                <div class="signin-info">
                    <div class="logopanel m-b">
                        <h1>[ H+ ]</h1>
                    </div>
                    <div class="m-b"></div>
                    <h4>欢迎使用 <strong>仓库管理系统</strong></h4>
                    
                    <strong>还没有账号？ <a href="#">立即注册&raquo;</a></strong>
                </div>
            </div>
            <div class="col-sm-5">
                <form runat="server">
                    <h4 class="no-margins">登录：</h4>
                    <p class="m-t-md">登录到仓库管理系统</p>
                    <input type="text" name="mno" class="form-control uname" placeholder="编码" />
                    <input type="text" name="mname" class="form-control pword" placeholder="姓名" />
                    <a href="#">忘记密码了？</a>
                    <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-success btn-block" Text="登录" OnClick="btnLogin_OnClick" />
                </form>
            </div>
        </div>
        <div class="signup-footer">
            <div class="pull-left">
                &copy; 2019-210 All Rights Reserved. GUFENG &reg;
            </div>
        </div>
    </div>
</body>


<!-- Mirrored from www.zi-han.net/theme/hplus/login_v2.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 20 Jan 2016 14:19:52 GMT -->
</html>

