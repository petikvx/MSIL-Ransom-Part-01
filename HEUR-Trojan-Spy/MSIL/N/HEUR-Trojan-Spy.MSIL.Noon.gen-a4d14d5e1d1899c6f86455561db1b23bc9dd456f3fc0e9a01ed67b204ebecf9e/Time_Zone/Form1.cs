using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Time_Zone;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private ListBox cityListBox;

	private Label label2;

	private Label timeZoneLabel;

	private Button okButton;

	private Button exitButton;

	public Form1()
	{
		InitializeComponent();
	}

	private void okButton_Click(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)cityListBox).get_SelectedIndex() != -1)
		{
			switch (cityListBox.get_SelectedItem().ToString())
			{
			case "New York":
				((Control)timeZoneLabel).set_Text("Eastern");
				break;
			case "Minneapolis":
				((Control)timeZoneLabel).set_Text("Central");
				break;
			case "Denver":
				((Control)timeZoneLabel).set_Text("Mountain");
				break;
			case "San Francisco":
				((Control)timeZoneLabel).set_Text("Pacific");
				break;
			case "Honolulu":
				((Control)timeZoneLabel).set_Text("Hawaii-Aleutian");
				break;
			}
		}
		else
		{
			MessageBox.Show("Select a city.");
		}
	}

	private void exitButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		cityListBox = new ListBox();
		label2 = new Label();
		timeZoneLabel = new Label();
		okButton = new Button();
		exitButton = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(35, 31));
		((Control)label1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(583, 32));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Select a city and I will give you the time zone.");
		((ListControl)cityListBox).set_FormattingEnabled(true);
		cityListBox.set_ItemHeight(31);
		cityListBox.get_Items().AddRange(new object[5] { "Denver", "Honolulu", "Minneapolis", "New York", "San Francisco" });
		((Control)cityListBox).set_Location(new Point(171, 72));
		((Control)cityListBox).set_Margin(new Padding(8, 7, 8, 7));
		((Control)cityListBox).set_Name("cityListBox");
		((Control)cityListBox).set_Size(new Size(313, 221));
		((Control)cityListBox).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(109, 334));
		((Control)label2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(158, 32));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Time Zone:");
		timeZoneLabel.set_BorderStyle((BorderStyle)1);
		((Control)timeZoneLabel).set_Location(new Point(288, 322));
		((Control)timeZoneLabel).set_Margin(new Padding(8, 0, 8, 0));
		((Control)timeZoneLabel).set_Name("timeZoneLabel");
		((Control)timeZoneLabel).set_Size(new Size(263, 52));
		((Control)timeZoneLabel).set_TabIndex(3);
		timeZoneLabel.set_TextAlign((ContentAlignment)32);
		((Control)okButton).set_Location(new Point(112, 405));
		((Control)okButton).set_Margin(new Padding(8, 7, 8, 7));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(200, 55));
		((Control)okButton).set_TabIndex(4);
		((Control)okButton).set_Text("&OK");
		((ButtonBase)okButton).set_UseVisualStyleBackColor(true);
		((Control)okButton).add_Click((EventHandler)okButton_Click);
		((Control)exitButton).set_Location(new Point(331, 405));
		((Control)exitButton).set_Margin(new Padding(8, 7, 8, 7));
		((Control)exitButton).set_Name("exitButton");
		((Control)exitButton).set_Size(new Size(200, 55));
		((Control)exitButton).set_TabIndex(5);
		((Control)exitButton).set_Text("&Exit");
		((ButtonBase)exitButton).set_UseVisualStyleBackColor(true);
		((Control)exitButton).add_Click((EventHandler)exitButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(779, 486));
		((Control)this).get_Controls().Add((Control)(object)exitButton);
		((Control)this).get_Controls().Add((Control)(object)okButton);
		((Control)this).get_Controls().Add((Control)(object)timeZoneLabel);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)cityListBox);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Time Zone");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
