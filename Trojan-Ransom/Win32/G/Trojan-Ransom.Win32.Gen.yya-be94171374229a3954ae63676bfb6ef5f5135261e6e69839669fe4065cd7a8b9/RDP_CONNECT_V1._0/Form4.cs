using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RDP_CONNECT_V1._0;

public class Form4 : Form
{
	private IContainer components;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private Button button2;

	private Button button8;

	private Button button7;

	private Button button6;

	private Button button1;

	private Label label1;

	public Form4()
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
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		button2 = new Button();
		button8 = new Button();
		button7 = new Button();
		button6 = new Button();
		button1 = new Button();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)textBox3).set_Location(new Point(84, 135));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(120, 20));
		((Control)textBox3).set_TabIndex(32);
		((Control)textBox3).set_Text("No server");
		((Control)textBox2).set_Location(new Point(84, 107));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(120, 20));
		((Control)textBox2).set_TabIndex(31);
		((Control)textBox2).set_Text("No server");
		((Control)textBox1).set_Location(new Point(84, 78));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(120, 20));
		((Control)textBox1).set_TabIndex(30);
		((Control)textBox1).set_Text("No server");
		((ButtonBase)button2).get_FlatAppearance().set_BorderColor(Color.FromArgb(40, 42, 54));
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(40, 42, 54));
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(40, 42, 54));
		((Control)button2).set_Location(new Point(3, 160));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(201, 23));
		((Control)button2).set_TabIndex(29);
		((Control)button2).set_Text("get a random one");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_ForeColor(Color.CornflowerBlue);
		((Control)button8).set_Location(new Point(3, 104));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(75, 23));
		((Control)button8).set_TabIndex(28);
		((Control)button8).set_Text("Login");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_ForeColor(Color.CornflowerBlue);
		((Control)button7).set_Location(new Point(3, 133));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(75, 23));
		((Control)button7).set_TabIndex(27);
		((Control)button7).set_Text("Passworld");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_ForeColor(Color.CadetBlue);
		((Control)button6).set_Location(new Point(3, 46));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(201, 23));
		((Control)button6).set_TabIndex(26);
		((Control)button6).set_Text("chosen country");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.CornflowerBlue);
		((Control)button1).set_Location(new Point(3, 75));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(25);
		((Control)button1).set_Text("IP country");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Trebuchet MS", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(80, 250, 123));
		((Control)label1).set_Location(new Point(49, 3));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(94, 27));
		((Control)label1).set_TabIndex(24);
		((Control)label1).set_Text("Get RDP");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(40, 42, 54));
		((Form)this).set_ClientSize(new Size(208, 186));
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form4");
		((Control)this).set_Text("Free RDP v0.1 | Laut Cat");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
