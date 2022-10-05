using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns2;

public class Add_Salesman : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer dVjYpmDZm = null;

	private Label label3;

	private TextBox textBox2;

	private Button button3;

	private Button button2;

	private Label label4;

	private TextBox textBox1;

	private TextBox textBox7;

	private Label label6;

	private Label label7;

	private Label label10;

	private Button button1;

	private TextBox textBox6;

	private Label Com_Name;

	private Label label5;

	private Label label1;

	private DataGridView dataGridView1;

	private DateTimePicker dateTimePicker1;

	private Label label8;

	private Panel panel1;

	private MaskedTextBox textBox8;

	private MaskedTextBox textBox5;

	private MaskedTextBox textBox4;

	public Add_Salesman()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Add_Salesman_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void WjxObOGGcce(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
		((TextBoxBase)textBox4).Clear();
		((TextBoxBase)textBox5).Clear();
		((TextBoxBase)textBox6).Clear();
		((TextBoxBase)textBox7).Clear();
		((TextBoxBase)textBox8).Clear();
	}

	public void method_1()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select * from accounts where status='salesman'", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		DataTable dataTable = new DataTable();
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "" || ((Control)textBox2).get_Text() == "" || ((Control)textBox4).get_Text() == "" || ((Control)textBox5).get_Text() == "" || ((Control)textBox7).get_Text() == "" || ((Control)textBox8).get_Text() == "" || ((Control)textBox6).get_Text() == "")
		{
			MessageBox.Show("Please Fill all the Required Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((TextBoxBase)textBox2).Clear();
			((TextBoxBase)textBox4).Clear();
			((TextBoxBase)textBox5).Clear();
			((TextBoxBase)textBox6).Clear();
			((TextBoxBase)textBox7).Clear();
			((TextBoxBase)textBox8).Clear();
			return;
		}
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("insert into accounts (username,password,cnic#,phone#,fname,lname,salary,hiredate) values ('" + ((Control)textBox1).get_Text() + "','" + ((Control)textBox2).get_Text() + "','" + ((Control)textBox4).get_Text() + "','" + ((Control)textBox5).get_Text() + "','" + ((Control)textBox6).get_Text() + "','" + ((Control)textBox7).get_Text() + "','" + ((Control)textBox8).get_Text() + "','" + dateTimePicker1.get_Value().Date.ToString() + "')", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		((DbConnection)(object)sqlConnection_0).Close();
		MessageBox.Show("Record Inserted Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		method_1();
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
		((TextBoxBase)textBox4).Clear();
		((TextBoxBase)textBox5).Clear();
		((TextBoxBase)textBox6).Clear();
		((TextBoxBase)textBox7).Clear();
		((TextBoxBase)textBox8).Clear();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && dVjYpmDZm != null)
		{
			dVjYpmDZm.Dispose();
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected O, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected O, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected O, but got Unknown
		label3 = new Label();
		textBox2 = new TextBox();
		button3 = new Button();
		button2 = new Button();
		label4 = new Label();
		textBox1 = new TextBox();
		textBox7 = new TextBox();
		label6 = new Label();
		label7 = new Label();
		label10 = new Label();
		button1 = new Button();
		textBox6 = new TextBox();
		Com_Name = new Label();
		label5 = new Label();
		label1 = new Label();
		dataGridView1 = new DataGridView();
		dateTimePicker1 = new DateTimePicker();
		label8 = new Label();
		panel1 = new Panel();
		textBox4 = new MaskedTextBox();
		textBox5 = new MaskedTextBox();
		textBox8 = new MaskedTextBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(247, 104));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(48, 13));
		((Control)label3).set_TabIndex(84);
		((Control)label3).set_Text("Phone #");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(314, 76));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(100, 20));
		((Control)textBox2).set_TabIndex(83);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.White);
		((Control)button3).set_Location(new Point(497, 535));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(111, 36));
		((Control)button3).set_TabIndex(82);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(387, 535));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(104, 36));
		((Control)button2).set_TabIndex(81);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)WjxObOGGcce);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(54, 130));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(58, 13));
		((Control)label4).set_TabIndex(80);
		((Control)label4).set_Text("Last Name");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(122, 75));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(78);
		((Control)textBox7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox7).set_Location(new Point(122, 127));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(100, 20));
		((Control)textBox7).set_TabIndex(77);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.LightGray);
		((Control)label6).set_Location(new Point(247, 131));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(36, 13));
		((Control)label6).set_TabIndex(75);
		((Control)label6).set_Text("Salary");
		((Control)label6).add_Click((EventHandler)label6_Click);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.LightGray);
		((Control)label7).set_Location(new Point(420, 104));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(57, 13));
		((Control)label7).set_TabIndex(74);
		((Control)label7).set_Text("First Name");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.LightGray);
		((Control)label10).set_Location(new Point(70, 101));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(39, 13));
		((Control)label10).set_TabIndex(73);
		((Control)label10).set_Text("CNIC#");
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(280, 535));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(99, 36));
		((Control)button1).set_TabIndex(72);
		((Control)button1).set_Text("Add");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox6).set_Location(new Point(483, 105));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(100, 20));
		((Control)textBox6).set_TabIndex(71);
		((Control)Com_Name).set_AutoSize(true);
		((Control)Com_Name).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Com_Name).set_ForeColor(Color.LightGray);
		((Control)Com_Name).set_Location(new Point(54, 76));
		((Control)Com_Name).set_Name("Com_Name");
		((Control)Com_Name).set_Size(new Size(55, 13));
		((Control)Com_Name).set_TabIndex(68);
		((Control)Com_Name).set_Text("Username");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.LightGray);
		((Control)label5).set_Location(new Point(247, 74));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(53, 13));
		((Control)label5).set_TabIndex(67);
		((Control)label5).set_Text("Password");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(349, 32));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(113, 20));
		((Control)label1).set_TabIndex(65);
		((Control)label1).set_Text("Add Salesman");
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(64, 232));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(783, 280));
		((Control)dataGridView1).set_TabIndex(85);
		((Control)dateTimePicker1).set_Location(new Point(483, 131));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(87);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.LightGray);
		((Control)label8).set_Location(new Point(430, 134));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(47, 13));
		((Control)label8).set_TabIndex(86);
		((Control)label8).set_Text("Hiredate");
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox8);
		((Control)panel1).get_Controls().Add((Control)(object)textBox5);
		((Control)panel1).get_Controls().Add((Control)(object)textBox4);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)Com_Name);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)textBox7);
		((Control)panel1).set_Location(new Point(64, 25));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(783, 201));
		((Control)panel1).set_TabIndex(88);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)textBox4).set_Location(new Point(122, 101));
		textBox4.set_Mask("00000");
		((Control)textBox4).set_Name("textBox4");
		textBox4.set_PromptChar(' ');
		((Control)textBox4).set_Size(new Size(100, 20));
		((Control)textBox4).set_TabIndex(88);
		textBox4.set_ValidatingType(typeof(int));
		((Control)textBox5).set_Location(new Point(314, 101));
		textBox5.set_Mask("00000");
		((Control)textBox5).set_Name("textBox5");
		textBox5.set_PromptChar(' ');
		((Control)textBox5).set_Size(new Size(100, 20));
		((Control)textBox5).set_TabIndex(89);
		textBox5.set_ValidatingType(typeof(int));
		((Control)textBox8).set_Location(new Point(314, 128));
		textBox8.set_Mask("00000");
		((Control)textBox8).set_Name("textBox8");
		textBox8.set_PromptChar(' ');
		((Control)textBox8).set_Size(new Size(100, 20));
		((Control)textBox8).set_TabIndex(90);
		textBox8.set_ValidatingType(typeof(int));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Add_Salesman");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Add_Salesman");
		((Form)this).add_Load((EventHandler)Add_Salesman_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
