using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns22;

public class view_invoice : Form
{
	private SqlConnection sqlConnection_0 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Umer Farooq\\Documents\\Visual Studio 2012\\Projects\\DB project\\DB project\\database.mdf;Integrated Security=True;Connect Timeout=30");

	private IContainer icontainer_0 = null;

	private DataGridView dataGridView1;

	private Button button2;

	private Button button1;

	private Label label8;

	private Panel panel1;

	private MaskedTextBox textBox6;

	public view_invoice()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		InitializeComponent();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Admin admin = new Admin();
		((Control)admin).Show();
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		((DbConnection)(object)sqlConnection_0).Open();
		SqlCommand val = new SqlCommand("select p.p_id,p.pname,p.potency,s.quantity,s.price,s.discount,o.gross_amount as 'Net Bill',o.customer,o.dated as date from products p, sub_order s ,order_details o  where o.id='" + ((Control)textBox6).get_Text() + "' and s.p_id=p.p_id and s.o_id=o.id", sqlConnection_0);
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Sr #");
		dataTable.Columns["Sr #"]!.AutoIncrement = true;
		dataTable.Columns["Sr #"]!.AutoIncrementSeed = 1L;
		((DbDataAdapter)(object)val2).Fill(dataTable);
		dataGridView1.set_DataSource((object)dataTable);
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
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		dataGridView1 = new DataGridView();
		button2 = new Button();
		button1 = new Button();
		label8 = new Label();
		panel1 = new Panel();
		textBox6 = new MaskedTextBox();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(99, 148));
		((Control)dataGridView1).set_Name("dataGridView1");
		dataGridView1.set_ReadOnly(true);
		((Control)dataGridView1).set_Size(new Size(705, 398));
		((Control)dataGridView1).set_TabIndex(111);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(491, 27));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 34));
		((Control)button2).set_TabIndex(110);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(390, 27));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 34));
		((Control)button1).set_TabIndex(109);
		((Control)button1).set_Text("Search");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.LightGray);
		((Control)label8).set_Location(new Point(80, 35));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(56, 13));
		((Control)label8).set_TabIndex(119);
		((Control)label8).set_Text("Invoice ID");
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).get_Controls().Add((Control)(object)textBox6);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).set_Location(new Point(99, 42));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(705, 100));
		((Control)panel1).set_TabIndex(120);
		((Control)textBox6).set_Location(new Point(174, 35));
		textBox6.set_Mask("00000");
		((Control)textBox6).set_Name("textBox6");
		textBox6.set_PromptChar(' ');
		((Control)textBox6).set_Size(new Size(100, 20));
		((Control)textBox6).set_TabIndex(120);
		textBox6.set_ValidatingType(typeof(int));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).set_Name("view_invoice");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("view_invoice");
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
