using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;

namespace Coache.Login;

public class ProveedorUserControl : UserControl
{
	private Proveedor _proveedor;

	private IContainer components;

	private ComboBox cbxCiudad;

	private Label label10;

	private TextBox txtTelefono;

	private Label label9;

	private TextBox txtCP;

	private Label label6;

	private TextBox txtDireccion;

	private Label label5;

	private TextBox txtMail;

	private Label label4;

	private TextBox txtRazonSocial;

	private Label label1;

	private TextBox txtCUIT;

	private Label label2;

	private ComboBox cbxRubro;

	private Label label3;

	private TextBox txtContacto;

	private Label label7;

	public ProveedorUserControl()
	{
		InitializeComponent();
		_proveedor = new Proveedor();
		List<City> all = new CiudadesManager().GetAll();
		RubrosManager rubrosManager = new RubrosManager();
		cbxRubro.set_DataSource((object)rubrosManager.GetAll());
		((ListControl)cbxRubro).set_DisplayMember("Name");
		((ListControl)cbxRubro).set_SelectedIndex(0);
		cbxCiudad.set_DataSource((object)all);
		((ListControl)cbxCiudad).set_DisplayMember("Name");
		((ListControl)cbxCiudad).set_SelectedIndex(0);
	}

	public Proveedor GetProveedor()
	{
		long result = 0L;
		if (!long.TryParse(((Control)txtTelefono).get_Text(), out result))
		{
			throw new Exception("El teléfono debe ser numérico!");
		}
		if (string.IsNullOrEmpty(((Control)txtCUIT).get_Text().Trim()))
		{
			throw new Exception("El CUIT es obligatorio!");
		}
		if (string.IsNullOrEmpty(((Control)txtRazonSocial).get_Text().Trim()))
		{
			throw new Exception("La Razón Social es obligatoria!");
		}
		_proveedor.CUIT = ((Control)txtCUIT).get_Text().Trim();
		_proveedor.NombreContacto = ((Control)txtContacto).get_Text().Trim();
		_proveedor.RazonSocial = ((Control)txtRazonSocial).get_Text().Trim();
		_proveedor.Rubro = (Rubro)cbxRubro.get_SelectedItem();
		_proveedor.DetalleEntidad = new DetalleEntidad
		{
			Ciudad = (City)cbxCiudad.get_SelectedItem(),
			CP = ((Control)txtCP).get_Text().Trim(),
			Email = ((Control)txtMail).get_Text().Trim(),
			Direccion = ((Control)txtDireccion).get_Text().Trim(),
			Telefono = result
		};
		return _proveedor;
	}

	public void SetUser(Proveedor proveedor)
	{
		_proveedor = proveedor;
		((Control)txtContacto).set_Text(proveedor.NombreContacto.Trim());
		((Control)txtCUIT).set_Text(proveedor.CUIT.Trim());
		((Control)txtRazonSocial).set_Text(proveedor.RazonSocial.Trim());
		((Control)txtCP).set_Text(proveedor.DetalleEntidad.CP.Trim());
		((Control)txtDireccion).set_Text(proveedor.DetalleEntidad.Direccion.Trim());
		((Control)txtTelefono).set_Text(proveedor.DetalleEntidad.Telefono.ToString());
		((Control)txtMail).set_Text(proveedor.DetalleEntidad.Email.Trim());
		cbxCiudad.set_SelectedItem((object)proveedor.DetalleEntidad.Ciudad);
		cbxRubro.set_SelectedItem((object)proveedor.Rubro);
	}

