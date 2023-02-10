using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jq45;
using Mi5m;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d6D;
using k2H;

namespace Xk1r;

[DesignerGenerated]
public class Je96 : Form
{
	private IContainer components;

	private SqlConnection con;

	private SqlCommand cmd;

	private SqlDataAdapter wr;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox3")]
	internal virtual MaskedTextBox MaskedTextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox2")]
	internal virtual MaskedTextBox MaskedTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j4X9;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a9FN;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox1")]
	internal virtual MaskedTextBox MaskedTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton2")]
	internal virtual RadioButton RadioButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PaidPartially")]
	internal virtual RadioButton PaidPartially
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Je96()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Md43);
		con = new SqlConnection();
		cmd = new SqlCommand();
		e2L5();
	}

	[DebuggerNonUserCode]
	protected override void n6G2(bool Qt3j)
	{
		try
		{
			if (Qt3j && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qt3j);
		}
	}

	[DebuggerStepThrough]
	private void e2L5()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected O, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		Panel1 = new Panel();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		RadioButton2 = new RadioButton();
		PaidPartially = new RadioButton();
		MaskedTextBox3 = new MaskedTextBox();
		MaskedTextBox2 = new MaskedTextBox();
		Button2 = new Button();
		Button1 = new Button();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		Label4 = new Label();
		Label3 = new Label();
		ComboBox1 = new ComboBox();
		Label2 = new Label();
		Label1 = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(128, 64, 64));
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)RadioButton2);
		((Control)Panel1).get_Controls().Add((Control)(object)PaidPartially);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label10);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).get_Controls().Add((Control)(object)Label8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)Label6);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Location(new Point(1, 199));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(531, 513));
		((Control)Panel1).set_TabIndex(0);
		((Control)TextBox3).set_Location(new Point(175, 294));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(168, 22));
		((Control)TextBox3).set_TabIndex(25);
		((Control)TextBox2).set_Location(new Point(175, 254));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(168, 22));
		((Control)TextBox2).set_TabIndex(24);
		((Control)TextBox1).set_Location(new Point(175, 203));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(168, 22));
		((Control)TextBox1).set_TabIndex(23);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((Control)RadioButton2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)RadioButton2).set_Location(new Point(175, 381));
		((Control)RadioButton2).set_Name("RadioButton2");
		((Control)RadioButton2).set_Size(new Size(90, 21));
		((Control)RadioButton2).set_TabIndex(22);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("Paid Fully");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)PaidPartially).set_AutoSize(true);
		((Control)PaidPartially).set_ForeColor(SystemColors.ControlLightLight);
		((Control)PaidPartially).set_Location(new Point(296, 380));
		((Control)PaidPartially).set_Name("PaidPartially");
		((Control)PaidPartially).set_Size(new Size(111, 21));
		((Control)PaidPartially).set_TabIndex(21);
		PaidPartially.set_TabStop(true);
		((ButtonBase)PaidPartially).set_Text("Paid Partially");
		((ButtonBase)PaidPartially).set_UseVisualStyleBackColor(true);
		((Control)MaskedTextBox3).set_Location(new Point(175, 419));
		((Control)MaskedTextBox3).set_Name("MaskedTextBox3");
		((Control)MaskedTextBox3).set_Size(new Size(168, 22));
		((Control)MaskedTextBox3).set_TabIndex(20);
		((Control)MaskedTextBox2).set_Location(new Point(175, 342));
		((Control)MaskedTextBox2).set_Name("MaskedTextBox2");
		((Control)MaskedTextBox2).set_Size(new Size(168, 22));
		((Control)MaskedTextBox2).set_TabIndex(17);
		((Control)Button2).set_Location(new Point(260, 476));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(122, 34));
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Back");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(91, 476));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(122, 34));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Submit");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label10).set_Location(new Point(34, 419));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(49, 17));
		((Control)Label10).set_TabIndex(11);
		Label10.set_Text("Phone");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label9).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label9).set_Location(new Point(31, 381));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(107, 17));
		((Control)Label9).set_TabIndex(10);
		Label9.set_Text("Payment Status");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label8).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label8).set_Location(new Point(34, 342));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(90, 17));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Rent Amount");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label7).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label7).set_Location(new Point(34, 259));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(85, 17));
		((Control)Label7).set_TabIndex(8);
		Label7.set_Text("Flat Number");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label6).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label6).set_Location(new Point(37, 299));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(67, 17));
		((Control)Label6).set_TabIndex(7);
		Label6.set_Text("Flat Type");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label5).set_Location(new Point(31, 209));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(83, 17));
		((Control)Label5).set_TabIndex(6);
		Label5.set_Text("Block Name");
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(175, 141));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(168, 34));
		((Control)MaskedTextBox1).set_TabIndex(5);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label4).set_Location(new Point(37, 162));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(63, 17));
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("in Family");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label3).set_Location(new Point(34, 141));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(102, 17));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("No. of Persons");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(175, 84));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(168, 24));
		((Control)ComboBox1).set_TabIndex(2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label2).set_Location(new Point(184, 24));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(139, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Flat Occupier Details");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label1).set_Location(new Point(31, 87));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(70, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Tenant ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(936, 713));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("House_Entry");
		((Form)this).set_Text("House_Entry");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void a9FN(object d8ZS, EventArgs f9BM)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = default(string);
			if (RadioButton2.get_Checked())
			{
				text = ((ButtonBase)RadioButton2).get_Text();
			}
			else if (PaidPartially.get_Checked())
			{
				text = Conversions.ToString(PaidPartially.get_Checked());
			}
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
			cmd.set_Connection(con);
			cmd.set_CommandText("insert into houseentry(tenantID,NoofpersoninFamily,BlockNo,flatno,flattype,rentAmount,PaymentStatus,Phone) values(" + ComboBox1.get_Text() + "," + MaskedTextBox1.get_Text() + "," + TextBox1.get_Text() + "," + TextBox2.get_Text() + ",'" + TextBox3.get_Text() + "'," + MaskedTextBox2.get_Text() + ",'" + text + "'," + MaskedTextBox3.get_Text() + ")");
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void j4X9(object f2G3, EventArgs Lw86)
	{
		((Control)b8G.Forms.Admin_Function).Show();
		((Form)this).Close();
	}

	private void Md43(object e1HW, EventArgs s6YM)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
			cmd.set_Connection(con);
			cmd.set_CommandText("Select * from [tenant_login] ");
			con.Open();
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				ComboBox1.get_Items().Add(RuntimeHelpers.GetObjectValue(rd.get_Item("tenant_id")));
			}
			rd.Close();
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)"invalid command", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static string[] Cx26()
	{
		z5B9.Qb3y();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Yw2.mDic.Add("Ann", value);
		return Ni73.b5A0();
	}
}
