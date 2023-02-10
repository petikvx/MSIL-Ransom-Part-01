using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d6D;

namespace c5T;

[DesignerGenerated]
public class My5 : Form
{
	private SqlCommand cmd;

	private SqlConnection con;

	private SqlDataReader rd;

	private IContainer components;

	internal virtual Button Login
	{
		[CompilerGenerated]
		get
		{
			return _Login;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Cg3;
			Button login = _Login;
			if (login != null)
			{
				((Control)login).remove_Click(eventHandler);
			}
			_Login = value;
			login = _Login;
			if (login != null)
			{
				((Control)login).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Reset
	{
		[CompilerGenerated]
		get
		{
			return _Reset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o2M;
			Button reset = _Reset;
			if (reset != null)
			{
				((Control)reset).remove_Click(eventHandler);
			}
			_Reset = value;
			reset = _Reset;
			if (reset != null)
			{
				((Control)reset).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("UserName")]
	internal virtual Label UserName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Password")]
	internal virtual Label Password
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public My5()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		cmd = new SqlCommand();
		con = new SqlConnection();
		n4T();
	}

	private void Cg3(object Zj6, EventArgs Cy0)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\MANISH\\SOURCE\\REPOS\\APARTMENT-MANAGEMENT-SYSTEM2\\APART.MDF;Integrated Security=True");
			cmd.set_Connection(con);
			cmd.set_CommandText("Select * from [login] where UserName='" + TextBox1.get_Text() + "' and password='" + TextBox2.get_Text() + "'");
			con.Close();
			con.Open();
			rd = cmd.ExecuteReader();
			SqlDataReader val = rd;
			if (val.Read())
			{
				Interaction.MsgBox((object)"               Login Successfully ", (MsgBoxStyle)0, (object)null);
				((Control)b8G.Forms.Admin_Function).Show();
				((TextBoxBase)TextBox1).Clear();
				((TextBoxBase)TextBox2).Clear();
			}
			else
			{
				((TextBoxBase)TextBox1).Clear();
				((TextBoxBase)TextBox2).Clear();
				MessageBox.Show("Invalid Username or Password");
			}
			val = null;
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)"invalid access", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool Tr8()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string i2Q in array2)
				{
					if (!Fr4(i2Q))
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

	private void o2M(object i1B, EventArgs Qy8)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
	}

	internal static bool Fr4(string i2Q)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(i2Q);
			WebResponse response = webRequest.GetResponse();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	[DebuggerNonUserCode]
	protected override void Hp1(bool Wp7)
	{
		try
		{
			if (Wp7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wp7);
		}
	}

	[DebuggerStepThrough]
	private void n4T()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(My5));
		Login = new Button();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Reset = new Button();
		UserName = new Label();
		Password = new Label();
		Label3 = new Label();
		Panel1 = new Panel();
		Panel2 = new Panel();
		((Control)this).SuspendLayout();
		((ButtonBase)Login).set_BackColor(SystemColors.ControlLightLight);
		((Control)Login).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Login).set_Location(new Point(863, 253));
		((Control)Login).set_Name("Login");
		((Control)Login).set_Size(new Size(108, 36));
		((Control)Login).set_TabIndex(2);
		((ButtonBase)Login).set_Text("Login");
		((ButtonBase)Login).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Location(new Point(863, 120));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(263, 25));
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox2).set_Location(new Point(863, 184));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(263, 25));
		((Control)TextBox2).set_TabIndex(1);
		((ButtonBase)Reset).set_BackColor(SystemColors.ControlLightLight);
		((Control)Reset).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Reset).set_Location(new Point(1011, 253));
		((Control)Reset).set_Name("Reset");
		((Control)Reset).set_Size(new Size(115, 36));
		((Control)Reset).set_TabIndex(3);
		((ButtonBase)Reset).set_Text("Reset");
		((ButtonBase)Reset).set_UseVisualStyleBackColor(false);
		UserName.set_AutoSize(true);
		((Control)UserName).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UserName).set_Location(new Point(732, 120));
		((Control)UserName).set_Name("UserName");
		((Control)UserName).set_Size(new Size(110, 25));
		((Control)UserName).set_TabIndex(4);
		UserName.set_Text("User Name");
		Password.set_AutoSize(true);
		((Control)Password).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Password).set_Location(new Point(732, 184));
		((Control)Password).set_Name("Password");
		((Control)Password).set_Size(new Size(98, 25));
		((Control)Password).set_TabIndex(5);
		Password.set_Text("Password");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(857, 35));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(185, 32));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Admin Login");
		((Control)Panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Panel1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel1).set_Location(new Point(-66, -48));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(792, 775));
		((Control)Panel1).set_TabIndex(7);
		((Control)Panel2).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)Panel2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel2).set_Location(new Point(723, 309));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(424, 401));
		((Control)Panel2).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1147, 710));
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Password);
		((Control)this).get_Controls().Add((Control)(object)UserName);
		((Control)this).get_Controls().Add((Control)(object)Reset);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Login);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
