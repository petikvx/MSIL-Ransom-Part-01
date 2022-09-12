using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

internal class PasswordDialog : Form
{
	private IContainer components = null;

	private Label lblText;

	private Label label2;

	private Label label3;

	private TextBox txtUserName;

	private TextBox txtPassword;

	private Button btnOK;

	private Button btnCancel;

	private CheckBox checkBox;

	public string UserName => ((Control)txtUserName).get_Text();

	public string Password => ((Control)txtPassword).get_Text();

	public bool IsChecked => checkBox.get_Checked();

	public PasswordDialog()
	{
		InitializeComponent();
	}

	public PasswordDialog(string title, string text, string username, string password, string checkMessage, bool checkState)
		: this()
	{
		if (!string.IsNullOrEmpty(title))
		{
			((Control)this).set_Text(title);
		}
		((Control)lblText).set_Text(text);
		((Control)txtUserName).set_Text(username);
		((Control)txtPassword).set_Text(password);
		if (!string.IsNullOrEmpty(checkMessage))
		{
			((Control)checkBox).set_Text(checkMessage);
			checkBox.set_Checked(checkState);
			return;
		}
		((Control)checkBox).set_Visible(false);
		((Control)btnOK).set_Top(((Control)checkBox).get_Top());
		((Control)btnCancel).set_Top(((Control)checkBox).get_Top());
		((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, ((Control)btnOK).get_Bottom() + 6));
	}

	public void DisableUserName()
	{
		((Control)txtUserName).set_Enabled(false);
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
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		lblText = new Label();
		label2 = new Label();
		label3 = new Label();
		txtUserName = new TextBox();
		txtPassword = new TextBox();
		btnOK = new Button();
		btnCancel = new Button();
		checkBox = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)lblText).set_Location(new Point(8, 12));
		((Control)lblText).set_Name("lblText");
		((Control)lblText).set_Size(new Size(383, 36));
		((Control)lblText).set_TabIndex(0);
		((Control)lblText).set_Text("label1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 64));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(63, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("User Name:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(8, 92));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(57, 13));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Password:");
		((Control)txtUserName).set_Location(new Point(76, 60));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_Size(new Size(315, 21));
		((Control)txtUserName).set_TabIndex(2);
		((Control)txtPassword).set_Location(new Point(76, 88));
		((Control)txtPassword).set_Name("txtPassword");
		((Control)txtPassword).set_Size(new Size(315, 21));
		((Control)txtPassword).set_TabIndex(4);
		txtPassword.set_UseSystemPasswordChar(true);
		btnOK.set_DialogResult((DialogResult)1);
		((Control)btnOK).set_Location(new Point(235, 140));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(75, 23));
		((Control)btnOK).set_TabIndex(6);
		((Control)btnOK).set_Text("OK");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Location(new Point(315, 140));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(5);
		((Control)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)checkBox).set_AutoSize(true);
		((Control)checkBox).set_Location(new Point(76, 116));
		((Control)checkBox).set_Name("checkBox");
		((Control)checkBox).set_Size(new Size(77, 17));
		((Control)checkBox).set_TabIndex(7);
		((Control)checkBox).set_Text("checkBox1");
		((ButtonBase)checkBox).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOK);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(403, 172));
		((Control)this).get_Controls().Add((Control)(object)checkBox);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)txtPassword);
		((Control)this).get_Controls().Add((Control)(object)txtUserName);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblText);
		((Control)this).set_Font(new Font("Tahoma", 8.25f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PasswordDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Authentication Required");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
