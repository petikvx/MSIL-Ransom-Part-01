using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.CargaCredito;

[NonNavigable]
public class NuevoPago : Form
{
	private PagosManager _manager = new PagosManager();

	private IContainer components;

	private Label lblPerfil;

	private ComboBox cbxTipoPago;

	private TextBox txtMonto;

	private Label label1;

	private TextBox txtBanco;

	private Label label2;

	private TextBox txtTarjeta;

	private Label label3;

	private Button btnCancelar;

	private Button btnGuardar;

	public event EventHandler<PagoAddedEventArgs> OnPagoAdded;

	public NuevoPago()
	{
		InitializeComponent();
		foreach (TipoPago tipoPago in _manager.GetTipoPagos())
		{
			cbxTipoPago.get_Items().Add((object)tipoPago);
		}
		((ListControl)cbxTipoPago).set_SelectedIndex(0);
	}

	private void btnCancelar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cbxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool enabled = (TipoPago)cbxTipoPago.get_SelectedItem() == TipoPago.Tarjeta;
		((Control)txtBanco).set_Enabled(enabled);
		((Control)txtTarjeta).set_Enabled(enabled);
	}

	private void btnGuardar_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		double result = 0.0;
		TipoPago tipoPago = (TipoPago)cbxTipoPago.get_SelectedItem();
		if (!double.TryParse(((Control)txtMonto).get_Text(), out result))
		{
			MessageBox.Show("El monto debe ser numérico");
			return;
		}
		if (result <= 15.0)
		{
			MessageBox.Show("El monto debe ser mayor a $15");
			return;
		}
		if (tipoPago == TipoPago.Tarjeta)
		{
			if (string.IsNullOrEmpty(((Control)txtBanco).get_Text()))
			{
				MessageBox.Show("Debe ingresar un banco");
				return;
			}
			if (string.IsNullOrEmpty(((Control)txtTarjeta).get_Text()))
			{
				MessageBox.Show("Debe ingresar los datos de la tarjeta");
				return;
			}
		}
		if (this.OnPagoAdded != null)
		{
			this.OnPagoAdded(this, new PagoAddedEventArgs
			{
				Pago = new Pago
				{
					Banco = ((Control)txtBanco).get_Text(),
					Credito = result,
					Tarjeta = ((Control)txtTarjeta).get_Text(),
					TipoPago = tipoPago,
					Fecha = Convert.ToDateTime(ConfigurationManager.get_AppSettings()["FechaSistema"])
				}
			});
		}
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
		lblPerfil = new Label();
		cbxTipoPago = new ComboBox();
		txtMonto = new TextBox();
		label1 = new Label();
		txtBanco = new TextBox();
		label2 = new Label();
		txtTarjeta = new TextBox();
		label3 = new Label();
		btnCancelar = new Button();
		btnGuardar = new Button();
		((Control)this).SuspendLayout();
		((Control)lblPerfil).set_AutoSize(true);
		((Control)lblPerfil).set_Location(new Point(23, 41));
		((Control)lblPerfil).set_Name("lblPerfil");
		((Control)lblPerfil).set_Size(new Size(71, 13));
		((Control)lblPerfil).set_TabIndex(13);
		((Control)lblPerfil).set_Text("Tipo de Pago");
		cbxTipoPago.set_DropDownStyle((ComboBoxStyle)2);
		((Control)cbxTipoPago).set_Location(new Point(100, 38));
		((Control)cbxTipoPago).set_Name("cbxTipoPago");
		((Control)cbxTipoPago).set_Size(new Size(145, 21));
		cbxTipoPago.set_Sorted(true);
		((Control)cbxTipoPago).set_TabIndex(12);
		cbxTipoPago.add_SelectedIndexChanged((EventHandler)cbxTipoPago_SelectedIndexChanged);
		((Control)txtMonto).set_Location(new Point(100, 12));
		((Control)txtMonto).set_Name("txtMonto");
		((Control)txtMonto).set_Size(new Size(145, 20));
		((Control)txtMonto).set_TabIndex(11);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(57, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(37, 13));
		((Control)label1).set_TabIndex(10);
		((Control)label1).set_Text("Monto");
		((Control)txtBanco).set_Location(new Point(100, 65));
		((Control)txtBanco).set_Name("txtBanco");
		((Control)txtBanco).set_Size(new Size(145, 20));
		((Control)txtBanco).set_TabIndex(15);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(57, 68));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(38, 13));
		((Control)label2).set_TabIndex(14);
		((Control)label2).set_Text("Banco");
		((Control)txtTarjeta).set_Location(new Point(100, 91));
		((Control)txtTarjeta).set_Name("txtTarjeta");
		((Control)txtTarjeta).set_Size(new Size(145, 20));
		((Control)txtTarjeta).set_TabIndex(17);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(54, 94));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(40, 13));
		((Control)label3).set_TabIndex(16);
		((Control)label3).set_Text("Tarjeta");
		btnCancelar.set_DialogResult((DialogResult)2);
		((Control)btnCancelar).set_Location(new Point(12, 178));
		((Control)btnCancelar).set_Name("btnCancelar");
		((Control)btnCancelar).set_Size(new Size(75, 23));
		((Control)btnCancelar).set_TabIndex(18);
		((Control)btnCancelar).set_Text("Cancelar");
		((ButtonBase)btnCancelar).set_UseVisualStyleBackColor(true);
		((Control)btnCancelar).add_Click((EventHandler)btnCancelar_Click);
		((Control)btnGuardar).set_Location(new Point(218, 178));
		((Control)btnGuardar).set_Name("btnGuardar");
		((Control)btnGuardar).set_Size(new Size(75, 23));
		((Control)btnGuardar).set_TabIndex(19);
		((Control)btnGuardar).set_Text("Guardar");
		((ButtonBase)btnGuardar).set_UseVisualStyleBackColor(true);
		((Control)btnGuardar).add_Click((EventHandler)btnGuardar_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnGuardar);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancelar);
		((Form)this).set_ClientSize(new Size(305, 213));
		((Control)this).get_Controls().Add((Control)(object)btnGuardar);
		((Control)this).get_Controls().Add((Control)(object)btnCancelar);
		((Control)this).get_Controls().Add((Control)(object)txtTarjeta);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtBanco);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblPerfil);
		((Control)this).get_Controls().Add((Control)(object)cbxTipoPago);
		((Control)this).get_Controls().Add((Control)(object)txtMonto);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("NuevoPago");
		((Control)this).set_Text("NuevoPago");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
