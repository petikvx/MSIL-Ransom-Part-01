using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns21;

public class Update_Supplier : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private SqlDataAdapter sqlDataAdapter_0;

	private SqlCommandBuilder sqlCommandBuilder_0;

	private DataTable dataTable_0;

	private IContainer icontainer_0 = null;

	private Label label4;

	private Button button4;

	private Button button5;

	private Button button6;

	private DataGridView dataGridView1;

	private Panel panel1;

	private TextBox textBox6;

	private Label label3;

	public Update_Supplier()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		sqlDataAdapter_0 = new SqlDataAdapter("select * from suppliers", sqlConnection_0);
		dataTable_0 = new DataTable();
		((DbDataAdapter)(object)sqlDataAdapter_0).Fill(dataTable_0);
		dataGridView1.set_DataSource((object)dataTable_0);
		((DbConnection)(object)sqlConnection_0).Close();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		sqlCommandBuilder_0 = new SqlCommandBuilder(sqlDataAdapter_0);
		((DbDataAdapter)(object)sqlDataAdapter_0).Update(dataTable_0);
		MessageBox.Show("Record Updated Successfully", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Update_Supplier_Load(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		sqlDataAdapter_0 = new SqlDataAdapter("select * from suppliers where sname like '%" + ((Control)textBox6).get_Text() + "%'", sqlConnection_0);
		dataTable_0 = new DataTable();
		((DbDataAdapter)(object)sqlDataAdapter_0).Fill(dataTable_0);
		dataGridView1.set_DataSource((object)dataTable_0);
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
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		label4 = new Label();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		dataGridView1 = new DataGridView();
		panel1 = new Panel();
		textBox6 = new TextBox();
		label3 = new Label();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(323, 14));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(124, 20));
		((Control)label4).set_TabIndex(45);
		((Control)label4).set_Text("Update Supplier");
		((Control)button4).set_BackColor(Color.DodgerBlue);
		((Control)button4).set_ForeColor(Color.LightGray);
		((Control)button4).set_Location(new Point(441, 451));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(80, 34));
		((Control)button4).set_TabIndex(56);
		((Control)button4).set_Text("Back");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button5).set_BackColor(Color.DodgerBlue);
		((Control)button5).set_ForeColor(Color.LightGray);
		((Control)button5).set_Location(new Point(346, 451));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(80, 34));
		((Control)button5).set_TabIndex(55);
		((Control)button5).set_Text("Refresh");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_BackColor(Color.DodgerBlue);
		((Control)button6).set_ForeColor(Color.LightGray);
		((Control)button6).set_Location(new Point(255, 451));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(80, 34));
		((Control)button6).set_TabIndex(54);
		((Control)button6).set_Text("Update");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button6).add_Click((EventHandler)button6_Click);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(102, 99));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(586, 334));
		((Control)dataGridView1).set_TabIndex(57);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)dataGridView1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)button4);
		((Control)panel1).get_Controls().Add((Control)(object)button6);
		((Control)panel1).get_Controls().Add((Control)(object)button5);
		((Control)panel1).set_ForeColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).set_Location(new Point(58, 29));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(803, 503));
		((Control)panel1).set_TabIndex(58);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)textBox6).set_Location(new Point(205, 62));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(158, 20));
		((Control)textBox6).set_TabIndex(106);
		((Control)textBox6).add_TextChanged((EventHandler)textBox6_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(99, 63));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(90, 15));
		((Control)label3).set_TabIndex(107);
		((Control)label3).set_Text("Supplier Name");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("Update_Supplier");
		((Control)this).set_Text("Update_Supplier");
		((Form)this).add_Load((EventHandler)Update_Supplier_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
