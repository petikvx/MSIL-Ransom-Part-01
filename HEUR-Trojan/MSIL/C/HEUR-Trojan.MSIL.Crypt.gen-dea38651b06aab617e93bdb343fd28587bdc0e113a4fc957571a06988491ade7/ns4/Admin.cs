using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ns1;
using ns12;
using ns13;
using ns15;
using ns19;
using ns2;
using ns20;
using ns21;
using ns22;
using ns3;
using ns7;
using ns8;
using ns9;

namespace ns4;

public class Admin : Form
{
	private IContainer icontainer_0 = null;

	private Button button12;

	private Button button11;

	private Button button10;

	private Button button9;

	private Button button6;

	private Button button5;

	private Button button4;

	private Button button3;

	private Button button2;

	private Label label1;

	private Button button13;

	private Panel panel1;

	private Panel panel2;

	private Panel panel4;

	private Panel panel3;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	public Admin()
	{
		InitializeComponent();
	}

	private void button12_Click(object sender, EventArgs e)
	{
		Login login = new Login();
		((Control)login).Show();
		((Form)this).Close();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Add_product add_product = new Add_product();
		((Control)add_product).Show();
		((Form)this).Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		Delete_Product delete_Product = new Delete_Product();
		((Control)delete_Product).Show();
		((Form)this).Close();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		Update_Product update_Product = new Update_Product();
		((Control)update_Product).Show();
		((Form)this).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Add_Salesman add_Salesman = new Add_Salesman();
		((Control)add_Salesman).Show();
		((Form)this).Close();
	}

	private void method_1(object sender, EventArgs e)
	{
		Delete_Salesman delete_Salesman = new Delete_Salesman();
		((Control)delete_Salesman).Show();
		((Form)this).Close();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Update_Salesman update_Salesman = new Update_Salesman();
		((Control)update_Salesman).Show();
		((Form)this).Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Add_Supplier add_Supplier = new Add_Supplier();
		((Control)add_Supplier).Show();
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		Delete_Supplier delete_Supplier = new Delete_Supplier();
		((Control)delete_Supplier).Show();
		((Form)this).Close();
	}

	private void button9_Click(object sender, EventArgs e)
	{
		Update_Supplier update_Supplier = new Update_Supplier();
		((Control)update_Supplier).Show();
		((Form)this).Close();
	}

