<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proj.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
        <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    

    <!-- Bootstrap Core CSS -->
    <link href="../Components/Bower/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"/>

    <!-- MetisMenu CSS -->
    <link href="../Components/Bower/metisMenu/dist/metisMenu.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="../Content/css/sb-admin-2.css" rel="stylesheet"/>

    <!-- Custom Fonts -->
    <link href="../Components/Bower/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>
    <body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Please Sign In</h3>
                    </div>
                    <div class="panel-body">
                       
                                <div class="form-group">
                                    <asp:TextBox ID="txtUserName" class="form-control" placeholder="E-mail" name="email" type="email" autofocus="true" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtPassword" class="form-control" placeholder="Password" name="password" type="password" runat="server"/>
                                </div>
                                <div class="checkbox">
                                    <label>
                                        <asp:CheckBox ID="cbRemember" name="remember" type="checkbox" value="Remember Me" runat="server"/>Remember Me
                                    </label>
                                </div>
                               
                                <asp:Button ID="btnLogin" class="btn btn-lg btn-success btn-block" Text="Login" runat="server" OnClick="btnLogin_Click"/>
                           <p>not a member? <a href="SignUp.aspx">Sign Up!</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- jQuery -->
    <script src="../Components/Bower/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../Components/Bower/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="../Components/Bower/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="../Scripts/sb-admin-2.js"></script>
    </form>
</body>
</html>
