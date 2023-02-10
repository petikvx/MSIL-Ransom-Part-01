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
using Be1o;
using Microsoft.VisualBasic.CompilerServices;

namespace Cx5b;

[DesignerGenerated]
public class Jw3x : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("FlowLayoutPanel2")]
	internal virtual FlowLayoutPanel FlowLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = No25;
			Button button = _Button8;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler eventHandler = x1DC;
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

	public Jw3x()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Fr3e);
		con = new OleDbConnection();
		x7MZ();
	}

	[DebuggerNonUserCode]
	protected override void b8D9(bool Rm9x)
	{
		try
		{
			if (Rm9x && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rm9x);
		}
	}

	[DebuggerStepThrough]
	private void x7MZ()
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
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		FlowLayoutPanel2 = new FlowLayoutPanel();
		Button8 = new Button();
		Label1 = new Label();
		ComboBox1 = new ComboBox();
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((ScrollableControl)FlowLayoutPanel2).set_AutoScroll(true);
		((Control)FlowLayoutPanel2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)FlowLayoutPanel2).set_Location(new Point(26, 89));
		((Control)FlowLayoutPanel2).set_Name("FlowLayoutPanel2");
		((Control)FlowLayoutPanel2).set_Size(new Size(641, 454));
		((Control)FlowLayoutPanel2).set_TabIndex(3);
		((Control)Button8).set_Location(new Point(571, 56));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(96, 27));
		((Control)Button8).set_TabIndex(15);
		((ButtonBase)Button8).set_Text("CLEAR");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(22, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(346, 27));
		((Control)Label1).set_TabIndex(14);
		Label1.set_Text("Check Availability Of Medicines By");
		Label1.set_TextAlign((ContentAlignment)16);
		ComboBox1.set_BackColor(Color.White);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[2] { "Eid", "Name" });
		((Control)ComboBox1).set_Location(new Point(26, 56));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(224, 24));
		((Control)ComboBox1).set_TabIndex(13);
		((Control)TextBox1).set_Location(new Point(270, 58));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(295, 22));
		((Control)TextBox1).set_TabIndex(12);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(698, 555));
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Form35");
		((Form)this).set_Text("Medicine Availability");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public object Ls54()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Pharmacy_DataBase where name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Pharmacy_DataBase where Eid like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Dt59 dt = new Dt59();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "name", false) == 0)
						{
							((ButtonBase)dt).set_Text(((ButtonBase)dt).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Eid", false) == 0)
						{
							((ButtonBase)dt).set_Text("     Eid   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "quantity", false) == 0)
						{
							((ButtonBase)dt).set_Text(((ButtonBase)dt).get_Text() + "              Quantity   :   " + dataRow[dataColumn].ToString());
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
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)dt);
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
		object result = default(object);
		return result;
	}

	private void Fr3e(object o9C6, EventArgs y2L9)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		Ls54();
	}

	private void No25(object Ak7q, EventArgs y5SE)
	{
		((TextBoxBase)TextBox1).Clear();
	}

	private void x1DC(object n7R3, EventArgs q4S9)
	{
		Ls54();
	}
}
