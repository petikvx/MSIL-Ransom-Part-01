using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Zy1f;

namespace b4R7;

[DesignerGenerated]
public class Df7s : Form
{
	private IContainer components;

	private short check_flag;

	private short Flag_control;

	private OleDbConnection con;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[CompilerGenerated]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Ek50);
			FlowLayoutPanel flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).remove_Paint(val);
			}
			_FlowLayoutPanel1 = value;
			flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).add_Paint(val);
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
			EventHandler eventHandler = Ek68;
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

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mj3a;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	public Df7s()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Eg27);
		check_flag = 0;
		Flag_control = 0;
		con = new OleDbConnection();
		Me86();
	}

	[DebuggerNonUserCode]
	protected override void k5P4(bool g9Z8)
	{
		try
		{
			if (g9Z8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g9Z8);
		}
	}

	[DebuggerStepThrough]
	private void Me86()
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
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		Label2 = new Label();
		TextBox2 = new TextBox();
		Label5 = new Label();
		DateTimePicker1 = new DateTimePicker();
		CheckBox2 = new CheckBox();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button1 = new Button();
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(12, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 27));
		((Control)Label2).set_TabIndex(26);
		Label2.set_Text("Patient ID:");
		Label2.set_TextAlign((ContentAlignment)64);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Location(new Point(118, 9));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(86, 22));
		((Control)TextBox2).set_TabIndex(29);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(210, 9));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(158, 27));
		((Control)Label5).set_TabIndex(30);
		Label5.set_Text("Enter Search Date :");
		Label5.set_TextAlign((ContentAlignment)64);
		((Control)DateTimePicker1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(374, 9));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(140, 27));
		((Control)DateTimePicker1).set_TabIndex(31);
		DateTimePicker1.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		CheckBox2.set_Checked(true);
		CheckBox2.set_CheckState((CheckState)1);
		((Control)CheckBox2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox2).set_Location(new Point(520, 10));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(99, 27));
		((Control)CheckBox2).set_TabIndex(32);
		((ButtonBase)CheckBox2).set_Text("Show All");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ScrollableControl)FlowLayoutPanel1).set_AutoScroll(true);
		((Control)FlowLayoutPanel1).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)FlowLayoutPanel1).set_Location(new Point(27, 46));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(726, 321));
		((Control)FlowLayoutPanel1).set_TabIndex(33);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(624, 12));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(131, 28));
		((Control)Button1).set_TabIndex(34);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(374, 9));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(128, 22));
		((Control)TextBox1).set_TabIndex(35);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(765, 377));
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).set_Name("Form71");
		((Form)this).set_Text("Patient History");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void o4Z2()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		((Control)FlowLayoutPanel1).get_Controls().Clear();
		con.Open();
		val = new OleDbDataAdapter("Select * from Appointment_Database where Patient_ID like '%" + TextBox2.get_Text() + "%' And  Date_Of_Appointment like '%" + TextBox1.get_Text() + "%' ", con);
		((DbDataAdapter)(object)val).Fill(dataTable);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Lw3m lw3m = new Lw3m();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Doctor_Name", false) == 0)
						{
							((ButtonBase)lw3m).set_Text(" Doctor_Name   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Remarks", false) == 0)
						{
							((ButtonBase)lw3m).set_Text(((ButtonBase)lw3m).get_Text() + "        Remarks/Medicines  :  " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)lw3m);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void Eg27(object Aw4d, EventArgs Xt70)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		o4Z2();
		Flag_control = 1;
	}

	private void t5J4(object m4SB, EventArgs Di4r)
	{
		if ((Flag_control == 1) & !CheckBox2.get_Checked())
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	private void Mj3a(object y2MJ, EventArgs Ya80)
	{
		o4Z2();
	}

	private void Ek68(object o9Q7, EventArgs Qa9o)
	{
		((Form)this).Close();
	}

	private void Tr6x(object o1QB, EventArgs x9H6)
	{
		if (CheckBox2.get_Checked())
		{
			((TextBoxBase)TextBox1).Clear();
		}
		if (!CheckBox2.get_Checked())
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	private void Ek50(object x4Y2, PaintEventArgs Nm0b)
	{
	}
}
