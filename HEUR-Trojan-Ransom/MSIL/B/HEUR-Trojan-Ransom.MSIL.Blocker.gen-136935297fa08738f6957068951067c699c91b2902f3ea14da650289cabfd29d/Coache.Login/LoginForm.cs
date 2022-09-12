using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Core;

namespace Coache.Login;

[NonNavigable]
public class LoginForm : Form
{
	private IContainer components;

	private Button btnLogin;

	private Label label1;

	private Label label2;

	private TextBox txtUserName;

	private TextBox txtPassword;

	private Panel panel1;

	private Button btnRegister;

	public LoginForm()
	{
		InitializeComponent();
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		Login(((Control)txtUserName).get_Text(), ((Control)txtPassword).get_Text());
	}

	private void btnRegister_Click(object sender, EventArgs e)
	{
		RegistroForm registroForm = new RegistroForm();
		registroForm.OnUserSaved += registroForm_OnUserCreated;
		ViewsManager.LoadModal((Form)(object)registroForm);
	}

	private void registroForm_OnUserCreated(object sender, UserSavedEventArgs e)
	{
		Login(e.Username, e.Password);
	}

	private void Login(string userName, string pass)
	{
		Session.StartSession(new LoginService().Login(userName, pass));
		ViewsManager.ClearViews();
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
		btnLogin = new Button();
		label1 = new Label();
		label2 = new Label();
		txtUserName = new TextBox();
		txtPassword = new TextBox();
		panel1 = new Panel();
		btnRegister = new Button();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnLogin).set_Location(new Point(150, 75));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(75, 23));
		((Control)btnLogin).set_TabIndex(0);
		((Control)btnLogin).set_Text("Login");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(10, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Usuario");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(10, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Password");
		((Control)txtUserName).set_Location(new Point(65, 13));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_Size(new Size(160, 20));
		((Control)txtUserName).set_TabIndex(3);
		((Control)txtPassword).set_Location(new Point(65, 45));
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('*');
		((Control)txtPassword).set_Size(new Size(160, 20));
		((Control)txtPassword).set_TabIndex(4);
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)btnRegister);
		((Control)panel1).get_Controls().Add((Control)(object)txtPassword);
		((Control)panel1).get_Controls().Add((Control)(object)btnLogin);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)txtUserName);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_Location(new Point(169, 103));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(235, 112));
		((Control)panel1).set_TabIndex(5);
		((Control)btnRegister).set_Location(new Point(13, 74));
		((Control)btnRegister).set_Name("btnRegister");
		((Control)btnRegister).set_Size(new Size(75, 23));
		((Control)btnRegister).set_TabIndex(5);
		((Control)btnRegister).set_Text("Registro");
		((ButtonBase)btnRegister).set_UseVisualStyleBackColor(true);
		((Control)btnRegister).add_Click((EventHandler)btnRegister_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnLogin);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(632, 356));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("LoginForm");
		((Control)this).set_Text("LoginForm");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
