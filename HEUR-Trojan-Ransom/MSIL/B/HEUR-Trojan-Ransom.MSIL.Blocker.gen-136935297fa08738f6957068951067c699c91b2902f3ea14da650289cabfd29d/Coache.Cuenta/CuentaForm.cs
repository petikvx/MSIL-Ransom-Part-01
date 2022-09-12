using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Core;

namespace Coache.Cuenta;

public class CuentaForm : Form
{
	private IContainer components;

	private Panel panel1;

	private TextBox txtPassword;

	private Button btnLogin;

	private Label label2;

	private TextBox txtActual;

	private Label label3;

	private GroupBox groupBox1;

	private TextBox txtConfirmPassword;

	private Label label1;

	private Panel panel2;

	private Button btnEliminarCuenta;

	public CuentaForm()
	{
		InitializeComponent();
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtPassword).get_Text() != ((Control)txtConfirmPassword).get_Text())
		{
			MessageBox.Show("Las contraseñas no coinciden!");
		}
		else if (new LoginService().UpdateUserPassword(Session.User, ((Control)txtActual).get_Text(), ((Control)txtPassword).get_Text()))
		{
			MessageBox.Show("Contraseñas actualizada correctamente!");
		}
		else
		{
			MessageBox.Show("La contraseña actual ingresada no es correcta");
		}
	}

	private void btnEliminarCuenta_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Confirma que desea eliminar la cuenta?", "Confirmar eliminar cuenta", (MessageBoxButtons)1) == 1)
		{
			new UsersManager().DeleteAccount(Session.User);
			MessageBox.Show("Su cuenta ha sido eliminada del sistema!");
			Session.Close();
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		panel1 = new Panel();
		groupBox1 = new GroupBox();
		txtConfirmPassword = new TextBox();
		label1 = new Label();
		txtActual = new TextBox();
		txtPassword = new TextBox();
		label2 = new Label();
		btnLogin = new Button();
		label3 = new Label();
		panel2 = new Panel();
		btnEliminarCuenta = new Button();
		((Control)panel1).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)groupBox1);
		((Control)panel1).set_Location(new Point(106, 85));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(259, 152));
		((Control)panel1).set_TabIndex(6);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtConfirmPassword);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtActual);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtPassword);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).set_Location(new Point(3, 3));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(252, 145));
		((Control)groupBox1).set_TabIndex(7);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Cambiar Contraseña");
		((Control)txtConfirmPassword).set_Location(new Point(72, 77));
		((Control)txtConfirmPassword).set_Name("txtConfirmPassword");
		txtConfirmPassword.set_PasswordChar('*');
		((Control)txtConfirmPassword).set_Size(new Size(160, 20));
		((Control)txtConfirmPassword).set_TabIndex(6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(17, 80));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(51, 13));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Confirmar");
		((Control)txtActual).set_Location(new Point(72, 25));
		((Control)txtActual).set_Name("txtActual");
		txtActual.set_PasswordChar('*');
		((Control)txtActual).set_Size(new Size(160, 20));
		((Control)txtActual).set_TabIndex(3);
		((Control)txtPassword).set_Location(new Point(72, 51));
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('*');
		((Control)txtPassword).set_Size(new Size(160, 20));
		((Control)txtPassword).set_TabIndex(4);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(17, 28));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(37, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Actual");
		((Control)btnLogin).set_Location(new Point(157, 116));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(75, 23));
		((Control)btnLogin).set_TabIndex(0);
		((Control)btnLogin).set_Text("Cambiar");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(17, 54));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(39, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Nueva");
		((Control)panel2).set_BackColor(SystemColors.ControlDark);
		((Control)panel2).get_Controls().Add((Control)(object)btnEliminarCuenta);
		((Control)panel2).set_Dock((DockStyle)1);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(485, 42));
		((Control)panel2).set_TabIndex(7);
		((Control)btnEliminarCuenta).set_Location(new Point(12, 12));
		((Control)btnEliminarCuenta).set_Name("btnEliminarCuenta");
		((Control)btnEliminarCuenta).set_Size(new Size(94, 23));
		((Control)btnEliminarCuenta).set_TabIndex(8);
		((Control)btnEliminarCuenta).set_Text("Eliminar Cuenta");
		((ButtonBase)btnEliminarCuenta).set_UseVisualStyleBackColor(true);
		((Control)btnEliminarCuenta).add_Click((EventHandler)btnEliminarCuenta_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(485, 312));
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("CuentaForm");
		((Control)this).set_Text("Mi Cuenta");
		((Control)panel1).ResumeLayout(false);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
