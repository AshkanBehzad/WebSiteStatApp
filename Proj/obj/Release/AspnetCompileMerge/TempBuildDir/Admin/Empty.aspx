<%@ Page Title="Empty" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Empty.aspx.cs" Inherits="Proj.Admin.WebForm1" %>
<asp:Content ID="cHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="bodyMain" runat="server">
   
      <!-- Page Content -->
        <div id="page-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                         <h1 class="page-header"><%: Title %>.</h1>
                        </div>
             <!-- /.col-lg-12 -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </div>
        <!-- /#page-wrapper -->
</asp:Content>
