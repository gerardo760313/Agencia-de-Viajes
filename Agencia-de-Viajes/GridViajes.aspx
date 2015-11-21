<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViajes.aspx.cs" Inherits="GridViajes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agencia de Viajes JMEN´s</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView runat="server" ID="gvViajes" AutoGenerateColumns="False" ShowFooter="True" DataKeyNames="Id,categoriaId,estatusId,fotoLugar,fotoHotel" OnRowCancelingEdit="gvViajes_RowCancelingEdit" OnRowDeleting="gvViajes_RowDeleting" OnRowEditing="gvViajes_RowEditing" OnRowUpdating="gvViajes_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="[Nombre]">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNombreEIT" runat="server" Text='<%# Bind("nombre") %>' placeholder="Nombre"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtNombreFT" runat="server" placeholder="Nombre"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha Llegada">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLlegadaEIT" runat="server" Text='<%# Bind("fechaLlegada") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("fechaLlegada", "{0:dd/MM/yyyy}") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtLlegadaFT" placeholder="Fecha de llegada" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Categoria]">
                    <EditItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlCategoriaEIT" AppendDataBoundItems="true">
                            <asp:ListItem Text="[Categoría]" Value="-1" />
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Categoria") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList runat="server" ID="ddlCategoriaFT" AppendDataBoundItems="true">
                            <asp:ListItem Text="[Categoría]" Value="-1" />
                        </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Destino]">
                    <EditItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlDestinoEIT" AppendDataBoundItems="true">
                            <asp:ListItem Text="[Destino]" Value="-1" />
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Destino") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList runat="server" ID="ddlDestinoFT" AppendDataBoundItems="true">
                            <asp:ListItem Text="[Destino]" Value="-1" />
                        </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Lugar]">
                    <EditItemTemplate>
                        <asp:FileUpload runat="server" ID="fuFotoLugarEIT" ToolTip="Foto del lugar a visitar" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ImageUrl='<%# Bind("fotoLugar") %>' runat="server" ID="imgFotoMini" Width="70px" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:FileUpload ID="fuFotoLugarFT" runat="server" ToolTip="Foto del lugar a visitar" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Hotel]">
                    <EditItemTemplate>
                        <asp:FileUpload runat="server" ID="fuFotoHotelEIT" ToolTip="Foto del Hotel" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ImageUrl='<%# Bind("fotoHotel") %>' runat="server" ID="imgFotoMini" Width="70px" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:FileUpload runat="server" ID="fuFotoHotelFT" ToolTip="Foto del hotel" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Descripción]">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDescrEIT" runat="server" Text='<%# Bind("descripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtDescrFT" runat="server" placeholder="Descripción" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Video]">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtVideoEIT" runat="server" Text='<%# Bind("video") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:PlaceHolder ID="phVideo" runat="server" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtVideoFT" runat="server" placeholder="Ruta de Video" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Estatus]">
                    <EditItemTemplate>
                        <asp:CheckBox ID="ckbEstatusEIT" runat="server" Checked='<%# Bind("estatus") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="ckbEstatus" runat="server" Checked='<%# Bind("estatus") %>' />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="chbEstatusFT" runat="server" Checked="true" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Editar]" ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="lnbEdit" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="lnbCancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnbEdit" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="lnbAgregar" Text="Agregar" runat="server" OnClick="lnbAgregar_Click" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="[Borrar]" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnbDelet" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>

    </form>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</body>
</html>
