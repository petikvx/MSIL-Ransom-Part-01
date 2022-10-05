using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns7;

public class Delete_Product : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Button button3;

	private Button button1;

	private Label label4;

	private Button button2;

	private TextBox textBox3;

	private Label label3;

	private DataGridView dataGridView1;

	private Label label1;

	private ComboBox comboBox1;

	public Delete_Product()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)comboBox1).get_Text() == "ID")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val = new SqlCommand("select count(p_id) from products where p_id='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
			int num = Convert.ToInt16(((DbCommand)(object)val).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num == 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val2 = new SqlCommand("delete from products where  p_id='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
				((DbCommand)(object)val2).ExecuteNonQuery();
				MessageBox.Show("Record Deleted Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((DbConnection)(object)sqlConnection_0).Close();
				method_0();
				((TextBoxBase)textBox3).Clear();
			}
			else
			{
				MessageBox.Show("There is no such record", "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else if (((Control)comboBox1).get_Text() == "Product Name")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val3 = new SqlCommand("select count(pname) from products where pname='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
			int num2 = Convert.ToInt16(((DbCommand)(object)val3).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num2 >= 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val4 = new SqlCommand("delete from products where  pname='" + ((Control)textBox3).get_Text() + "' ", sqlConnection_0);
				((DbCommand)(object)val4).ExecuteNonQuery();
				MessageBox.Show("Record Deleted Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((DbConnection)(object)sqlConnection_0).Close();
				method_0();
				((TextBoxBase)textBox3).Clear();
			}
			else
			{
				MessageBox.Show("There is no such record", "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else
		{
			MessageBox.Show("Choose a Valid Value.", "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	public void method_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select 5 from products", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		DataTable dataTable = new DataTable();
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Delete_Product_Load(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		if (((Control)comboBox1).get_Text() == "ID")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val = new SqlCommand("select * from products where p_id like '%" + ((Control)textBox3).get_Text() + "%'", sqlConnection_0);
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
			SqlCommand val3 = new SqlCommand("select * from products where pname like '%" + ((Control)textBox3).get_Text() + "%'", sqlConnection_0);
			SqlDataAdapter val4 = new SqlDataAdapter(val3);
			DataTable dataTable2 = new DataTable();
			((DbDataAdapter)(object)val4).Fill(dataTable2);
			dataGridView1.set_DataSource((object)dataTable2);
			((DbConnection)(object)sqlConnection_0).Close();
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox3).Clear();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
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
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		button3 = new Button();
		button1 = new Button();
		label4 = new Label();
		button2 = new Button();
		textBox3 = new TextBox();
		label3 = new Label();
		dataGridView1 = new DataGridView();
		label1 = new Label();
		comboBox1 = new ComboBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button3).set_Location(new Point(125, 126));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(84, 22));
		((Control)button3).set_TabIndex(16);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button1).set_Location(new Point(215, 126));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(84, 22));
		((Control)button1).set_TabIndex(15);
		((Control)button1).set_Text("Back");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(308, 9));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(115, 20));
		((Control)label4).set_TabIndex(14);
		((Control)label4).set_Text("Delete Product");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)button2).set_Location(new Point(31, 126));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(84, 22));
		((Control)button2).set_TabIndex(13);
		((Control)button2).set_Text("Delete");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox3).set_Location(new Point(125, 84));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(121, 20));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).add_TextChanged((EventHandler)textBox3_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(44, 35));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(71, 13));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("Delete Using:");
		((Control)label3).add_Click((EventHandler)label3_Click);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(31, 164));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(689, 238));
		((Control)dataGridView1).set_TabIndex(17);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(44, 84));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(62, 13));
		((Control)label1).set_TabIndex(18);
		((Control)label1).set_Text("Enter Value");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[2] { "ID", "Product Name" });
		((Control)comboBox1).set_Location(new Point(125, 32));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 21));
		((Control)comboBox1).set_TabIndex(20);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).set_Name("Delete_Product");
		((Control)this).set_Text("Delete_Product");
		((Form)this).add_Load((EventHandler)Delete_Product_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
