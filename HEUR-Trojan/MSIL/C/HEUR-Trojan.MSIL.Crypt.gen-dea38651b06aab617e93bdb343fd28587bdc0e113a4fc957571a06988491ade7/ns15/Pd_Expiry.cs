using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns15;

public class Pd_Expiry : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private Label label2;

	private Label label1;

	private DateTimePicker dateTimePicker1;

	private DateTimePicker dateTimePicker2;

	private Label label3;

	private DataGridView dataGridView1;

	private Button button1;

	private Button button2;

	private Panel panel1;

	public Pd_Expiry()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Pd_Expiry_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select p_id as 'Product ID', pname as 'Product Name',quantity as 'Quatitity',potency as 'Potency'from products where exp>='" + dateTimePicker1.get_Value().Date.ToString() + "' and  exp<='" + dateTimePicker2.get_Value().Date.ToString() + "'", sqlConnection_0);
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
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
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
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		label2 = new Label();
		label1 = new Label();
		dateTimePicker1 = new DateTimePicker();
		dateTimePicker2 = new DateTimePicker();
		label3 = new Label();
		dataGridView1 = new DataGridView();
		button1 = new Button();
		button2 = new Button();
		panel1 = new Panel();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(312, 34));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(110, 20));
		((Control)label2).set_TabIndex(103);
		((Control)label2).set_Text("Product Expiry");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(17, 78));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(30, 13));
		((Control)label1).set_TabIndex(104);
		((Control)label1).set_Text("Form");
		((Control)dateTimePicker1).set_Location(new Point(53, 77));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(111);
		((Control)dateTimePicker2).set_Location(new Point(316, 78));
		((Control)dateTimePicker2).set_Name("dateTimePicker2");
		((Control)dateTimePicker2).set_Size(new Size(200, 20));
		((Control)dateTimePicker2).set_TabIndex(113);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(290, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(20, 13));
		((Control)label3).set_TabIndex(114);
		((Control)label3).set_Text("To");
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(70, 216));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(768, 333));
		((Control)dataGridView1).set_TabIndex(115);
		dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(dataGridView1_CellContentClick));
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(550, 77));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(89, 31));
		((Control)button1).set_TabIndex(116);
		((Control)button1).set_Text("Display");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(660, 78));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(89, 31));
		((Control)button2).set_TabIndex(117);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)dateTimePicker2);
		((Control)panel1).set_Location(new Point(70, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(768, 183));
		((Control)panel1).set_TabIndex(118);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).set_Name("Pd_Expiry");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Pd_Expiry");
		((Form)this).add_Load((EventHandler)Pd_Expiry_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
