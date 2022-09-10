using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class CtrlLogin : UserControl
{
	public delegate void GDelegate2(string string_0, string string_1, string string_2);

	private IContainer icontainer_0;

	private Label label1;

	private Label lblLogin;

	private TextBox tbLogin;

	private Label lblPassword;

	private Button btnLogin;

	private TextBox tbPassword;

	private ComboBox cbbServer;

	private Button btnClose;

	private Label label2;

	private GClass8 gclass8_0;

	public Form form_0;

	private GDelegate2 gdelegate2_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		label1 = new Label();
		lblLogin = new Label();
		tbLogin = new TextBox();
		lblPassword = new Label();
		btnLogin = new Button();
		tbPassword = new TextBox();
		cbbServer = new ComboBox();
		btnClose = new Button();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_Font(new Font("Verdana", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(15, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(151, 19));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Travian server:");
		((Control)lblLogin).set_Font(new Font("Verdana", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblLogin).set_Location(new Point(15, 60));
		((Control)lblLogin).set_Name("lblLogin");
		((Control)lblLogin).set_Size(new Size(125, 20));
		((Control)lblLogin).set_TabIndex(4);
		((Control)lblLogin).set_Text("Login:");
		((Control)tbLogin).set_Location(new Point(155, 59));
		((Control)tbLogin).set_Name("tbLogin");
		((Control)tbLogin).set_Size(new Size(187, 20));
		((Control)tbLogin).set_TabIndex(2);
		((Control)tbLogin).add_KeyPress(new KeyPressEventHandler(cbbServer_KeyPress));
		((Control)lblPassword).set_Font(new Font("Verdana", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblPassword).set_Location(new Point(15, 95));
		((Control)lblPassword).set_Name("lblPassword");
		((Control)lblPassword).set_Size(new Size(125, 32));
		((Control)lblPassword).set_TabIndex(7);
		((Control)lblPassword).set_Text("Password:");
		((Control)btnLogin).set_Anchor((AnchorStyles)10);
		((Control)btnLogin).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnLogin).set_ForeColor(Color.Green);
		((Control)btnLogin).set_Location(new Point(195, 138));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(122, 32));
		((Control)btnLogin).set_TabIndex(4);
		((Control)btnLogin).set_Text("Login");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)tbPassword).set_Location(new Point(155, 94));
		((Control)tbPassword).set_Name("tbPassword");
		tbPassword.set_PasswordChar('*');
		((Control)tbPassword).set_Size(new Size(187, 20));
		((Control)tbPassword).set_TabIndex(3);
		((Control)tbPassword).add_KeyPress(new KeyPressEventHandler(cbbServer_KeyPress));
		((ListControl)cbbServer).set_FormattingEnabled(true);
		((Control)cbbServer).set_Location(new Point(155, 20));
		((Control)cbbServer).set_Name("cbbServer");
		((Control)cbbServer).set_Size(new Size(290, 21));
		((Control)cbbServer).set_TabIndex(1);
		cbbServer.add_SelectedIndexChanged((EventHandler)cbbServer_SelectedIndexChanged);
		((Control)cbbServer).add_KeyPress(new KeyPressEventHandler(cbbServer_KeyPress));
		((Control)cbbServer).add_KeyUp(new KeyEventHandler(cbbServer_KeyUp));
		((Control)btnClose).set_Anchor((AnchorStyles)10);
		((Control)btnClose).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnClose).set_ForeColor(Color.Green);
		((Control)btnClose).set_Location(new Point(323, 138));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(122, 32));
		((Control)btnClose).set_TabIndex(5);
		((Control)btnClose).set_Text("Close");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(155, 4));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(126, 13));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("(e.g. http://s2.travian.dk)");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)cbbServer);
		((Control)this).get_Controls().Add((Control)(object)tbPassword);
		((Control)this).get_Controls().Add((Control)(object)btnLogin);
		((Control)this).get_Controls().Add((Control)(object)tbLogin);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lblLogin);
		((Control)this).get_Controls().Add((Control)(object)lblPassword);
		((Control)this).set_Name("CtrlLogin");
		((Control)this).set_Size(new Size(461, 177));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, gdelegate2_1);
	}

	public CtrlLogin()
	{
		InitializeComponent();
		method_2();
	}

	private void method_2()
	{
		GClass0 gclass0_ = GClass0.gclass0_0;
		string text = gclass0_.method_6(GClass0.GEnum0.const_10.ToString());
		gclass8_0 = GClass5.gclass5_0.method_0().method_1();
		if (text != null)
		{
			((Control)cbbServer).set_Text(text);
		}
		else
		{
			((Control)cbbServer).set_Text("http://");
		}
		method_4();
		string text2 = gclass0_.method_6(GClass0.GEnum0.const_8.ToString());
		string text3 = gclass0_.method_6(GClass0.GEnum0.const_9.ToString());
		if (text2 != null)
		{
			((Control)tbLogin).set_Text(text2);
		}
		if (text3 != null)
		{
			((Control)tbPassword).set_Text(text3);
		}
	}

	private void cbbServer_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() != 8 && (int)e.get_KeyCode() != 37 && (int)e.get_KeyCode() != 39 && (int)e.get_KeyCode() != 38 && (int)e.get_KeyCode() != 40 && (int)e.get_KeyCode() != 46 && (int)e.get_KeyCode() != 33 && (int)e.get_KeyCode() != 34 && (int)e.get_KeyCode() != 36 && (int)e.get_KeyCode() != 35 && (int)e.get_KeyCode() != 65536 && (int)e.get_KeyCode() != 16 && (int)e.get_KeyCode() != 13)
		{
			string text = ((Control)cbbServer).get_Text();
			int num = cbbServer.FindString(text);
			if (num > -1)
			{
				string text2 = cbbServer.get_Items().get_Item(num).ToString();
				((ListControl)cbbServer).set_SelectedIndex(num);
				cbbServer.set_SelectionStart(text.Length);
				cbbServer.set_SelectionLength(text2.Length);
			}
		}
	}

	private bool method_3()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)cbbServer).get_Text() == "")
		{
			MessageBox.Show("Please specify a Travian server");
			return false;
		}
		if (((Control)tbLogin).get_Text() == "")
		{
			MessageBox.Show("Please specify login information");
			return false;
		}
		if (((Control)tbPassword).get_Text() == "")
		{
			MessageBox.Show("Please specify password information");
			return false;
		}
		return true;
	}

	private void method_4()
	{
		cbbServer.get_Items().Clear();
		for (int num = gclass8_0.method_0().Count - 1; num >= 0; num--)
		{
			cbbServer.get_Items().Add((object)gclass8_0.method_0()[num]);
		}
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)cbbServer).get_SelectedIndex() == -1 && !gclass8_0.method_0().Contains(((Control)cbbServer).get_Text()))
		{
			gclass8_0.method_2(((Control)cbbServer).get_Text());
			GClass5.gclass5_0.method_3();
		}
		if (!method_3())
		{
			return;
		}
		method_4();
		GClass3.string_0 = ((Control)cbbServer).get_Text();
		string text = ((Control)tbLogin).get_Text();
		string text2 = ((Control)tbPassword).get_Text();
		GClass3.string_1 = ((Control)tbLogin).get_Text();
		GClass6 gClass = new GClass6();
		bool flag = false;
		try
		{
			flag = gClass.method_19(text, text2);
		}
		catch (Exception ex)
		{
			GClass3.string_0 = "";
			GClass3.string_1 = "";
			gdelegate2_0("Failed", GClass3.string_1, GClass3.string_0);
			MessageBox.Show(ex.Message);
			return;
		}
		if (flag)
		{
			GClass0.gclass0_0.method_7(GClass0.GEnum0.const_10.ToString(), GClass3.string_0);
			GClass0.gclass0_0.method_7(GClass0.GEnum0.const_8.ToString(), text);
			GClass0.gclass0_0.method_7(GClass0.GEnum0.const_9.ToString(), text2);
			if (gdelegate2_0 != null)
			{
				gdelegate2_0("Success", GClass3.string_1, GClass3.string_0);
			}
			form_0.Close();
		}
		else
		{
			MessageBox.Show("Login failed, please make sure server, username, and password is correct");
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		if (form_0 != null)
		{
			form_0.Close();
		}
	}

	private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void cbbServer_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\r')
		{
			btnLogin_Click(btnLogin, null);
		}
	}
}
