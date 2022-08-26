<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClienteWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <h3>Mantenimiento para Alumno</h3>

        <p>
            CodAlumno : <asp:TextBox runat="server" Id="txtCodAlumno"/>
        </p>
        <p>
            Apellidos : <asp:TextBox runat="server" Id="txtApellidos"/>
        </p>
        <p>
            Nombres : <asp:TextBox runat="server" Id="txtNombres"/>
        </p>
        <p>
            LugarNac : <asp:TextBox runat="server" Id="txtLugarNac"/>
        </p>
        <p>
            FechaNac : <asp:TextBox runat="server" Id="txtFechaNac"/>
        </p>
        <p>
            CodEscuela : <asp:TextBox runat="server" Id="txtCodEscuela"/>
        </p>
        <p>
            <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click1"/>
            <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
            <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" />
        </p>
        <p>
            Buscar:<asp:TextBox runat="server" ID="Buscar" />
            <asp:DropDownList runat="server" ID="Busqueda">
                <asp:ListItem Text="codAlumno" />
                <asp:ListItem Text="alumno" />
            </asp:DropDownList>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
        </p>
        <p>
            <h1>Tabla Escuela</h1>
            <asp:GridView runat="server" ID="gvEscuela"></asp:GridView>
        </p>
    </form>
</body>
</html>
