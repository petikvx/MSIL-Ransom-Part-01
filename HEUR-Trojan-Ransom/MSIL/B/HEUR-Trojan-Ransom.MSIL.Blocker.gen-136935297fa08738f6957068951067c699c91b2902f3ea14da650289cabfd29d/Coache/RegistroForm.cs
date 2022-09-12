using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.Login;

namespace Coache;

[NonNavigable]
public class RegistroForm : Form
{
	private List<Profile> Profiles;

	private ClienteUserControl clienteUserControl = new ClienteUserControl();

	private ProveedorUserControl proveedorUserControl = new ProveedorUserControl();

	private Proveedor _proveedor = new Proveedor();

	private Cliente _cliente = new Cliente();

	private bool _updatingData;

	private IContainer components;

	private Button btnSave;

	private Button btnCancel;

	private Label label1;

	private TextBox txtUsername;

	private TextBox txtPassword;

	private Label label2;

	private TextBox txtConfirmPassword;

	private Label label3;

	private ComboBox cbxProfiles;

	private Label lblPerfil;

	private Panel userPanel;

	public Profile Profile
	{
		get
		{
			return (Profile)cbxProfiles.get_SelectedItem();
		}
		set
		{
			cbxProfiles.set_SelectedItem((object)value);
			((Control)cbxProfiles).set_Enabled(false);
			((Control)cbxProfiles).set_Visible(false);
			((Control)lblPerfil).set_Visible(false);
		}
	}

	public event EventHandler<UserSavedEventArgs> OnUserSaved;

	public RegistroForm()
	{
		InitializeComponent();
		ProfileManager profileManager = new ProfileManager();
		Profiles = profileManager.GetRegistrationProfiles();
		Profiles.ForEach(delegate(Profile x)
		{
			cbxProfiles.get_Items().Add((object)x);
		});
		((ListControl)cbxProfiles).set_SelectedIndex(0);
	}

	public void SetUser(User user)
	{
		_updatingData = true;
		((Control)txtUsername).set_Text(user.UserName);
		((Control)txtUsername).set_Enabled(false);
		((Control)txtPassword).set_Enabled(false);
		((Control)txtConfirmPassword).set_Enabled(false);
		((Control)cbxProfiles).set_Enabled(false);
		if (user is Cliente)
		{
			_cliente = user as Cliente;
			cbxProfiles.set_SelectedItem((object)Profile.Cliente);
			clienteUserControl.SetUser(_cliente);
		}
		else
		{
			_proveedor = user as Proveedor;
			cbxProfiles.set_SelectedItem((object)Profile.Proveedor);
			proveedorUserControl.SetUser(_proveedor);
		}
	}

	private void RegistroForm_Load(object sender, EventArgs e)
	{
	}

