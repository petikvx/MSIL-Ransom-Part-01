using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns19;

public class Update_Product : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private SqlDataAdapter sqlDataAdapter_0;

	private SqlCommandBuilder sqlCommandBuilder_0;

	private DataTable dataTable_0;

	private IContainer icontainer_0 = null;

	private Button button2;

	private Button button1;

	private Button button3;

	private DataGridView dataGridView1;

	private Label label4;

	private Panel panel1;

	private TextBox textBox6;

	private Label label3;

	public Update_Product()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void Update_Product_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		sqlCommandBuilder_0 = new SqlCommandBuilder(sqlDataAdapter_0);
		((DbDataAdapter)(object)sqlDataAdapter_0).Update(dataTable_0);
		MessageBox.Show("Record Updated Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		sqlDataAdapter_0 = new SqlDataAdapter("select * from products", sqlConnection_0);
		dataTable_0 = new DataTable();
		((DbDataAdapter)(object)sqlDataAdapter_0).Fill(dataTable_0);
		dataGridView1.set_DataSource((object)dataTable_0);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		sqlDataAdapter_0 = new SqlDataAdapter("select * from products where pname like '%" + ((Control)textBox6).get_Text() + "%'", sqlConnection_0);
		dataTable_0 = new DataTable();
		((DbDataAdapter)(object)sqlDataAdapter_0).Fill(dataTable_0);
		dataGridView1.set_DataSource((object)dataTable_0);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
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
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		button2 = new Button();
		button1 = new Button();
		button3 = new Button();
		dataGridView1 = new DataGridView();
		label4 = new Label();
		panel1 = new Panel();
		label3 = new Label();
		textBox6 = new TextBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(370, 435));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(86, 28));
		((Control)button2).set_TabIndex(30);
		((Control)button2).set_Text("Refresh");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(279, 435));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(86, 28));
		((Control)button1).set_TabIndex(29);
		((Control)button1).set_Text("Update");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(465, 435));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(86, 28));
		((Control)button3).set_TabIndex(31);
		((Control)button3).set_Text("Back");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(46, 102));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(733, 307));
		((Control)dataGridView1).set_TabIndex(32);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(335, 22));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(121, 20));
		((Control)label4).set_TabIndex(23);
		((Control)label4).set_Text("Update Product");
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)dataGridView1);
		((Control)panel1).get_Controls().Add((Control)(object)button3);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).set_Location(new Point(40, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(825, 503));
		((Control)panel1).set_TabIndex(33);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(54, 63));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(86, 15));
		((Control)label3).set_TabIndex(103);
		((Control)label3).set_Text("Product Name");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)textBox6).set_Location(new Point(139, 63));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(158, 20));
		((Control)textBox6).set_TabIndex(102);
		((Control)textBox6).add_TextChanged((EventHandler)textBox6_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("Update_Product");
		((Control)this).set_Text("Update_Product");
		((Form)this).add_Load((EventHandler)Update_Product_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
