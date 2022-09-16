using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LuminousForts;

public class EditItem : Form
{
	private IContainer components = null;

	private Button cancel;

	private Button okay;

	private TextBox value;

	private TextBox key;

	private Label valueLabel;

	private Label keyLabel;

	public string Key
	{
		get
		{
			return ((Control)key).get_Text();
		}
		set
		{
			((Control)key).set_Text(value);
		}
	}

	public string Value
	{
		get
		{
			return ((Control)value).get_Text();
		}
		set
		{
			((Control)this.value).set_Text(value);
		}
	}

	public EditItem()
	{
		InitializeComponent();
	}

	private void OkayClick(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)1);
		((Form)this).Close();
	}

	private void CancelClick(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)2);
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
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EditItem));
		keyLabel = new Label();
		valueLabel = new Label();
		key = new TextBox();
		value = new TextBox();
		okay = new Button();
		cancel = new Button();
		((Control)this).SuspendLayout();
		((Control)keyLabel).set_Location(new Point(24, 17));
		((Control)keyLabel).set_Margin(new Padding(6, 0, 6, 0));
		((Control)keyLabel).set_Name("keyLabel");
		((Control)keyLabel).set_Size(new Size(200, 45));
		((Control)keyLabel).set_TabIndex(0);
		((Control)keyLabel).set_Text("Key");
		((Control)valueLabel).set_Location(new Point(24, 87));
		((Control)valueLabel).set_Margin(new Padding(6, 0, 6, 0));
		((Control)valueLabel).set_Name("valueLabel");
		((Control)valueLabel).set_Size(new Size(200, 45));
		((Control)valueLabel).set_TabIndex(1);
		((Control)valueLabel).set_Text("Value");
		((Control)key).set_Enabled(false);
		((Control)key).set_Location(new Point(236, 23));
		((Control)key).set_Margin(new Padding(6, 6, 6, 6));
		((Control)key).set_Name("key");
		((Control)key).set_Size(new Size(500, 38));
		((Control)key).set_TabIndex(2);
		((Control)value).set_Location(new Point(236, 89));
		((Control)value).set_Margin(new Padding(6, 6, 6, 6));
		((Control)value).set_Name("value");
		((Control)value).set_Size(new Size(500, 38));
		((Control)value).set_TabIndex(3);
		((Control)okay).set_Location(new Point(414, 198));
		((Control)okay).set_Margin(new Padding(6, 6, 6, 6));
		((Control)okay).set_Name("okay");
		((Control)okay).set_Size(new Size(178, 66));
		((Control)okay).set_TabIndex(4);
		((Control)okay).set_Text("&OK");
		((ButtonBase)okay).set_UseVisualStyleBackColor(true);
		((Control)okay).add_Click((EventHandler)OkayClick);
		((Control)cancel).set_Location(new Point(604, 198));
		((Control)cancel).set_Margin(new Padding(6, 6, 6, 6));
		((Control)cancel).set_Name("cancel");
		((Control)cancel).set_Size(new Size(178, 66));
		((Control)cancel).set_TabIndex(5);
		((Control)cancel).set_Text("&Cancel");
		((ButtonBase)cancel).set_UseVisualStyleBackColor(true);
		((Control)cancel).add_Click((EventHandler)CancelClick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(806, 287));
		((Control)this).get_Controls().Add((Control)(object)cancel);
		((Control)this).get_Controls().Add((Control)(object)okay);
		((Control)this).get_Controls().Add((Control)(object)value);
		((Control)this).get_Controls().Add((Control)(object)key);
		((Control)this).get_Controls().Add((Control)(object)valueLabel);
		((Control)this).get_Controls().Add((Control)(object)keyLabel);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(6, 6, 6, 6));
		((Control)this).set_Name("EditItem");
		((Control)this).set_Text("Edit Item");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
