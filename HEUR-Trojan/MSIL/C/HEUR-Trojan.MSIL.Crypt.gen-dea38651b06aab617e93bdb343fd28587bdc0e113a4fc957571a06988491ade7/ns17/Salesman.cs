using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns13;
using ns14;
using ns18;

namespace ns17;

public class Salesman : Form
{
	private IContainer icontainer_0 = null;

	private Button button12;

	private Button button4;

	private Button button1;

	private Label label1;

	private Panel panel1;

	public Salesman()
	{
		InitializeComponent();
	}

	private void button12_Click(object sender, EventArgs e)
	{
		Login login = new Login();
		((Control)login).Show();
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Search_Products search_Products = new Search_Products();
		((Control)search_Products).Show();
		((Form)this).Close();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Make_Sale make_Sale = new Make_Sale();
		((Control)make_Sale).Show();
		((Form)this).Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		button12 = new Button();
		button4 = new Button();
		button1 = new Button();
		label1 = new Label();
		panel1 = new Panel();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button12).set_BackColor(Color.DodgerBlue);
		((Control)button12).set_ForeColor(Color.LightGray);
		((Control)button12).set_Location(new Point(714, 282));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(82, 32));
		((Control)button12).set_TabIndex(29);
		((Control)button12).set_Text("Sign Out");
		((ButtonBase)button12).set_UseVisualStyleBackColor(false);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button4).set_BackColor(Color.DodgerBlue);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_ForeColor(Color.LightGray);
		((Control)button4).set_Location(new Point(238, 102));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(171, 75));
		((Control)button4).set_TabIndex(28);
		((Control)button4).set_Text("Make Sale");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(445, 102));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(171, 75));
		((Control)button1).set_TabIndex(27);
		((Control)button1).set_Text("View Products");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(371, 31));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(100, 25));
		((Control)label1).set_TabIndex(26);
		((Control)label1).set_Text("Salesman");
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)button12);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)button4);
		((Control)panel1).set_Cursor(Cursors.get_Default());
		((Control)panel1).set_ForeColor(SystemColors.Control);
		((Control)panel1).set_Location(new Point(32, 60));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(852, 352));
		((Control)panel1).set_TabIndex(30);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("Salesman");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Salesman");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
