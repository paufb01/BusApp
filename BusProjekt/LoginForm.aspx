<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BusProjekt.LoginForm" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
         <title>BUS PROJEKT</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet"
            integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
        <link rel="stylesheet" href="index.css">
    </head>

    <body>
        <div class="container-fluid">
            <h1 class="h1">EXAMPLE LOG IN/SIGN UP</h1>
            <nav class="navbar navbar-expand-lg bg-light">
                <div class="container-fluid">
                    <a class="navbar-brand" href="index.aspx"><img src="IMG/BUS.png" alt="" height="40" width="40" class="mb-3"></a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link" aria-current="page" href="index.aspx">Anmelden</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link active" href="#">Einloggen</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>


            <div class="form-content">
                <form id="form1" runat="server">
                    <h1 style="color: #2C2C2E;" class="h3 mb-3">Einloggen Sie Bitte</h1>
                    <label class="sr-only" for="email"></label>
                   <asp:TextBox ID="txtEmail" Cssclass="form-control mb-3" placeholder="E-Mail" runat="server" required autofocus></asp:TextBox>
                        <asp:TextBox ID="txtPasswort" type="password"  Cssclass="form-control mb-3" placeholder="Passwort" runat="server" required autofocus></asp:TextBox>
                    <div class="mb-3">
                        <span class="missatges mb-3"><a href="RecoveryRequest.aspx">Haben Sie Ihr Passwort vergessen?</a></span>
                    </div>
                    <div class="d-grid gap-2 mb-3">
                        <asp:Button ID="Einloggen" CssClass="btn btn-primary" runat="server" OnClick="Einloggen_Click" Text="Einloggen" />
                    </div>
                </form>
            </div>
        </div>
    </body>
        
    <!-- //bootstrap: -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous">
    </script>

    </html>
