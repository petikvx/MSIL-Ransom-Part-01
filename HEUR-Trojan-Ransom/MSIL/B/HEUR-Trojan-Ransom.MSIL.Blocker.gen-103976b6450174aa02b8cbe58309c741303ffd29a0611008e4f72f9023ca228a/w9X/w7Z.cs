using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace w9X;

[DesignerGenerated]
public class w7Z : Form
{
	private IContainer components;

	private TextBox _txtLastName;

	private BindingSource _TblCustomersBindingSource1;

	private TextBox _txtCustomerID;

	private Button _btnSave;

	private Label _Label6;

	internal TextBox U;

	internal PictureBox K;

	internal BindingSource D;

	internal PictureBox m;

	public w7Z()
	{
		Lr7();
	}

	protected override void Aw1(bool Ka8)
	{
		try
		{
			if (Ka8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ka8);
		}
	}

	private void Lr7()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(w7Z));
		Cd7(new TextBox());
		Lc0(new BindingSource(components));
		r3M(new BindingSource(components));
		Mt4(new PictureBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)r8W()).BeginInit();
		((ISupportInitialize)s9X()).BeginInit();
		((ISupportInitialize)Kr4()).BeginInit();
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
		((Control)Jt4()).set_Location(new Point(158, 156));
		((Control)Jt4()).set_Name("txtLastName");
		((Control)Jt4()).set_Size(new Size(100, 20));
		((Control)Jt4()).set_TabIndex(63);
		r8W().set_DataMember("tblCustomers");
		((Control)Sf1()).set_Location(new Point(158, 88));
		((Control)Sf1()).set_Name("txtCustomerID");
		((Control)Sf1()).set_Size(new Size(100, 20));
		((Control)Sf1()).set_TabIndex(59);
		((Control)Lb1()).set_Location(new Point(158, 124));
		((Control)Lb1()).set_Name("txtFirstName");
		((Control)Lb1()).set_Size(new Size(100, 20));
		((Control)Lb1()).set_TabIndex(61);
		((ButtonBase)y0E()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)y0E()).set_FlatStyle((FlatStyle)0);
		((Control)y0E()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)y0E()).set_Location(new Point(120, 213));
		((Control)y0E()).set_Name("btnSave");
		((Control)y0E()).set_Size(new Size(84, 23));
		((Control)y0E()).set_TabIndex(58);
		((ButtonBase)y0E()).set_Text("Save ");
		((ButtonBase)y0E()).set_UseVisualStyleBackColor(true);
		p2W().set_AutoSize(true);
		((Control)p2W()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)p2W()).set_ForeColor(SystemColors.ControlLight);
		((Control)p2W()).set_Location(new Point(44, 15));
		((Control)p2W()).set_Name("Label6");
		((Control)p2W()).set_Size(new Size(214, 24));
		((Control)p2W()).set_TabIndex(56);
		p2W().set_Text("Create New Customer");
		((Control)d6D()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)d6D()).set_Dock((DockStyle)2);
		((Control)d6D()).set_Location(new Point(0, 259));
		((Control)d6D()).set_Name("PictureBox2");
		((Control)d6D()).set_Size(new Size(338, 57));
		d6D().set_TabIndex(55);
		d6D().set_TabStop(false);
		s9X().set_DataMember("tblCustomers");
		((Control)Kr4()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Kr4()).set_Dock((DockStyle)1);
		((Control)Kr4()).set_Location(new Point(0, 0));
		((Control)Kr4()).set_Name("PictureBox1");
		((Control)Kr4()).set_Size(new Size(338, 50));
		Kr4().set_TabIndex(54);
		Kr4().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)Jt4());
		((Control)this).get_Controls().Add((Control)(object)Sf1());
		((Control)this).get_Controls().Add((Control)(object)Lb1());
		((Control)this).get_Controls().Add((Control)(object)y0E());
		((Control)this).get_Controls().Add((Control)(object)p2W());
		((Control)this).get_Controls().Add((Control)(object)d6D());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)Kr4());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)r8W()).EndInit();
		((ISupportInitialize)s9X()).EndInit();
		((ISupportInitialize)Kr4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Jt4()
	{
		return _txtLastName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd7(TextBox s4L)
	{
		_txtLastName = s4L;
	}

	[SpecialName]
	internal virtual BindingSource r8W()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc0(BindingSource y3R)
	{
		_TblCustomersBindingSource1 = y3R;
	}

	[SpecialName]
	internal virtual TextBox Sf1()
	{
		return _txtCustomerID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8H(TextBox b8Y)
	{
		_txtCustomerID = b8Y;
	}

	[SpecialName]
	internal virtual TextBox Lb1()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp2(TextBox Eq5)
	{
		TextBox val = (U = Eq5);
	}

	[SpecialName]
	internal virtual Button y0E()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5K(Button t5M)
	{
		EventHandler eventHandler = Pm9;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = t5M;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label p2W()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo2(Label k6Q)
	{
		_Label6 = k6Q;
	}

	[SpecialName]
	internal virtual PictureBox d6D()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tp5(PictureBox Dw8)
	{
		PictureBox val = (K = Dw8);
	}

	[SpecialName]
	internal virtual BindingSource s9X()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3M(BindingSource a1L)
	{
		BindingSource val = (D = a1L);
	}

	[SpecialName]
	internal virtual PictureBox Kr4()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt4(PictureBox Be8)
	{
		PictureBox val = (m = Be8);
	}

	private void Pm9(object sender, EventArgs e)
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
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + Sf1().get_Text() + "','" + Lb1().get_Text() + "','" + Jt4().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)Sf1()).Clear();
		((TextBoxBase)Lb1()).Clear();
		((TextBoxBase)Jt4()).Clear();
		val.Close();
	}

	internal static bool Xg0(int Pk6)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Pk6 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Pk6 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Pk6 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Pk6 = -1;
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
