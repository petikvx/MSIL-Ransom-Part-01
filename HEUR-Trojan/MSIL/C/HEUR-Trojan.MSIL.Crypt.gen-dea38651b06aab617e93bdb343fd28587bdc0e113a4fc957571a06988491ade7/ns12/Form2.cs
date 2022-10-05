using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns12;

public class Form2 : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private DataGridView dataGridView1;

	private Label label1;

	private DateTimePicker dateTimePicker1;

	private DateTimePicker dateTimePicker2;

	private Label label4;

	private Label label2;

	private Button button1;

	private Button button2;

	private Label label3;

	private TextBox textBox1;

	private Button button3;

	private Panel panel1;

	public Form2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select p.p_id,p.pname,sum(s.quantity) quantity,sum(s.price) as 'gross sale',o.dated as date from products p, sub_order s ,order_details o  where p.pname='" + ((Control)textBox1).get_Text() + "' and s.p_id=p.p_id and s.o_id=o.id and (o.dated >='" + dateTimePicker1.get_Value().Date.ToString() + "' and o.dated <='" + dateTimePicker2.get_Value().Date.ToString() + "') group by p.p_id,o.dated,p.pname,s.price,s.quantity order by o.dated,s.price desc", sqlConnection_0);
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Sr #");
		dataTable.Columns["Sr #"]!.AutoIncrement = true;
		dataTable.Columns["Sr #"]!.AutoIncrementSeed = 1L;
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select p.p_id,p.pname,sum(s.quantity) quantity,sum(s.price) as 'gross sale',o.dated as date from products p, sub_order s ,order_details o  where s.p_id=p.p_id and o.id=s.o_id and (o.dated >='" + dateTimePicker1.get_Value().Date.ToString() + "' and o.dated <='" + dateTimePicker2.get_Value().Date.ToString() + "') group by p.p_id, p.pname,p.potency,s.price,o.dated order by o.dated,s.price desc", sqlConnection_0);
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Sr #");
		dataTable.Columns["Sr #"]!.AutoIncrement = true;
		dataTable.Columns["Sr #"]!.AutoIncrementSeed = 1L;
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
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
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected O, but got Unknown
		dataGridView1 = new DataGridView();
		label1 = new Label();
		dateTimePicker1 = new DateTimePicker();
		dateTimePicker2 = new DateTimePicker();
		label4 = new Label();
		label2 = new Label();
		button1 = new Button();
		button2 = new Button();
		label3 = new Label();
		textBox1 = new TextBox();
		button3 = new Button();
		panel1 = new Panel();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(37, 254));
		((Control)dataGridView1).set_Name("dataGridView1");
		dataGridView1.set_ReadOnly(true);
		((Control)dataGridView1).set_Size(new Size(837, 293));
		((Control)dataGridView1).set_TabIndex(109);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(335, 19));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(155, 25));
		((Control)label1).set_TabIndex(111);
		((Control)label1).set_Text("Generate Report");
		((Control)dateTimePicker1).set_Location(new Point(131, 78));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(110);
		((Control)dateTimePicker2).set_Location(new Point(506, 78));
		((Control)dateTimePicker2).set_Name("dateTimePicker2");
		((Control)dateTimePicker2).set_Size(new Size(200, 20));
		((Control)dateTimePicker2).set_TabIndex(112);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(448, 78));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(27, 20));
		((Control)label4).set_TabIndex(113);
		((Control)label4).set_Text("To");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(57, 78));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(46, 20));
		((Control)label2).set_TabIndex(114);
		((Control)label2).set_Text("From");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(369, 123));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 34));
		((Control)button1).set_TabIndex(115);
		((Control)button1).set_Text("Generate");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(465, 123));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 34));
		((Control)button2).set_TabIndex(116);
		((Control)button2).set_Text("Display All");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(128, 134));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(75, 13));
		((Control)label3).set_TabIndex(118);
		((Control)label3).set_Text("Product Name");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.WindowText);
		((Control)textBox1).set_Location(new Point(207, 131));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(117);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(559, 123));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 34));
		((Control)button3).set_TabIndex(119);
		((Control)button3).set_Text("Back");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)button3);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).set_ForeColor(Color.LightGray);
		((Control)panel1).set_Location(new Point(37, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(837, 225));
		((Control)panel1).set_TabIndex(120);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
