using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fw80;
using Ga80;
using Microsoft.VisualBasic.CompilerServices;

namespace Xb2p;

[DesignerGenerated]
public class Re53 : Form
{
	private IContainer components;

	private OleDbConnection connection;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("pick")]
	internal virtual DateTimePicker pick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("quantity")]
	internal virtual TextBox quantity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rate")]
	internal virtual TextBox rate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("input")]
	internal virtual TextBox input
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button upda
	{
		[CompilerGenerated]
		get
		{
			return _upda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = q9H6;
			Button val = _upda;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_upda = value;
			val = _upda;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
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
			EventHandler eventHandler = o2F7;
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
			EventHandler eventHandler = b6Q9;
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

	public Re53()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)z5FX);
		connection = new OleDbConnection();
		i7N8();
	}

	[DebuggerNonUserCode]
	protected override void Fo7c(bool Rj45)
	{
		try
		{
			if (Rj45 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rj45);
		}
	}

	[DebuggerStepThrough]
	private void i7N8()
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
		GroupBox1 = new GroupBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		pick = new DateTimePicker();
		quantity = new TextBox();
		rate = new TextBox();
		input = new TextBox();
		id = new TextBox();
		upda = new Button();
		Button1 = new Button();
		Button2 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)pick);
		((Control)GroupBox1).get_Controls().Add((Control)(object)quantity);
		((Control)GroupBox1).get_Controls().Add((Control)(object)rate);
		((Control)GroupBox1).get_Controls().Add((Control)(object)input);
		((Control)GroupBox1).get_Controls().Add((Control)(object)id);
		((Control)GroupBox1).set_Location(new Point(22, 27));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(402, 297));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Update");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(6, 227));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(92, 17));
		((Control)Label5).set_TabIndex(21);
		Label5.set_Text("Expiry Before");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(37, 184));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(61, 17));
		((Control)Label4).set_TabIndex(20);
		Label4.set_Text("Quantity");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(60, 143));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(38, 17));
		((Control)Label3).set_TabIndex(19);
		Label3.set_Text("Rate");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(53, 105));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(45, 17));
		((Control)Label2).set_TabIndex(18);
		Label2.set_Text("Name");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(70, 61));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(28, 17));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Eid");
		((Control)pick).set_Location(new Point(127, 222));
		((Control)pick).set_Name("pick");
		((Control)pick).set_Size(new Size(249, 22));
		((Control)pick).set_TabIndex(16);
		((Control)quantity).set_Location(new Point(127, 184));
		((Control)quantity).set_Name("quantity");
		((Control)quantity).set_Size(new Size(249, 22));
		((Control)quantity).set_TabIndex(15);
		((Control)rate).set_Location(new Point(127, 143));
		((Control)rate).set_Name("rate");
		((Control)rate).set_Size(new Size(249, 22));
		((Control)rate).set_TabIndex(14);
		((Control)input).set_Location(new Point(127, 105));
		((Control)input).set_Name("input");
		((Control)input).set_Size(new Size(249, 22));
		((Control)input).set_TabIndex(13);
		((Control)id).set_Location(new Point(127, 58));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(249, 22));
		((Control)id).set_TabIndex(12);
		((ButtonBase)upda).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)upda).set_Location(new Point(22, 356));
		((Control)upda).set_Name("upda");
		((Control)upda).set_Size(new Size(127, 45));
		((Control)upda).set_TabIndex(11);
		((ButtonBase)upda).set_Text("Update");
		((ButtonBase)upda).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(168, 356));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(123, 45));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("clear");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(297, 356));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(127, 45));
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Close");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)upda);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(449, 428));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)upda);
		((Control)this).set_Name("Form34");
		((Form)this).set_Text("Update Pharmacy");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void z5FX(object By12, EventArgs Wb41)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		connection.set_ConnectionString(connectionString);
	}

	private void q9H6(object Jr73, EventArgs Ej9k)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Invalid comparison between Unknown and I4
		connection.Open();
		int num = Conversions.ToInteger(quantity.get_Text());
		OleDbCommand val = new OleDbCommand();
		OleDbCommand val2 = new OleDbCommand();
		OleDbCommand val3 = new OleDbCommand();
		val.set_CommandText("Select COUNT(*) FROM Pharmacy_DataBase where  name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' ");
		val.set_CommandType(CommandType.Text);
		val.set_Connection(connection);
		val2.set_CommandText("Select quantity FROM Pharmacy_DataBase where name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' ");
		val2.set_CommandType(CommandType.Text);
		val2.set_Connection(connection);
		val3.set_CommandText("UPDATE  Pharmacy_DataBase SET quantity =quantity+'" + Conversions.ToString(num) + "'  where  ( name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' )");
		val3.set_CommandType(CommandType.Text);
		val3.set_Connection(connection);
		if (Operators.ConditionalCompareObjectNotEqual(val.ExecuteScalar(), (object)0, false))
		{
			val3.ExecuteNonQuery();
			((Component)(object)val3).Dispose();
			MessageBox.Show("Update successful", "Success", (MessageBoxButtons)0, (MessageBoxIcon)0);
		}
		else
		{
			if ((int)MessageBox.Show("Invalid Combination Of name and Eid or they may be not present in the data", "Invalid Input", (MessageBoxButtons)5, (MessageBoxIcon)16) == 2)
			{
				((Form)this).Close();
				return;
			}
			id.set_Text("");
			input.set_Text("");
		}
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		connection.Close();
	}

	internal static void g7R6()
	{
		Xr5i.q4QP(t4P2.mDic[t4P2.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}

	private void b6Q9(object e7LK, EventArgs Gk56)
	{
		((Form)this).Close();
	}

	private void o2F7(object f6P8, EventArgs Gr89)
	{
		((TextBoxBase)id).Clear();
		((TextBoxBase)input).Clear();
		((TextBoxBase)rate).Clear();
		((TextBoxBase)quantity).Clear();
	}
}