	private void cbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)userPanel).get_Controls().Clear();
		if (Profile == Profile.Cliente)
		{
			((Control)userPanel).get_Controls().Add((Control)(object)clienteUserControl);
		}
		else
		{
			((Control)userPanel).get_Controls().Add((Control)(object)proveedorUserControl);
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (!_updatingData)
		{
			if (string.IsNullOrEmpty(((Control)txtUsername).get_Text()))
			{
				throw new Exception("El nombre de usuario es obligatorio!");
			}
			if (string.IsNullOrEmpty(((Control)txtPassword).get_Text()))
			{
				throw new Exception("El password es obligatorio!");
			}
			if (((Control)txtPassword).get_Text() != ((Control)txtConfirmPassword).get_Text())
			{
				throw new Exception("Los passwords no coinciden!");
			}
		}
		User user = null;
		if (Profile == Profile.Cliente)
		{
			_cliente = clienteUserControl.GetCliente();
			_cliente.UserName = ((Control)txtUsername).get_Text();
			new ClienteManager().GuardarCliente(_cliente, ((Control)txtPassword).get_Text());
			user = _cliente;
		}
		else
		{
			_proveedor = proveedorUserControl.GetProveedor();
			_proveedor.UserName = ((Control)txtUsername).get_Text();
			new ProveedorManager().GuardarProveedor(_proveedor, ((Control)txtPassword).get_Text());
			user = _proveedor;
		}
		if (this.OnUserSaved != null)
		{
			this.OnUserSaved(this, new UserSavedEventArgs
			{
				Username = ((Control)txtUsername).get_Text(),
				Password = ((Control)txtPassword).get_Text(),
				User = user
			});
			((Form)this).Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		btnSave = new Button();
		btnCancel = new Button();
		label1 = new Label();
		txtUsername = new TextBox();
		txtPassword = new TextBox();
		label2 = new Label();
		txtConfirmPassword = new TextBox();
		label3 = new Label();
		cbxProfiles = new ComboBox();
		lblPerfil = new Label();
		userPanel = new Panel();
		((Control)this).SuspendLayout();
		((Control)btnSave).set_Anchor((AnchorStyles)10);
		((Control)btnSave).set_Location(new Point(443, 510));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(0);
		((Control)btnSave).set_Text("Guardar");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)btnSave).add_Click((EventHandler)btnSave_Click);
		((Control)btnCancel).set_Anchor((AnchorStyles)6);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Location(new Point(12, 510));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(1);
		((Control)btnCancel).set_Text("Cancelar");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(59, 29));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(55, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Username");
		((Control)txtUsername).set_Location(new Point(120, 26));
		((Control)txtUsername).set_Name("txtUsername");
		((Control)txtUsername).set_Size(new Size(145, 20));
		((Control)txtUsername).set_TabIndex(3);
		((Control)txtPassword).set_Location(new Point(120, 52));
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('*');
		((Control)txtPassword).set_Size(new Size(145, 20));
		((Control)txtPassword).set_TabIndex(5);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(61, 55));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Password");
		((Control)txtConfirmPassword).set_Location(new Point(120, 78));
		((Control)txtConfirmPassword).set_Name("txtConfirmPassword");
		txtConfirmPassword.set_PasswordChar('*');
		((Control)txtConfirmPassword).set_Size(new Size(145, 20));
		((Control)txtConfirmPassword).set_TabIndex(7);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(37, 81));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(77, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Confirmar Pass");
		cbxProfiles.set_DropDownStyle((ComboBoxStyle)2);
		((Control)cbxProfiles).set_Location(new Point(120, 104));
		((Control)cbxProfiles).set_Name("cbxProfiles");
		((Control)cbxProfiles).set_Size(new Size(145, 21));
		cbxProfiles.set_Sorted(true);
		((Control)cbxProfiles).set_TabIndex(8);
		cbxProfiles.add_SelectedIndexChanged((EventHandler)cbxProfiles_SelectedIndexChanged);
		((Control)lblPerfil).set_AutoSize(true);
		((Control)lblPerfil).set_Location(new Point(84, 107));
		((Control)lblPerfil).set_Name("lblPerfil");
		((Control)lblPerfil).set_Size(new Size(30, 13));
		((Control)lblPerfil).set_TabIndex(9);
		((Control)lblPerfil).set_Text("Perfil");
		((Control)userPanel).set_Anchor((AnchorStyles)15);
		((Control)userPanel).set_Location(new Point(12, 131));
		((Control)userPanel).set_Name("userPanel");
		((Control)userPanel).set_Size(new Size(506, 373));
		((Control)userPanel).set_TabIndex(10);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnSave);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(530, 545));
		((Control)this).get_Controls().Add((Control)(object)userPanel);
		((Control)this).get_Controls().Add((Control)(object)lblPerfil);
		((Control)this).get_Controls().Add((Control)(object)cbxProfiles);
		((Control)this).get_Controls().Add((Control)(object)txtConfirmPassword);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtPassword);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)txtUsername);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).set_Name("RegistroForm");
		((Control)this).set_Text("Registro");
		((Form)this).add_Load((EventHandler)RegistroForm_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
