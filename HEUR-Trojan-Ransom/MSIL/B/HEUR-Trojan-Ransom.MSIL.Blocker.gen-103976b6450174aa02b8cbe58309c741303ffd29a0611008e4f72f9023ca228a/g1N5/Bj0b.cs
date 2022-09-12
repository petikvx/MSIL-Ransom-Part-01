using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pm02;

namespace g1N5;

[DesignerGenerated]
public class Bj0b : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private Label _Label1;

	private Label _Label2;

	private Button _btnSave;

	internal Label R;

	internal TextBox s;

	internal TextBox G;

	internal TextBox t;

	internal Label V;

	public Bj0b()
	{
		Se58();
	}

	protected override void b0F3(bool So1i)
	{
		try
		{
			if (So1i && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(So1i);
		}
	}

	private void Se58()
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bj0b));
		e6WS(new PictureBox());
		Pt2f(new PictureBox());
		Gq32(new Label());
		n9GX(new TextBox());
		Qz9m(new TextBox());
		r7HE(new TextBox());
		Co7t(new Label());
		Eq7r(new Label());
		Mf53(new Label());
		i4N8(new Button());
		((ISupportInitialize)Zx89()).BeginInit();
		((ISupportInitialize)Px9e()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Zx89()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Zx89()).set_Dock((DockStyle)1);
		((Control)Zx89()).set_Location(new Point(0, 0));
		((Control)Zx89()).set_Name("PictureBox1");
		((Control)Zx89()).set_Size(new Size(284, 50));
		Zx89().set_TabIndex(0);
		Zx89().set_TabStop(false);
		((Control)Px9e()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Px9e()).set_Dock((DockStyle)2);
		((Control)Px9e()).set_Location(new Point(0, 204));
		((Control)Px9e()).set_Name("PictureBox2");
		((Control)Px9e()).set_Size(new Size(284, 57));
		Px9e().set_TabIndex(1);
		Px9e().set_TabStop(false);
		w4D6().set_AutoSize(true);
		((Control)w4D6()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)w4D6()).set_ForeColor(SystemColors.ControlLight);
		((Control)w4D6()).set_Location(new Point(44, 15));
		((Control)w4D6()).set_Name("Label6");
		((Control)w4D6()).set_Size(new Size(214, 24));
		((Control)w4D6()).set_TabIndex(21);
		w4D6().set_Text("Create New Customer");
		((Control)Mr4j()).set_Location(new Point(140, 85));
		((Control)Mr4j()).set_Name("txtCustomerID");
		((Control)Mr4j()).set_Size(new Size(100, 20));
		((Control)Mr4j()).set_TabIndex(22);
		((Control)m6BY()).set_Location(new Point(140, 120));
		((Control)m6BY()).set_Name("txtFirstName");
		((Control)m6BY()).set_Size(new Size(100, 20));
		((Control)m6BY()).set_TabIndex(23);
		((Control)Qi14()).set_Location(new Point(140, 155));
		((Control)Qi14()).set_Name("txtLastName");
		((Control)Qi14()).set_Size(new Size(100, 20));
		((Control)Qi14()).set_TabIndex(24);
		Xs07().set_AutoSize(true);
		((Control)Xs07()).set_BackColor(Color.Transparent);
		((Control)Xs07()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Xs07()).set_Location(new Point(28, 85));
		((Control)Xs07()).set_Name("Label1");
		((Control)Xs07()).set_Size(new Size(68, 13));
		((Control)Xs07()).set_TabIndex(25);
		Xs07().set_Text("Customer ID:");
		y6K7().set_AutoSize(true);
		((Control)y6K7()).set_BackColor(Color.Transparent);
		((Control)y6K7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)y6K7()).set_Location(new Point(28, 123));
		((Control)y6K7()).set_Name("Label2");
		((Control)y6K7()).set_Size(new Size(57, 13));
		((Control)y6K7()).set_TabIndex(26);
		y6K7().set_Text("First Name");
		d5X6().set_AutoSize(true);
		((Control)d5X6()).set_BackColor(Color.Transparent);
		((Control)d5X6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)d5X6()).set_Location(new Point(28, 159));
		((Control)d5X6()).set_Name("Label3");
		((Control)d5X6()).set_Size(new Size(56, 13));
		((Control)d5X6()).set_TabIndex(27);
		d5X6().set_Text("Last name");
		((ButtonBase)Bs0j()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Bs0j()).set_FlatStyle((FlatStyle)0);
		((Control)Bs0j()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Bs0j()).set_Location(new Point(96, 216));
		((Control)Bs0j()).set_Name("btnSave");
		((Control)Bs0j()).set_Size(new Size(84, 23));
		((Control)Bs0j()).set_TabIndex(40);
		((ButtonBase)Bs0j()).set_Text("Save ");
		((ButtonBase)Bs0j()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)Bs0j());
		((Control)this).get_Controls().Add((Control)(object)d5X6());
		((Control)this).get_Controls().Add((Control)(object)y6K7());
		((Control)this).get_Controls().Add((Control)(object)Xs07());
		((Control)this).get_Controls().Add((Control)(object)Qi14());
		((Control)this).get_Controls().Add((Control)(object)m6BY());
		((Control)this).get_Controls().Add((Control)(object)Mr4j());
		((Control)this).get_Controls().Add((Control)(object)w4D6());
		((Control)this).get_Controls().Add((Control)(object)Px9e());
		((Control)this).get_Controls().Add((Control)(object)Zx89());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddNewCustomer");
		((ISupportInitialize)Zx89()).EndInit();
		((ISupportInitialize)Px9e()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Zx89()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6WS(PictureBox b8CW)
	{
		_PictureBox1 = b8CW;
	}

	[SpecialName]
	internal virtual PictureBox Px9e()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt2f(PictureBox p6JR)
	{
		_PictureBox2 = p6JR;
	}

	[SpecialName]
	internal virtual Label w4D6()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq32(Label Fm7j)
	{
		Label val = (R = Fm7j);
	}

	[SpecialName]
	internal virtual TextBox Mr4j()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9GX(TextBox Ft7w)
	{
		TextBox val = (s = Ft7w);
	}

	[SpecialName]
	internal virtual TextBox m6BY()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz9m(TextBox i6ML)
	{
		TextBox val = (G = i6ML);
	}

	[SpecialName]
	internal virtual TextBox Qi14()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7HE(TextBox Et5c)
	{
		TextBox val = (t = Et5c);
	}

	[SpecialName]
	internal virtual Label Xs07()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Co7t(Label Xa10)
	{
		_Label1 = Xa10;
	}

	[SpecialName]
	internal virtual Label y6K7()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq7r(Label r2C9)
	{
		_Label2 = r2C9;
	}

	[SpecialName]
	internal virtual Label d5X6()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mf53(Label n3RT)
	{
		Label val = (V = n3RT);
	}

	[SpecialName]
	internal virtual Button Bs0j()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4N8(Button f7S8)
	{
		EventHandler eventHandler = Kf06;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = f7S8;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	private void Kf06(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 1.accdb";
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand();
		val2.set_Connection(val);
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + Mr4j().get_Text() + "','" + m6BY().get_Text() + "','" + Qi14().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)Mr4j()).Clear();
		((TextBoxBase)m6BY()).Clear();
		((TextBoxBase)Qi14()).Clear();
		val.Close();
	}

	internal static bool Ct3n()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string c7CM in array2)
				{
					if (!z9RZ.y4G6(c7CM))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
