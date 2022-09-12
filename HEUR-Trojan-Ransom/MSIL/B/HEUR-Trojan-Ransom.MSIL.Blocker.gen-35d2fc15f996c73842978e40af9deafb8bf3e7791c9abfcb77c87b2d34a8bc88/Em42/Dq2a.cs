using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Em42;

[DesignerGenerated]
public class Dq2a : Form
{
	private TextBox _txtCustomerID;

	private TextBox _txtLastName;

	private Label _Label6;

	internal IContainer t;

	internal PictureBox D;

	internal TextBox G;

	internal Button E;

	internal PictureBox V;

	public Dq2a()
	{
		Ej8c();
	}

	protected override void Kk84(bool f2C7)
	{
		try
		{
			if (f2C7 && t != null)
			{
				t.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f2C7);
		}
	}

	private void Ej8c()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dq2a));
		w5B7(new PictureBox());
		Mr53(new TextBox());
		Tf80(new TextBox());
		r6TG(new TextBox());
		f3W0(new Button());
		As0e(new Label());
		j3SM(new PictureBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)Bk53()).BeginInit();
		((ISupportInitialize)Mj43()).BeginInit();
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
		((Control)Bk53()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Bk53()).set_Dock((DockStyle)2);
		((Control)Bk53()).set_Location(new Point(0, 259));
		((Control)Bk53()).set_Name("PictureBox2");
		((Control)Bk53()).set_Size(new Size(338, 57));
		Bk53().set_TabIndex(65);
		Bk53().set_TabStop(false);
		((Control)q1HL()).set_Location(new Point(158, 124));
		((Control)q1HL()).set_Name("txtFirstName");
		((Control)q1HL()).set_Size(new Size(100, 20));
		((Control)q1HL()).set_TabIndex(71);
		((Control)Hj52()).set_Location(new Point(158, 88));
		((Control)Hj52()).set_Name("txtCustomerID");
		((Control)Hj52()).set_Size(new Size(100, 20));
		((Control)Hj52()).set_TabIndex(69);
		((Control)k2C6()).set_Location(new Point(158, 156));
		((Control)k2C6()).set_Name("txtLastName");
		((Control)k2C6()).set_Size(new Size(100, 20));
		((Control)k2C6()).set_TabIndex(73);
		((ButtonBase)e9YS()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)e9YS()).set_FlatStyle((FlatStyle)0);
		((Control)e9YS()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)e9YS()).set_Location(new Point(120, 213));
		((Control)e9YS()).set_Name("btnSave");
		((Control)e9YS()).set_Size(new Size(84, 23));
		((Control)e9YS()).set_TabIndex(68);
		((ButtonBase)e9YS()).set_Text("Save ");
		((ButtonBase)e9YS()).set_UseVisualStyleBackColor(true);
		Qx8m().set_AutoSize(true);
		((Control)Qx8m()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Qx8m()).set_ForeColor(SystemColors.ControlLight);
		((Control)Qx8m()).set_Location(new Point(66, 16));
		((Control)Qx8m()).set_Name("Label6");
		((Control)Qx8m()).set_Size(new Size(214, 24));
		((Control)Qx8m()).set_TabIndex(75);
		Qx8m().set_Text("Create New Customer");
		((Control)Mj43()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Mj43()).set_Dock((DockStyle)1);
		((Control)Mj43()).set_Location(new Point(0, 0));
		((Control)Mj43()).set_Name("PictureBox1");
		((Control)Mj43()).set_Size(new Size(338, 50));
		Mj43().set_TabIndex(74);
		Mj43().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)Qx8m());
		((Control)this).get_Controls().Add((Control)(object)Mj43());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)Bk53());
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)q1HL());
		((Control)this).get_Controls().Add((Control)(object)Hj52());
		((Control)this).get_Controls().Add((Control)(object)k2C6());
		((Control)this).get_Controls().Add((Control)(object)e9YS());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)Bk53()).EndInit();
		((ISupportInitialize)Mj43()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Bk53()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5B7(PictureBox x6M1)
	{
		PictureBox val = (D = x6M1);
	}

	[SpecialName]
	internal virtual TextBox q1HL()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr53(TextBox x3DS)
	{
		TextBox val = (G = x3DS);
	}

	[SpecialName]
	internal virtual TextBox Hj52()
	{
		return _txtCustomerID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tf80(TextBox Jk02)
	{
		_txtCustomerID = Jk02;
	}

	[SpecialName]
	internal virtual TextBox k2C6()
	{
		return _txtLastName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6TG(TextBox n7J4)
	{
		_txtLastName = n7J4;
	}

	[SpecialName]
	internal virtual Button e9YS()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3W0(Button d8S6)
	{
		EventHandler eventHandler = Rj6o;
		Button e = E;
		if (e != null)
		{
			((Control)e).remove_Click(eventHandler);
		}
		Button val = (E = d8S6);
		e = E;
		if (e != null)
		{
			((Control)e).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Qx8m()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As0e(Label Jy38)
	{
		_Label6 = Jy38;
	}

	[SpecialName]
	internal virtual PictureBox Mj43()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3SM(PictureBox m7QW)
	{
		PictureBox val = (V = m7QW);
	}

	private void Rj6o(object sender, EventArgs e)
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
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + Hj52().get_Text() + "','" + q1HL().get_Text() + "','" + k2C6().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)Hj52()).Clear();
		((TextBoxBase)q1HL()).Clear();
		((TextBoxBase)k2C6()).Clear();
		val.Close();
	}

	internal static string Sg96(string[] An39, int La2i, int Kf3g)
	{
		string text = "";
		for (int i = La2i; i <= Kf3g; i = checked(i + 1))
		{
			text += An39[i];
		}
		return text.ToString();
	}
}
