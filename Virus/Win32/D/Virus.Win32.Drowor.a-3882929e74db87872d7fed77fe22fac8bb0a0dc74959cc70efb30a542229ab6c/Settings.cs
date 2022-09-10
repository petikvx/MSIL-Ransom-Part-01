using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Settings : Form
{
	private IContainer icontainer_0;

	private TabControl tabControl1;

	private TabPage tabPageNetwork;

	private Button btnOk;

	private Button btnCancel;

	private GroupBox groupBox1;

	private GroupBox gbProxy;

	private Label label2;

	private TextBox tbProxyAddress;

	private Label label1;

	private RadioButton rbManualConnection;

	private RadioButton rbDirectConnection;

	private TextBox tbProxyPort;

	private Label label3;

	private CheckBox cbProxyByPass;

	private CheckBox cbUseAuthentication;

	private GroupBox gbAuthentication;

	private TextBox tbProxyPassword;

	private Label label4;

	private TextBox tbProxyLogin;

	private Label lblLogin;

	private TextBox tbProxyDomain;

	private Label label5;

	public Settings()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		GClass0 gclass0_ = GClass0.gclass0_0;
		string text = gclass0_.method_6(GClass0.GEnum0.const_0.ToString());
		string text2 = gclass0_.method_6(GClass0.GEnum0.const_1.ToString());
		string text3 = gclass0_.method_6(GClass0.GEnum0.const_2.ToString());
		string text4 = gclass0_.method_6(GClass0.GEnum0.const_3.ToString());
		string text5 = gclass0_.method_6(GClass0.GEnum0.const_4.ToString());
		string text6 = gclass0_.method_6(GClass0.GEnum0.const_5.ToString());
		string text7 = gclass0_.method_6(GClass0.GEnum0.const_6.ToString());
		string text8 = gclass0_.method_6(GClass0.GEnum0.const_7.ToString());
		if (text != null)
		{
			rbManualConnection.set_Checked(text.ToLower().Contains("true"));
			if (rbManualConnection.get_Checked())
			{
				((Control)gbProxy).set_Enabled(true);
			}
			else
			{
				((Control)gbProxy).set_Enabled(false);
			}
		}
		if (text2 != null)
		{
			((Control)tbProxyAddress).set_Text(text2);
		}
		if (text3 != null)
		{
			((Control)tbProxyPort).set_Text(text3);
		}
		if (text4 != null)
		{
			cbProxyByPass.set_Checked(text4.ToLower().Contains("true"));
		}
		if (text5 != null)
		{
			CheckBox obj = cbUseAuthentication;
			bool @checked;
			((Control)gbAuthentication).set_Enabled(@checked = text5.ToLower().Contains("true"));
			obj.set_Checked(@checked);
		}
		if (text6 != null)
		{
			((Control)tbProxyLogin).set_Text(text6);
		}
		if (text7 != null)
		{
			((Control)tbProxyPassword).set_Text(text7);
		}
		if (text8 != null)
		{
			((Control)tbProxyDomain).set_Text(text8);
		}
	}

	private bool method_1()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (rbManualConnection.get_Checked())
		{
			if (((Control)tbProxyAddress).get_Text() == "")
			{
				MessageBox.Show("Please specify a proxy address.");
				return false;
			}
			if (!((Control)tbProxyAddress).get_Text().ToLower().Contains("http://"))
			{
				MessageBox.Show("Address must contain http://");
				return false;
			}
			if (((Control)tbProxyPort).get_Text() == "")
			{
				MessageBox.Show("Please specify a proxy port");
				return false;
			}
			if (cbUseAuthentication.get_Checked())
			{
				if (((Control)tbProxyLogin).get_Text() == "")
				{
					MessageBox.Show("Please specify authentication login.");
					return false;
				}
				if (((Control)tbProxyPassword).get_Text() == "")
				{
					MessageBox.Show("Please specify authentication password.");
				}
			}
		}
		return true;
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		if (!method_1())
		{
			return;
		}
		GClass0 gclass0_ = GClass0.gclass0_0;
		gclass0_.method_7(GClass0.GEnum0.const_0.ToString(), rbManualConnection.get_Checked().ToString());
		if (rbManualConnection.get_Checked())
		{
			gclass0_.method_7(GClass0.GEnum0.const_1.ToString(), ((Control)tbProxyAddress).get_Text());
			gclass0_.method_7(GClass0.GEnum0.const_2.ToString(), ((Control)tbProxyPort).get_Text());
			gclass0_.method_7(GClass0.GEnum0.const_3.ToString(), cbProxyByPass.get_Checked().ToString());
			gclass0_.method_7(GClass0.GEnum0.const_4.ToString(), cbUseAuthentication.get_Checked().ToString());
			if (cbUseAuthentication.get_Checked())
			{
				gclass0_.method_7(GClass0.GEnum0.const_5.ToString(), ((Control)tbProxyLogin).get_Text());
				gclass0_.method_7(GClass0.GEnum0.const_6.ToString(), ((Control)tbProxyPassword).get_Text());
				gclass0_.method_7(GClass0.GEnum0.const_7.ToString(), ((Control)tbProxyDomain).get_Text());
			}
		}
		((Form)this).Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void rbDirectConnection_CheckedChanged(object sender, EventArgs e)
	{
		if (rbDirectConnection.get_Checked())
		{
			((Control)gbProxy).set_Enabled(false);
		}
		else
		{
			((Control)gbProxy).set_Enabled(true);
		}
	}

	private void tbProxyPort_KeyPress(object sender, KeyPressEventArgs e)
	{
		string text = "1234567890\b";
		if (text.IndexOf(e.get_KeyChar()) < 0)
		{
			e.set_Handled(true);
		}
	}

	private void cbUseAuthentication_CheckedChanged(object sender, EventArgs e)
	{
		((Control)gbAuthentication).set_Enabled(cbUseAuthentication.get_Checked());
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Expected O, but got Unknown
		tabControl1 = new TabControl();
		tabPageNetwork = new TabPage();
		groupBox1 = new GroupBox();
		gbProxy = new GroupBox();
		gbAuthentication = new GroupBox();
		tbProxyDomain = new TextBox();
		label5 = new Label();
		tbProxyPassword = new TextBox();
		label4 = new Label();
		tbProxyLogin = new TextBox();
		lblLogin = new Label();
		cbUseAuthentication = new CheckBox();
		cbProxyByPass = new CheckBox();
		tbProxyPort = new TextBox();
		label3 = new Label();
		label2 = new Label();
		tbProxyAddress = new TextBox();
		label1 = new Label();
		rbManualConnection = new RadioButton();
		rbDirectConnection = new RadioButton();
		btnOk = new Button();
		btnCancel = new Button();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPageNetwork).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)gbProxy).SuspendLayout();
		((Control)gbAuthentication).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabControl1).set_Anchor((AnchorStyles)15);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageNetwork);
		((Control)tabControl1).set_Location(new Point(12, 12));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(485, 446));
		((Control)tabControl1).set_TabIndex(0);
		((Control)tabPageNetwork).get_Controls().Add((Control)(object)groupBox1);
		tabPageNetwork.set_Location(new Point(4, 22));
		((Control)tabPageNetwork).set_Name("tabPageNetwork");
		((Control)tabPageNetwork).set_Padding(new Padding(3));
		((Control)tabPageNetwork).set_Size(new Size(477, 420));
		tabPageNetwork.set_TabIndex(0);
		((Control)tabPageNetwork).set_Text("Network");
		tabPageNetwork.set_UseVisualStyleBackColor(true);
		((Control)groupBox1).get_Controls().Add((Control)(object)gbProxy);
		((Control)groupBox1).get_Controls().Add((Control)(object)rbManualConnection);
		((Control)groupBox1).get_Controls().Add((Control)(object)rbDirectConnection);
		((Control)groupBox1).set_Location(new Point(6, 6));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(465, 372));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Proxy settings");
		((Control)gbProxy).get_Controls().Add((Control)(object)gbAuthentication);
		((Control)gbProxy).get_Controls().Add((Control)(object)cbUseAuthentication);
		((Control)gbProxy).get_Controls().Add((Control)(object)cbProxyByPass);
		((Control)gbProxy).get_Controls().Add((Control)(object)tbProxyPort);
		((Control)gbProxy).get_Controls().Add((Control)(object)label3);
		((Control)gbProxy).get_Controls().Add((Control)(object)label2);
		((Control)gbProxy).get_Controls().Add((Control)(object)tbProxyAddress);
		((Control)gbProxy).get_Controls().Add((Control)(object)label1);
		((Control)gbProxy).set_Enabled(false);
		((Control)gbProxy).set_Location(new Point(14, 77));
		((Control)gbProxy).set_Name("gbProxy");
		((Control)gbProxy).set_Size(new Size(439, 276));
		((Control)gbProxy).set_TabIndex(2);
		gbProxy.set_TabStop(false);
		((Control)gbProxy).set_Text("Proxy-server");
		((Control)gbAuthentication).get_Controls().Add((Control)(object)tbProxyDomain);
		((Control)gbAuthentication).get_Controls().Add((Control)(object)label5);
		((Control)gbAuthentication).get_Controls().Add((Control)(object)tbProxyPassword);
		((Control)gbAuthentication).get_Controls().Add((Control)(object)label4);
		((Control)gbAuthentication).get_Controls().Add((Control)(object)tbProxyLogin);
		((Control)gbAuthentication).get_Controls().Add((Control)(object)lblLogin);
		((Control)gbAuthentication).set_Enabled(false);
		((Control)gbAuthentication).set_Location(new Point(21, 126));
		((Control)gbAuthentication).set_Name("gbAuthentication");
		((Control)gbAuthentication).set_Size(new Size(276, 115));
		((Control)gbAuthentication).set_TabIndex(7);
		gbAuthentication.set_TabStop(false);
		((Control)tbProxyDomain).set_Location(new Point(84, 80));
		((Control)tbProxyDomain).set_Name("tbProxyDomain");
		tbProxyDomain.set_PasswordChar('*');
		((Control)tbProxyDomain).set_Size(new Size(166, 20));
		((Control)tbProxyDomain).set_TabIndex(6);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(17, 83));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(46, 13));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("Domain:");
		((Control)tbProxyPassword).set_Location(new Point(84, 51));
		((Control)tbProxyPassword).set_Name("tbProxyPassword");
		tbProxyPassword.set_PasswordChar('*');
		((Control)tbProxyPassword).set_Size(new Size(166, 20));
		((Control)tbProxyPassword).set_TabIndex(4);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(17, 54));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(56, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Password:");
		((Control)tbProxyLogin).set_Location(new Point(84, 22));
		((Control)tbProxyLogin).set_Name("tbProxyLogin");
		((Control)tbProxyLogin).set_Size(new Size(166, 20));
		((Control)tbProxyLogin).set_TabIndex(2);
		((Control)lblLogin).set_AutoSize(true);
		((Control)lblLogin).set_Location(new Point(17, 25));
		((Control)lblLogin).set_Name("lblLogin");
		((Control)lblLogin).set_Size(new Size(36, 13));
		((Control)lblLogin).set_TabIndex(1);
		((Control)lblLogin).set_Text("Login:");
		((Control)cbUseAuthentication).set_AutoSize(true);
		((Control)cbUseAuthentication).set_Location(new Point(21, 111));
		((Control)cbUseAuthentication).set_Name("cbUseAuthentication");
		((Control)cbUseAuthentication).set_Size(new Size(94, 17));
		((Control)cbUseAuthentication).set_TabIndex(6);
		((Control)cbUseAuthentication).set_Text("Authentication");
		((ButtonBase)cbUseAuthentication).set_UseVisualStyleBackColor(true);
		cbUseAuthentication.add_CheckedChanged((EventHandler)cbUseAuthentication_CheckedChanged);
		((Control)cbProxyByPass).set_AutoSize(true);
		((Control)cbProxyByPass).set_Location(new Point(21, 88));
		((Control)cbProxyByPass).set_Name("cbProxyByPass");
		((Control)cbProxyByPass).set_Size(new Size(211, 17));
		((Control)cbProxyByPass).set_TabIndex(5);
		((Control)cbProxyByPass).set_Text("Bypass proxy server for local addresses");
		((ButtonBase)cbProxyByPass).set_UseVisualStyleBackColor(true);
		((Control)tbProxyPort).set_Location(new Point(103, 54));
		((Control)tbProxyPort).set_Name("tbProxyPort");
		((Control)tbProxyPort).set_Size(new Size(50, 20));
		((Control)tbProxyPort).set_TabIndex(4);
		((Control)tbProxyPort).set_Text("0");
		((Control)tbProxyPort).add_KeyPress(new KeyPressEventHandler(tbProxyPort_KeyPress));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(18, 57));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(29, 13));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Port:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(334, 27));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(90, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("(e.g. http://proxy)");
		((Control)tbProxyAddress).set_Location(new Point(103, 24));
		((Control)tbProxyAddress).set_Name("tbProxyAddress");
		((Control)tbProxyAddress).set_Size(new Size(225, 20));
		((Control)tbProxyAddress).set_TabIndex(1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(18, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(79, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("HTTP-address:");
		((Control)rbManualConnection).set_AutoSize(true);
		((Control)rbManualConnection).set_Location(new Point(14, 45));
		((Control)rbManualConnection).set_Name("rbManualConnection");
		((Control)rbManualConnection).set_Size(new Size(152, 17));
		((Control)rbManualConnection).set_TabIndex(1);
		((Control)rbManualConnection).set_Text("Manual proxy configuration");
		((ButtonBase)rbManualConnection).set_UseVisualStyleBackColor(true);
		rbManualConnection.add_CheckedChanged((EventHandler)rbDirectConnection_CheckedChanged);
		((Control)rbDirectConnection).set_AutoSize(true);
		rbDirectConnection.set_Checked(true);
		((Control)rbDirectConnection).set_Location(new Point(14, 22));
		((Control)rbDirectConnection).set_Name("rbDirectConnection");
		((Control)rbDirectConnection).set_Size(new Size(177, 17));
		((Control)rbDirectConnection).set_TabIndex(0);
		rbDirectConnection.set_TabStop(true);
		((Control)rbDirectConnection).set_Text("Direct connection to the internet");
		((ButtonBase)rbDirectConnection).set_UseVisualStyleBackColor(true);
		rbDirectConnection.add_CheckedChanged((EventHandler)rbDirectConnection_CheckedChanged);
		((Control)btnOk).set_Anchor((AnchorStyles)10);
		((Control)btnOk).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnOk).set_ForeColor(Color.Green);
		((Control)btnOk).set_Location(new Point(279, 464));
		((Control)btnOk).set_Name("btnOk");
		((Control)btnOk).set_Size(new Size(105, 31));
		((Control)btnOk).set_TabIndex(1);
		((Control)btnOk).set_Text("Ok");
		((ButtonBase)btnOk).set_UseVisualStyleBackColor(true);
		((Control)btnOk).add_Click((EventHandler)btnOk_Click);
		((Control)btnCancel).set_Anchor((AnchorStyles)10);
		((Control)btnCancel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnCancel).set_ForeColor(Color.Green);
		((Control)btnCancel).set_Location(new Point(390, 464));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(107, 31));
		((Control)btnCancel).set_TabIndex(2);
		((Control)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(509, 499));
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOk);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("Settings");
		((Control)this).set_Text("Settings");
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPageNetwork).ResumeLayout(false);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)gbProxy).ResumeLayout(false);
		((Control)gbProxy).PerformLayout();
		((Control)gbAuthentication).ResumeLayout(false);
		((Control)gbAuthentication).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
