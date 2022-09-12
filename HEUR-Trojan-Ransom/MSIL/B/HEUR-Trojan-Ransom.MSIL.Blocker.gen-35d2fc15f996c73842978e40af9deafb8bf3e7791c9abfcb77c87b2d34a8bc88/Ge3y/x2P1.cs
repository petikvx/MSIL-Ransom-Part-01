using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ge3y;

[DesignerGenerated]
public class x2P1 : Form
{
	private IContainer components;

	private TextBox _txtLastName;

	private BindingSource _TblCustomersBindingSource1;

	private TextBox _txtCustomerID;

	private TextBox _txtFirstName;

	private Button _btnSave;

	private Label _Label6;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox1;

	internal BindingSource l;

	public x2P1()
	{
		d0Y4();
	}

	protected override void Mi2g(bool c1W9)
	{
		try
		{
			if (c1W9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c1W9);
		}
	}

	private void d0Y4()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(x2P1));
		Wi02(new TextBox());
		Ci45(new BindingSource(components));
		Fo79(new BindingSource(components));
		s4RW(new PictureBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)z3TM()).BeginInit();
		((ISupportInitialize)f1QS()).BeginInit();
		((ISupportInitialize)o2X3()).BeginInit();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_BackColor(Color.Transparent);
		((Control)val).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val).set_Location(new Point(83, 159));
		((Control)val).set_Name("LastNameLabel");
		((Control)val).set_Size(new Size(61, 13));
		((Control)val).set_TabIndex(62);
		val.set_Text("Last Name:");
		val2.set_AutoSize(true);
		((Control)val2).set_BackColor(Color.Transparent);
		((Control)val2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val2).set_Location(new Point(84, 127));
		((Control)val2).set_Name("FirstNameLabel");
		((Control)val2).set_Size(new Size(60, 13));
		((Control)val2).set_TabIndex(60);
		val2.set_Text("First Name:");
		val3.set_AutoSize(true);
		((Control)val3).set_BackColor(Color.Transparent);
		((Control)val3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val3).set_Location(new Point(84, 91));
		((Control)val3).set_Name("CustomerIDLabel");
		((Control)val3).set_Size(new Size(68, 13));
		((Control)val3).set_TabIndex(57);
		val3.set_Text("Customer ID:");
		((Control)Mj1o()).set_Location(new Point(158, 156));
		((Control)Mj1o()).set_Name("txtLastName");
		((Control)Mj1o()).set_Size(new Size(100, 20));
		((Control)Mj1o()).set_TabIndex(63);
		z3TM().set_DataMember("tblCustomers");
		((Control)m2N5()).set_Location(new Point(158, 88));
		((Control)m2N5()).set_Name("txtCustomerID");
		((Control)m2N5()).set_Size(new Size(100, 20));
		((Control)m2N5()).set_TabIndex(59);
		((Control)y2R5()).set_Location(new Point(158, 124));
		((Control)y2R5()).set_Name("txtFirstName");
		((Control)y2R5()).set_Size(new Size(100, 20));
		((Control)y2R5()).set_TabIndex(61);
		((ButtonBase)m1DE()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)m1DE()).set_FlatStyle((FlatStyle)0);
		((Control)m1DE()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)m1DE()).set_Location(new Point(120, 213));
		((Control)m1DE()).set_Name("btnSave");
		((Control)m1DE()).set_Size(new Size(84, 23));
		((Control)m1DE()).set_TabIndex(58);
		((ButtonBase)m1DE()).set_Text("Save ");
		((ButtonBase)m1DE()).set_UseVisualStyleBackColor(true);
		j1Q4().set_AutoSize(true);
		((Control)j1Q4()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)j1Q4()).set_ForeColor(SystemColors.ControlLight);
		((Control)j1Q4()).set_Location(new Point(44, 15));
		((Control)j1Q4()).set_Name("Label6");
		((Control)j1Q4()).set_Size(new Size(214, 24));
		((Control)j1Q4()).set_TabIndex(56);
		j1Q4().set_Text("Create New Customer");
		((Control)Tt25()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Tt25()).set_Dock((DockStyle)2);
		((Control)Tt25()).set_Location(new Point(0, 259));
		((Control)Tt25()).set_Name("PictureBox2");
		((Control)Tt25()).set_Size(new Size(338, 57));
		Tt25().set_TabIndex(55);
		Tt25().set_TabStop(false);
		f1QS().set_DataMember("tblCustomers");
		((Control)o2X3()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)o2X3()).set_Dock((DockStyle)1);
		((Control)o2X3()).set_Location(new Point(0, 0));
		((Control)o2X3()).set_Name("PictureBox1");
		((Control)o2X3()).set_Size(new Size(338, 50));
		o2X3().set_TabIndex(54);
		o2X3().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)Mj1o());
		((Control)this).get_Controls().Add((Control)(object)m2N5());
		((Control)this).get_Controls().Add((Control)(object)y2R5());
		((Control)this).get_Controls().Add((Control)(object)m1DE());
		((Control)this).get_Controls().Add((Control)(object)j1Q4());
		((Control)this).get_Controls().Add((Control)(object)Tt25());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)o2X3());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)z3TM()).EndInit();
		((ISupportInitialize)f1QS()).EndInit();
		((ISupportInitialize)o2X3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Mj1o()
	{
		return _txtLastName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wi02(TextBox f3EX)
	{
		_txtLastName = f3EX;
	}

	[SpecialName]
	internal virtual BindingSource z3TM()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci45(BindingSource g3FW)
	{
		_TblCustomersBindingSource1 = g3FW;
	}

	[SpecialName]
	internal virtual TextBox m2N5()
	{
		return _txtCustomerID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yd38(TextBox Ct95)
	{
		_txtCustomerID = Ct95;
	}

	[SpecialName]
	internal virtual TextBox y2R5()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At27(TextBox p6LB)
	{
		_txtFirstName = p6LB;
	}

	[SpecialName]
	internal virtual Button m1DE()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0FR(Button Ri34)
	{
		EventHandler eventHandler = Ar9z;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Ri34;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label j1Q4()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ae9f(Label Mn04)
	{
		_Label6 = Mn04;
	}

	[SpecialName]
	internal virtual PictureBox Tt25()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mg6o(PictureBox d0Y6)
	{
		_PictureBox2 = d0Y6;
	}

	[SpecialName]
	internal virtual BindingSource f1QS()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo79(BindingSource y4XQ)
	{
		BindingSource val = (l = y4XQ);
	}

	[SpecialName]
	internal virtual PictureBox o2X3()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4RW(PictureBox t4W7)
	{
		_PictureBox1 = t4W7;
	}

	private void Ar9z(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 3.accdb";
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand();
		val2.set_Connection(val);
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + m2N5().get_Text() + "','" + y2R5().get_Text() + "','" + Mj1o().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)m2N5()).Clear();
		((TextBoxBase)y2R5()).Clear();
		((TextBoxBase)Mj1o()).Clear();
		val.Close();
	}

	internal static bool Sx0z(int Pi1q)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Pi1q + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Pi1q = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Pi1q = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Pi1q = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}
}
