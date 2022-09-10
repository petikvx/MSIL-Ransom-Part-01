using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WebCruiserWVS;

public class FormAbout : Form
{
	private IContainer icontainer_0;

	private SplitContainer splitAbout;

	private TextBox txtHelp;

	private Label lblRegInfo;

	private LinkLabel linkLblSite;

	private LinkLabel linkLblBuy;

	private Button btnReg;

	private TextBox txtRegCode;

	private TextBox txtRegUsername;

	private Label lblRegCode;

	private Label lblRegUsername;

	private LinkLabel linkLabelSite2;

	private LinkLabel linkLabelMail;

	private LinkLabel linkPaypal;

	private FormMain formMain_0;

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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormAbout));
		splitAbout = new SplitContainer();
		txtHelp = new TextBox();
		linkLblBuy = new LinkLabel();
		btnReg = new Button();
		txtRegCode = new TextBox();
		txtRegUsername = new TextBox();
		lblRegCode = new Label();
		lblRegUsername = new Label();
		linkLblSite = new LinkLabel();
		lblRegInfo = new Label();
		linkLabelSite2 = new LinkLabel();
		linkLabelMail = new LinkLabel();
		linkPaypal = new LinkLabel();
		((Control)splitAbout.get_Panel1()).SuspendLayout();
		((Control)splitAbout.get_Panel2()).SuspendLayout();
		((Control)splitAbout).SuspendLayout();
		((Control)this).SuspendLayout();
		splitAbout.set_Dock((DockStyle)5);
		((Control)splitAbout).set_Location(new Point(0, 0));
		((Control)splitAbout).set_Name("splitAbout");
		splitAbout.set_Orientation((Orientation)0);
		((Control)splitAbout.get_Panel1()).get_Controls().Add((Control)(object)txtHelp);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)linkPaypal);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)linkLabelMail);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)linkLabelSite2);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)linkLblBuy);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)btnReg);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)txtRegCode);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)txtRegUsername);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)lblRegCode);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)lblRegUsername);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)linkLblSite);
		((Control)splitAbout.get_Panel2()).get_Controls().Add((Control)(object)lblRegInfo);
		((Control)splitAbout).set_Size(new Size(634, 371));
		splitAbout.set_SplitterDistance(259);
		((Control)splitAbout).set_TabIndex(0);
		((Control)txtHelp).set_BackColor(SystemColors.Control);
		((Control)txtHelp).set_Dock((DockStyle)5);
		((Control)txtHelp).set_Location(new Point(0, 0));
		((Control)txtHelp).set_Margin(new Padding(2));
		((TextBoxBase)txtHelp).set_Multiline(true);
		((Control)txtHelp).set_Name("txtHelp");
		((TextBoxBase)txtHelp).set_ReadOnly(true);
		((Control)txtHelp).set_Size(new Size(634, 259));
		((Control)txtHelp).set_TabIndex(9);
		((Control)txtHelp).set_Text(componentResourceManager.GetString("txtHelp.Text"));
		((Control)linkLblBuy).set_AutoSize(true);
		((Control)linkLblBuy).set_Location(new Point(484, 86));
		((Control)linkLblBuy).set_Name("linkLblBuy");
		((Control)linkLblBuy).set_Size(new Size(47, 12));
		((Control)linkLblBuy).set_TabIndex(18);
		((Label)linkLblBuy).set_TabStop(true);
		((Control)linkLblBuy).set_Text("RegNow!");
		linkLblBuy.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLblBuy_LinkClicked));
		((Control)btnReg).set_Location(new Point(394, 81));
		((Control)btnReg).set_Name("btnReg");
		((Control)btnReg).set_Size(new Size(75, 23));
		((Control)btnReg).set_TabIndex(17);
		((Control)btnReg).set_Text("Register");
		((ButtonBase)btnReg).set_UseVisualStyleBackColor(true);
		((Control)btnReg).add_Click((EventHandler)btnReg_Click);
		((Control)txtRegCode).set_Location(new Point(394, 56));
		((Control)txtRegCode).set_Name("txtRegCode");
		((Control)txtRegCode).set_Size(new Size(193, 21));
		((Control)txtRegCode).set_TabIndex(16);
		((Control)txtRegUsername).set_Location(new Point(394, 30));
		((Control)txtRegUsername).set_Name("txtRegUsername");
		((Control)txtRegUsername).set_Size(new Size(193, 21));
		((Control)txtRegUsername).set_TabIndex(15);
		((Control)lblRegCode).set_AutoSize(true);
		((Control)lblRegCode).set_Location(new Point(321, 59));
		((Control)lblRegCode).set_Name("lblRegCode");
		((Control)lblRegCode).set_Size(new Size(53, 12));
		((Control)lblRegCode).set_TabIndex(14);
		((Control)lblRegCode).set_Text("RegCode:");
		((Control)lblRegUsername).set_AutoSize(true);
		((Control)lblRegUsername).set_Location(new Point(321, 33));
		((Control)lblRegUsername).set_Name("lblRegUsername");
		((Control)lblRegUsername).set_Size(new Size(59, 12));
		((Control)lblRegUsername).set_TabIndex(13);
		((Control)lblRegUsername).set_Text("Username:");
		((Control)linkLblSite).set_AutoSize(true);
		((Control)linkLblSite).set_Location(new Point(3, 38));
		((Control)linkLblSite).set_Name("linkLblSite");
		((Control)linkLblSite).set_Size(new Size(113, 12));
		((Control)linkLblSite).set_TabIndex(11);
		((Label)linkLblSite).set_TabStop(true);
		((Control)linkLblSite).set_Text("http://sec4app.com");
		linkLblSite.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLblSite_LinkClicked));
		((Control)lblRegInfo).set_AutoSize(true);
		((Control)lblRegInfo).set_Location(new Point(3, 10));
		((Control)lblRegInfo).set_Name("lblRegInfo");
		((Control)lblRegInfo).set_Size(new Size(461, 12));
		((Control)lblRegInfo).set_TabIndex(1);
		((Control)lblRegInfo).set_Text("This Copy of WebCruiser is UnRegistered! You can use it for another 30 days.");
		((Control)linkLabelSite2).set_AutoSize(true);
		((Control)linkLabelSite2).set_Location(new Point(3, 59));
		((Control)linkLabelSite2).set_Name("linkLabelSite2");
		((Control)linkLabelSite2).set_Size(new Size(137, 12));
		((Control)linkLabelSite2).set_TabIndex(19);
		((Label)linkLabelSite2).set_TabStop(true);
		((Control)linkLabelSite2).set_Text("http://www.janusec.com");
		linkLabelSite2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabelSite2_LinkClicked));
		((Control)linkLabelMail).set_AutoSize(true);
		((Control)linkLabelMail).set_Location(new Point(3, 82));
		((Control)linkLabelMail).set_Name("linkLabelMail");
		((Control)linkLabelMail).set_Size(new Size(137, 12));
		((Control)linkLabelMail).set_TabIndex(20);
		((Label)linkLabelMail).set_TabStop(true);
		((Control)linkLabelMail).set_Text("janusecurity@gmail.com");
		linkLabelMail.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabelMail_LinkClicked));
		((Control)linkPaypal).set_AutoSize(true);
		((Control)linkPaypal).set_Location(new Point(540, 86));
		((Control)linkPaypal).set_Name("linkPaypal");
		((Control)linkPaypal).set_Size(new Size(41, 12));
		((Control)linkPaypal).set_TabIndex(21);
		((Label)linkPaypal).set_TabStop(true);
		((Control)linkPaypal).set_Text("PayPal");
		linkPaypal.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkPaypal_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(634, 371));
		((Control)this).get_Controls().Add((Control)(object)splitAbout);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormAbout");
		((Control)this).set_Text("FormAbout");
		((Control)splitAbout.get_Panel1()).ResumeLayout(false);
		((Control)splitAbout.get_Panel1()).PerformLayout();
		((Control)splitAbout.get_Panel2()).ResumeLayout(false);
		((Control)splitAbout.get_Panel2()).PerformLayout();
		((Control)splitAbout).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public FormAbout(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
	}

	public void method_0()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (Class2.smethod_0())
		{
			((Control)lblRegInfo).set_Text("This copy of WebCruiser is licensed to: " + Class2.string_0);
			((Control)lblRegUsername).set_Visible(false);
			((Control)lblRegCode).set_Visible(false);
			((Control)txtRegUsername).set_Visible(false);
			((Control)txtRegCode).set_Visible(false);
			((Control)btnReg).set_Visible(false);
			((Control)linkLblBuy).set_Visible(false);
			((Control)linkPaypal).set_Visible(false);
		}
		else if (Class2.int_0 > 0)
		{
			((Control)lblRegInfo).set_Text("This Copy of WebCruiser is UnRegistered! You can use it for " + Class2.int_0 + " days.");
		}
		else
		{
			((Control)lblRegInfo).set_Text("This Copy of WebCruiser is UnRegistered and Expired! Please Register If You Would Like To Continue Using It!");
			MessageBox.Show("This Copy of WebCruiser is UnRegistered and Expired! Please Register If You Would Like To Continue Using It!", "", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		formMain_0.method_29(Class2.smethod_0(), Class2.int_0);
	}

	private void linkLblBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		linkLblBuy.set_LinkVisited(true);
		string text = "";
		text = "https://www.regnow.com/softsell/nph-softsell.cgi?item=25854-2";
		try
		{
			Process.Start(text);
		}
		catch
		{
			Clipboard.SetText(text);
			MessageBox.Show("* Default browser not found, please open the following URL for order information.\r\n* " + text + "\r\n* This URL has been set to ClipBoard and you can paste it to you browser directly.", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void btnReg_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)txtRegUsername).get_Text().Trim();
		if (!string.IsNullOrEmpty(text) && text.Length >= 2)
		{
			string text2 = ((Control)txtRegCode).get_Text();
			if (string.IsNullOrEmpty(text2))
			{
				MessageBox.Show("RegCode can not be null!");
				return;
			}
			if (!Class2.smethod_5(text, text2) && !Class2.smethod_4(text, text2))
			{
				MessageBox.Show("Invalid RegCode !");
				return;
			}
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Sec4App\\WebCruiser");
			registryKey.SetValue("Username", text);
			registryKey.SetValue("RegCode", text2);
			string string_ = DateTime.Now.ToString("yyyy-MM-dd");
			string_ = Class2.smethod_8(string_);
			registryKey.SetValue("InitDate", string_);
			((Control)lblRegInfo).set_Text("This copy of WebCruiser is licensed to: " + text);
			MessageBox.Show("Thank You For Registration!", "Registration OK!");
			((Control)lblRegUsername).set_Visible(false);
			((Control)lblRegCode).set_Visible(false);
			((Control)txtRegUsername).set_Visible(false);
			((Control)txtRegCode).set_Visible(false);
			((Control)btnReg).set_Visible(false);
			((Control)linkLblBuy).set_Visible(false);
			((Control)linkPaypal).set_Visible(false);
			Class2.smethod_1(bool_1: true);
			Class2.string_0 = text;
		}
		else
		{
			MessageBox.Show("Username should has at least 2 letters!");
		}
	}

	private void linkLblSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "http://sec4app.com/";
		try
		{
			Process.Start(text);
		}
		catch
		{
			formMain_0.method_28(text, GEnum0.GET, "");
		}
	}

	private void linkLabelSite2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "http://www.janusec.com/";
		try
		{
			Process.Start(text);
		}
		catch
		{
			formMain_0.method_28(text, GEnum0.GET, "");
		}
	}

	private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string fileName = "mailto:janusecurity@gmail.com?subject=WebCruiserWVS";
		try
		{
			Process.Start(fileName);
		}
		catch
		{
		}
	}

	private void linkPaypal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		linkPaypal.set_LinkVisited(true);
		string text = "";
		text = "http://www.janusec.com/product/2/webcruiser+web+vulnerability+scanner+enterprise+edition";
		try
		{
			Process.Start(text);
		}
		catch
		{
			Clipboard.SetText(text);
			MessageBox.Show("* Default browser not found, please open the following URL for order information.\r\n* " + text + "\r\n* This URL has been set to ClipBoard and you can paste it to you browser directly.", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}
}
