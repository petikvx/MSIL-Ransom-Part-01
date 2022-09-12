using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Common;
using Coache.Core;

namespace Coache.PedirDevolucion;

[NonNavigable]
[PermissionRequired(new Functionalities[] { Functionalities.PedirDevoluciones })]
public class PedirDevolucionForm : Form
{
	private CompraCupon _compraCupon;

	private IContainer components;

	private Label label1;

	private Label label2;

	private TextBox txtCodigo;

	private TextBox txtMensaje;

	private Button btnGuardar;

	private Button btnCancelar;

	public event EventHandler<CuponDevueltoEventArgs> OnCuponDevuelto;

	public PedirDevolucionForm(CompraCupon compraCupon)
	{
		InitializeComponent();
		_compraCupon = compraCupon;
		((Control)txtCodigo).set_Text(compraCupon.Codigo);
	}

	private void btnCancelar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnGuardar_Click(object sender, EventArgs e)
	{
		if (this.OnCuponDevuelto != null)
		{
			this.OnCuponDevuelto(this, new CuponDevueltoEventArgs
			{
				Mensaje = ((Control)txtMensaje).get_Text(),
				CompraCupon = _compraCupon
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
		label1 = new Label();
		label2 = new Label();
		txtCodigo = new TextBox();
		txtMensaje = new TextBox();
		btnGuardar = new Button();
		btnCancelar = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(83, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(38, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Cupón");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 35));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(109, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Motivo de devolución");
		((Control)txtCodigo).set_Location(new Point(127, 6));
		((Control)txtCodigo).set_Name("txtCodigo");
		((TextBoxBase)txtCodigo).set_ReadOnly(true);
		((Control)txtCodigo).set_Size(new Size(171, 20));
		((Control)txtCodigo).set_TabIndex(2);
		((Control)txtMensaje).set_Location(new Point(127, 32));
		((TextBoxBase)txtMensaje).set_Multiline(true);
		((Control)txtMensaje).set_Name("txtMensaje");
		((Control)txtMensaje).set_Size(new Size(171, 86));
		((Control)txtMensaje).set_TabIndex(3);
		((Control)btnGuardar).set_Location(new Point(223, 131));
		((Control)btnGuardar).set_Name("btnGuardar");
		((Control)btnGuardar).set_Size(new Size(75, 23));
		((Control)btnGuardar).set_TabIndex(4);
		((Control)btnGuardar).set_Text("Guardar");
		((ButtonBase)btnGuardar).set_UseVisualStyleBackColor(true);
		((Control)btnGuardar).add_Click((EventHandler)btnGuardar_Click);
		btnCancelar.set_DialogResult((DialogResult)2);
		((Control)btnCancelar).set_Location(new Point(12, 131));
		((Control)btnCancelar).set_Name("btnCancelar");
		((Control)btnCancelar).set_Size(new Size(75, 23));
		((Control)btnCancelar).set_TabIndex(5);
		((Control)btnCancelar).set_Text("Cancelar");
		((ButtonBase)btnCancelar).set_UseVisualStyleBackColor(true);
		((Control)btnCancelar).add_Click((EventHandler)btnCancelar_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnGuardar);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancelar);
		((Form)this).set_ClientSize(new Size(321, 166));
		((Control)this).get_Controls().Add((Control)(object)btnCancelar);
		((Control)this).get_Controls().Add((Control)(object)btnGuardar);
		((Control)this).get_Controls().Add((Control)(object)txtMensaje);
		((Control)this).get_Controls().Add((Control)(object)txtCodigo);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("PedirDevolucionForm");
		((Control)this).set_Text("Devoluciones");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
