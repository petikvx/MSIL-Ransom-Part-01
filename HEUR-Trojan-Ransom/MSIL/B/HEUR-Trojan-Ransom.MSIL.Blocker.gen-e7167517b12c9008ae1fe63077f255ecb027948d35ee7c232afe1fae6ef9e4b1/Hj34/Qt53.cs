using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d6D;
using k2H;

namespace Hj34;

[DesignerGenerated]
public class Qt53 : Form
{
	private IContainer components;

	private SqlConnection con;

	private SqlCommand cmd;

	private SqlDataAdapter wr;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mg1z;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectionChangeCommitted(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectionChangeCommitted(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PAY
	{
		[CompilerGenerated]
		get
		{
			return _PAY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rg2s;
			Button pAY = _PAY;
			if (pAY != null)
			{
				((Control)pAY).remove_Click(eventHandler);
			}
			_PAY = value;
			pAY = _PAY;
			if (pAY != null)
			{
				((Control)pAY).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Decline")]
	internal virtual Button Decline
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

	[field: AccessedThroughProperty("ComboBox5")]
	internal virtual ComboBox ComboBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Date3")]
	internal virtual Label Date3
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

	[field: AccessedThroughProperty("MaskedTextBox5")]
	internal virtual MaskedTextBox MaskedTextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PinNumber")]
	internal virtual Label PinNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox4")]
	internal virtual MaskedTextBox MaskedTextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CardNumber")]
	internal virtual Label CardNumber
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
			EventHandler eventHandler = t7E3;
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flatNumber")]
	internal virtual TextBox flatNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flattype")]
	internal virtual TextBox flattype
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("b_name")]
	internal virtual TextBox b_name
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
			EventHandler eventHandler = Eb3g;
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

	public Qt53()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)f7Q4);
		con = new SqlConnection();
		cmd = new SqlCommand();
		y5SN();
	}

	[DebuggerNonUserCode]
	protected override void Yn73(bool z8PT)
	{
		try
		{
			if (z8PT && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z8PT);
		}
	}

	[DebuggerStepThrough]
	private void y5SN()
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
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected O, but got Unknown
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		ComboBox1 = new ComboBox();
		Label3 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label10 = new Label();
		PAY = new Button();
		Decline = new Button();
		MaskedTextBox3 = new MaskedTextBox();
		ComboBox5 = new ComboBox();
		Date3 = new Label();
		Panel1 = new Panel();
		DateTimePicker1 = new DateTimePicker();
		flatNumber = new TextBox();
		flattype = new TextBox();
		b_name = new TextBox();
		Panel2 = new Panel();
		Submit = new Button();
		CardNumber = new Label();
		MaskedTextBox5 = new MaskedTextBox();
		MaskedTextBox4 = new MaskedTextBox();
		PinNumber = new Label();
		Button1 = new Button();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label1).set_Location(new Point(31, 87));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(70, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Tenant ID");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label2).set_Location(new Point(180, 18));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(85, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Rent Details");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(175, 84));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(168, 24));
		((Control)ComboBox1).set_TabIndex(2);
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label3).set_Location(new Point(34, 149));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(45, 17));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Name");
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(175, 141));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(168, 28));
		((Control)MaskedTextBox1).set_TabIndex(5);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label5).set_Location(new Point(31, 209));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(83, 17));
		((Control)Label5).set_TabIndex(6);
		Label5.set_Text("Block Name");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label6).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label6).set_Location(new Point(34, 255));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(67, 17));
		((Control)Label6).set_TabIndex(7);
		Label6.set_Text("Flat Type");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label7).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label7).set_Location(new Point(34, 298));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(85, 17));
		((Control)Label7).set_TabIndex(8);
		Label7.set_Text("Flat Number");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label8).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label8).set_Location(new Point(34, 451));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(90, 17));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Rent Amount");
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label10).set_Location(new Point(34, 349));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(49, 17));
		((Control)Label10).set_TabIndex(11);
		Label10.set_Text("Phone");
		((Control)PAY).set_Location(new Point(53, 518));
		((Control)PAY).set_Name("PAY");
		((Control)PAY).set_Size(new Size(122, 34));
		((Control)PAY).set_TabIndex(12);
		((ButtonBase)PAY).set_Text("PAY");
		((ButtonBase)PAY).set_UseVisualStyleBackColor(true);
		((Control)Decline).set_Location(new Point(219, 518));
		((Control)Decline).set_Name("Decline");
		((Control)Decline).set_Size(new Size(122, 34));
		((Control)Decline).set_TabIndex(13);
		((ButtonBase)Decline).set_Text("Decline");
		((ButtonBase)Decline).set_UseVisualStyleBackColor(true);
		((Control)MaskedTextBox3).set_Location(new Point(175, 349));
		((Control)MaskedTextBox3).set_Name("MaskedTextBox3");
		((Control)MaskedTextBox3).set_Size(new Size(168, 22));
		((Control)MaskedTextBox3).set_TabIndex(20);
		((ListControl)ComboBox5).set_FormattingEnabled(true);
		ComboBox5.get_Items().AddRange(new object[3] { "5000", "10000", "15000" });
		((Control)ComboBox5).set_Location(new Point(175, 451));
		((Control)ComboBox5).set_Name("ComboBox5");
		((Control)ComboBox5).set_Size(new Size(168, 24));
		((Control)ComboBox5).set_TabIndex(23);
		Date3.set_AutoSize(true);
		((Control)Date3).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Date3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Date3).set_Location(new Point(34, 402));
		((Control)Date3).set_Name("Date3");
		((Control)Date3).set_Size(new Size(38, 17));
		((Control)Date3).set_TabIndex(24);
		Date3.set_Text("Date");
		((Control)Panel1).set_BackColor(Color.FromArgb(128, 64, 64));
		((Control)Panel1).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)Panel1).get_Controls().Add((Control)(object)flatNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)flattype);
		((Control)Panel1).get_Controls().Add((Control)(object)b_name);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)Date3);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox5);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)Decline);
		((Control)Panel1).get_Controls().Add((Control)(object)PAY);
		((Control)Panel1).get_Controls().Add((Control)(object)Label10);
		((Control)Panel1).get_Controls().Add((Control)(object)Label8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)Label6);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Location(new Point(3, 1));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(411, 748));
		((Control)Panel1).set_TabIndex(1);
		((Control)DateTimePicker1).set_Location(new Point(156, 398));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(200, 22));
		((Control)DateTimePicker1).set_TabIndex(2);
		((Control)flatNumber).set_Location(new Point(173, 298));
		((Control)flatNumber).set_Name("flatNumber");
		((Control)flatNumber).set_Size(new Size(168, 22));
		((Control)flatNumber).set_TabIndex(29);
		((Control)flattype).set_Location(new Point(173, 250));
		((Control)flattype).set_Name("flattype");
		((Control)flattype).set_Size(new Size(168, 22));
		((Control)flattype).set_TabIndex(28);
		((Control)b_name).set_Location(new Point(175, 203));
		((Control)b_name).set_Name("b_name");
		((Control)b_name).set_Size(new Size(168, 22));
		((Control)b_name).set_TabIndex(27);
		((Control)Panel2).get_Controls().Add((Control)(object)Submit);
		((Control)Panel2).get_Controls().Add((Control)(object)CardNumber);
		((Control)Panel2).get_Controls().Add((Control)(object)MaskedTextBox5);
		((Control)Panel2).get_Controls().Add((Control)(object)MaskedTextBox4);
		((Control)Panel2).get_Controls().Add((Control)(object)PinNumber);
		((Control)Panel2).set_Location(new Point(24, 568));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(361, 161));
		((Control)Panel2).set_TabIndex(26);
		((Control)Submit).set_Location(new Point(105, 122));
		((Control)Submit).set_Name("Submit");
		((Control)Submit).set_Size(new Size(122, 34));
		((Control)Submit).set_TabIndex(30);
		((ButtonBase)Submit).set_Text("Submit");
		((ButtonBase)Submit).set_UseVisualStyleBackColor(true);
		CardNumber.set_AutoSize(true);
		((Control)CardNumber).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)CardNumber).set_ForeColor(SystemColors.ControlLightLight);
		((Control)CardNumber).set_Location(new Point(10, 12));
		((Control)CardNumber).set_Name("CardNumber");
		((Control)CardNumber).set_Size(new Size(92, 17));
		((Control)CardNumber).set_TabIndex(26);
		CardNumber.set_Text("Card Number");
		((Control)MaskedTextBox5).set_Location(new Point(154, 65));
		((Control)MaskedTextBox5).set_Name("MaskedTextBox5");
		((Control)MaskedTextBox5).set_Size(new Size(178, 22));
		((Control)MaskedTextBox5).set_TabIndex(29);
		((Control)MaskedTextBox4).set_Location(new Point(154, 12));
		((Control)MaskedTextBox4).set_Name("MaskedTextBox4");
		((Control)MaskedTextBox4).set_Size(new Size(178, 22));
		((Control)MaskedTextBox4).set_TabIndex(27);
		PinNumber.set_AutoSize(true);
		((Control)PinNumber).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)PinNumber).set_ForeColor(SystemColors.ControlLightLight);
		((Control)PinNumber).set_Location(new Point(13, 67));
		((Control)PinNumber).set_Name("PinNumber");
		((Control)PinNumber).set_Size(new Size(82, 17));
		((Control)PinNumber).set_TabIndex(28);
		PinNumber.set_Text("Pin Number");
		((Control)Button1).set_Location(new Point(583, 210));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(236, 84));
		((Control)Button1).set_TabIndex(26);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(913, 751));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Flat_Rent");
		((Form)this).set_Text("Flat_Rent");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void t7E3(object Qz48, EventArgs Wp0b)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		con.Open();
		cmd.set_CommandText(" insert into RentDetails(tenantId,name,blockNumber,flatType,flatNumber,phone,date,rentAmount)values(@tenantId,@name,@blockNumber,@flatType,@flatNumber,@phone,@date,@rentAmout )");
		cmd.get_Parameters().Add("@tenantId", SqlDbType.Int).set_Value((object)ComboBox1.get_Text());
		cmd.get_Parameters().Add("@name", SqlDbType.VarChar).set_Value((object)MaskedTextBox1.get_Text());
		cmd.get_Parameters().Add("@blockNumber", SqlDbType.Int).set_Value((object)b_name.get_Text());
		cmd.get_Parameters().Add("@flatType", SqlDbType.VarChar).set_Value((object)flattype.get_Text());
		cmd.get_Parameters().Add("@flatNumber", SqlDbType.Int).set_Value((object)flatNumber.get_Text());
		cmd.get_Parameters().Add("@phone", SqlDbType.Int).set_Value((object)MaskedTextBox3.get_Text());
		cmd.get_Parameters().Add("@date", SqlDbType.Date).set_Value((object)DateTimePicker1.get_Value());
		cmd.get_Parameters().Add("@rentAmout", SqlDbType.Int).set_Value((object)ComboBox5.get_Text());
		con.Close();
		Interaction.MsgBox((object)"done", (MsgBoxStyle)0, (object)null);
		ComboBox1.set_SelectedIndex(0);
		((TextBoxBase)MaskedTextBox1).Clear();
		((TextBoxBase)b_name).Clear();
		((TextBoxBase)flattype).Clear();
		((TextBoxBase)flatNumber).Clear();
		((TextBoxBase)MaskedTextBox3).Clear();
		ComboBox5.set_SelectedIndex(0);
	}

	private void f7Q4(object g9Z7, EventArgs e3J2)
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
		((Control)Panel2).Hide();
	}

	private void Mg1z(object Zp4j, EventArgs e5AN)
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		cmd.set_CommandText("Select * from [tenant_login] where tenant_id = " + ComboBox1.get_SelectedItem().ToString() + " ");
		con.Open();
		rd = cmd.ExecuteReader();
		SqlDataReader val = rd;
		if (val.Read())
		{
			MaskedTextBox1.set_Text(Conversions.ToString(rd.get_Item("tenantName")));
			b_name.set_Text(Conversions.ToString(rd.get_Item("blockNo")));
			flattype.set_Text(Conversions.ToString(rd.get_Item("flatType")));
			flatNumber.set_Text(Conversions.ToString(rd.get_Item("flatNumber")));
			MaskedTextBox3.set_Text(Conversions.ToString(rd.get_Item("phone")));
		}
		else
		{
			MessageBox.Show("Invalid");
		}
		val = null;
		con.Close();
	}

	private void Rg2s(object e5XQ, EventArgs Fs85)
	{
		((Control)Panel2).Show();
	}

	private void Eb3g(object Mx58, EventArgs Gm7o)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Admin_Function).Show();
	}

	internal static byte[] d8W0(string[] e0HC, int Nn4m)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[e0HC.Length - 1 + 1];
				int num = e0HC.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = e0HC[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Yw2.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("UIO", CultureInfo.CurrentUICulture);
						if (array3.Length != Nn4m)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