	private void ProveedorUserControl_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		cbxCiudad = new ComboBox();
		label10 = new Label();
		txtTelefono = new TextBox();
		label9 = new Label();
		txtCP = new TextBox();
		label6 = new Label();
		txtDireccion = new TextBox();
		label5 = new Label();
		txtMail = new TextBox();
		label4 = new Label();
		txtRazonSocial = new TextBox();
		label1 = new Label();
		txtCUIT = new TextBox();
		label2 = new Label();
		cbxRubro = new ComboBox();
		label3 = new Label();
		txtContacto = new TextBox();
		label7 = new Label();
		((Control)this).SuspendLayout();
		cbxCiudad.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbxCiudad).set_FormattingEnabled(true);
		((Control)cbxCiudad).set_Location(new Point(112, 117));
		((Control)cbxCiudad).set_Name("cbxCiudad");
		((Control)cbxCiudad).set_Size(new Size(200, 21));
		((Control)cbxCiudad).set_TabIndex(31);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(66, 120));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(40, 13));
		((Control)label10).set_TabIndex(40);
		((Control)label10).set_Text("Ciudad");
		((Control)txtTelefono).set_Location(new Point(112, 65));
		((Control)txtTelefono).set_Name("txtTelefono");
		((Control)txtTelefono).set_Size(new Size(200, 20));
		((Control)txtTelefono).set_TabIndex(29);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(56, 68));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(49, 13));
		((Control)label9).set_TabIndex(38);
		((Control)label9).set_Text("Telefono");
		((Control)txtCP).set_Location(new Point(112, 144));
		((Control)txtCP).set_Name("txtCP");
		((Control)txtCP).set_Size(new Size(200, 20));
		((Control)txtCP).set_TabIndex(32);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(85, 147));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(21, 13));
		((Control)label6).set_TabIndex(31);
		((Control)label6).set_Text("CP");
		((Control)txtDireccion).set_Location(new Point(112, 91));
		((Control)txtDireccion).set_Name("txtDireccion");
		((Control)txtDireccion).set_Size(new Size(200, 20));
		((Control)txtDireccion).set_TabIndex(30);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(56, 94));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(52, 13));
		((Control)label5).set_TabIndex(29);
		((Control)label5).set_Text("Dirección");
		((Control)txtMail).set_Location(new Point(112, 39));
		((Control)txtMail).set_Name("txtMail");
		((Control)txtMail).set_Size(new Size(200, 20));
		((Control)txtMail).set_TabIndex(28);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(78, 42));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(26, 13));
		((Control)label4).set_TabIndex(27);
		((Control)label4).set_Text("Mail");
		((Control)txtRazonSocial).set_Location(new Point(112, 13));
		((Control)txtRazonSocial).set_Name("txtRazonSocial");
		((Control)txtRazonSocial).set_Size(new Size(200, 20));
		((Control)txtRazonSocial).set_TabIndex(22);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(38, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(70, 13));
		((Control)label1).set_TabIndex(21);
		((Control)label1).set_Text("Razón Social");
		((Control)txtCUIT).set_Location(new Point(112, 170));
		((TextBoxBase)txtCUIT).set_MaxLength(20);
		((Control)txtCUIT).set_Name("txtCUIT");
		((Control)txtCUIT).set_Size(new Size(200, 20));
		((Control)txtCUIT).set_TabIndex(33);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(74, 173));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(32, 13));
		((Control)label2).set_TabIndex(42);
		((Control)label2).set_Text("CUIT");
		cbxRubro.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbxRubro).set_FormattingEnabled(true);
		((Control)cbxRubro).set_Location(new Point(112, 196));
		((Control)cbxRubro).set_Name("cbxRubro");
		((Control)cbxRubro).set_Size(new Size(200, 21));
		((Control)cbxRubro).set_TabIndex(43);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(66, 199));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(36, 13));
		((Control)label3).set_TabIndex(44);
		((Control)label3).set_Text("Rubro");
		((Control)txtContacto).set_Location(new Point(111, 223));
		((Control)txtContacto).set_Name("txtContacto");
		((Control)txtContacto).set_Size(new Size(200, 20));
		((Control)txtContacto).set_TabIndex(45);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(55, 226));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(50, 13));
		((Control)label7).set_TabIndex(46);
		((Control)label7).set_Text("Contacto");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)txtContacto);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)cbxRubro);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtCUIT);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)cbxCiudad);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)txtTelefono);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)txtCP);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)txtDireccion);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)txtMail);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)txtRazonSocial);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("ProveedorUserControl");
		((Control)this).set_Size(new Size(385, 276));
		((UserControl)this).add_Load((EventHandler)ProveedorUserControl_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
