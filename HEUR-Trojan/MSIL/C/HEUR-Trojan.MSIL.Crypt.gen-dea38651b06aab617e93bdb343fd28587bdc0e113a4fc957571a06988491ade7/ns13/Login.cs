using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns17;
using ns4;

namespace ns13;

public class Login : Form
{
	private IContainer icontainer_0 = null;

	private Panel panel1;

	private Button button3;

	private Button button2;

	private Button button1;

	private TextBox textBox2;

	private TextBox textBox1;

	private Label label2;

	private Label label1;

	private Label label3;

	public Login()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "" || ((Control)textBox2).get_Text() == "")
		{
			MessageBox.Show("Please Enter valid Username and Password", "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		SqlConnection val = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");
		SqlCommand val2 = new SqlCommand("select status from accounts where username='" + ((Control)textBox1).get_Text() + "' and password='" + ((Control)textBox2).get_Text() + "'", val);
		((DbConnection)(object)val).Open();
		string text = Convert.ToString(((DbCommand)(object)val2).ExecuteScalar());
		if (text == "admin")
		{
			Admin admin = new Admin();
			((Control)admin).Show();
			((Form)this).Close();
		}
		else if (text == "salesman")
		{
			Salesman salesman = new Salesman();
			((Control)salesman).Show();
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Invalid Username or Password", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((TextBoxBase)textBox2).Clear();
		}
		((DbConnection)(object)val).Close();
	}

	private void method_0(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			button1.PerformClick();
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Login_Activated(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void Login_Load(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		panel1 = new Panel();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		label2 = new Label();
		label1 = new Label();
		label3 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)button3);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(78, 70));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(404, 206));
		((Control)panel1).set_TabIndex(8);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_Location(new Point(255, 157));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(79, 29));
		((Control)button3).set_TabIndex(15);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_Location(new Point(174, 157));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(79, 29));
		((Control)button2).set_TabIndex(14);
		((Control)button2).set_Text("Cancel");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Location(new Point(90, 157));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(79, 29));
		((Control)button1).set_TabIndex(13);
		((Control)button1).set_Text("Log In");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(90, 109));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(203, 29));
		((Control)textBox2).set_TabIndex(12);
		textBox2.set_UseSystemPasswordChar(true);
		textBox1.set_AcceptsReturn(true);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Black);
		((Control)textBox1).set_Location(new Point(90, 48));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(203, 29));
		((Control)textBox1).set_TabIndex(11);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(87, 89));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(69, 17));
		((Control)label2).set_TabIndex(9);
		((Control)label2).set_Text("Password");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(87, 28));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(73, 17));
		((Control)label1).set_TabIndex(8);
		((Control)label1).set_Text("Username");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial Rounded MT Bold", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(229, 19));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(102, 32));
		((Control)label3).set_TabIndex(10);
		((Control)label3).set_Text("LOGIN");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(569, 322));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Login");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Login");
		((Form)this).add_Activated((EventHandler)Login_Activated);
		((Form)this).add_Load((EventHandler)Login_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
