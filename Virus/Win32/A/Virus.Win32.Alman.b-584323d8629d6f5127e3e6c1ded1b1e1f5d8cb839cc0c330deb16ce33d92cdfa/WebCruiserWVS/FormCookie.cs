using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebCruiserWVS;

public class FormCookie : Form
{
	private FormMain formMain_0;

	private IContainer icontainer_0;

	private ToolStrip toolStripCookei;

	private TextBox txtCookie;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripComboBox cmbEscapeCookie;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripButton btnGetCookie;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripButton btnSetCookie;

	private ToolStripSeparator toolStripSeparator4;

	public FormCookie(FormMain formMain_1)
	{
		InitializeComponent();
		cmbEscapeCookie.set_SelectedIndex(0);
		formMain_0 = formMain_1;
	}

	private void btnGetCookie_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)txtCookie).set_Text(formMain_0.gclass0_0.method_33());
			((ToolStripItem)btnSetCookie).set_Enabled(true);
		}
		catch (Exception)
		{
			MessageBox.Show("Please Navigate the Web site at first!  ", "Information");
		}
	}

	private void btnSetCookie_Click(object sender, EventArgs e)
	{
		char[] trimChars = new char[2] { ' ', ';' };
		string text = ((Control)txtCookie).get_Text().Trim(trimChars);
		if (!string.IsNullOrEmpty(text))
		{
			((Control)txtCookie).set_Text(text);
			formMain_0.gclass0_0.method_25(text);
		}
	}

	private void cmbEscapeCookie_DropDownClosed(object sender, EventArgs e)
	{
		if (cmbEscapeCookie.get_SelectedIndex() == 0)
		{
			GClass0.bool_0 = true;
			formMain_0.method_49(bool_0: true);
		}
		else
		{
			GClass0.bool_0 = false;
			formMain_0.method_49(bool_0: false);
		}
	}

	public void method_0(bool bool_0)
	{
		if (bool_0)
		{
			cmbEscapeCookie.set_SelectedIndex(0);
		}
		else
		{
			cmbEscapeCookie.set_SelectedIndex(1);
		}
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
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormCookie));
		toolStripCookei = new ToolStrip();
		txtCookie = new TextBox();
		toolStripSeparator1 = new ToolStripSeparator();
		cmbEscapeCookie = new ToolStripComboBox();
		toolStripSeparator2 = new ToolStripSeparator();
		btnGetCookie = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		btnSetCookie = new ToolStripButton();
		toolStripSeparator4 = new ToolStripSeparator();
		((Control)toolStripCookei).SuspendLayout();
		((Control)this).SuspendLayout();
		toolStripCookei.set_BackColor(SystemColors.ButtonFace);
		toolStripCookei.set_GripStyle((ToolStripGripStyle)0);
		toolStripCookei.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)cmbEscapeCookie,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)btnGetCookie,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)btnSetCookie,
			(ToolStripItem)toolStripSeparator4
		});
		((Control)toolStripCookei).set_Location(new Point(0, 0));
		((Control)toolStripCookei).set_Name("toolStripCookei");
		((Control)toolStripCookei).set_Size(new Size(555, 25));
		((Control)toolStripCookei).set_TabIndex(4);
		((Control)toolStripCookei).set_Text("toolStrip1");
		((Control)txtCookie).set_Dock((DockStyle)5);
		((Control)txtCookie).set_Location(new Point(0, 25));
		((Control)txtCookie).set_Margin(new Padding(3, 4, 3, 4));
		((TextBoxBase)txtCookie).set_Multiline(true);
		((Control)txtCookie).set_Name("txtCookie");
		((Control)txtCookie).set_Size(new Size(555, 329));
		((Control)txtCookie).set_TabIndex(5);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		cmbEscapeCookie.set_DropDownStyle((ComboBoxStyle)2);
		cmbEscapeCookie.get_Items().AddRange(new object[2] { "Escape Special Characters(Default)", "Not Escape" });
		((ToolStripItem)cmbEscapeCookie).set_Name("cmbEscapeCookie");
		((ToolStripItem)cmbEscapeCookie).set_Size(new Size(230, 25));
		cmbEscapeCookie.add_DropDownClosed((EventHandler)cmbEscapeCookie_DropDownClosed);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetCookie).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetCookie).set_Image((Image)componentResourceManager.GetObject("btnGetCookie.Image"));
		((ToolStripItem)btnGetCookie).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetCookie).set_Name("btnGetCookie");
		((ToolStripItem)btnGetCookie).set_Size(new Size(63, 22));
		((ToolStripItem)btnGetCookie).set_Text("GetCookie");
		((ToolStripItem)btnGetCookie).add_Click((EventHandler)btnGetCookie_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		((ToolStripItem)btnSetCookie).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnSetCookie).set_Enabled(false);
		((ToolStripItem)btnSetCookie).set_Image((Image)componentResourceManager.GetObject("btnSetCookie.Image"));
		((ToolStripItem)btnSetCookie).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnSetCookie).set_Name("btnSetCookie");
		((ToolStripItem)btnSetCookie).set_Size(new Size(63, 22));
		((ToolStripItem)btnSetCookie).set_Text("SetCookie");
		((ToolStripItem)btnSetCookie).add_Click((EventHandler)btnSetCookie_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(6, 25));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(555, 354));
		((Control)this).get_Controls().Add((Control)(object)txtCookie);
		((Control)this).get_Controls().Add((Control)(object)toolStripCookei);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormCookie");
		((Control)this).set_Text("FormCookie");
		((Control)toolStripCookei).ResumeLayout(false);
		((Control)toolStripCookei).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
