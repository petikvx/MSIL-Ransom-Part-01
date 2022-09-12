using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;

namespace Coache.Login;

public class ClienteUserControl : UserControl
{
	private Cliente _cliente;

	private IContainer components;

	private Label label1;

	private TextBox txtNombre;

	private TextBox txtApellido;

	private Label label2;

	private TextBox txtDNI;

	private Label label3;

	private TextBox txtMail;

	private Label label4;

	private TextBox txtDireccion;

	private Label label5;

	private TextBox txtCP;

	private Label label6;

	private Label label7;

	private DateTimePicker dtFechaNacimiento;

	private CheckedListBox clbCiudades;

	private Label cities;

	private Label label8;

	private TextBox txtTelefono;

	private Label label9;

	private Label label10;

	private ComboBox cbxCiudad;

	public Cliente GetCliente()
	{
		long result = 0L;
		long result2 = 0L;
		if (!long.TryParse(((Control)txtTelefono).get_Text().Trim().Replace("-", ""), out result))
		{
			throw new Exception("El teléfono debe ser numérico!");
		}
		if (!long.TryParse(((Control)txtDNI).get_Text(), out result2))
		{
			throw new Exception("El DNI debe ser numérico!");
		}
		if (string.IsNullOrEmpty(((Control)txtNombre).get_Text().Trim()))
		{
			throw new Exception("El Nombre es obligatorio!");
		}
		if (string.IsNullOrEmpty(((Control)txtApellido).get_Text().Trim()))
		{
			throw new Exception("El Apellido es obligatorio!");
		}
		List<City> list = ((IEnumerable)clbCiudades.get_CheckedItems()).Cast<City>().ToList();
		if (list.Count == 0)
		{
			throw new Exception("Debe seleccionar al menos una ciudad!");
		}
		_cliente.Apellido = ((Control)txtApellido).get_Text().Trim();
		_cliente.Nombre = ((Control)txtNombre).get_Text().Trim();
		_cliente.DNI = result2;
		_cliente.FechaNacimiento = dtFechaNacimiento.get_Value();
		_cliente.Ciudades = list;
		_cliente.DetalleEntidad.CP = ((Control)txtCP).get_Text().Trim();
		_cliente.DetalleEntidad.Direccion = ((Control)txtDireccion).get_Text().Trim();
		_cliente.DetalleEntidad.Telefono = result;
		_cliente.DetalleEntidad.Email = ((Control)txtMail).get_Text().Trim();
		_cliente.DetalleEntidad.Ciudad = (City)cbxCiudad.get_SelectedItem();
		return _cliente;
	}

	public void SetUser(Cliente cliente)
	{
		_cliente = cliente;
		((Control)txtApellido).set_Text(cliente.Apellido.Trim());
		((Control)txtNombre).set_Text(cliente.Nombre.Trim());
		((Control)txtDNI).set_Text(cliente.DNI.ToString());
		dtFechaNacimiento.set_Value(cliente.FechaNacimiento);
		((Control)txtCP).set_Text(cliente.DetalleEntidad.CP.Trim());
		((Control)txtDireccion).set_Text(cliente.DetalleEntidad.Direccion.Trim());
		((Control)txtTelefono).set_Text(cliente.DetalleEntidad.Telefono.ToString());
		((Control)txtMail).set_Text(cliente.DetalleEntidad.Email.Trim());
		cbxCiudad.set_SelectedItem((object)cliente.DetalleEntidad.Ciudad);
		foreach (City ciudade in cliente.Ciudades)
		{
			clbCiudades.SetItemChecked(((ObjectCollection)clbCiudades.get_Items()).IndexOf((object)ciudade), true);
		}
	}

	public ClienteUserControl()
	{
		InitializeComponent();
		_cliente = new Cliente();
		List<City> all = new CiudadesManager().GetAll();
		clbCiudades.set_DisplayMember("Name");
		((ListControl)cbxCiudad).set_DisplayMember("Name");
		all.ForEach(delegate(City x)
		{
			clbCiudades.get_Items().Add((object)x, false);
		});
		all.ForEach(delegate(City x)
		{
			cbxCiudad.get_Items().Add((object)x);
		});
		((ListControl)cbxCiudad).set_SelectedIndex(0);
	}