	private void button10_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		((Control)form).Show();
		((Form)this).Close();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		view_invoice view_invoice = new view_invoice();
		((Control)view_invoice).Show();
		((Form)this).Close();
	}

	private void button13_Click(object sender, EventArgs e)
	{
		Pd_Expiry pd_Expiry = new Pd_Expiry();
		((Control)pd_Expiry).Show();
		((Form)this).Close();
	}

	private void Admin_Load(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, PrintPageEventArgs e)
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected O, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected O, but got Unknown
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		button12 = new Button();
		button11 = new Button();
		button10 = new Button();
		button9 = new Button();
		button6 = new Button();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		label1 = new Label();
		button13 = new Button();
		panel1 = new Panel();
		panel2 = new Panel();
		panel4 = new Panel();
		panel3 = new Panel();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button12).set_BackColor(Color.DodgerBlue);
		((Control)button12).set_ForeColor(Color.LightGray);
		((Control)button12).set_Location(new Point(792, 537));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(82, 32));
		((Control)button12).set_TabIndex(25);
		((Control)button12).set_Text("Sign Out");
		((ButtonBase)button12).set_UseVisualStyleBackColor(false);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button11).set_BackColor(Color.DodgerBlue);
		((Control)button11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button11).set_ForeColor(Color.LightGray);
		((Control)button11).set_Location(new Point(33, 25));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(75, 60));
		((Control)button11).set_TabIndex(24);
		((Control)button11).set_Text("View Invoice Record");
		((ButtonBase)button11).set_UseVisualStyleBackColor(false);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button10).set_BackColor(Color.DodgerBlue);
		((Control)button10).set_ForeColor(Color.LightGray);
		((Control)button10).set_Location(new Point(195, 25));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(75, 60));
		((Control)button10).set_TabIndex(23);
		((Control)button10).set_Text("Generate Sales Report");
		((ButtonBase)button10).set_UseVisualStyleBackColor(false);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button9).set_BackColor(Color.DodgerBlue);
		((Control)button9).set_ForeColor(Color.LightGray);
		((Control)button9).set_Location(new Point(62, 106));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(75, 60));
		((Control)button9).set_TabIndex(22);
		((Control)button9).set_Text("Update Supplier Record");
		((ButtonBase)button9).set_UseVisualStyleBackColor(false);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button6).set_BackColor(Color.DodgerBlue);
		((Control)button6).set_ForeColor(Color.LightGray);
		((Control)button6).set_Location(new Point(63, 106));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(75, 60));
		((Control)button6).set_TabIndex(19);
		((Control)button6).set_Text("Update Salesman Record");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button5).set_BackColor(Color.DodgerBlue);
		((Control)button5).set_ForeColor(Color.LightGray);
		((Control)button5).set_Location(new Point(62, 106));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(79, 60));
		((Control)button5).set_TabIndex(18);
		((Control)button5).set_Text("Update Product Record");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button4).set_BackColor(Color.DodgerBlue);
		((Control)button4).set_ForeColor(Color.LightGray);
		((Control)button4).set_Location(new Point(62, 40));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(79, 60));
		((Control)button4).set_TabIndex(17);
		((Control)button4).set_Text("Add product");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button3).set_BackColor(Color.DodgerBlue);
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(63, 40));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 60));
		((Control)button3).set_TabIndex(16);
		((Control)button3).set_Text("Add Salesman");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_BackColor(Color.DodgerBlue);
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(62, 40));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 60));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("Add Supplier");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 17f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(413, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(81, 29));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("Admin");
		((Control)button13).set_BackColor(Color.DodgerBlue);
		((Control)button13).set_ForeColor(Color.LightGray);
		((Control)button13).set_Location(new Point(114, 25));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(75, 60));
		((Control)button13).set_TabIndex(26);
		((Control)button13).set_Text("View Product Expiry");
		((ButtonBase)button13).set_UseVisualStyleBackColor(false);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(64, 65, 64));
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)button4);
		((Control)panel1).get_Controls().Add((Control)(object)button5);
		((Control)panel1).set_ForeColor(Color.FromArgb(64, 65, 64));
		((Control)panel1).set_Location(new Point(128, 94));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(200, 212));
		((Control)panel1).set_TabIndex(27);
		((Control)panel2).set_BackColor(Color.FromArgb(64, 65, 64));
		panel2.set_BorderStyle((BorderStyle)1);
		((Control)panel2).get_Controls().Add((Control)(object)button3);
		((Control)panel2).get_Controls().Add((Control)(object)button6);
		((Control)panel2).set_ForeColor(Color.FromArgb(64, 65, 64));
		((Control)panel2).set_Location(new Point(354, 94));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(202, 212));
		((Control)panel2).set_TabIndex(28);
		((Control)panel4).set_BackColor(Color.FromArgb(64, 65, 64));
		panel4.set_BorderStyle((BorderStyle)1);
		((Control)panel4).get_Controls().Add((Control)(object)button2);
		((Control)panel4).get_Controls().Add((Control)(object)button9);
		((Control)panel4).set_ForeColor(Color.FromArgb(64, 65, 64));
		((Control)panel4).set_Location(new Point(585, 94));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(202, 212));
		((Control)panel4).set_TabIndex(29);
		((Control)panel3).set_BackColor(Color.FromArgb(64, 65, 64));
		panel3.set_BorderStyle((BorderStyle)1);
		((Control)panel3).get_Controls().Add((Control)(object)button11);
		((Control)panel3).get_Controls().Add((Control)(object)button10);
		((Control)panel3).get_Controls().Add((Control)(object)button13);
		((Control)panel3).set_ForeColor(Color.FromArgb(64, 65, 64));
		((Control)panel3).set_Location(new Point(128, 349));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(302, 114));
		((Control)panel3).set_TabIndex(30);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(250, 321));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(73, 22));
		((Control)label2).set_TabIndex(31);
		((Control)label2).set_Text("Reports");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(643, 66));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(85, 22));
		((Control)label3).set_TabIndex(32);
		((Control)label3).set_Text("Suppliers");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Cursor(Cursors.get_No());
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.LightGray);
		((Control)label4).set_Location(new Point(413, 66));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(89, 22));
		((Control)label4).set_TabIndex(33);
		((Control)label4).set_Text("Salesmen");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Cursor(Cursors.get_No());
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.LightGray);
		((Control)label5).set_Location(new Point(186, 66));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(81, 22));
		((Control)label5).set_TabIndex(34);
		((Control)label5).set_Text("Products");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel4);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Admin");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Admin");
		((Form)this).add_Load((EventHandler)Admin_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
