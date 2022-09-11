using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class Custom : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button3;

	private TextBox textBox1;

	public Custom()
	{
		InitializeComponent();
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
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Custom));
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(1, 203));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(89, 50));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Clear");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(199, 172));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(99, 38));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Execute");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(388, 203));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(89, 50));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("Open");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)textBox1).set_Location(new Point(1, -3));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)3);
		((Control)textBox1).set_Size(new Size(476, 56));
		((Control)textBox1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(477, 255));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Custom");
		((Control)this).set_Text("GhostC");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
