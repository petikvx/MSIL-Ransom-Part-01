using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

public class info_box : Form
{
	private IContainer components = null;

	public MetroLabel metroLabel1;

	public MetroLabel label3;

	public MetroLabel label2;

	public info_box()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
		Icon icon = new Icon(update_app.folder_path + "\\Poshmark_.ico");
		((Form)this).set_Icon(icon);
	}

	private void label3_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://bit.ly/2KqADHR");
		}
		catch
		{
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
		label3 = new MetroLabel();
		label2 = new MetroLabel();
		metroLabel1 = new MetroLabel();
		((Control)this).SuspendLayout();
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Label)label3).set_BorderStyle((BorderStyle)2);
		((Control)label3).set_Cursor(Cursors.get_Hand());
		label3.FontWeight = MetroLabelWeight.Bold;
		((Control)label3).set_ForeColor(Color.Plum);
		((Control)label3).set_Location(new Point(53, 250));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(294, 57));
		label3.Style = MetroColorStyle.Brown;
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Check out our YouTube channel for guides \r\n& money making strategies!\r\nhttp://bit.ly/2KqADHR");
		((Label)label3).set_UseMnemonic(false);
		label3.UseStyleColors = true;
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label2).set_AutoSize(true);
		label2.FontWeight = MetroLabelWeight.Bold;
		((Control)label2).set_ForeColor(Color.Crimson);
		((Control)label2).set_Location(new Point(20, 81));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(276, 76));
		label2.Style = MetroColorStyle.Red;
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("In this Version,\r\n\r\n> Having Issue With Browser?\r\n     ----> Change Browser From Settings ");
		((Label)label2).set_UseMnemonic(false);
		label2.UseStyleColors = true;
		((Control)metroLabel1).set_AutoSize(true);
		metroLabel1.FontSize = MetroLabelSize.Tall;
		metroLabel1.FontWeight = MetroLabelWeight.Bold;
		((Control)metroLabel1).set_ForeColor(Color.Plum);
		((Control)metroLabel1).set_Location(new Point(80, 9));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(251, 25));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(6);
		((Control)metroLabel1).set_Text("Welcome to Poshmark Tools");
		((Label)metroLabel1).set_UseMnemonic(false);
		metroLabel1.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(402, 392));
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Name("info_box");
		((Control)this).set_Text("Info box");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
