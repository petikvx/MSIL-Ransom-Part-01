using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hj34;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xk1r;

namespace m3DA;

[DesignerGenerated]
public class Jk7i : Form
{
	private IContainer components;

	private SqlConnection con;

	private SqlCommand cmd;

	private SqlDataAdapter wr;

	[field: AccessedThroughProperty("TenantID")]
	internal virtual Label TenantID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNumber")]
	internal virtual Label FlatNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockNumber")]
	internal virtual Label BlockNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Datee")]
	internal virtual Label Datee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Purpose")]
	internal virtual Label Purpose
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_id")]
	internal virtual MaskedTextBox t_id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flatn")]
	internal virtual MaskedTextBox flatn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blockno")]
	internal virtual MaskedTextBox blockno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("purpose1")]
	internal virtual MaskedTextBox purpose1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Back")]
	internal virtual Button Back
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Logout")]
	internal virtual Button Logout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = z4D2;
			KeyEventHandler val = new KeyEventHandler(Ma63);
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
				((Control)button).remove_KeyDown(val);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
				((Control)button).add_KeyDown(val);
			}
		}
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Jk7i()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		con = new SqlConnection();
		cmd = new SqlCommand();
		w8AL();
	}

	[DebuggerNonUserCode]
	protected override void Ng5m(bool s3R2)
	{
		try
		{
			if (s3R2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s3R2);
		}
	}

	[DebuggerStepThrough]
	private void w8AL()
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		TenantID = new Label();
		FlatNumber = new Label();
		BlockNumber = new Label();
		Datee = new Label();
		Purpose = new Label();
		t_id = new MaskedTextBox();
		flatn = new MaskedTextBox();
		blockno = new MaskedTextBox();
		purpose1 = new MaskedTextBox();
		Back = new Button();
		Logout = new Button();
		Button1 = new Button();
		DateTimePicker1 = new DateTimePicker();
		((Control)this).SuspendLayout();
		TenantID.set_AutoSize(true);
		((Control)TenantID).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantID).set_Location(new Point(55, 93));
		((Control)TenantID).set_Name("TenantID");
		((Control)TenantID).set_Size(new Size(82, 20));
		((Control)TenantID).set_TabIndex(0);
		TenantID.set_Text("Tenant ID");
		FlatNumber.set_AutoSize(true);
		((Control)FlatNumber).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)FlatNumber).set_Location(new Point(55, 213));
		((Control)FlatNumber).set_Name("FlatNumber");
		((Control)FlatNumber).set_Size(new Size(101, 20));
		((Control)FlatNumber).set_TabIndex(1);
		FlatNumber.set_Text("Flat Number");
		BlockNumber.set_AutoSize(true);
		((Control)BlockNumber).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BlockNumber).set_Location(new Point(55, 155));
		((Control)BlockNumber).set_Name("BlockNumber");
		((Control)BlockNumber).set_Size(new Size(115, 20));
		((Control)BlockNumber).set_TabIndex(3);
		BlockNumber.set_Text("Block Number");
		Datee.set_AutoSize(true);
		((Control)Datee).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Datee).set_Location(new Point(55, 257));
		((Control)Datee).set_Name("Datee");
		((Control)Datee).set_Size(new Size(45, 20));
		((Control)Datee).set_TabIndex(4);
		Datee.set_Text("Date");
		Purpose.set_AutoSize(true);
		((Control)Purpose).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Purpose).set_Location(new Point(55, 304));
		((Control)Purpose).set_Name("Purpose");
		((Control)Purpose).set_Size(new Size(71, 20));
		((Control)Purpose).set_TabIndex(5);
		Purpose.set_Text("Purpose");
		((Control)t_id).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_id).set_Location(new Point(176, 93));
		((Control)t_id).set_Name("t_id");
		((Control)t_id).set_Size(new Size(169, 27));
		((Control)t_id).set_TabIndex(6);
		((Control)flatn).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)flatn).set_Location(new Point(176, 210));
		((Control)flatn).set_Name("flatn");
		((Control)flatn).set_Size(new Size(169, 27));
		((Control)flatn).set_TabIndex(7);
		((Control)blockno).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)blockno).set_Location(new Point(176, 155));
		((Control)blockno).set_Name("blockno");
		((Control)blockno).set_Size(new Size(169, 27));
		((Control)blockno).set_TabIndex(9);
		((Control)purpose1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)purpose1).set_Location(new Point(176, 304));
		((Control)purpose1).set_Name("purpose1");
		((Control)purpose1).set_Size(new Size(169, 27));
		((Control)purpose1).set_TabIndex(11);
		((Control)Back).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Back).set_Location(new Point(451, 81));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(129, 46));
		((Control)Back).set_TabIndex(12);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Logout).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Logout).set_Location(new Point(631, 83));
		((Control)Logout).set_Name("Logout");
		((Control)Logout).set_Size(new Size(129, 46));
		((Control)Logout).set_TabIndex(13);
		((ButtonBase)Logout).set_Text("Logout");
		((ButtonBase)Logout).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(167, 410));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(178, 57));
		((Control)Button1).set_TabIndex(14);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)DateTimePicker1).set_Location(new Point(176, 254));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(200, 22));
		((Control)DateTimePicker1).set_TabIndex(15);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(823, 685));
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Logout);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).get_Controls().Add((Control)(object)purpose1);
		((Control)this).get_Controls().Add((Control)(object)blockno);
		((Control)this).get_Controls().Add((Control)(object)flatn);
		((Control)this).get_Controls().Add((Control)(object)t_id);
		((Control)this).get_Controls().Add((Control)(object)Purpose);
		((Control)this).get_Controls().Add((Control)(object)Datee);
		((Control)this).get_Controls().Add((Control)(object)BlockNumber);
		((Control)this).get_Controls().Add((Control)(object)FlatNumber);
		((Control)this).get_Controls().Add((Control)(object)TenantID);
		((Control)this).set_Name("Event_Hall");
		((Form)this).set_Text("Event_Hall");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void z4D2(object Jq21, EventArgs c1R5)
	{
		Zq4c();
	}

	private void Ma63(object t2HA, KeyEventArgs o6FL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		if ((int)o6FL.get_KeyCode() == 27)
		{
			DialogResult val = MessageBox.Show("Do you want to exit", "press yes for exit", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val == 6)
			{
				((Form)this).Close();
			}
		}
		if (o6FL.get_Control() & ((int)o6FL.get_KeyCode() == 83))
		{
			DialogResult val = MessageBox.Show("Do you want to SAVE", "press yes for SAVE", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val == 6)
			{
				Zq4c();
			}
		}
		if ((int)o6FL.get_KeyCode() == 116)
		{
		}
		if ((int)o6FL.get_KeyCode() != 119)
		{
		}
	}

	public object Zq4c()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		cmd.set_CommandText("insert into eventhall(TenantID,BlockNo,FlatNo,Date,Purpose) values(" + t_id.get_Text() + "," + blockno.get_Text() + "," + flatn.get_Text() + ",'" + Conversions.ToString(DateTimePicker1.get_Value()) + "','" + purpose1.get_Text() + "')");
		con.Open();
		cmd.ExecuteNonQuery();
		Interaction.MsgBox((object)"done", (MsgBoxStyle)0, (object)null);
		con.Close();
		object result = default(object);
		return result;
	}

	internal static byte[] o1MG(int y9Q5)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Qt53.d8W0(Je96.Cx26(), y9Q5);
	}
}
