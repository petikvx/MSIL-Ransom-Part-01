using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.ArmarCupon;

[NonNavigable]
public class NuevoCupon : Form
{
	private double _precio;

	private double _precioFicticio;

	private int _cantidad;

	private int _cantidadPorUsuario;

	private IContainer components;

	private Label label3;

	private Label label2;

	private TextBox txtCodigo;

	private Label label1;

	private Button btnCancel;

	private Button btnSave;

	private DateTimePicker dtpFechaPublicacion;

	private DateTimePicker dtpFechaVigencia;

	private DateTimePicker dtpFechaVencimiento;

	private Label label4;

	private TextBox txtPrecio;

	private Label label5;

	private TextBox txtPrecioOriginal;

	private Label label6;

	private TextBox txtCantidad;

	private Label label7;

	private TextBox txtCantidadPorUsuario;

	private Label label8;

	private Label cities;

	private CheckedListBox clbCiudades;

	private TextBox txtDescripcion;

	private Label label9;

	public event EventHandler<CuponSavedEventArgs> OnCuponSaved;

	public NuevoCupon()
	{
		InitializeComponent();
		new CiudadesManager().GetAll().ForEach(delegate(City x)
		{
			clbCiudades.get_Items().Add((object)x, false);
		});
		clbCiudades.set_DisplayMember("Name");
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void NuevoCupon_Load(object sender, EventArgs e)
	{
		((Control)txtCodigo).set_Text(CuponManager.GetCodigo());
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (Validate())
		{
			Cupon cupon = new Cupon
			{
				Cantidad = _cantidad,
				CantidadPorUsuario = _cantidadPorUsuario,
				Ciudades = ((IEnumerable)clbCiudades.get_CheckedItems()).OfType<City>().ToList(),
				Codigo = ((Control)txtCodigo).get_Text(),
				Descripcion = ((Control)txtDescripcion).get_Text(),
				FechaPublicacion = dtpFechaPublicacion.get_Value(),
				FechaVencimientoConsumo = dtpFechaVencimiento.get_Value(),
				FechaVencimientoOferta = dtpFechaVigencia.get_Value(),
				Precio = _precio,
				PrecioOriginal = _precioFicticio,
				Proveedor = new Proveedor
				{
					UserID = Session.User.UserID,
					UserName = Session.User.UserName
				},
				Publicado = false
			};
			if (this.OnCuponSaved != null)
			{
				this.OnCuponSaved(this, new CuponSavedEventArgs
				{
					Cupon = cupon
				});
			}
		}
	}

	private bool Validate()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime = Convert.ToDateTime(ConfigurationManager.get_AppSettings()["FechaSistema"]);
		if (dtpFechaPublicacion.get_Value() < dateTime)
		{
			MessageBox.Show(string.Format("La fecha de publicación no puede ser menor a ", dateTime.ToShortDateString()));
			return false;
		}
		if (dtpFechaVigencia.get_Value() < dtpFechaPublicacion.get_Value())
		{
			MessageBox.Show("La fecha de vigencia no puede ser menor a la fecha de publicación");
			return false;
		}
		if (dtpFechaVencimiento.get_Value() < dtpFechaVigencia.get_Value())
		{
			MessageBox.Show("La fecha de vencimiento no puede ser menor a la fecha de vigencia");
			return false;
		}
		if (!double.TryParse(((Control)txtPrecio).get_Text(), out _precio))
		{
			MessageBox.Show("El precio real debe ser numérico");
			return false;
		}
		if (!double.TryParse(((Control)txtPrecioOriginal).get_Text(), out _precioFicticio))
		{
			MessageBox.Show("El precio ficticio debe ser numérico");
			return false;
		}
		if (!int.TryParse(((Control)txtCantidad).get_Text(), out _cantidad))
		{
			MessageBox.Show("La cantidad de cupones disponibles debe ser numérica");
			return false;
		}
		if (!int.TryParse(((Control)txtCantidadPorUsuario).get_Text(), out _cantidadPorUsuario))
		{
			MessageBox.Show("La cantidad de cupones por usuario debe ser numérica");
			return false;
		}
		if (clbCiudades.get_CheckedItems().get_Count() == 0)
		{
			MessageBox.Show("Debe seleccionar al menos una ciudad");
			return false;
		}
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		label3 = new Label();
		label2 = new Label();
		txtCodigo = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		btnSave = new Button();
		dtpFechaPublicacion = new DateTimePicker();
		dtpFechaVigencia = new DateTimePicker();
		dtpFechaVencimiento = new DateTimePicker();
		label4 = new Label();
		txtPrecio = new TextBox();
		label5 = new Label();
		txtPrecioOriginal = new TextBox();
		label6 = new Label();
		txtCantidad = new TextBox();
		label7 = new Label();
		txtCantidadPorUsuario = new TextBox();
		label8 = new Label();
		cities = new Label();
		clbCiudades = new CheckedListBox();
		txtDescripcion = new TextBox();
		label9 = new Label();
		((Control)this).SuspendLayout();
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(19, 96));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(121, 13));
		((Control)label3).set_TabIndex(17);
		((Control)label3).set_Text("Vencimiento de la oferta");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(30, 70));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(110, 13));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("Fecha de Publicación");
		((Control)txtCodigo).set_Location(new Point(141, 13));
		((Control)txtCodigo).set_Name("txtCodigo");
		((TextBoxBase)txtCodigo).set_ReadOnly(true);
		((Control)txtCodigo).set_Size(new Size(181, 20));
		((Control)txtCodigo).set_TabIndex(14);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(99, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(40, 13));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("Código");
		((Control)btnCancel).set_Anchor((AnchorStyles)6);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Location(new Point(22, 402));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(12);
		((Control)btnCancel).set_Text("Cancelar");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Control)btnSave).set_Anchor((AnchorStyles)10);
		((Control)btnSave).set_Location(new Point(247, 402));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(11);
		((Control)btnSave).set_Text("Guardar");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)btnSave).add_Click((EventHandler)btnSave_Click);
		dtpFechaPublicacion.set_Format((DateTimePickerFormat)2);
		((Control)dtpFechaPublicacion).set_Location(new Point(141, 67));
		((Control)dtpFechaPublicacion).set_Name("dtpFechaPublicacion");
		((Control)dtpFechaPublicacion).set_Size(new Size(181, 20));
		((Control)dtpFechaPublicacion).set_TabIndex(21);
		dtpFechaVigencia.set_Format((DateTimePickerFormat)2);
		((Control)dtpFechaVigencia).set_Location(new Point(141, 93));
		((Control)dtpFechaVigencia).set_Name("dtpFechaVigencia");
		((Control)dtpFechaVigencia).set_Size(new Size(181, 20));
		((Control)dtpFechaVigencia).set_TabIndex(22);
		dtpFechaVencimiento.set_Format((DateTimePickerFormat)2);
		((Control)dtpFechaVencimiento).set_Location(new Point(141, 119));
		((Control)dtpFechaVencimiento).set_Name("dtpFechaVencimiento");
		((Control)dtpFechaVencimiento).set_Size(new Size(181, 20));
		((Control)dtpFechaVencimiento).set_TabIndex(24);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(11, 122));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(128, 13));
		((Control)label4).set_TabIndex(23);
		((Control)label4).set_Text("Vencimiento del consumo");
		((Control)txtPrecio).set_Location(new Point(141, 145));
		((Control)txtPrecio).set_Name("txtPrecio");
		((Control)txtPrecio).set_Size(new Size(181, 20));
		((Control)txtPrecio).set_TabIndex(26);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(82, 148));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(57, 13));
		((Control)label5).set_TabIndex(25);
		((Control)label5).set_Text("Precio real");
		((Control)txtPrecioOriginal).set_Location(new Point(141, 171));
		((Control)txtPrecioOriginal).set_Name("txtPrecioOriginal");
		((Control)txtPrecioOriginal).set_Size(new Size(181, 20));
		((Control)txtPrecioOriginal).set_TabIndex(28);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(69, 174));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(70, 13));
		((Control)label6).set_TabIndex(27);
		((Control)label6).set_Text("Precio ficticio");
		((Control)txtCantidad).set_Location(new Point(141, 198));
		((Control)txtCantidad).set_Name("txtCantidad");
		((Control)txtCantidad).set_Size(new Size(181, 20));
		((Control)txtCantidad).set_TabIndex(36);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(41, 201));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(99, 13));
		((Control)label7).set_TabIndex(35);
		((Control)label7).set_Text("Cantidad disponible");
		((Control)txtCantidadPorUsuario).set_Location(new Point(141, 224));
		((Control)txtCantidadPorUsuario).set_Name("txtCantidadPorUsuario");
		((Control)txtCantidadPorUsuario).set_Size(new Size(181, 20));
		((Control)txtCantidadPorUsuario).set_TabIndex(38);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(35, 227));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(104, 13));
		((Control)label8).set_TabIndex(37);
		((Control)label8).set_Text("Cantidad por usuario");
		((Control)cities).set_AutoSize(true);
		((Control)cities).set_Location(new Point(27, 250));
		((Control)cities).set_Name("cities");
		((Control)cities).set_Size(new Size(108, 13));
		((Control)cities).set_TabIndex(40);
		((Control)cities).set_Text("Zonas de adquisición");
		((ListControl)clbCiudades).set_FormattingEnabled(true);
		((Control)clbCiudades).set_Location(new Point(141, 250));
		((Control)clbCiudades).set_Name("clbCiudades");
		((Control)clbCiudades).set_Size(new Size(181, 139));
		((Control)clbCiudades).set_TabIndex(39);
		((Control)txtDescripcion).set_Location(new Point(141, 40));
		((Control)txtDescripcion).set_Name("txtDescripcion");
		((Control)txtDescripcion).set_Size(new Size(181, 20));
		((Control)txtDescripcion).set_TabIndex(42);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(72, 43));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(63, 13));
		((Control)label9).set_TabIndex(41);
		((Control)label9).set_Text("Descripción");
		((Form)this).set_AcceptButton((IButtonControl)(object)btnSave);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(344, 437));
		((Control)this).get_Controls().Add((Control)(object)txtDescripcion);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)cities);
		((Control)this).get_Controls().Add((Control)(object)clbCiudades);
		((Control)this).get_Controls().Add((Control)(object)txtCantidadPorUsuario);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)txtCantidad);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)txtPrecioOriginal);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)txtPrecio);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)dtpFechaVencimiento);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)dtpFechaVigencia);
		((Control)this).get_Controls().Add((Control)(object)dtpFechaPublicacion);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)txtCodigo);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).set_Name("NuevoCupon");
		((Control)this).set_Text("Nuevo Cupón");
		((Form)this).add_Load((EventHandler)NuevoCupon_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
