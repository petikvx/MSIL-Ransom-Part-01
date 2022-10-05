using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns17;

namespace ns14;

public class Make_Sale : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private int int_0;

	private IContainer icontainer_0 = null;

	private Label label1;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private Label label2;

	private TextBox textBox1;

	private TextBox LwyknVTZTI;

	private Label Com_Name;

	private Label label5;

	private DateTimePicker dateTimePicker1;

	private DataGridView dataGridView1;

	private Label label3;

	private DataGridView dataGridView2;

	private Label LmbnMQvie;

	private Label label6;

	private TextBox textBox5;

	private Label label7;

	private Label label8;

	private Button button5;

	private TextBox textBox7;

	private Label label9;

	private Label label10;

	private Panel panel1;

	private MaskedTextBox textBox8;

	private MaskedTextBox textBox3;

	private MaskedTextBox textBox2;

	private MaskedTextBox textBox6;

	public Make_Sale()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	public void GblkEGQatZ()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select count(id) from order_details", sqlConnection_0);
		int_0 = Convert.ToInt16(((DbCommand)(object)val).ExecuteScalar());
		((DbConnection)(object)sqlConnection_0).Close();
		((Control)textBox5).set_Text(int_0.ToString() ?? "");
	}

	private void Make_Sale_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		GblkEGQatZ();
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand();
		SqlDataAdapter val2 = new SqlDataAdapter();
		DataTable dataTable = new DataTable();
		val.set_Connection(sqlConnection_0);
		((DbCommand)(object)val).CommandText = "select p_id,pname,potency,quantity,retailunitprice as 'unit price',mfg,exp from products";
		val2.set_SelectCommand(val);
		dataTable.Clear();
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Salesman salesman = new Salesman();
		((Control)salesman).Show();
		((Form)this).Close();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select p_id, pname,potency,quantity,retailunitprice as 'unit price',mfg,exp from products where pname like '%" + ((Control)textBox1).get_Text() + "%'", sqlConnection_0);
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)sqlConnection_0).Open();
		if (((Control)textBox6).get_Text() == "")
		{
			MessageBox.Show("Enter a Valid Product ID.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((DbConnection)(object)sqlConnection_0).Close();
			return;
		}
		SqlCommand val = new SqlCommand("select quantity from products where p_id='" + ((Control)textBox6).get_Text() + "'", sqlConnection_0);
		int num = Convert.ToInt16(((DbCommand)(object)val).ExecuteScalar());
		if (num >= Convert.ToInt16(((Control)textBox2).get_Text()) && num != 0)
		{
			SqlCommand val2 = new SqlCommand("select retailunitprice from products where p_id='" + ((Control)textBox6).get_Text() + "'", sqlConnection_0);
			double num2 = Convert.ToDouble(((DbCommand)(object)val2).ExecuteScalar());
			num2 *= Convert.ToDouble(((Control)textBox2).get_Text());
			double num3 = num2 / 100.0 * Convert.ToDouble(((Control)textBox3).get_Text());
			((Control)textBox7).set_Text(Convert.ToString(Convert.ToDouble(((Control)textBox7).get_Text()) + (num2 - num3)));
			SqlCommand val3 = new SqlCommand("insert into sub_order (p_id,o_id,quantity,discount,price) values ( '" + ((Control)textBox6).get_Text() + "','" + int_0 + "','" + ((Control)textBox2).get_Text() + "','" + ((Control)textBox3).get_Text() + "','" + (num2 - num3) + "')", sqlConnection_0);
			((DbCommand)(object)val3).ExecuteNonQuery();
			val2 = new SqlCommand("select p.pname as 'product name',s.quantity,s.discount,s.price from products p,sub_order s where s.p_id=p.p_id and o_id='" + int_0 + "'", sqlConnection_0);
			SqlDataAdapter val4 = new SqlDataAdapter(val2);
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Sr #");
			dataTable.Columns["Sr #"]!.AutoIncrement = true;
			dataTable.Columns["Sr #"]!.AutoIncrementSeed = 1L;
			((DbDataAdapter)(object)val4).Fill(dataTable);
			dataGridView2.set_DataSource((object)dataTable);
			((DbConnection)(object)sqlConnection_0).Close();
			((TextBoxBase)textBox1).Clear();
			((Control)textBox2).set_Text(0.ToString() ?? "");
			((Control)textBox3).set_Text(0.ToString() ?? "");
			((TextBoxBase)textBox6).Clear();
		}
		else if (num == 0)
		{
			((DbConnection)(object)sqlConnection_0).Close();
			MessageBox.Show("Product is out of Stock!", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((Control)textBox2).set_Text(0.ToString() ?? "");
			((Control)textBox3).set_Text(0.ToString() ?? "");
			((TextBoxBase)textBox6).Clear();
		}
		else
		{
			((DbConnection)(object)sqlConnection_0).Close();
			MessageBox.Show("Enter Valid Quantity!", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((TextBoxBase)textBox1).Clear();
			((Control)textBox2).set_Text(0.ToString() ?? "");
			((Control)textBox3).set_Text(0.ToString() ?? "");
			((TextBoxBase)textBox6).Clear();
		}
	}

	private void LmbnMQvie_Click(object sender, EventArgs e)
	{
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand();
		SqlDataAdapter val2 = new SqlDataAdapter();
		DataTable dataTable = new DataTable();
		val.set_Connection(sqlConnection_0);
		((DbCommand)(object)val).CommandText = "select p_id,pname,potency,quantity,retailunitprice as 'unit price',mfg,exp from products";
		val2.set_SelectCommand(val);
		dataTable.Clear();
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		if (dataGridView2.get_DataSource() != null)
		{
			SqlCommand val = new SqlCommand("delete from sub_order where o_id='" + int_0 + "'", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
		}
		dataGridView2.set_DataSource((object)null);
		((Control)textBox7).set_Text(0.ToString() ?? "");
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		if (dataGridView2.get_DataSource() != null)
		{
			((DbConnection)(object)sqlConnection_0).Open();
			dataGridView2.set_DataSource((object)null);
			MessageBox.Show("Sale Successful.", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			SqlCommand val = new SqlCommand("update order_details set id='" + int_0 + "', dated='" + dateTimePicker1.get_Value().Date.ToString() + "', quantity= (select sum(quantity) from sub_order where o_id='" + int_0 + "'), customer='" + ((Control)LwyknVTZTI).get_Text() + "', gross_amount=(select sum(price) from sub_order where o_id='" + int_0 + "'),sal_id='" + ((Control)textBox8).get_Text() + "'  where order_details.id='" + int_0 + "'", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
			val = new SqlCommand("update products set products.quantity=(products.quantity-sub_order.quantity) from products,sub_order where products.p_id=sub_order.p_id and sub_order.o_id='" + int_0 + "'", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
			val = new SqlCommand("insert into order_details (id) values('" + (int_0 + 1) + "')", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
			((DbConnection)(object)sqlConnection_0).Close();
			GblkEGQatZ();
			((Control)textBox7).set_Text(0.ToString() ?? "");
			((TextBoxBase)LwyknVTZTI).Clear();
		}
		else
		{
			MessageBox.Show("Invoice is Empty", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void textBox7_TextChanged(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void label10_Click(object sender, EventArgs e)
	{
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected O, but got Unknown
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected O, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected O, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected O, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected O, but got Unknown
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Expected O, but got Unknown
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected O, but got Unknown
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		label1 = new Label();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		label2 = new Label();
		textBox1 = new TextBox();
		LwyknVTZTI = new TextBox();
		Com_Name = new Label();
		label5 = new Label();
		dateTimePicker1 = new DateTimePicker();
		dataGridView1 = new DataGridView();
		label3 = new Label();
		dataGridView2 = new DataGridView();
		LmbnMQvie = new Label();
		label6 = new Label();
		textBox5 = new TextBox();
		label7 = new Label();
		label8 = new Label();
		button5 = new Button();
		textBox7 = new TextBox();
		label9 = new Label();
		label10 = new Label();
		panel1 = new Panel();
		textBox8 = new MaskedTextBox();
		textBox3 = new MaskedTextBox();
		textBox2 = new MaskedTextBox();
		textBox6 = new MaskedTextBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((ISupportInitialize)dataGridView2).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_Hand());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(418, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(106, 25));
		((Control)label1).set_TabIndex(107);
		((Control)label1).set_Text("Make Sale");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)button4).set_BackColor(Color.DodgerBlue);
		((Control)button4).set_ForeColor(Color.LightGray);
		((Control)button4).set_Location(new Point(483, 533));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 34));
		((Control)button4).set_TabIndex(106);
		((Control)button4).set_Text("Print Receipt");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(591, 533));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 34));
		((Control)button3).set_TabIndex(105);
		((Control)button3).set_Text("Back");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(479, 114));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 34));
		((Control)button2).set_TabIndex(104);
		((Control)button2).set_Text("Refresh");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(388, 114));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 34));
		((Control)button1).set_TabIndex(103);
		((Control)button1).set_Text("Add");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(3, 77));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(75, 13));
		((Control)label2).set_TabIndex(102);
		((Control)label2).set_Text("Product Name");
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(82, 74));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(101);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)LwyknVTZTI).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LwyknVTZTI).set_Location(new Point(785, 72));
		((Control)LwyknVTZTI).set_Name("textBox4");
		((Control)LwyknVTZTI).set_Size(new Size(100, 20));
		((Control)LwyknVTZTI).set_TabIndex(99);
		((Control)Com_Name).set_AutoSize(true);
		((Control)Com_Name).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Com_Name).set_ForeColor(Color.LightGray);
		((Control)Com_Name).set_Location(new Point(385, 75));
		((Control)Com_Name).set_Name("Com_Name");
		((Control)Com_Name).set_Size(new Size(46, 13));
		((Control)Com_Name).set_TabIndex(98);
		((Control)Com_Name).set_Text("Quantity");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.LightGray);
		((Control)label5).set_Location(new Point(554, 75));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(57, 13));
		((Control)label5).set_TabIndex(97);
		((Control)label5).set_Text("Discount%");
		((Control)dateTimePicker1).set_Location(new Point(577, 30));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(96);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		dataGridView1.set_ColumnHeadersDefaultCellStyle(val);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(Color.Black);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.HighlightText);
		val2.set_WrapMode((DataGridViewTriState)2);
		dataGridView1.set_DefaultCellStyle(val2);
		((Control)dataGridView1).set_Location(new Point(9, 220));
		((Control)dataGridView1).set_Name("dataGridView1");
		dataGridView1.set_ReadOnly(true);
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Control);
		val3.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		dataGridView1.set_RowHeadersDefaultCellStyle(val3);
		((Control)dataGridView1).set_Size(new Size(456, 291));
		((Control)dataGridView1).set_TabIndex(108);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(726, 75));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(51, 13));
		((Control)label3).set_TabIndex(109);
		((Control)label3).set_Text("Customer");
		val4.set_Alignment((DataGridViewContentAlignment)16);
		val4.set_BackColor(SystemColors.Control);
		val4.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val4.set_ForeColor(SystemColors.WindowText);
		val4.set_SelectionBackColor(SystemColors.Highlight);
		val4.set_SelectionForeColor(SystemColors.HighlightText);
		val4.set_WrapMode((DataGridViewTriState)1);
		dataGridView2.set_ColumnHeadersDefaultCellStyle(val4);
		dataGridView2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		val5.set_Alignment((DataGridViewContentAlignment)16);
		val5.set_BackColor(SystemColors.Window);
		val5.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val5.set_ForeColor(Color.Black);
		val5.set_SelectionBackColor(SystemColors.Highlight);
		val5.set_SelectionForeColor(SystemColors.HighlightText);
		val5.set_WrapMode((DataGridViewTriState)2);
		dataGridView2.set_DefaultCellStyle(val5);
		((Control)dataGridView2).set_Location(new Point(488, 220));
		((Control)dataGridView2).set_Name("dataGridView2");
		dataGridView2.set_ReadOnly(true);
		val6.set_Alignment((DataGridViewContentAlignment)16);
		val6.set_BackColor(SystemColors.Control);
		val6.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val6.set_ForeColor(SystemColors.WindowText);
		val6.set_SelectionBackColor(SystemColors.Highlight);
		val6.set_SelectionForeColor(SystemColors.HighlightText);
		val6.set_WrapMode((DataGridViewTriState)1);
		dataGridView2.set_RowHeadersDefaultCellStyle(val6);
		((Control)dataGridView2).set_Size(new Size(412, 291));
		((Control)dataGridView2).set_TabIndex(111);
		dataGridView2.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView2_CellContentClick));
		((Control)LmbnMQvie).set_AutoSize(true);
		((Control)LmbnMQvie).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LmbnMQvie).set_ForeColor(Color.LightGray);
		((Control)LmbnMQvie).set_Location(new Point(97, 197));
		((Control)LmbnMQvie).set_Name("label4");
		((Control)LmbnMQvie).set_Size(new Size(50, 20));
		((Control)LmbnMQvie).set_TabIndex(112);
		((Control)LmbnMQvie).set_Text("Stock");
		((Control)LmbnMQvie).add_Click((EventHandler)LmbnMQvie_Click);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.LightGray);
		((Control)label6).set_Location(new Point(592, 197));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(59, 20));
		((Control)label6).set_TabIndex(113);
		((Control)label6).set_Text("Invoice");
		((Control)textBox5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_Location(new Point(82, 34));
		((Control)textBox5).set_Name("textBox5");
		((TextBoxBase)textBox5).set_ReadOnly(true);
		((Control)textBox5).set_Size(new Size(100, 20));
		((Control)textBox5).set_TabIndex(115);
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.LightGray);
		((Control)label7).set_Location(new Point(12, 37));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(56, 13));
		((Control)label7).set_TabIndex(114);
		((Control)label7).set_Text("Invoice ID");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.LightGray);
		((Control)label8).set_Location(new Point(198, 77));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(58, 13));
		((Control)label8).set_TabIndex(117);
		((Control)label8).set_Text("Product ID");
		((Control)button5).set_BackColor(Color.DodgerBlue);
		((Control)button5).set_ForeColor(Color.LightGray);
		((Control)button5).set_Location(new Point(385, 533));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 34));
		((Control)button5).set_TabIndex(118);
		((Control)button5).set_Text("Clear Invoice");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)textBox7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox7).set_Location(new Point(785, 114));
		((Control)textBox7).set_Name("textBox7");
		((TextBoxBase)textBox7).set_ReadOnly(true);
		((Control)textBox7).set_Size(new Size(100, 20));
		((Control)textBox7).set_TabIndex(119);
		((Control)textBox7).set_Text("0");
		((Control)textBox7).add_TextChanged((EventHandler)textBox7_TextChanged);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.LightGray);
		((Control)label9).set_Location(new Point(716, 114));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(63, 13));
		((Control)label9).set_TabIndex(120);
		((Control)label9).set_Text("Net Amount");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.LightGray);
		((Control)label10).set_Location(new Point(3, 117));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(67, 13));
		((Control)label10).set_TabIndex(122);
		((Control)label10).set_Text("Salesman ID");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox8);
		((Control)panel1).get_Controls().Add((Control)(object)textBox3);
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label9);
		((Control)panel1).get_Controls().Add((Control)(object)Com_Name);
		((Control)panel1).get_Controls().Add((Control)(object)textBox7);
		((Control)panel1).get_Controls().Add((Control)(object)LwyknVTZTI);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox5);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).set_Location(new Point(9, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(891, 169));
		((Control)panel1).set_TabIndex(123);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)textBox8).set_Location(new Point(82, 111));
		textBox8.set_Mask("00000");
		((Control)textBox8).set_Name("textBox8");
		textBox8.set_PromptChar(' ');
		((Control)textBox8).set_Size(new Size(100, 20));
		((Control)textBox8).set_TabIndex(126);
		textBox8.set_ValidatingType(typeof(int));
		((Control)textBox3).set_Location(new Point(617, 70));
		textBox3.set_Mask("00000");
		((Control)textBox3).set_Name("textBox3");
		textBox3.set_PromptChar(' ');
		((Control)textBox3).set_Size(new Size(100, 20));
		((Control)textBox3).set_TabIndex(125);
		((Control)textBox3).set_Text("0");
		textBox3.set_ValidatingType(typeof(int));
		((Control)textBox2).set_Location(new Point(437, 72));
		textBox2.set_Mask("00000");
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_PromptChar(' ');
		((Control)textBox2).set_Size(new Size(100, 20));
		((Control)textBox2).set_TabIndex(124);
		((Control)textBox2).set_Text("0");
		textBox2.set_ValidatingType(typeof(int));
		((Control)textBox6).set_Location(new Point(262, 72));
		textBox6.set_Mask("00000");
		((Control)textBox6).set_Name("textBox6");
		textBox6.set_PromptChar(' ');
		((Control)textBox6).set_Size(new Size(100, 20));
		((Control)textBox6).set_TabIndex(123);
		textBox6.set_ValidatingType(typeof(int));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)LmbnMQvie);
		((Control)this).get_Controls().Add((Control)(object)dataGridView2);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).set_ForeColor(Color.Black);
		((Control)this).set_Name("Make_Sale");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Make_Sale");
		((Form)this).add_Load((EventHandler)Make_Sale_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((ISupportInitialize)dataGridView2).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
