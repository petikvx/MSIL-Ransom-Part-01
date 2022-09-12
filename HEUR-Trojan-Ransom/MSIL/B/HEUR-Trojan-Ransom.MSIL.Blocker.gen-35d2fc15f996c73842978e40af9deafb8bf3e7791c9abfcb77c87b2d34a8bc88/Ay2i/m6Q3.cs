using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ay2i;

[DesignerGenerated]
public class m6Q3 : Form
{
	private IContainer components;

	private Label _Label6;

	private PictureBox _PictureBox1;

	internal PictureBox N;

	internal Button M;

	internal TextBox J;

	internal TextBox U;

	internal TextBox E;

	public m6Q3()
	{
		Fa08();
	}

	protected override void Tf2p(bool p1K5)
	{
		try
		{
			if (p1K5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p1K5);
		}
	}

	private void Fa08()
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
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(m6Q3));
		r9W0(new Label());
		k4M2(new PictureBox());
		f3KQ(new PictureBox());
		Ex98(new Button());
		Tb0x(new TextBox());
		Go87(new TextBox());
		c1D7(new TextBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)Fr4n()).BeginInit();
		((ISupportInitialize)w1W2()).BeginInit();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_BackColor(Color.Transparent);
		((Control)val).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val).set_Location(new Point(84, 91));
		((Control)val).set_Name("CustomerIDLabel");
		((Control)val).set_Size(new Size(68, 13));
		((Control)val).set_TabIndex(50);
		val.set_Text("Customer ID:");
		val2.set_AutoSize(true);
		((Control)val2).set_BackColor(Color.Transparent);
		((Control)val2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val2).set_Location(new Point(84, 127));
		((Control)val2).set_Name("FirstNameLabel");
		((Control)val2).set_Size(new Size(60, 13));
		((Control)val2).set_TabIndex(51);
		val2.set_Text("First Name:");
		val3.set_AutoSize(true);
		((Control)val3).set_BackColor(Color.Transparent);
		((Control)val3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)val3).set_Location(new Point(83, 159));
		((Control)val3).set_Name("LastNameLabel");
		((Control)val3).set_Size(new Size(61, 13));
		((Control)val3).set_TabIndex(52);
		val3.set_Text("Last Name:");
		Fb49().set_AutoSize(true);
		((Control)Fb49()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fb49()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fb49()).set_Location(new Point(44, 15));
		((Control)Fb49()).set_Name("Label6");
		((Control)Fb49()).set_Size(new Size(214, 24));
		((Control)Fb49()).set_TabIndex(43);
		Fb49().set_Text("Create New Customer");
		((Control)Fr4n()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Fr4n()).set_Dock((DockStyle)2);
		((Control)Fr4n()).set_Location(new Point(0, 259));
		((Control)Fr4n()).set_Name("PictureBox2");
		((Control)Fr4n()).set_Size(new Size(338, 57));
		Fr4n().set_TabIndex(42);
		Fr4n().set_TabStop(false);
		((Control)w1W2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)w1W2()).set_Dock((DockStyle)1);
		((Control)w1W2()).set_Location(new Point(0, 0));
		((Control)w1W2()).set_Name("PictureBox1");
		((Control)w1W2()).set_Size(new Size(338, 50));
		w1W2().set_TabIndex(41);
		w1W2().set_TabStop(false);
		((ButtonBase)g3S0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)g3S0()).set_FlatStyle((FlatStyle)0);
		((Control)g3S0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)g3S0()).set_Location(new Point(120, 213));
		((Control)g3S0()).set_Name("btnSave");
		((Control)g3S0()).set_Size(new Size(84, 23));
		((Control)g3S0()).set_TabIndex(50);
		((ButtonBase)g3S0()).set_Text("Save ");
		((ButtonBase)g3S0()).set_UseVisualStyleBackColor(true);
		((Control)j5B4()).set_Location(new Point(158, 88));
		((Control)j5B4()).set_Name("txtCustomerID");
		((Control)j5B4()).set_Size(new Size(100, 20));
		((Control)j5B4()).set_TabIndex(51);
		((Control)b6H3()).set_Location(new Point(158, 124));
		((Control)b6H3()).set_Name("txtFirstName");
		((Control)b6H3()).set_Size(new Size(100, 20));
		((Control)b6H3()).set_TabIndex(52);
		((Control)Xd15()).set_Location(new Point(158, 156));
		((Control)Xd15()).set_Name("txtLastName");
		((Control)Xd15()).set_Size(new Size(100, 20));
		((Control)Xd15()).set_TabIndex(53);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)Xd15());
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)b6H3());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)j5B4());
		((Control)this).get_Controls().Add((Control)(object)Fb49());
		((Control)this).get_Controls().Add((Control)(object)Fr4n());
		((Control)this).get_Controls().Add((Control)(object)w1W2());
		((Control)this).get_Controls().Add((Control)(object)g3S0());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)Fr4n()).EndInit();
		((ISupportInitialize)w1W2()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Fb49()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9W0(Label r8JA)
	{
		_Label6 = r8JA;
	}

	[SpecialName]
	internal virtual PictureBox Fr4n()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4M2(PictureBox g9FQ)
	{
		PictureBox val = (N = g9FQ);
	}

	[SpecialName]
	internal virtual PictureBox w1W2()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3KQ(PictureBox d6J3)
	{
		_PictureBox1 = d6J3;
	}

	[SpecialName]
	internal virtual Button g3S0()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex98(Button a9BG)
	{
		EventHandler eventHandler = Rb5j;
		Button m = M;
		if (m != null)
		{
			((Control)m).remove_Click(eventHandler);
		}
		Button val = (M = a9BG);
		m = M;
		if (m != null)
		{
			((Control)m).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox j5B4()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb0x(TextBox As8k)
	{
		TextBox val = (J = As8k);
	}

	[SpecialName]
	internal virtual TextBox b6H3()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go87(TextBox g2H9)
	{
		TextBox val = (U = g2H9);
	}

	[SpecialName]
	internal virtual TextBox Xd15()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1D7(TextBox Mf4x)
	{
		TextBox val = (E = Mf4x);
	}

	private void Rb5j(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 2.accdb";
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand();
		val2.set_Connection(val);
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + j5B4().get_Text() + "','" + b6H3().get_Text() + "','" + Xd15().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)j5B4()).Clear();
		((TextBoxBase)b6H3()).Clear();
		((TextBoxBase)Xd15()).Clear();
		val.Close();
	}

	internal static bool Xn82(string St23)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(St23);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
