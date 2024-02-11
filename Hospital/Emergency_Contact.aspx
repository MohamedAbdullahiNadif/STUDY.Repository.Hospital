﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emergency_Contact.aspx.cs" Inherits="Hospital.Emergency_Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>
  <title>Dashtreme Admin - Free Dashboard for Bootstrap 4 by Codervent</title>
  <!-- loader-->
  <link href="assets/css/pace.min.css" rel="stylesheet"/>
  <script src="assets/js/pace.min.js"></script>
  <!--favicon-->
  <link rel="icon" href="assets/images/favicon.ico" type="image/x-icon"/>
  <!-- simplebar CSS-->
  <link href="assets/plugins/simplebar/css/simplebar.css" rel="stylesheet"/>
  <!-- Bootstrap core CSS-->
  <link href="assets/css/bootstrap.min.css" rel="stylesheet"/>
  <!-- animate CSS-->
  <link href="assets/css/animate.css" rel="stylesheet" type="text/css"/>
  <!-- Icons CSS-->
  <link href="assets/css/icons.css" rel="stylesheet" type="text/css"/>
  <!-- Sidebar CSS-->
  <link href="assets/css/sidebar-menu.css" rel="stylesheet"/>
  <!-- Custom Style-->
  <link href="assets/css/app-style.css" rel="stylesheet"/>
  
  
</head>

<body class="bg-theme bg-theme2">
        <!-- start loader -->
   <div id="pageloader-overlay" class="visible incoming"><div class="loader-wrapper-outer"><div class="loader-wrapper-inner" ><div class="loader"></div></div></div></div>
   <!-- end loader -->

<!-- Start wrapper-->
 <div id="wrapper">
   <div id="sidebar-wrapper" data-simplebar="" data-simplebar-auto-hide="true">
     <div class="brand-logo" id="theme2">
      <a href="form.aspx">
       <img src="assets/images/logo-icon.png" class="logo-icon" alt="logo icon"/>
       <h5 class="logo-text">Dashtreme Admin</h5>
     </a>
   </div>
   <ul id="theme2" class="sidebar-menu do-nicescrol">
      <li class="sidebar-header">MAIN NAVIGATION</li>
      <li>
        <a href="index.aspx">
          <i class="fa fa-dashboard"></i> 
          <span>Dashboard</span>
        </a>
       <li class="submenu">
       <a href="#"><i class="fa fa-bed" style="font-size:24px"></i> <span>Patient</span>  <span
                                    class="arrow"></span></a>
       <ul>
        <li><a href="Patient.aspx">Add Patient</a></li>
      <li><a href="Patient List.aspx">Patient List</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="nav-icon fa fa-hospital-o" style="font-size:24px"></i> <span>Department</span></a>
       <ul>
       <li><a href="Department.aspx">Add Department</a></li>
      <li><a href="Department List.aspx">Department List</a></li>
      </ul>
      </li> 
       <li class="submenu">
       <a href="#"><i class="fa fa-user-secret" style="font-size:24px"></i> <span>Staff</span></a>
       <ul>
       <li><a href="Staff.aspx">Add Staff</a></li>
      <li><a href="Staff List.aspx">Staff List</a></li>
      </ul>
      </li> 
     <li class="submenu">
       <a href="#"><i class="fa fa-user-md" style="font-size:24px"></i> <span>Doctor</span></a>
       <ul>
       <li><a href="Doctor.aspx">Add Doctor</a></li>
      <li><a href="Doctor List.aspx">Doctor List</a></li>
      </ul>
      </li> 
      <li class="submenu">
       <a href="#"><i class="fa fa-user-nurse" style="font-size:24px"></i> <span>Nurse</span></a>
       <ul>
       <li><a href="Nurse.aspx">Add Nurse</a></li>
      <li><a href="Nurse List.aspx">Nurse List</a></li>
      </ul>
      </li>
       <li class="submenu">
       <a href="#"><i class="fa fa-ambulance" style="font-size:24px"></i> <span>Emergency</span></a>
        </li>
       <ul>
       <li><a href="Emergency_Contact.aspx">Add Emergency</a></li>
      <li><a href="Emergency List.aspx">Emergency List</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="fa-solid fa-microscope" style="font-size:24px"></i> <span>lab_Test</span></a>
       <ul>
       <li><a href="Labtast.aspx">Add lab_Test</a></li>
       <li><a href="Lab_Screening.aspx">Add Lab_Results</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="fa fa-door-open" style="font-size:24px"></i> <span>Room</span></a>
       <ul>
       <li><a href="Room.aspx">Add Room</a></li>
      <li><a href="Room List.aspx">Room List</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="fa-solid fa-syringe" style="font-size:24px"></i> <span>Medicine</span></a>
       <ul>
       <li><a href="Medicine.aspx">Add Medicine</a></li>
      <li><a href="Medicine List.aspx">Medicine List</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="fa-solid fa-prescription" style="font-size:24px"></i> <span>Prescription</span></a>
       <ul>
       <li><a href="Prescription.aspx">Add Prescription</a></li>
      <li><a href="Prescription List.aspx">Prescription List</a></li>
      </ul>
      </li>
       <li class="submenu">
       <a href="#"><i class="fa fa-medkit" style="font-size:24px"></i> <span>Medical_History</span></a>
       <ul>
       <li><a href="Medical_History.aspx">Add Medical_History</a></li>
      <li><a href="Medical_History List.aspx">Medical_History List</a></li>
      </ul>
      </li>
       <li class="submenu">
       <a href="#"><i class="fa fa-clock-o" style="font-size:24px"></i> <span>Appointment</span></a>
       <ul>
       <li><a href="Appointment.aspx">Add Appointment</a></li>
      <li><a href="Appointment List.aspx">Appointment List</a></li>
      </ul>
      </li>
      <li class="submenu">
       <a href="#"><i class="fa-solid fa-comments-dollar" style="font-size:24px"></i> <span>Bill</span></a>
       <ul>
       <li><a href="Bill.aspx">Add Bill</a></li>
      <li><a href="Bill List.aspx">Bill List</a></li>
      </ul>
      </li>
       </ul>
       </div>
   <!--End sidebar-wrapper-->
  

