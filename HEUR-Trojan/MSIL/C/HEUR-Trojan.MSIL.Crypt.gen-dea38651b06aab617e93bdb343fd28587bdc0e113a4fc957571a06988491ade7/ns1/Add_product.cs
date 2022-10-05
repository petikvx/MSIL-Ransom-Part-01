using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns1;

public class Add_product : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Button button3;

	private Button button2;

	private Button button1;

	private Label label1;

	private DataGridView dataGridView1;

	private Panel panel1;

	private DateTimePicker dateTimePicker3;

	private DateTimePicker dateTimePicker2;

	private DateTimePicker dateTimePicker1;

	private Label label14;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label8;

	private Label label9;

	private TextBox textBox2;

	private Label label3;

	private TextBox textBox1;

	private Label label6;

	private Label label7;

	private Label label10;

	private TextBox textBox4;

	private Label Com_Name;

	private Label label5;

	private Label label2;

	private MaskedTextBox textBox3;

	private MaskedTextBox textBox8;

	private MaskedTextBox textBox7;

	private MaskedTextBox textBox5;

	private MaskedTextBox textBox11;

	private MaskedTextBox textBox10;

	private MaskedTextBox textBox9;

	private Label label4;

	public Add_product()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Add_product_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "" || ((Control)textBox2).get_Text() == "" || ((Control)textBox3).get_Text() == "" || ((Control)textBox4).get_Text() == "" || ((Control)textBox5).get_Text() == "" || ((Control)textBox7).get_Text() == "" || ((Control)textBox8).get_Text() == "" || ((Control)textBox9).get_Text() == "" || ((Control)textBox10).get_Text() == "" || ((Control)textBox11).get_Text() == "")
		{
			MessageBox.Show("Please Fill all the Required Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((TextBoxBase)textBox2).Clear();
			((TextBoxBase)textBox3).Clear();
			((TextBoxBase)textBox4).Clear();
			((TextBoxBase)textBox5).Clear();
			((TextBoxBase)textBox7).Clear();
			((TextBoxBase)textBox8).Clear();
			((TextBoxBase)textBox9).Clear();
			((TextBoxBase)textBox10).Clear();
			((TextBoxBase)textBox11).Clear();
			return;
		}
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("insert into products (pname,company,potency,category,quantity,ppackprice,punitprice,retailunitprice,s_id,a_id,dated,mfg,exp) values ('" + ((Control)textBox1).get_Text() + "','" + ((Control)textBox2).get_Text() + "','" + ((Control)textBox3).get_Text() + "','" + ((Control)textBox4).get_Text() + "','" + ((Control)textBox5).get_Text() + "','" + ((Control)textBox7).get_Text() + "','" + ((Control)textBox8).get_Text() + "','" + ((Control)textBox9).get_Text() + "','" + ((Control)textBox10).get_Text() + "','" + ((Control)textBox11).get_Text() + "','" + dateTimePicker1.get_Value().Date.ToString() + "','" + dateTimePicker2.get_Value().Date.ToString() + "','" + dateTimePicker3.get_Value().Date.ToString() + "')", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		((DbConnection)(object)sqlConnection_0).Close();
		MessageBox.Show("Record Inserted Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		method_1();
		((TextBoxBase)textBox1).Clear();
		((TextBoxBase)textBox2).Clear();
		((TextBoxBase)textBox3).Clear();
		((TextBoxBase)textBox4).Clear();
		((TextBoxBase)textBox5).Clear();
		((TextBoxBase)textBox7).Clear();
		((TextBoxBase)textBox8).Clear();
		((TextBoxBase)textBox9).Clear();
		((TextBoxBase)textBox10).Clear();
		((TextBoxBase)textBox11).Clear();
	}

	public void method_1()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select * from products", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		DataTable dataTable = new DataTable();
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
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
		((TextBoxBase)textBox5).Clear();
		((TextBoxBase)textBox7).Clear();
		((TextBoxBase)textBox8).Clear();
		((TextBoxBase)textBox9).Clear();
		((TextBoxBase)textBox10).Clear();
		((TextBoxBase)textBox11).Clear();
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void label9_Click(object sender, EventArgs e)
	{
	}

	private void textBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected O, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected O, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected O, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected O, but got Unknown
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected O, but got Unknown
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected O, but got Unknown
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0feb: Expected O, but got Unknown
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected O, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected O, but got Unknown
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected O, but got Unknown
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e0: Expected O, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected O, but got Unknown
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected O, but got Unknown
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected O, but got Unknown
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f7: Expected O, but got Unknown
		//IL_147a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1484: Expected O, but got Unknown
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		label1 = new Label();
		dataGridView1 = new DataGridView();
		panel1 = new Panel();
		label4 = new Label();
		textBox11 = new MaskedTextBox();
		textBox10 = new MaskedTextBox();
		textBox9 = new MaskedTextBox();
		textBox8 = new MaskedTextBox();
		textBox7 = new MaskedTextBox();
		textBox5 = new MaskedTextBox();
		textBox3 = new MaskedTextBox();
		dateTimePicker3 = new DateTimePicker();
		dateTimePicker2 = new DateTimePicker();
		dateTimePicker1 = new DateTimePicker();
		label14 = new Label();
		label13 = new Label();
		label12 = new Label();
		label11 = new Label();
		label8 = new Label();
		label9 = new Label();
		textBox2 = new TextBox();
		label3 = new Label();
		textBox1 = new TextBox();
		label6 = new Label();
		label7 = new Label();
		label10 = new Label();
		textBox4 = new TextBox();
		Com_Name = new Label();
		label5 = new Label();
		label2 = new Label();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.White);
		((Control)button3).set_Location(new Point(548, 552));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(102, 36));
		((Control)button3).set_TabIndex(62);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(426, 552));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(102, 36));
		((Control)button2).set_TabIndex(59);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(313, 552));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(93, 36));
		((Control)button1).set_TabIndex(44);
		((Control)button1).set_Text("Insert");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 112));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 13));
		((Control)label1).set_TabIndex(63);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(18, 263));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(870, 272));
		((Control)dataGridView1).set_TabIndex(72);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)textBox11);
		((Control)panel1).get_Controls().Add((Control)(object)textBox10);
		((Control)panel1).get_Controls().Add((Control)(object)textBox9);
		((Control)panel1).get_Controls().Add((Control)(object)textBox8);
		((Control)panel1).get_Controls().Add((Control)(object)textBox7);
		((Control)panel1).get_Controls().Add((Control)(object)textBox5);
		((Control)panel1).get_Controls().Add((Control)(object)textBox3);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker3);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker2);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label14);
		((Control)panel1).get_Controls().Add((Control)(object)label13);
		((Control)panel1).get_Controls().Add((Control)(object)label12);
		((Control)panel1).get_Controls().Add((Control)(object)label11);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)label9);
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)textBox4);
		((Control)panel1).get_Controls().Add((Control)(object)Com_Name);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_ForeColor(Color.LightGray);
		((Control)panel1).set_Location(new Point(18, 44));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(872, 203));
		((Control)panel1).set_TabIndex(73);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(381, 17));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(97, 20));
		((Control)label4).set_TabIndex(74);
		((Control)label4).set_Text("Add Product");
		((Control)textBox11).set_Location(new Point(67, 121));
		textBox11.set_Mask("00000");
		((Control)textBox11).set_Name("textBox11");
		textBox11.set_PromptChar(' ');
		((Control)textBox11).set_Size(new Size(51, 20));
		((Control)textBox11).set_TabIndex(105);
		textBox11.set_ValidatingType(typeof(int));
		((Control)textBox10).set_Location(new Point(652, 89));
		textBox10.set_Mask("00000");
		((Control)textBox10).set_Name("textBox10");
		textBox10.set_PromptChar(' ');
		((Control)textBox10).set_Size(new Size(51, 20));
		((Control)textBox10).set_TabIndex(104);
		textBox10.set_ValidatingType(typeof(int));
		((Control)textBox9).set_Location(new Point(471, 89));
		textBox9.set_Mask("00000");
		((Control)textBox9).set_Name("textBox9");
		textBox9.set_PromptChar(' ');
		((Control)textBox9).set_Size(new Size(100, 20));
		((Control)textBox9).set_TabIndex(103);
		textBox9.set_ValidatingType(typeof(int));
		((Control)textBox8).set_Location(new Point(267, 89));
		textBox8.set_Mask("00000");
		((Control)textBox8).set_Name("textBox8");
		textBox8.set_PromptChar(' ');
		((Control)textBox8).set_Size(new Size(100, 20));
		((Control)textBox8).set_TabIndex(102);
		textBox8.set_ValidatingType(typeof(int));
		((Control)textBox7).set_Location(new Point(67, 88));
		textBox7.set_Mask("00000");
		((Control)textBox7).set_Name("textBox7");
		textBox7.set_PromptChar(' ');
		((Control)textBox7).set_Size(new Size(100, 20));
		((Control)textBox7).set_TabIndex(101);
		textBox7.set_ValidatingType(typeof(int));
		((Control)textBox5).set_Location(new Point(758, 50));
		textBox5.set_Mask("00000");
		((Control)textBox5).set_Name("textBox5");
		textBox5.set_PromptChar(' ');
		((Control)textBox5).set_Size(new Size(100, 20));
		((Control)textBox5).set_TabIndex(100);
		textBox5.set_ValidatingType(typeof(int));
		textBox5.add_MaskInputRejected(new MaskInputRejectedEventHandler(textBox5_MaskInputRejected));
		((Control)textBox3).set_Location(new Point(442, 54));
		textBox3.set_Mask("00000");
		((Control)textBox3).set_Name("textBox3");
		textBox3.set_PromptChar(' ');
		((Control)textBox3).set_Size(new Size(100, 20));
		((Control)textBox3).set_TabIndex(99);
		textBox3.set_ValidatingType(typeof(int));
		((Control)dateTimePicker3).set_Location(new Point(67, 160));
		((Control)dateTimePicker3).set_Name("dateTimePicker3");
		((Control)dateTimePicker3).set_Size(new Size(200, 20));
		((Control)dateTimePicker3).set_TabIndex(98);
		((Control)dateTimePicker2).set_Location(new Point(440, 124));
		((Control)dateTimePicker2).set_Name("dateTimePicker2");
		((Control)dateTimePicker2).set_Size(new Size(200, 20));
		((Control)dateTimePicker2).set_TabIndex(97);
		((Control)dateTimePicker1).set_Location(new Point(167, 124));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(96);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_ForeColor(Color.LightGray);
		((Control)label14).set_Location(new Point(590, 93));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(56, 13));
		((Control)label14).set_TabIndex(94);
		((Control)label14).set_Text("Supplier id");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_ForeColor(Color.LightGray);
		((Control)label13).set_Location(new Point(1, 124));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(47, 13));
		((Control)label13).set_TabIndex(92);
		((Control)label13).set_Text("Admin id");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.LightGray);
		((Control)label12).set_Location(new Point(382, 91));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(83, 13));
		((Control)label12).set_TabIndex(91);
		((Control)label12).set_Text("Retail Unit Price");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.LightGray);
		((Control)label11).set_Location(new Point(548, 57));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(49, 13));
		((Control)label11).set_TabIndex(89);
		((Control)label11).set_Text("Category");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.LightGray);
		((Control)label8).set_Location(new Point(131, 127));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(30, 13));
		((Control)label8).set_TabIndex(88);
		((Control)label8).set_Text("Date");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.LightGray);
		((Control)label9).set_Location(new Point(716, 53));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(46, 13));
		((Control)label9).set_TabIndex(86);
		((Control)label9).set_Text("Quantity");
		((Control)label9).add_Click((EventHandler)label9_Click);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(267, 57));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(100, 20));
		((Control)textBox2).set_TabIndex(85);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(382, 57));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(46, 13));
		((Control)label3).set_TabIndex(84);
		((Control)label3).set_Text("Potency");
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(67, 57));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(83);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.LightGray);
		((Control)label6).set_Location(new Point(382, 126));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(51, 13));
		((Control)label6).set_TabIndex(81);
		((Control)label6).set_Text("Mfg Date");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.LightGray);
		((Control)label7).set_Location(new Point(1, 160));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(51, 13));
		((Control)label7).set_TabIndex(80);
		((Control)label7).set_Text("Exp Date");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.LightGray);
		((Control)label10).set_Location(new Point(173, 92));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(100, 13));
		((Control)label10).set_TabIndex(79);
		((Control)label10).set_Text("Purchase Unit price");
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_Location(new Point(603, 54));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(100, 20));
		((Control)textBox4).set_TabIndex(77);
		((Control)Com_Name).set_AutoSize(true);
		((Control)Com_Name).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Com_Name).set_ForeColor(Color.LightGray);
		((Control)Com_Name).set_Location(new Point(172, 57));
		((Control)Com_Name).set_Name("Com_Name");
		((Control)Com_Name).set_Size(new Size(51, 13));
		((Control)Com_Name).set_TabIndex(76);
		((Control)Com_Name).set_Text("Company");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.LightGray);
		((Control)label5).set_Location(new Point(2, 92));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(59, 13));
		((Control)label5).set_TabIndex(75);
		((Control)label5).set_Text("Pack Price");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(1, 57));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(74);
		((Control)label2).set_Text("Name");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Add_product");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Add_product");
		((Form)this).add_Load((EventHandler)Add_product_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
