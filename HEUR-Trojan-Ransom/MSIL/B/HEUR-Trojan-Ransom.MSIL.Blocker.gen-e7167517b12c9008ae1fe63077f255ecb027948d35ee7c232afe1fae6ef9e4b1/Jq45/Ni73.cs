using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k2H;

namespace Jq45;

[DesignerGenerated]
public class Ni73 : Form
{
	private const string V1 = "Problem_Report";

	private const string V = "Problem_Report";

	private IContainer components;

	private static readonly Label to;

	private SqlConnection con;

	private SqlCommand cmd;

	private SqlDataAdapter wr;

	[field: AccessedThroughProperty("Logout")]
	internal virtual Button Logout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d7NP;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TenantID")]
	internal virtual Label TenantID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Name")]
	internal virtual Label Name
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

	[field: AccessedThroughProperty("Complaint")]
	internal virtual Label Complaint
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Date2")]
	internal virtual Label Date2
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

	[field: AccessedThroughProperty("tname")]
	internal virtual MaskedTextBox tname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("f_no")]
	internal virtual MaskedTextBox f_no
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
			EventHandler eventHandler = Ba4j;
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

	[field: AccessedThroughProperty("complain")]
	internal virtual ComboBox complain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ni73()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		con = new SqlConnection();
		cmd = new SqlCommand();
		k7EF();
	}

	[DebuggerNonUserCode]
	protected override void Cm92(bool f7QJ)
	{
		try
		{
			if (f7QJ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f7QJ);
		}
	}

	[DebuggerStepThrough]
	private void k7EF()
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		Logout = new Button();
		Back = new Button();
		TenantID = new Label();
		Name = new Label();
		FlatNumber = new Label();
		Complaint = new Label();
		Date2 = new Label();
		t_id = new MaskedTextBox();
		tname = new MaskedTextBox();
		f_no = new MaskedTextBox();
		Submit = new Button();
		complain = new ComboBox();
		DateTimePicker1 = new DateTimePicker();
		((Control)this).SuspendLayout();
		((Control)Logout).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Logout).set_Location(new Point(696, 131));
		((Control)Logout).set_Name("Logout");
		((Control)Logout).set_Size(new Size(122, 37));
		((Control)Logout).set_TabIndex(17);
		((ButtonBase)Logout).set_Text("Logout");
		((ButtonBase)Logout).set_UseVisualStyleBackColor(true);
		((Control)Back).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Back).set_Location(new Point(496, 131));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(122, 37));
		((Control)Back).set_TabIndex(16);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		TenantID.set_AutoSize(true);
		((Control)TenantID).set_Location(new Point(61, 131));
		((Control)TenantID).set_Name("TenantID");
		((Control)TenantID).set_Size(new Size(70, 17));
		((Control)TenantID).set_TabIndex(0);
		TenantID.set_Text("Tenant ID");
		Name.set_AutoSize(true);
		((Control)Name).set_Location(new Point(61, 198));
		((Control)Name).set_Name("Name");
		((Control)Name).set_Size(new Size(45, 17));
		((Control)Name).set_TabIndex(1);
		Name.set_Text("Name");
		FlatNumber.set_AutoSize(true);
		((Control)FlatNumber).set_Location(new Point(61, 247));
		((Control)FlatNumber).set_Name("FlatNumber");
		((Control)FlatNumber).set_Size(new Size(85, 17));
		((Control)FlatNumber).set_TabIndex(2);
		FlatNumber.set_Text("Flat Number");
		Complaint.set_AutoSize(true);
		((Control)Complaint).set_Location(new Point(61, 298));
		((Control)Complaint).set_Name("Complaint");
		((Control)Complaint).set_Size(new Size(70, 17));
		((Control)Complaint).set_TabIndex(3);
		Complaint.set_Text("Complaint");
		Date2.set_AutoSize(true);
		((Control)Date2).set_Location(new Point(61, 352));
		((Control)Date2).set_Name("Date2");
		((Control)Date2).set_Size(new Size(38, 17));
		((Control)Date2).set_TabIndex(4);
		Date2.set_Text("Date");
		((Control)t_id).set_Location(new Point(191, 126));
		((Control)t_id).set_Name("t_id");
		((Control)t_id).set_Size(new Size(183, 22));
		((Control)t_id).set_TabIndex(15);
		((Control)tname).set_Location(new Point(191, 193));
		((Control)tname).set_Name("tname");
		((Control)tname).set_Size(new Size(183, 22));
		((Control)tname).set_TabIndex(16);
		((Control)f_no).set_Location(new Point(191, 244));
		((Control)f_no).set_Name("f_no");
		((Control)f_no).set_Size(new Size(183, 22));
		((Control)f_no).set_TabIndex(17);
		((Control)Submit).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Submit).set_Location(new Point(585, 488));
		((Control)Submit).set_Name("Submit");
		((Control)Submit).set_Size(new Size(127, 42));
		((Control)Submit).set_TabIndex(15);
		((ButtonBase)Submit).set_Text("Submit");
		((ButtonBase)Submit).set_UseVisualStyleBackColor(true);
		((ListControl)complain).set_FormattingEnabled(true);
		complain.get_Items().AddRange(new object[3] { "Insufficiency of Water", "Road Damage", "Parking Camera Not Working" });
		((Control)complain).set_Location(new Point(191, 295));
		((Control)complain).set_Name("complain");
		((Control)complain).set_Size(new Size(183, 24));
		((Control)complain).set_TabIndex(22);
		((Control)DateTimePicker1).set_Location(new Point(191, 352));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(200, 22));
		((Control)DateTimePicker1).set_TabIndex(23);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(902, 642));
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)complain);
		((Control)this).get_Controls().Add((Control)(object)Submit);
		((Control)this).get_Controls().Add((Control)(object)f_no);
		((Control)this).get_Controls().Add((Control)(object)tname);
		((Control)this).get_Controls().Add((Control)(object)t_id);
		((Control)this).get_Controls().Add((Control)(object)Date2);
		((Control)this).get_Controls().Add((Control)(object)Complaint);
		((Control)this).get_Controls().Add((Control)(object)FlatNumber);
		((Control)this).get_Controls().Add((Control)(object)Name);
		((Control)this).get_Controls().Add((Control)(object)TenantID);
		((Control)this).get_Controls().Add((Control)(object)Logout);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Ba4j(object Wk4y, EventArgs b5H9)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
			cmd.set_Connection(con);
			cmd.set_CommandText(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)("insert into complain(tenantid,name,flatnumber,complain,date) values(" + t_id.get_Text() + ",'" + tname.get_Text() + "'," + f_no.get_Text() + ",'"), complain.get_SelectedItem()), (object)"','"), (object)DateTimePicker1.get_Value()), (object)"')")));
			con.Open();
			if (cmd.ExecuteNonQuery() == 1)
			{
				MessageBox.Show(" Added");
			}
			else
			{
				MessageBox.Show(" Not Added");
			}
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)"invalid cmd", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void d7NP(object f7W1, EventArgs p1BN)
	{
		((Form)this).Close();
	}

	internal static string[] b5A0()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Yw2.mDic["Ann"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}
}
