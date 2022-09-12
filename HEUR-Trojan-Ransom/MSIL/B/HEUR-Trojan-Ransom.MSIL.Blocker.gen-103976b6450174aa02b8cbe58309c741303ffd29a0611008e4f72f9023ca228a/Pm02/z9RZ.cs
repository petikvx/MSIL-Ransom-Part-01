using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Pm02;

[DesignerGenerated]
public class z9RZ : Form
{
	private Label _Label6;

	private Button _btnSave;

	private TextBox _txtCustomerID;

	private TextBox _txtLastName;

	internal IContainer q;

	internal PictureBox J;

	internal PictureBox v;

	internal TextBox X;

	public z9RZ()
	{
		y0F8();
	}

	protected override void Tw57(bool e5HB)
	{
		try
		{
			if (e5HB && q != null)
			{
				q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e5HB);
		}
	}

	private void y0F8()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(z9RZ));
		k2BX(new Label());
		j7TX(new PictureBox());
		Km78(new PictureBox());
		d1FD(new Button());
		Ax7w(new TextBox());
		Kr1k(new TextBox());
		k3PE(new TextBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		((ISupportInitialize)Ge70()).BeginInit();
		((ISupportInitialize)s7WT()).BeginInit();
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
		n3MC().set_AutoSize(true);
		((Control)n3MC()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n3MC()).set_ForeColor(SystemColors.ControlLight);
		((Control)n3MC()).set_Location(new Point(44, 15));
		((Control)n3MC()).set_Name("Label6");
		((Control)n3MC()).set_Size(new Size(214, 24));
		((Control)n3MC()).set_TabIndex(43);
		n3MC().set_Text("Create New Customer");
		((Control)Ge70()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Ge70()).set_Dock((DockStyle)2);
		((Control)Ge70()).set_Location(new Point(0, 259));
		((Control)Ge70()).set_Name("PictureBox2");
		((Control)Ge70()).set_Size(new Size(338, 57));
		Ge70().set_TabIndex(42);
		Ge70().set_TabStop(false);
		((Control)s7WT()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)s7WT()).set_Dock((DockStyle)1);
		((Control)s7WT()).set_Location(new Point(0, 0));
		((Control)s7WT()).set_Name("PictureBox1");
		((Control)s7WT()).set_Size(new Size(338, 50));
		s7WT().set_TabIndex(41);
		s7WT().set_TabStop(false);
		((ButtonBase)Mz7f()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Mz7f()).set_FlatStyle((FlatStyle)0);
		((Control)Mz7f()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Mz7f()).set_Location(new Point(120, 213));
		((Control)Mz7f()).set_Name("btnSave");
		((Control)Mz7f()).set_Size(new Size(84, 23));
		((Control)Mz7f()).set_TabIndex(50);
		((ButtonBase)Mz7f()).set_Text("Save ");
		((ButtonBase)Mz7f()).set_UseVisualStyleBackColor(true);
		((Control)Lt40()).set_Location(new Point(158, 88));
		((Control)Lt40()).set_Name("txtCustomerID");
		((Control)Lt40()).set_Size(new Size(100, 20));
		((Control)Lt40()).set_TabIndex(51);
		((Control)x0F8()).set_Location(new Point(158, 124));
		((Control)x0F8()).set_Name("txtFirstName");
		((Control)x0F8()).set_Size(new Size(100, 20));
		((Control)x0F8()).set_TabIndex(52);
		((Control)Tj87()).set_Location(new Point(158, 156));
		((Control)Tj87()).set_Name("txtLastName");
		((Control)Tj87()).set_Size(new Size(100, 20));
		((Control)Tj87()).set_TabIndex(53);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(338, 316));
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)Tj87());
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)x0F8());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)Lt40());
		((Control)this).get_Controls().Add((Control)(object)n3MC());
		((Control)this).get_Controls().Add((Control)(object)Ge70());
		((Control)this).get_Controls().Add((Control)(object)s7WT());
		((Control)this).get_Controls().Add((Control)(object)Mz7f());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddCustomer2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddCustomer");
		((ISupportInitialize)Ge70()).EndInit();
		((ISupportInitialize)s7WT()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label n3MC()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2BX(Label Zk3y)
	{
		_Label6 = Zk3y;
	}

	[SpecialName]
	internal virtual PictureBox Ge70()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7TX(PictureBox y1WL)
	{
		PictureBox val = (J = y1WL);
	}

	[SpecialName]
	internal virtual PictureBox s7WT()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Km78(PictureBox m2SW)
	{
		PictureBox val = (v = m2SW);
	}

	[SpecialName]
	internal virtual Button Mz7f()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1FD(Button Cy5e)
	{
		EventHandler eventHandler = Da62;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Cy5e;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Lt40()
	{
		return _txtCustomerID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ax7w(TextBox Hz29)
	{
		_txtCustomerID = Hz29;
	}

	[SpecialName]
	internal virtual TextBox x0F8()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kr1k(TextBox Xd8m)
	{
		TextBox val = (X = Xd8m);
	}

	[SpecialName]
	internal virtual TextBox Tj87()
	{
		return _txtLastName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3PE(TextBox z7S5)
	{
		_txtLastName = z7S5;
	}

	private void Da62(object sender, EventArgs e)
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
		string commandText = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" + Lt40().get_Text() + "','" + x0F8().get_Text() + "','" + Tj87().get_Text() + "' )";
		val2.set_CommandText(commandText);
		val2.ExecuteNonQuery();
		((TextBoxBase)Lt40()).Clear();
		((TextBoxBase)x0F8()).Clear();
		((TextBoxBase)Tj87()).Clear();
		val.Close();
	}

	internal static bool y4G6(string c7CM)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(c7CM);
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