	private void ClienteUserControl_Load(object sender, EventArgs e)
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		label1 = new Label();
		txtNombre = new TextBox();
		txtApellido = new TextBox();
		label2 = new Label();
		txtDNI = new TextBox();
		label3 = new Label();
		txtMail = new TextBox();
		label4 = new Label();
		txtDireccion = new TextBox();
		label5 = new Label();
		txtCP = new TextBox();
		label6 = new Label();
		label7 = new Label();
		dtFechaNacimiento = new DateTimePicker();
		clbCiudades = new CheckedListBox();
		cities = new Label();
		label8 = new Label();
		txtTelefono = new TextBox();
		label9 = new Label();
		label10 = new Label();
		cbxCiudad = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(50, 14));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(44, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Nombre");
		((Control)txtNombre).set_Location(new Point(102, 11));
		((Control)txtNombre).set_Name("txtNombre");
		((Control)txtNombre).set_Size(new Size(200, 20));
		((Control)txtNombre).set_TabIndex(1);
		((Control)txtApellido).set_Location(new Point(102, 37));
		((Control)txtApellido).set_Name("txtApellido");
		((Control)txtApellido).set_Size(new Size(200, 20));
		((Control)txtApellido).set_TabIndex(3);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(52, 40));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(44, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Apellido");
		((Control)txtDNI).set_Location(new Point(102, 63));
		((Control)txtDNI).set_Name("txtDNI");
		((Control)txtDNI).set_Size(new Size(200, 20));
		((Control)txtDNI).set_TabIndex(5);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(68, 66));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(26, 13));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("DNI");
		((Control)txtMail).set_Location(new Point(102, 89));
		((Control)txtMail).set_Name("txtMail");
		((Control)txtMail).set_Size(new Size(200, 20));
		((Control)txtMail).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(68, 92));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(26, 13));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Mail");
		((Control)txtDireccion).set_Location(new Point(102, 115));
		((Control)txtDireccion).set_Name("txtDireccion");
		((Control)txtDireccion).set_Size(new Size(200, 20));
		((Control)txtDireccion).set_TabIndex(9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(46, 118));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(52, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("Dirección");
		((Control)txtCP).set_Location(new Point(102, 194));
		((Control)txtCP).set_Name("txtCP");
		((Control)txtCP).set_Size(new Size(200, 20));
		((Control)txtCP).set_TabIndex(11);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(75, 197));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(21, 13));
		((Control)label6).set_TabIndex(10);
		((Control)label6).set_Text("CP");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(5, 223));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(93, 13));
		((Control)label7).set_TabIndex(12);
		((Control)label7).set_Text("Fecha Nacimiento");
		dtFechaNacimiento.set_Format((DateTimePickerFormat)2);
		((Control)dtFechaNacimiento).set_Location(new Point(102, 220));
		((Control)dtFechaNacimiento).set_Name("dtFechaNacimiento");
		((Control)dtFechaNacimiento).set_Size(new Size(200, 20));
		((Control)dtFechaNacimiento).set_TabIndex(13);
		((ListControl)clbCiudades).set_FormattingEnabled(true);
		((Control)clbCiudades).set_Location(new Point(102, 246));
		((Control)clbCiudades).set_Name("clbCiudades");
		((Control)clbCiudades).set_Size(new Size(200, 109));
		((Control)clbCiudades).set_TabIndex(14);
		((Control)cities).set_AutoSize(true);
		((Control)cities).set_Location(new Point(28, 239));
		((Control)cities).set_Name("cities");
		((Control)cities).set_Size(new Size(66, 13));
		((Control)cities).set_TabIndex(15);
		((Control)cities).set_Text("Ciudades de");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(34, 259));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(60, 13));
		((Control)label8).set_TabIndex(16);
		((Control)label8).set_Text("preferencia");
		((Control)txtTelefono).set_Location(new Point(102, 167));
		((Control)txtTelefono).set_Name("txtTelefono");
		((Control)txtTelefono).set_Size(new Size(200, 20));
		((Control)txtTelefono).set_TabIndex(18);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(46, 170));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(49, 13));
		((Control)label9).set_TabIndex(17);
		((Control)label9).set_Text("Telefono");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(46, 144));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(40, 13));
		((Control)label10).set_TabIndex(19);
		((Control)label10).set_Text("Ciudad");
		cbxCiudad.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbxCiudad).set_FormattingEnabled(true);
		((Control)cbxCiudad).set_Location(new Point(102, 141));
		((Control)cbxCiudad).set_Name("cbxCiudad");
		((Control)cbxCiudad).set_Size(new Size(200, 21));
		((Control)cbxCiudad).set_TabIndex(20);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)cbxCiudad);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)txtTelefono);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)cities);
		((Control)this).get_Controls().Add((Control)(object)clbCiudades);
		((Control)this).get_Controls().Add((Control)(object)dtFechaNacimiento);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)txtCP);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)txtDireccion);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)txtMail);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)txtDNI);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtApellido);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)txtNombre);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("ClienteUserControl");
		((Control)this).set_Size(new Size(336, 402));
		((UserControl)this).add_Load((EventHandler)ClienteUserControl_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
