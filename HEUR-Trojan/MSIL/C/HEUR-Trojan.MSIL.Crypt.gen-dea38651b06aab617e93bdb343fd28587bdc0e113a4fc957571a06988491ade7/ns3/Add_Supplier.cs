using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns3;

public class Add_Supplier : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Label label10;

	private Label label2;

	private Button button3;

	private Button button2;

	private TextBox textBox1;

	private Button button1;

	private TextBox textBox3;

	private Label Com_Name;

	private Label label5;

	private Label label1;

	private Label label3;

	private DateTimePicker dateTimePicker1;

	private DataGridView dataGridView1;

	private Label label4;

	private Panel panel1;

	private MaskedTextBox textBox4;

	private MaskedTextBox textBox2;

	private MaskedTextBox textBox5;

	public Add_Supplier()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Add_Supplier_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
		((TextBoxBase)textBox3).Clear();
		((TextBoxBase)textBox4).Clear();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "" || ((Control)textBox2).get_Text() == "" || ((Control)textBox4).get_Text() == "" || ((Control)textBox5).get_Text() == "" || ((Control)textBox3).get_Text() == "")
		{
			MessageBox.Show("Please Fill all the Required Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((TextBoxBase)textBox2).Clear();
			((TextBoxBase)textBox4).Clear();
			((TextBoxBase)textBox5).Clear();
			((TextBoxBase)textBox3).Clear();
			return;
		}
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("insert into suppliers (s_id,sname,phone#,city,a_id,dated) values ('" + ((Control)textBox5).get_Text() + "','" + ((Control)textBox1).get_Text() + "','" + ((Control)textBox2).get_Text() + "','" + ((Control)textBox3).get_Text() + "','" + ((Control)textBox4).get_Text() + "','" + dateTimePicker1.get_Value().Date.ToString() + "')", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		((DbConnection)(object)sqlConnection_0).Close();
		MessageBox.Show("Record Inserted Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		method_0();
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
		((TextBoxBase)textBox3).Clear();
		((TextBoxBase)textBox4).Clear();
	}

	public void method_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select * from suppliers", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		DataTable dataTable = new DataTable();
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
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
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected O, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		label10 = new Label();
		label2 = new Label();
		button3 = new Button();
		button2 = new Button();
		textBox1 = new TextBox();
		button1 = new Button();
		textBox3 = new TextBox();
		Com_Name = new Label();
		label5 = new Label();
		label1 = new Label();
		label3 = new Label();
		dateTimePicker1 = new DateTimePicker();
		dataGridView1 = new DataGridView();
		label4 = new Label();
		panel1 = new Panel();
		textBox5 = new MaskedTextBox();
		textBox2 = new MaskedTextBox();
		textBox4 = new MaskedTextBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.LightGray);
		((Control)label10).set_Location(new Point(269, 106));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(50, 13));
		((Control)label10).set_TabIndex(95);
		((Control)label10).set_Text("Admin ID");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(269, 67));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(94);
		((Control)label2).set_Text("Name");
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.White);
		((Control)button3).set_Location(new Point(511, 543));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(102, 36));
		((Control)button3).set_TabIndex(93);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(390, 543));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(102, 36));
		((Control)button2).set_TabIndex(92);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(328, 67));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(91);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(284, 543));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(93, 36));
		((Control)button1).set_TabIndex(90);
		((Control)button1).set_Text("Add");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox3).set_Location(new Point(517, 64));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(100, 20));
		((Control)textBox3).set_TabIndex(87);
		((Control)Com_Name).set_AutoSize(true);
		((Control)Com_Name).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Com_Name).set_ForeColor(Color.LightGray);
		((Control)Com_Name).set_Location(new Point(78, 109));
		((Control)Com_Name).set_Name("Com_Name");
		((Control)Com_Name).set_Size(new Size(45, 13));
		((Control)Com_Name).set_TabIndex(86);
		((Control)Com_Name).set_Text("Phone#");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.LightGray);
		((Control)label5).set_Location(new Point(465, 70));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(24, 13));
		((Control)label5).set_TabIndex(85);
		((Control)label5).set_Text("City");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(312, 21));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(100, 20));
		((Control)label1).set_TabIndex(84);
		((Control)label1).set_Text("Add Supplier");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(465, 109));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(30, 13));
		((Control)label3).set_TabIndex(96);
		((Control)label3).set_Text("Date");
		((Control)dateTimePicker1).set_Location(new Point(517, 107));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(97);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(58, 203));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(795, 300));
		((Control)dataGridView1).set_TabIndex(98);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(78, 70));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(18, 13));
		((Control)label4).set_TabIndex(99);
		((Control)label4).set_Text("ID");
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox4);
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox5);
		((Control)panel1).get_Controls().Add((Control)(object)textBox3);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)Com_Name);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_Location(new Point(58, 24));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(795, 173));
		((Control)panel1).set_TabIndex(101);
		((Control)textBox5).set_Location(new Point(137, 67));
		textBox5.set_Mask("00000");
		((Control)textBox5).set_Name("textBox5");
		textBox5.set_PromptChar(' ');
		((Control)textBox5).set_Size(new Size(100, 20));
		((Control)textBox5).set_TabIndex(101);
		textBox5.set_ValidatingType(typeof(int));
		((Control)textBox2).set_Location(new Point(137, 103));
		textBox2.set_Mask("00000");
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_PromptChar(' ');
		((Control)textBox2).set_Size(new Size(100, 20));
		((Control)textBox2).set_TabIndex(102);
		textBox2.set_ValidatingType(typeof(int));
		((Control)textBox4).set_Location(new Point(328, 102));
		textBox4.set_Mask("00000");
		((Control)textBox4).set_Name("textBox4");
		textBox4.set_PromptChar(' ');
		((Control)textBox4).set_Size(new Size(100, 20));
		((Control)textBox4).set_TabIndex(103);
		textBox4.set_ValidatingType(typeof(int));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Add_Supplier");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Add_Supplier");
		((Form)this).add_Load((EventHandler)Add_Supplier_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
