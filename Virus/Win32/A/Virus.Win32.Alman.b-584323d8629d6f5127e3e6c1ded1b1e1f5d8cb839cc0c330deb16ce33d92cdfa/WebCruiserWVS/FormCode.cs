using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WebCruiserWVS;

public class FormCode : Form
{
	private FormMain formMain_0;

	private IContainer icontainer_0;

	private ToolStrip toolStripCode;

	private ToolStripButton btnGetCode;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripButton btnGetWBCode;

	private ToolStripSeparator toolStripSeparator2;

	private TextBox txtCode;

	private ToolStripSeparator toolStripSeparator3;

	public FormCode(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
	}

	private void btnGetCode_Click(object sender, EventArgs e)
	{
		string text = formMain_0.method_2();
		((TextBoxBase)txtCode).Clear();
		formMain_0.method_11("Getting Source ...");
		if (formMain_0.method_0() != 0)
		{
			text = text + "^" + formMain_0.method_4();
		}
		try
		{
			HttpWebResponse httpWebResponse = formMain_0.gclass0_0.method_28(text, formMain_0.method_0());
			if (httpWebResponse != null)
			{
				string text2 = formMain_0.gclass0_0.method_29(httpWebResponse);
				((Control)txtCode).set_Text(text2);
				formMain_0.method_11("HTTP Status: " + httpWebResponse.StatusCode);
			}
		}
		catch
		{
		}
	}

	private void btnGetWBCode_Click(object sender, EventArgs e)
	{
		((TextBoxBase)txtCode).Clear();
		string text = formMain_0.method_25();
		((Control)txtCode).set_Text(text);
	}

	public void method_0(string string_0)
	{
		((Control)txtCode).set_Text(string_0);
	}

	public void method_1(int int_0, int int_1)
	{
		((TextBoxBase)txtCode).Select(int_0, int_1);
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
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormCode));
		toolStripCode = new ToolStrip();
		btnGetCode = new ToolStripButton();
		toolStripSeparator1 = new ToolStripSeparator();
		btnGetWBCode = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		txtCode = new TextBox();
		toolStripSeparator3 = new ToolStripSeparator();
		((Control)toolStripCode).SuspendLayout();
		((Control)this).SuspendLayout();
		toolStripCode.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripCode).set_Dock((DockStyle)2);
		toolStripCode.set_GripStyle((ToolStripGripStyle)0);
		toolStripCode.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)btnGetCode,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)btnGetWBCode,
			(ToolStripItem)toolStripSeparator3
		});
		((Control)toolStripCode).set_Location(new Point(0, 341));
		((Control)toolStripCode).set_Name("toolStripCode");
		((Control)toolStripCode).set_Size(new Size(575, 25));
		((Control)toolStripCode).set_TabIndex(0);
		((Control)toolStripCode).set_Text("toolStrip1");
		((ToolStripItem)btnGetCode).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetCode).set_Image((Image)componentResourceManager.GetObject("btnGetCode.Image"));
		((ToolStripItem)btnGetCode).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetCode).set_Name("btnGetCode");
		((ToolStripItem)btnGetCode).set_Size(new Size(159, 22));
		((ToolStripItem)btnGetCode).set_Text("Get Code From Current URL");
		((ToolStripItem)btnGetCode).add_Click((EventHandler)btnGetCode_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetWBCode).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetWBCode).set_Image((Image)componentResourceManager.GetObject("btnGetWBCode.Image"));
		((ToolStripItem)btnGetWBCode).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetWBCode).set_Name("btnGetWBCode");
		((ToolStripItem)btnGetWBCode).set_Size(new Size(183, 22));
		((ToolStripItem)btnGetWBCode).set_Text("Get Code From Current Browser");
		((ToolStripItem)btnGetWBCode).add_Click((EventHandler)btnGetWBCode_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((Control)txtCode).set_Dock((DockStyle)5);
		((TextBoxBase)txtCode).set_HideSelection(false);
		((Control)txtCode).set_Location(new Point(0, 0));
		((TextBoxBase)txtCode).set_Multiline(true);
		((Control)txtCode).set_Name("txtCode");
		txtCode.set_ScrollBars((ScrollBars)3);
		((Control)txtCode).set_Size(new Size(575, 341));
		((Control)txtCode).set_TabIndex(6);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(575, 366));
		((Control)this).get_Controls().Add((Control)(object)txtCode);
		((Control)this).get_Controls().Add((Control)(object)toolStripCode);
		((Control)this).set_Cursor(Cursors.get_Arrow());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormCode");
		((Control)this).set_Text("FormCode");
		((Control)toolStripCode).ResumeLayout(false);
		((Control)toolStripCode).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
