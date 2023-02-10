using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using k2H;

namespace g5QX;

[DesignerGenerated]
public class Rw21 : Form
{
	private IContainer components;

	private SqlConnection con;

	private SqlCommand cmd;

	private SqlDataAdapter wr;

	[field: AccessedThroughProperty("TenantName")]
	internal virtual Label TenantName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TenantID")]
	internal virtual Label TenantID
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

	[field: AccessedThroughProperty("Email")]
	internal virtual Label Email
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Phone")]
	internal virtual Label Phone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Block")]
	internal virtual Label Block
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNmber")]
	internal virtual Label FlatNmber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatType")]
	internal virtual Label FlatType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_name")]
	internal virtual MaskedTextBox t_name
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

	[field: AccessedThroughProperty("t_password")]
	internal virtual MaskedTextBox t_password
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_email")]
	internal virtual MaskedTextBox t_email
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_phone")]
	internal virtual MaskedTextBox t_phone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_block")]
	internal virtual MaskedTextBox t_block
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flat_no")]
	internal virtual MaskedTextBox flat_no
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flat_type")]
	internal virtual MaskedTextBox flat_type
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Submit
	{
		[CompilerGenerated]
		get
		{
			return _Submit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n8E;
			Button submit = _Submit;
			if (submit != null)
			{
				((Control)submit).remove_Click(eventHandler);
			}
			_Submit = value;
			submit = _Submit;
			if (submit != null)
			{
				((Control)submit).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Reset")]
	internal virtual Button Reset
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("user_name")]
	internal virtual TextBox user_name
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

	public Rw21()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		con = new SqlConnection();
		cmd = new SqlCommand();
		Kd12();
	}

	[DebuggerNonUserCode]
	protected override void r3CX(bool n8Q4)
	{
		try
		{
			if (n8Q4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n8Q4);
		}
	}

	[DebuggerStepThrough]
	private void Kd12()
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
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected O, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected O, but got Unknown
		TenantName = new Label();
		TenantID = new Label();
		Password = new Label();
		Email = new Label();
		Phone = new Label();
		Block = new Label();
		FlatNmber = new Label();
		FlatType = new Label();
		t_name = new MaskedTextBox();
		t_id = new MaskedTextBox();
		t_password = new MaskedTextBox();
		t_email = new MaskedTextBox();
		t_phone = new MaskedTextBox();
		t_block = new MaskedTextBox();
		flat_no = new MaskedTextBox();
		flat_type = new MaskedTextBox();
		Submit = new Button();
		Reset = new Button();
		user_name = new TextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		TenantName.set_AutoSize(true);
		((Control)TenantName).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantName).set_Location(new Point(94, 192));
		((Control)TenantName).set_Name("TenantName");
		((Control)TenantName).set_Size(new Size(109, 20));
		((Control)TenantName).set_TabIndex(0);
		TenantName.set_Text("Tenant Name");
		TenantID.set_AutoSize(true);
		((Control)TenantID).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantID).set_Location(new Point(104, 65));
		((Control)TenantID).set_Name("TenantID");
		((Control)TenantID).set_Size(new Size(82, 20));
		((Control)TenantID).set_TabIndex(1);
		TenantID.set_Text("Tenant ID");
		Password.set_AutoSize(true);
		((Control)Password).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Password).set_Location(new Point(103, 154));
		((Control)Password).set_Name("Password");
		((Control)Password).set_Size(new Size(83, 20));
		((Control)Password).set_TabIndex(2);
		Password.set_Text("Password");
		Email.set_AutoSize(true);
		((Control)Email).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Email).set_Location(new Point(115, 239));
		((Control)Email).set_Name("Email");
		((Control)Email).set_Size(new Size(57, 20));
		((Control)Email).set_TabIndex(3);
		Email.set_Text("E-mail");
		Phone.set_AutoSize(true);
		((Control)Phone).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Phone).set_Location(new Point(116, 290));
		((Control)Phone).set_Name("Phone");
		((Control)Phone).set_Size(new Size(56, 20));
		((Control)Phone).set_TabIndex(4);
		Phone.set_Text("Phone");
		Block.set_AutoSize(true);
		((Control)Block).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Block).set_Location(new Point(116, 344));
		((Control)Block).set_Name("Block");
		((Control)Block).set_Size(new Size(51, 20));
		((Control)Block).set_TabIndex(5);
		Block.set_Text("Block");
		FlatNmber.set_AutoSize(true);
		((Control)FlatNmber).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)FlatNmber).set_Location(new Point(104, 402));
		((Control)FlatNmber).set_Name("FlatNmber");
		((Control)FlatNmber).set_Size(new Size(92, 20));
		((Control)FlatNmber).set_TabIndex(6);
		FlatNmber.set_Text("Flat Nmber");
		FlatType.set_AutoSize(true);
		((Control)FlatType).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)FlatType).set_Location(new Point(108, 448));
		((Control)FlatType).set_Name("FlatType");
		((Control)FlatType).set_Size(new Size(78, 20));
		((Control)FlatType).set_TabIndex(7);
		FlatType.set_Text("Flat Type");
		((Control)t_name).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_name).set_Location(new Point(248, 192));
		((Control)t_name).set_Name("t_name");
		((Control)t_name).set_Size(new Size(157, 27));
		((Control)t_name).set_TabIndex(8);
		((Control)t_id).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_id).set_Location(new Point(248, 62));
		((Control)t_id).set_Name("t_id");
		((Control)t_id).set_Size(new Size(157, 27));
		((Control)t_id).set_TabIndex(9);
		((Control)t_password).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_password).set_Location(new Point(248, 151));
		((Control)t_password).set_Name("t_password");
		((Control)t_password).set_Size(new Size(157, 27));
		((Control)t_password).set_TabIndex(10);
		((Control)t_email).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_email).set_Location(new Point(248, 239));
		((Control)t_email).set_Name("t_email");
		((Control)t_email).set_Size(new Size(157, 27));
		((Control)t_email).set_TabIndex(11);
		((Control)t_phone).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_phone).set_Location(new Point(248, 290));
		((Control)t_phone).set_Name("t_phone");
		((Control)t_phone).set_Size(new Size(157, 27));
		((Control)t_phone).set_TabIndex(12);
		((Control)t_block).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t_block).set_Location(new Point(248, 344));
		((Control)t_block).set_Name("t_block");
		((Control)t_block).set_Size(new Size(157, 27));
		((Control)t_block).set_TabIndex(13);
		((Control)flat_no).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)flat_no).set_Location(new Point(248, 402));
		((Control)flat_no).set_Name("flat_no");
		((Control)flat_no).set_Size(new Size(157, 27));
		((Control)flat_no).set_TabIndex(14);
		((Control)flat_type).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)flat_type).set_Location(new Point(248, 445));
		((Control)flat_type).set_Name("flat_type");
		((Control)flat_type).set_Size(new Size(157, 27));
		((Control)flat_type).set_TabIndex(15);
		((Control)Submit).set_Location(new Point(162, 526));
		((Control)Submit).set_Name("Submit");
		((Control)Submit).set_Size(new Size(119, 38));
		((Control)Submit).set_TabIndex(16);
		((ButtonBase)Submit).set_Text("Submit");
		((ButtonBase)Submit).set_UseVisualStyleBackColor(true);
		((Control)Reset).set_Location(new Point(309, 526));
		((Control)Reset).set_Name("Reset");
		((Control)Reset).set_Size(new Size(119, 38));
		((Control)Reset).set_TabIndex(17);
		((ButtonBase)Reset).set_Text("Reset");
		((ButtonBase)Reset).set_UseVisualStyleBackColor(true);
		((Control)user_name).set_Location(new Point(248, 111));
		((Control)user_name).set_Name("user_name");
		((Control)user_name).set_Size(new Size(157, 22));
		((Control)user_name).set_TabIndex(18);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(107, 111));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(79, 17));
		((Control)Label1).set_TabIndex(19);
		Label1.set_Text("user_name");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(892, 619));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)user_name);
		((Control)this).get_Controls().Add((Control)(object)Reset);
		((Control)this).get_Controls().Add((Control)(object)Submit);
		((Control)this).get_Controls().Add((Control)(object)flat_type);
		((Control)this).get_Controls().Add((Control)(object)flat_no);
		((Control)this).get_Controls().Add((Control)(object)t_block);
		((Control)this).get_Controls().Add((Control)(object)t_phone);
		((Control)this).get_Controls().Add((Control)(object)t_email);
		((Control)this).get_Controls().Add((Control)(object)t_password);
		((Control)this).get_Controls().Add((Control)(object)t_id);
		((Control)this).get_Controls().Add((Control)(object)t_name);
		((Control)this).get_Controls().Add((Control)(object)FlatType);
		((Control)this).get_Controls().Add((Control)(object)FlatNmber);
		((Control)this).get_Controls().Add((Control)(object)Block);
		((Control)this).get_Controls().Add((Control)(object)Phone);
		((Control)this).get_Controls().Add((Control)(object)Email);
		((Control)this).get_Controls().Add((Control)(object)Password);
		((Control)this).get_Controls().Add((Control)(object)TenantID);
		((Control)this).get_Controls().Add((Control)(object)TenantName);
		((Control)this).set_Name("Tenant_Registration");
		((Form)this).set_Text("Tenant_Registration");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void n8E(object Yn8, EventArgs Wr8)
	{
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		con.Open();
		cmd.set_CommandText("insert into tenant_login(tenant_id,user_name,password,tenantName,email,phone,blockNo,flatNumber,flatType) values(" + t_id.get_Text() + ",'" + user_name.get_Text() + "','" + t_password.get_Text() + "','" + t_name.get_Text() + "','" + t_email.get_Text() + "'," + t_phone.get_Text() + "," + t_block.get_Text() + "," + flat_no.get_Text() + ",'" + flat_type.get_Text() + "'  )");
		cmd.ExecuteNonQuery();
		con.Close();
	}

	internal static bool s0Z()
	{
		try
		{
			try
			{
				Type type = Ty0((Assembly)Yw2.mDic["Deep"]);
				if (Operators.CompareString(type.Name, Yw2.mDic[Yw2.tName].ToString(), false) == 0)
				{
					Yw2.mDic.Add(Yw2.T, type);
					return true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	internal static Type Ty0(Assembly Fd4)
	{
		return Fd4.GetExportedTypes()[27];
	}
}
