using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace _111zal2;

public class remove_Popup : Form
{
	private IContainer ByteConverter = null;

	private Label DelegateHelpers;

	private Label ThumbTop;

	private LinkLabel CodeTypeDeclaration;

	private Panel TypeNumericSchemaImporterExtension;

	private TextBox ApplicationException;

	private Label PermissionState;

	private Button SafeLsaReturnBufferHandle;

	private Class2.Class4.Class6.Class7 class7_0 = new Class2.Class4.Class6.Class7();

	public remove_Popup()
	{
		new get_EntryAssembly();
		ICollection_00601();
		((Control)TypeNumericSchemaImporterExtension).Hide();
	}

	private void EXPRFLAG(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public bool CRYPT_BIT_BLOB()
	{
		return false;
	}

	private void LocalVariableInfo(object sender, EventArgs e)
	{
		if (CRYPT_BIT_BLOB())
		{
			((Control)this).Hide();
			Form val = (Form)(object)new get_EntryAssembly();
			((Control)(val as get_EntryAssembly)).Show();
		}
	}

	private void TreeNodeMouseHoverEventHandler(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)TypeNumericSchemaImporterExtension).Show();
		((Control)TypeNumericSchemaImporterExtension).BringToFront();
	}

	private void DescendantBaseQuery(object sender, EventArgs e)
	{
		((TextBoxBase)ApplicationException).Clear();
		((TextBoxBase)class7_0.textBox_3).Clear();
		((TextBoxBase)class7_0.textBox_2).Clear();
		((Control)TypeNumericSchemaImporterExtension).Hide();
	}

	private void SyncHashtable(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		object obj = new get_IsTransient();
		if (((Control)class7_0.textBox_3).get_Text() == ((Control)class7_0.textBox_2).get_Text())
		{
			MessageBox.Show("Username is already in use");
			((TextBoxBase)ApplicationException).Clear();
			((TextBoxBase)class7_0.textBox_3).Clear();
			((TextBoxBase)class7_0.textBox_2).Clear();
			((get_IsTransient)obj).SxSRequirements = ((Control)ApplicationException).get_Text();
			(obj as get_IsTransient)._003CParseRootLevelWhitespaceAsync_003Ed__557 = ((Control)class7_0.textBox_3).get_Text();
			((Control)TypeNumericSchemaImporterExtension).Hide();
		}
		else
		{
			((TextBoxBase)class7_0.textBox_3).Clear();
			((TextBoxBase)class7_0.textBox_2).Clear();
			MessageBox.Show("Passwords must match");
		}
	}

	protected override void ReadStream(bool _003CScanElement1Async_003Ed__180)
	{
		if (_003CScanElement1Async_003Ed__180 && ByteConverter != null)
		{
			ByteConverter.Dispose();
		}
		((Form)this).Dispose(_003CScanElement1Async_003Ed__180);
	}

	private void ICollection_00601()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		ButtonBase val = (ButtonBase)new Button();
		class7_0.button_0 = (Button)(object)((val is Button) ? val : null);
		ButtonBase val2 = (ButtonBase)new Button();
		class7_0.button_1 = (Button)(object)((val2 is Button) ? val2 : null);
		DelegateHelpers = new Label();
		ThumbTop = new Label();
		TextBoxBase val3 = (TextBoxBase)new TextBox();
		class7_0.textBox_0 = (TextBox)(object)((val3 is TextBox) ? val3 : null);
		object obj = (object)new TextBox();
		class7_0.textBox_1 = (TextBox)((obj is TextBox) ? obj : null);
		CodeTypeDeclaration = new LinkLabel();
		TypeNumericSchemaImporterExtension = new Panel();
		IButtonControl val4 = (IButtonControl)new Button();
		class7_0.button_2 = (Button)(object)((val4 is Button) ? val4 : null);
		SafeLsaReturnBufferHandle = new Button();
		ApplicationException = new TextBox();
		TextBoxBase val5 = (TextBoxBase)new TextBox();
		class7_0.textBox_2 = (TextBox)val5;
		object obj2 = (object)new TextBox();
		class7_0.textBox_3 = (TextBox)obj2;
		IAutomationLiveRegion val6 = (IAutomationLiveRegion)new Label();
		class7_0.label_0 = (Label)(object)((val6 is Label) ? val6 : null);
		object obj3 = (object)new Label();
		class7_0.label_1 = (Label)((obj3 is Label) ? obj3 : null);
		PermissionState = new Label();
		((Control)TypeNumericSchemaImporterExtension).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)class7_0.button_0).set_Location(new Point(133, 175));
		((Control)class7_0.button_0).set_Name("button1");
		((Control)class7_0.button_0).set_Size(new Size(75, 23));
		((Control)class7_0.button_0).set_TabIndex(3);
		((Control)class7_0.button_0).set_Text("Exit");
		((ButtonBase)class7_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)class7_0.button_0).set_Visible(false);
		((Control)class7_0.button_0).add_Click((EventHandler)EXPRFLAG);
		((Control)class7_0.button_1).set_Location(new Point(275, 175));
		((Control)class7_0.button_1).set_Name("button2");
		((Control)class7_0.button_1).set_Size(new Size(75, 23));
		((Control)class7_0.button_1).set_TabIndex(4);
		((Control)class7_0.button_1).set_Text("Login");
		((ButtonBase)class7_0.button_1).set_UseVisualStyleBackColor(true);
		((Control)class7_0.button_1).set_Visible(false);
		((Control)class7_0.button_1).add_Click((EventHandler)LocalVariableInfo);
		((Control)DelegateHelpers).set_AutoSize(true);
		((Control)DelegateHelpers).set_Location(new Point(130, 68));
		((Control)DelegateHelpers).set_Name("label1");
		((Control)DelegateHelpers).set_Size(new Size(55, 13));
		((Control)DelegateHelpers).set_TabIndex(2);
		((Control)DelegateHelpers).set_Text("Username");
		((Control)DelegateHelpers).set_Visible(false);
		((Control)ThumbTop).set_AutoSize(true);
		((Control)ThumbTop).set_Location(new Point(130, 122));
		((Control)ThumbTop).set_Name("label2");
		((Control)ThumbTop).set_Size(new Size(53, 13));
		((Control)ThumbTop).set_TabIndex(3);
		((Control)ThumbTop).set_Text("Password");
		((Control)ThumbTop).set_Visible(false);
		((Control)class7_0.textBox_0).set_Location(new Point(209, 65));
		((Control)class7_0.textBox_0).set_Name("textBox1");
		((Control)class7_0.textBox_0).set_Size(new Size(141, 20));
		((Control)class7_0.textBox_0).set_TabIndex(1);
		((Control)class7_0.textBox_0).set_Visible(false);
		((Control)class7_0.textBox_1).set_Location(new Point(209, 119));
		((Control)class7_0.textBox_1).set_Name("textBox2");
		class7_0.textBox_1.set_PasswordChar('*');
		((Control)class7_0.textBox_1).set_Size(new Size(141, 20));
		((Control)class7_0.textBox_1).set_TabIndex(2);
		((Control)class7_0.textBox_1).set_Visible(false);
		((Control)CodeTypeDeclaration).set_AutoSize(true);
		((Control)CodeTypeDeclaration).set_Location(new Point(147, 228));
		((Control)CodeTypeDeclaration).set_Name("linkLabel1");
		((Control)CodeTypeDeclaration).set_Size(new Size(203, 13));
		((Control)CodeTypeDeclaration).set_TabIndex(5);
		CodeTypeDeclaration.set_TabStop(true);
		((Control)CodeTypeDeclaration).set_Text("Don't have account. Click here to register");
		((Control)CodeTypeDeclaration).set_Visible(false);
		CodeTypeDeclaration.add_LinkClicked(new LinkLabelLinkClickedEventHandler(TreeNodeMouseHoverEventHandler));
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)class7_0.button_2);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)SafeLsaReturnBufferHandle);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)ApplicationException);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)class7_0.textBox_2);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)class7_0.textBox_3);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)class7_0.label_0);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)class7_0.label_1);
		((Control)TypeNumericSchemaImporterExtension).get_Controls().Add((Control)(object)PermissionState);
		((Control)TypeNumericSchemaImporterExtension).set_Location(new Point(453, 38));
		((Control)TypeNumericSchemaImporterExtension).set_Name("panel1");
		((Control)TypeNumericSchemaImporterExtension).set_Size(new Size(458, 260));
		((Control)TypeNumericSchemaImporterExtension).set_TabIndex(7);
		((Control)TypeNumericSchemaImporterExtension).set_Visible(false);
		((Control)class7_0.button_2).set_Location(new Point(263, 190));
		((Control)class7_0.button_2).set_Name("button4");
		((Control)class7_0.button_2).set_Size(new Size(75, 23));
		((Control)class7_0.button_2).set_TabIndex(4);
		((Control)class7_0.button_2).set_Text("Register");
		((ButtonBase)class7_0.button_2).set_UseVisualStyleBackColor(true);
		((Control)class7_0.button_2).add_Click((EventHandler)SyncHashtable);
		((Control)SafeLsaReturnBufferHandle).set_Location(new Point(121, 190));
		((Control)SafeLsaReturnBufferHandle).set_Name("button3");
		((Control)SafeLsaReturnBufferHandle).set_Size(new Size(75, 23));
		((Control)SafeLsaReturnBufferHandle).set_TabIndex(5);
		((Control)SafeLsaReturnBufferHandle).set_Text("Cancel");
		((ButtonBase)SafeLsaReturnBufferHandle).set_UseVisualStyleBackColor(true);
		((Control)SafeLsaReturnBufferHandle).add_Click((EventHandler)DescendantBaseQuery);
		((Control)ApplicationException).set_Location(new Point(197, 53));
		((Control)ApplicationException).set_Name("textBox5");
		((Control)ApplicationException).set_Size(new Size(100, 20));
		((Control)ApplicationException).set_TabIndex(1);
		((Control)class7_0.textBox_2).set_Location(new Point(197, 134));
		((Control)class7_0.textBox_2).set_Name("textBox4");
		class7_0.textBox_2.set_PasswordChar('*');
		((Control)class7_0.textBox_2).set_Size(new Size(100, 20));
		((Control)class7_0.textBox_2).set_TabIndex(3);
		((Control)class7_0.textBox_3).set_Location(new Point(197, 94));
		((Control)class7_0.textBox_3).set_Name("textBox3");
		class7_0.textBox_3.set_PasswordChar('*');
		((Control)class7_0.textBox_3).set_Size(new Size(100, 20));
		((Control)class7_0.textBox_3).set_TabIndex(2);
		((Control)class7_0.label_0).set_AutoSize(true);
		((Control)class7_0.label_0).set_Location(new Point(95, 137));
		((Control)class7_0.label_0).set_Name("label5");
		((Control)class7_0.label_0).set_Size(new Size(96, 13));
		((Control)class7_0.label_0).set_TabIndex(2);
		((Control)class7_0.label_0).set_Text("Re-enter password");
		((Control)class7_0.label_1).set_AutoSize(true);
		((Control)class7_0.label_1).set_Location(new Point(138, 97));
		((Control)class7_0.label_1).set_Name("label4");
		((Control)class7_0.label_1).set_Size(new Size(53, 13));
		((Control)class7_0.label_1).set_TabIndex(1);
		((Control)class7_0.label_1).set_Text("Password");
		((Control)PermissionState).set_AutoSize(true);
		((Control)PermissionState).set_Location(new Point(156, 56));
		((Control)PermissionState).set_Name("label3");
		((Control)PermissionState).set_Size(new Size(33, 13));
		((Control)PermissionState).set_TabIndex(0);
		((Control)PermissionState).set_Text("Login");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_ClientSize(new Size(593, 109));
		((Control)this).get_Controls().Add((Control)(object)TypeNumericSchemaImporterExtension);
		((Control)this).get_Controls().Add((Control)(object)CodeTypeDeclaration);
		((Control)this).get_Controls().Add((Control)(object)class7_0.textBox_1);
		((Control)this).get_Controls().Add((Control)(object)class7_0.textBox_0);
		((Control)this).get_Controls().Add((Control)(object)ThumbTop);
		((Control)this).get_Controls().Add((Control)(object)DelegateHelpers);
		((Control)this).get_Controls().Add((Control)(object)class7_0.button_1);
		((Control)this).get_Controls().Add((Control)(object)class7_0.button_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("LoginForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Control)TypeNumericSchemaImporterExtension).ResumeLayout(false);
		((Control)TypeNumericSchemaImporterExtension).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
