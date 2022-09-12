using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace r5F;

[DesignerGenerated]
public class d9P : Form
{
	private TextBox _txtCustomerID;

	private TextBox _txtLastName;

	private Button _btnSave;

	private Label _Label6;

	private PictureBox _PictureBox1;

	internal IContainer M;

	internal PictureBox e;

	internal TextBox C;

	public d9P()
	{
		Ab5();
	}

	protected override void Ha8(bool Ps3)
	{
		try
		{
			if (Ps3 && M != null)
			{
				M.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ps3);
		}
	}

	private void Ab5()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(d9P));
		f2B(new PictureBox());
		f6H(new TextBox());
		Tj2(new TextBox());
		a1N(new TextBox());
		Gy0(new Button());
		Ny3(new Label());
		Qx5(new PictureBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)i4N()).BeginInit();
		((ISupportInitialize)n8Z()).BeginInit();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_BackColor(Color.Transparent);
		((Control)val).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val).set_Location(new Point(83, 159));
		((Control)val).set_Name("LastNameLabel");
		((Control)val).set_Size(new Size(61, 13));
		((Control)val).set_TabIndex(72);
		val.set_Text("Last Name:");
		val2.set_AutoSize(true);
		((Control)val2).set_BackColor(Color.Transparent);
		((Control)val2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val2).set_Location(new Point(84, 127));
		((Control)val2).set_Name("FirstNameLabel");
		((Control)val2).set_Size(new Size(60, 13));
		((Control)val2).set_TabIndex(70);
		val2.set_Text("First Name:");
		val3.set_AutoSize(true);
		((Control)val3).set_BackColor(Color.Transparent);
		((Control)val3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val3).set_Location(new Point(84, 91));
		((Control)val3).set_Name("CustomerIDLabel");
		((Control)val3).set_Size(new Size(68, 13));
		((Control)val3).set_TabIndex(67);
		val3.set_Text("Customer ID:");
		((Control)i4N()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)i4N()).set_Dock((DockStyle)2);
		((Control)i4N()).set_Location(new Point(0, 259));
		((Control)i4N()).set_Name("PictureBox2");
		((Control)i4N()).set_Size(new Size(338, 57));
		i4N().set_TabIndex(65);
		i4N().set_TabStop(false);
		((Control)Be2()).set_Location(new Point(158, 124));
		((Control)Be2()).set_Name("txtFirstName");
		((Control)Be2()).set_Size(new Size(100, 20));
		((Control)Be2()).set_TabIndex(71);
		((Control)e3D()).set_Location(new Point(158, 88));
		((Control)e3D()).set_Name("txtCustomerID");
		((Control)e3D()).set_Size(new Size(100, 20));
		((Control)e3D()).set_TabIndex(69);
		((Control)t8E()).set_Location(new Point(158, 156));
		((Control)t8E()).set_Name("txtLastName");
		((Control)t8E()).set_Size(new Size(100, 20));
		((Control)t8E()).set_TabIndex(73);
		((ButtonBase)f8K()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)f8K()).set_FlatStyle((FlatStyle)0);
		((Control)f8K()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)f8K()).set_Location(new Point(120, 213));
		((Control)f8K()).set_Name("btnSave");
		((Control)f8K()).set_Size(new Size(84, 23));
		((Control)f8K()).set_TabIndex(68);
		((ButtonBase)f8K()).set_Text("Save ");
		((ButtonBase)f8K()).set_UseVisualStyleBackColor(true);
		Cx5().set_AutoSize(true);
		((Control)Cx5()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Cx5()).set_ForeColor(SystemColors.ControlLight);
		((Control)Cx5()).set_Location(new Point(66, 16));
		((Control)Cx5()).set_Name("Label6");
		((Control)Cx5()).set_Size(new Size(214, 24));
		((Control)Cx5()).set_TabIndex(75);
		Cx5().set_Text("Create New Customer");
		((Control)n8Z()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)n8Z()).set_Dock((DockStyle)1);
		((Control)n8Z()).set_Location(new Point(0, 0));
		((Control)n8Z()).set_Name("PictureBox1");
		((Control)n8Z()).set_Size(new Size(338, 50));
		n8Z().set_TabIndex(74);
		n8Z().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)Cx5());
		((Control)this).get_Controls().Add((Control)(object)n8Z());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)i4N());
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)Be2());
		((Control)this).get_Controls().Add((Control)(object)e3D());
		((Control)this).get_Controls().Add((Control)(object)t8E());
		((Control)this).get_Controls().Add((Control)(object)f8K());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)i4N()).EndInit();
		((ISupportInitialize)n8Z()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox i4N()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2B(PictureBox t5R)
	{
		PictureBox val = (e = t5R);
	}

	[SpecialName]
	internal virtual TextBox Be2()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6H(TextBox t3C)
	{
		TextBox val = (C = t3C);
	}

	[SpecialName]
	internal virtual TextBox e3D()
	{
		return _txtCustomerID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tj2(TextBox p7E)
	{
		_txtCustomerID = p7E;
	}

	[SpecialName]
	internal virtual TextBox t8E()
	{
		return _txtLastName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1N(TextBox Zs4)
	{
		_txtLastName = Zs4;
	}

	[SpecialName]
	internal virtual Button f8K()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy0(Button Ct2)
	{
		EventHandler eventHandler = Jz0;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Ct2;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Cx5()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ny3(Label w2T)
	{
		_Label6 = w2T;
	}

	[SpecialName]
	internal virtual PictureBox n8Z()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx5(PictureBox i7Y)
	{
		_PictureBox1 = i7Y;
	}

	private void Jz0(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 4.accdb";
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand();
		val2.set_Connection(val);
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + e3D().get_Text() + "','" + Be2().get_Text() + "','" + t8E().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)e3D()).Clear();
		((TextBoxBase)Be2()).Clear();
		((TextBoxBase)t8E()).Clear();
		val.Close();
	}

	internal static string Xz1(string[] b4Y, int Kt1, int d0E)
	{
		string text = "";
		for (int i = Kt1; i <= d0E; i = checked(i + 1))
		{
			text += b4Y[i];
		}
		return text.ToString();
	}
}
