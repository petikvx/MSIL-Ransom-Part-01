using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class pricing_change : Form
{
	public struct value_percentage
	{
		public bool raise_drop;

		public bool percentage;

		public int value;
	}

	public value_percentage vp = default(value_percentage);

	private IContainer components = null;

	private MetroTextBox flat_percentage_value_metroTextBox1;

	private MetroCheckBox flat_percentage_drop_metroCheckBox1;

	private MetroCheckBox Lower_high_metroCheckBox1;

	private Button update_price_value_button1;

	public pricing_change()
	{
		InitializeComponent();
		vp.percentage = false;
		vp.value = 0;
		vp.raise_drop = false;
	}

	private void flat_percentage_value_metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()))
		{
			e.set_Handled(true);
		}
	}

	private void update_price_value_button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (((Control)flat_percentage_value_metroTextBox1).get_Text() != "")
			{
				int num = int.Parse(((Control)flat_percentage_value_metroTextBox1).get_Text());
				if (num <= 0)
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nProvide value above 0");
					((Form)this).Close();
				}
				if (((CheckBox)flat_percentage_drop_metroCheckBox1).get_Checked())
				{
					vp.percentage = true;
					if (num >= 100)
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nProvide value less than 100");
						((Form)this).Close();
					}
				}
				if (((CheckBox)Lower_high_metroCheckBox1).get_Checked())
				{
					vp.raise_drop = true;
				}
				vp.value = num;
			}
			else
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nProvide Valid Discount Number");
				((Form)this).Close();
			}
		}
		catch
		{
		}
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		flat_percentage_value_metroTextBox1 = new MetroTextBox();
		flat_percentage_drop_metroCheckBox1 = new MetroCheckBox();
		Lower_high_metroCheckBox1 = new MetroCheckBox();
		update_price_value_button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)flat_percentage_value_metroTextBox1).set_ForeColor(Color.Black);
		((Control)flat_percentage_value_metroTextBox1).set_Location(new Point(534, 88));
		((Control)flat_percentage_value_metroTextBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)flat_percentage_value_metroTextBox1).set_Name("flat_percentage_value_metroTextBox1");
		((Control)flat_percentage_value_metroTextBox1).set_Size(new Size(76, 35));
		((Control)flat_percentage_value_metroTextBox1).set_TabIndex(92);
		((Control)flat_percentage_value_metroTextBox1).set_Text("30");
		((Control)flat_percentage_value_metroTextBox1).add_KeyPress(new KeyPressEventHandler(flat_percentage_value_metroTextBox1_KeyPress));
		((Control)flat_percentage_drop_metroCheckBox1).set_AutoSize(true);
		((Control)flat_percentage_drop_metroCheckBox1).set_Location(new Point(13, 88));
		((Control)flat_percentage_drop_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)flat_percentage_drop_metroCheckBox1).set_Name("flat_percentage_drop_metroCheckBox1");
		((Control)flat_percentage_drop_metroCheckBox1).set_Size(new Size(295, 15));
		flat_percentage_drop_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)flat_percentage_drop_metroCheckBox1).set_TabIndex(91);
		((Control)flat_percentage_drop_metroCheckBox1).set_Text("Flat/%tage (Check for Percentage, uncheck for Flat)");
		flat_percentage_drop_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)flat_percentage_drop_metroCheckBox1).set_UseVisualStyleBackColor(false);
		((Control)Lower_high_metroCheckBox1).set_AutoSize(true);
		((Control)Lower_high_metroCheckBox1).set_Location(new Point(13, 47));
		((Control)Lower_high_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Lower_high_metroCheckBox1).set_Name("Lower_high_metroCheckBox1");
		((Control)Lower_high_metroCheckBox1).set_Size(new Size(310, 15));
		Lower_high_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)Lower_high_metroCheckBox1).set_TabIndex(93);
		((Control)Lower_high_metroCheckBox1).set_Text("Drop/Increase (check for price raise, uncheck for drop)");
		Lower_high_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)Lower_high_metroCheckBox1).set_UseVisualStyleBackColor(false);
		((Control)update_price_value_button1).set_Location(new Point(13, 135));
		((Control)update_price_value_button1).set_Name("update_price_value_button1");
		((Control)update_price_value_button1).set_Size(new Size(112, 34));
		((Control)update_price_value_button1).set_TabIndex(94);
		((Control)update_price_value_button1).set_Text("Update");
		((ButtonBase)update_price_value_button1).set_UseVisualStyleBackColor(true);
		((Control)update_price_value_button1).add_Click((EventHandler)update_price_value_button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(654, 217));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)update_price_value_button1);
		((Control)this).get_Controls().Add((Control)(object)Lower_high_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)flat_percentage_value_metroTextBox1);
		((Control)this).get_Controls().Add((Control)(object)flat_percentage_drop_metroCheckBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("pricing_change");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Price Change");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
