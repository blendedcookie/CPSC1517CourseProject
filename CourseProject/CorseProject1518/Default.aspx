<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Course Project - R6</h1>
        <p class="lead">Seans Course Project - R6</p>
        <p><a href="http://www.github.com" class="btn btn-primary btn-lg">Github &raquo;</a></p>

        <p>This form was created as a final project for CPSC 1517 in 2017 by Sean Laing.</p>
    </div>


    

    <div class="col-md-12">
        <h3>Incomplete Sections</h3>
        <p>
            1. Form A<br />
            2. Form B<br />
            3. Form C<br />
            4. Class OutLine?<br />
        </p>
    </div>

    <div class="col-md-12">
        <h3>Known Bugs List</h3>
        <p>
            1. <br />
            2. <br />
            3. <br />
            4. <br />
        </p>
    </div>

    <div class="col-md-12">
        <h3>Stored Procedures Used</h3>
        <p>
            1. <br />
            2. <br />
            3. <br />
            4. <br />
        </p>
    </div>


    <div class="row">
        <div class="col-md-4">
            <h2>Form Page A</h2>
            <p>
                This is the CRUD page (create read update delete). used for making and maintaining single records on the server for ship methods.
            </p>
            
        </div>
        <div class="col-md-4">
            <h2>Form Page B</h2>
            <p>
              Gridview lookup with code-behind. Purchase orders for ship method.

            </p>
           
        </div>
        <div class="col-md-4">
            <h2>Form Page C</h2>
            <p>
                Gridview lookup with ObjectDataSource controls. Purchase orders for ship method.
            </p>
        </div>
        
        <div class="col-md-12">
            <img  src="images/ERD.PNG"  alt="ERD PICTURE"  height="350"  />
        </div>


    </div>
</asp:Content>
