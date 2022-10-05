using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns8;

public class Delete_Salesman : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Button button3;

	private Button button1;

	private Label label4;

	private Button button2;

	private TextBox textBox3;

	private Label label3;

	private ComboBox comboBox1;

	private Label label1;

	private DataGridView dataGridView1;

	private Button button4;

	private Button button5;

	private Button button6;

	private TextBox textBox1;

	private Label label5;

	public Delete_Salesman()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void button6_Click(object sender, EventArgs e)
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
			SqlCommand val = new SqlCommand("select count(id) from accounts where id='" + ((Control)textBox1).get_Text() + "'", sqlConnection_0);
			int num = Convert.ToInt16(((DbCommand)(object)val).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num == 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val2 = new SqlCommand("delete from accounts where  id='" + ((Control)textBox1).get_Text() + "'", sqlConnection_0);
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
			SqlCommand val3 = new SqlCommand("select count(fname) from accounts where fname='" + ((Control)textBox1).get_Text() + "'", sqlConnection_0);
			int num2 = Convert.ToInt16(((DbCommand)(object)val3).ExecuteScalar());
			((DbConnection)(object)sqlConnection_0).Close();
			if (num2 == 1)
			{
				((DbConnection)(object)sqlConnection_0).Open();
				SqlCommand val4 = new SqlCommand("delete from accounts where  fname='" + ((Control)textBox1).get_Text() + "' ", sqlConnection_0);
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

	private void button4_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox1).Clear();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	public void method_0()
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

	private void Delete_Salesman_Load(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
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
			SqlCommand val = new SqlCommand("select * from accounts where status='salesman' and id like '%" + ((Control)textBox1).get_Text() + "%'", sqlConnection_0);
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
			SqlCommand val3 = new SqlCommand("select * from accounts where status='salesman' and fname like '%" + ((Control)textBox1).get_Text() + "%'", sqlConnection_0);
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
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		button3 = new Button();
		button1 = new Button();
		label4 = new Label();
		button2 = new Button();
		textBox3 = new TextBox();
		label3 = new Label();
		comboBox1 = new ComboBox();
		label1 = new Label();
		dataGridView1 = new DataGridView();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		textBox1 = new TextBox();
		label5 = new Label();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button3).set_Location(new Point(369, 298));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(84, 22));
		((Control)button3).set_TabIndex(22);
		((Control)button3).set_Text("Reset");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Location(new Point(478, 298));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(84, 22));
		((Control)button1).set_TabIndex(21);
		((Control)button1).set_Text("Back");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(322, 20));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(131, 20));
		((Control)label4).set_TabIndex(20);
		((Control)label4).set_Text("Delete Salesman");
		((Control)button2).set_Location(new Point(275, 298));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(84, 22));
		((Control)button2).set_TabIndex(19);
		((Control)button2).set_Text("Delete");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)textBox3).set_Location(new Point(342, 214));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(160, 20));
		((Control)textBox3).set_TabIndex(18);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(272, 217));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(46, 13));
		((Control)label3).set_TabIndex(17);
		((Control)label3).set_Text("S_name");
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[2] { "ID", "Name" });
		((Control)comboBox1).set_Location(new Point(167, 64));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 21));
		((Control)comboBox1).set_TabIndex(31);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(86, 116));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(62, 13));
		((Control)label1).set_TabIndex(30);
		((Control)label1).set_Text("Enter Value");
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(73, 196));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(689, 238));
		((Control)dataGridView1).set_TabIndex(29);
		((Control)button4).set_Location(new Point(167, 158));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(84, 22));
		((Control)button4).set_TabIndex(28);
		((Control)button4).set_Text("Reset");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button5).set_Location(new Point(257, 158));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(84, 22));
		((Control)button5).set_TabIndex(27);
		((Control)button5).set_Text("Back");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_Location(new Point(73, 158));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(84, 22));
		((Control)button6).set_TabIndex(25);
		((Control)button6).set_Text("Delete");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)textBox1).set_Location(new Point(167, 116));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(121, 20));
		((Control)textBox1).set_TabIndex(24);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(86, 67));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(71, 13));
		((Control)label5).set_TabIndex(23);
		((Control)label5).set_Text("Delete Using:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).set_Name("Delete_Salesman");
		((Control)this).set_Text("Delete_Salesman");
		((Form)this).add_Load((EventHandler)Delete_Salesman_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
