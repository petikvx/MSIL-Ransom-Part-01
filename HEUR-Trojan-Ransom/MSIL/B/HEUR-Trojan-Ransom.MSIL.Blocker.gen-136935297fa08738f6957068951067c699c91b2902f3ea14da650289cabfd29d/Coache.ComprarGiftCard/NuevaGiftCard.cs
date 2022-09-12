using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Coache.AbmCliente;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.Login;

namespace Coache.ComprarGiftCard;

[NonNavigable]
public class NuevaGiftCard : Form
{
	private User _user;

	private ClientesForm _clientesForm;

	private IContainer components;

	private Button btnGuardar;

	private Button btnCancelar;

	private Label lblPerfil;

	private Label label1;

	private TextBox txtCliente;

	private Button btnBuscar;

	private ComboBox cbxMonto;

	public event EventHandler<NewGiftCardEventArgs> OnGiftCardCreated;

	public NuevaGiftCard()
	{
		InitializeComponent();
		GiftCardManager giftCardManager = new GiftCardManager();
		cbxMonto.set_DataSource((object)giftCardManager.GetMontos());
		((ListControl)cbxMonto).set_SelectedIndex(0);
	}

	private void btnGuardar_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (_user == null)
		{
			MessageBox.Show("Debe seleccionar un usuario");
		}
		if (this.OnGiftCardCreated != null)
		{
			this.OnGiftCardCreated(this, new NewGiftCardEventArgs
			{
				GiftCard = new GiftCard
				{
					ClienteOrigen = new Cliente
					{
						UserID = Session.User.UserID
					},
					ClienteDestino = (_user as Cliente),
					Credito = (double)cbxMonto.get_SelectedItem(),
					Fecha = Convert.ToDateTime(ConfigurationManager.get_AppSettings()["FechaSistema"])
				}
			});
		}
	}

	private void btnCancelar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnBuscar_Click(object sender, EventArgs e)
	{
		if (_clientesForm == null)
		{
			_clientesForm = new ClientesForm();
			_clientesForm.SetSearchMode();
			_clientesForm.OnUserSelected += clientesForm_OnUserSelected;
		}
		ViewsManager.LoadModal((Form)(object)_clientesForm);
	}

	private void clientesForm_OnUserSelected(object sender, UserSelectedEventArgs e)
	{
		_user = e.User;
		((Control)txtCliente).set_Text(_user.UserName);
		((Control)_clientesForm).Hide();
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
		btnGuardar = new Button();
		btnCancelar = new Button();
		lblPerfil = new Label();
		label1 = new Label();
		txtCliente = new TextBox();
		btnBuscar = new Button();
		cbxMonto = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)btnGuardar).set_Location(new Point(206, 97));
		((Control)btnGuardar).set_Name("btnGuardar");
		((Control)btnGuardar).set_Size(new Size(75, 23));
		((Control)btnGuardar).set_TabIndex(29);
		((Control)btnGuardar).set_Text("Guardar");
		((ButtonBase)btnGuardar).set_UseVisualStyleBackColor(true);
		((Control)btnGuardar).add_Click((EventHandler)btnGuardar_Click);
		btnCancelar.set_DialogResult((DialogResult)2);
		((Control)btnCancelar).set_Location(new Point(9, 97));
		((Control)btnCancelar).set_Name("btnCancelar");
		((Control)btnCancelar).set_Size(new Size(75, 23));
		((Control)btnCancelar).set_TabIndex(28);
		((Control)btnCancelar).set_Text("Cancelar");
		((ButtonBase)btnCancelar).set_UseVisualStyleBackColor(true);
		((Control)btnCancelar).add_Click((EventHandler)btnCancelar_Click);
		((Control)lblPerfil).set_AutoSize(true);
		((Control)lblPerfil).set_Location(new Point(25, 44));
		((Control)lblPerfil).set_Name("lblPerfil");
		((Control)lblPerfil).set_Size(new Size(39, 13));
		((Control)lblPerfil).set_TabIndex(23);
		((Control)lblPerfil).set_Text("Cliente");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(27, 18));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(37, 13));
		((Control)label1).set_TabIndex(20);
		((Control)label1).set_Text("Monto");
		((Control)txtCliente).set_Location(new Point(68, 41));
		((Control)txtCliente).set_Name("txtCliente");
		((TextBoxBase)txtCliente).set_ReadOnly(true);
		((Control)txtCliente).set_Size(new Size(100, 20));
		((Control)txtCliente).set_TabIndex(30);
		((Control)btnBuscar).set_Location(new Point(174, 39));
		((Control)btnBuscar).set_Name("btnBuscar");
		((Control)btnBuscar).set_Size(new Size(75, 23));
		((Control)btnBuscar).set_TabIndex(31);
		((Control)btnBuscar).set_Text("Buscar");
		((ButtonBase)btnBuscar).set_UseVisualStyleBackColor(true);
		((Control)btnBuscar).add_Click((EventHandler)btnBuscar_Click);
		cbxMonto.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbxMonto).set_FormattingEnabled(true);
		((Control)cbxMonto).set_Location(new Point(68, 15));
		((Control)cbxMonto).set_Name("cbxMonto");
		((Control)cbxMonto).set_Size(new Size(181, 21));
		((Control)cbxMonto).set_TabIndex(32);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnGuardar);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancelar);
		((Form)this).set_ClientSize(new Size(293, 134));
		((Control)this).get_Controls().Add((Control)(object)cbxMonto);
		((Control)this).get_Controls().Add((Control)(object)btnBuscar);
		((Control)this).get_Controls().Add((Control)(object)txtCliente);
		((Control)this).get_Controls().Add((Control)(object)btnGuardar);
		((Control)this).get_Controls().Add((Control)(object)btnCancelar);
		((Control)this).get_Controls().Add((Control)(object)lblPerfil);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("NuevaGiftCard");
		((Control)this).set_Text("NuevaGiftCard");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
