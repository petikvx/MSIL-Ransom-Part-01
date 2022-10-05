using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns17;

namespace ns18;

public class Search_Products : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Button button3;

	private Label label2;

	private TextBox textBox6;

	private DataGridView dataGridView1;

	private Label label1;

	private ComboBox comboBox1;

	private Label label3;

	private Button button1;

	private Panel panel1;

	public Search_Products()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Salesman salesman = new Salesman();
		((Control)salesman).Show();
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
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

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)comboBox1).get_Text() == "Product Category")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val = new SqlCommand("select * from products where category like '%" + ((Control)textBox6).get_Text() + "%'", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
			DataTable dataTable = new DataTable();
			SqlDataAdapter val2 = new SqlDataAdapter(val);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			dataGridView1.set_DataSource((object)dataTable);
			((DbConnection)(object)sqlConnection_0).Close();
		}
		else if (((Control)comboBox1).get_Text() == "Product Name")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val3 = new SqlCommand("select * from products where pname like '%" + ((Control)textBox6).get_Text() + "%'", sqlConnection_0);
			SqlDataAdapter val4 = new SqlDataAdapter(val3);
			DataTable dataTable2 = new DataTable();
			((DbDataAdapter)(object)val4).Fill(dataTable2);
			dataGridView1.set_DataSource((object)dataTable2);
			((DbConnection)(object)sqlConnection_0).Close();
		}
		else
		{
			MessageBox.Show("Choose a Valid Value.", "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void Search_Products_Load(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		button3 = new Button();
		label2 = new Label();
		textBox6 = new TextBox();
		dataGridView1 = new DataGridView();
		label1 = new Label();
		comboBox1 = new ComboBox();
		label3 = new Label();
		button1 = new Button();
		panel1 = new Panel();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(425, 136));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 28));
		((Control)button3).set_TabIndex(99);
		((Control)button3).set_Text("Back");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(61, 71));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(62, 15));
		((Control)label2).set_TabIndex(98);
		((Control)label2).set_Text("Search By");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)textBox6).set_Location(new Point(146, 104));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(158, 20));
		((Control)textBox6).set_TabIndex(97);
		((Control)textBox6).add_TextChanged((EventHandler)textBox6_TextChanged);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(59, 247));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(792, 308));
		((Control)dataGridView1).set_TabIndex(96);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(324, 14));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(157, 25));
		((Control)label1).set_TabIndex(95);
		((Control)label1).set_Text("Search Products");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[2] { "Product Name", "Product Category" });
		((Control)comboBox1).set_Location(new Point(146, 70));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(158, 21));
		((Control)comboBox1).set_TabIndex(100);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(61, 104));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(70, 15));
		((Control)label3).set_TabIndex(101);
		((Control)label3).set_Text("Enter Value");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(329, 136));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 28));
		((Control)button1).set_TabIndex(102);
		((Control)button1).set_Text("Display All");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)comboBox1);
		((Control)panel1).get_Controls().Add((Control)(object)button3);
		((Control)panel1).set_Location(new Point(59, 45));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(792, 186));
		((Control)panel1).set_TabIndex(103);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).set_ForeColor(Color.Black);
		((Control)this).set_Name("Search_Products");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Search_Products");
		((Form)this).add_Load((EventHandler)Search_Products_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
