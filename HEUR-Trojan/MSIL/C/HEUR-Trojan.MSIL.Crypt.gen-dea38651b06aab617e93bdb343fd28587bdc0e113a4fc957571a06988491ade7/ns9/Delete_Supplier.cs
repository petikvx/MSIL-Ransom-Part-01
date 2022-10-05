using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns9;

public class Delete_Supplier : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Label label4;

	private ComboBox comboBox1;

	private Label label1;

	private DataGridView dataGridView1;

	private Button button3;

	private Button button1;

	private Button button2;

	private TextBox textBox3;

	private Label label3;

	public Delete_Supplier()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
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
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)comboBox1).get_Text() == "ID")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val = new SqlCommand("select count(id) from suppliers where id='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
			int num = Convert.ToInt16(((DbCommand)(object)val).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num == 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val2 = new SqlCommand("delete from suppliers where  id='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
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
		else if (((Control)comboBox1).get_Text() == "Name")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val3 = new SqlCommand("select count(sname) from suppliers where sname='" + ((Control)textBox3).get_Text() + "'", sqlConnection_0);
			int num2 = Convert.ToInt16(((DbCommand)(object)val3).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num2 == 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val4 = new SqlCommand("delete from suppliers where  sname='" + ((Control)textBox3).get_Text() + "' ", sqlConnection_0);
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
		SqlCommand val = new SqlCommand("select * from suppliers", sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
		DataTable dataTable = new DataTable();
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void Delete_Supplier_Load(object sender, EventArgs e)
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
			SqlCommand val = new SqlCommand("select * from suppliers where id like '%" + ((Control)textBox3).get_Text() + "%'", sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
			DataTable dataTable = new DataTable();
			SqlDataAdapter val2 = new SqlDataAdapter(val);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			dataGridView1.set_DataSource((object)dataTable);
			((DbConnection)(object)sqlConnection_0).Close();
		}
		else if (((Control)comboBox1).get_Text() == "Name")
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val3 = new SqlCommand("select * from suppliers where sname like '%" + ((Control)textBox3).get_Text() + "%'", sqlConnection_0);
			SqlDataAdapter val4 = new SqlDataAdapter(val3);
			DataTable dataTable2 = new DataTable();
			((DbDataAdapter)(object)val4).Fill(dataTable2);
			dataGridView1.set_DataSource((object)dataTable2);
			((DbConnection)(object)sqlConnection_0).Close();
		}
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
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		label4 = new Label();
		comboBox1 = new ComboBox();
		label1 = new Label();
		dataGridView1 = new DataGridView();
		button3 = new Button();
		button1 = new Button();
		button2 = new Button();
		textBox3 = new TextBox();
		label3 = new Label();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(311, 26));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(118, 20));
		((Control)label4).set_TabIndex(26);
		((Control)label4).set_Text("Delete Supplier");
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[2] { "ID", "Name" });
		((Control)comboBox1).set_Location(new Point(135, 69));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 21));
		((Control)comboBox1).set_TabIndex(34);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(54, 121));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(62, 13));
		((Control)label1).set_TabIndex(33);
		((Control)label1).set_Text("Enter Value");
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(41, 201));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(689, 238));
		((Control)dataGridView1).set_TabIndex(32);
		((Control)button3).set_Location(new Point(135, 163));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(84, 22));
		((Control)button3).set_TabIndex(31);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button1).set_Location(new Point(225, 163));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(84, 22));
		((Control)button1).set_TabIndex(30);
		((Control)button1).set_Text("Back");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(41, 163));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(84, 22));
		((Control)button2).set_TabIndex(29);
		((Control)button2).set_Text("Delete");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox3).set_Location(new Point(135, 121));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(121, 20));
		((Control)textBox3).set_TabIndex(28);
		((Control)textBox3).add_TextChanged((EventHandler)textBox3_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(54, 72));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(71, 13));
		((Control)label3).set_TabIndex(27);
		((Control)label3).set_Text("Delete Using:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).set_Name("Delete_Supplier");
		((Control)this).set_Text("Delete_Supplier");
		((Form)this).add_Load((EventHandler)Delete_Supplier_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