<!--Start topbar header-->
<header class="topbar-nav">
 <nav class="navbar navbar-expand fixed-top">
  <ul class="navbar-nav mr-auto align-items-center">
    <li class="nav-item">
      <a class="nav-link toggle-menu" href="javascript:void();">
       <i class="icon-menu menu-icon"></i>
     </a>
    </li>
    <li class="nav-item">
      Dashboard
    </li>
  </ul>
     
  
</nav>
</header>
<!--End topbar header-->
<div class="clearfix"></div>
  <div class="content-wrapper">
    <div class="container-fluid">
      <div class="col-lg-6">
        <div class="card">
           <div class="card-body">
           <div class="card-title">Emergency Form</div>
           <hr/>
            <form id="form2" runat="server">
           <div class="form-group">
            <label for="input-6">Contact_Name</label>
            <asp:TextBox ID="txtContact_Name" CssClass="form-control form-control-rounded" runat="server" placeholder="Enter Your full_Name"></asp:TextBox>
           </div>
             <div class="form-group">
            <label for="input-6">Phone</label>
            <asp:TextBox ID="txtphone" CssClass="form-control form-control-rounded" runat="server" placeholder="Enter Your Phone"></asp:TextBox>
           </div>
           <div class="form-group">
            <label for="input-7">Relation</label>
           <asp:TextBox ID="txtRelation" CssClass="form-control form-control-rounded" runat="server" placeholder="Enter Your Relation"></asp:TextBox>
           </div>
            <hr />
           <div class="col-4 form-control-rounded">
               <div class="row">
               <asp:TextBox ID="txtid" CssClass="form-control form-control-rounded"  runat="server" placeholder="Enter ID:Update or Delet" ></asp:TextBox>
                   <asp:Label ID="lbl" runat="server" BorderStyle="Ridge" ForeColor="#0066FF"></asp:Label>

                   </div>
                   </div>
                <asp:Button ID="btnsubmit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                <asp:Button ID="btnUpdate" CssClass="btn btn-success" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btndelet"  CssClass="btn btn-danger" runat="server" Text="Delet" OnClick="btndelet_Click" />
                <br />
          </form>
         </div>
         </div>
      </div>
    </div><!--End Row-->

	<!--start overlay-->
		  <div class="overlay toggle-menu"></div>
		<!--end overlay-->

    </div>
    <!-- End container-fluid-->
    
   </div><!--End content-wrapper-->
   <!--Start Back To Top Button-->
    <a href="javaScript:void();" class="back-to-top"><i class="fa fa-angle-double-up"></i> </a>
    <!--End Back To Top Button-->
	
	<!--Start footer-->
	<footer class="footer">
      <div class="container">
        <div class="text-center">
          Copyright © 2018 Dashtreme Admin
        </div>
      </div>
    </footer>
	<!--End footer-->
	
	<!--start color switcher-->
  <!--- <div class="right-sidebar">
    <div class="switcher-icon">
      <i class="zmdi zmdi-settings zmdi-hc-spin"></i>
    </div>
    <div class="right-sidebar-content">

      <p class="mb-0">Gaussion Texture</p>
      <hr>
      
      <ul class="switcher">
        <li id="theme1"></li>
        <li id="theme2"></li>
        <li id="theme3"></li>
        <li id="theme4"></li>
        <li id="theme5"></li>
        <li id="theme6"></li>
      </ul>

      <p class="mb-0">Gradient Background</p>
      <hr>
      
      <ul class="switcher">
        <li id="theme7"></li>
        <li id="theme8"></li>
        <li id="theme9"></li>
        <li id="theme10"></li>
        <li id="theme11"></li>
        <li id="theme12"></li>
		<li id="theme13"></li>
        <li id="theme14"></li>
        <li id="theme15"></li>
      </ul>
      
     </div>
   </div>
  <!--end color switcher-->-------->
   
 <!--End wrapper-->


  <!-- Bootstrap core JavaScript-->
  <script src="assets/js/jquery.min.js"></script>
  <script src="assets/js/popper.min.js"></script>
  <script src="assets/js/bootstrap.min.js"></script>
	
 <!-- simplebar js -->
  <script src="assets/plugins/simplebar/js/simplebar.js"></script>
  <!-- sidebar-menu js -->
  <script src="assets/js/sidebar-menu.js"></script>
  
  <!-- Custom scripts -->
  <script src="assets/js/app-script.js"></script>
	
</body>
</html>

