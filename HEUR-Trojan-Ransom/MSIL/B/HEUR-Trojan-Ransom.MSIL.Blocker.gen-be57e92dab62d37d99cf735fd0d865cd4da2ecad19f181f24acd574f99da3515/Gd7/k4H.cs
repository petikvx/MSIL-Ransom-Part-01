using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using g7W;

namespace Gd7;

[DesignerGenerated]
public class k4H : Form
{
	private IContainer components;

	private short check_flag;

	private short Flag_control;

	private OleDbConnection con;

	internal virtual DateTimePicker DateTimePicker1
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = En9;
			DateTimePicker dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.remove_ValueChanged(eventHandler);
			}
			_DateTimePicker1 = value;
			dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
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
			EventHandler eventHandler = e1E;
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

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
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
			EventHandler eventHandler = g1P;
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wy8;
			CheckBox checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.remove_CheckedChanged(eventHandler);
			}
			_CheckBox2 = value;
			checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.add_CheckedChanged(eventHandler);
			}
		}
	}

	public k4H()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Yy2);
		check_flag = 0;
		Flag_control = 0;
		con = new OleDbConnection();
		n8B();
	}

	[DebuggerNonUserCode]
	protected override void Xg8(bool w4G)
	{
		try
		{
			if (w4G && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w4G);
		}
	}

	[DebuggerStepThrough]
	private void n8B()
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
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		DateTimePicker1 = new DateTimePicker();
		Label5 = new Label();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		RichTextBox1 = new RichTextBox();
		Label1 = new Label();
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		Label2 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		CheckBox2 = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)DateTimePicker1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(374, 9));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(140, 27));
		((Control)DateTimePicker1).set_TabIndex(22);
		DateTimePicker1.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(210, 11));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(158, 27));
		((Control)Label5).set_TabIndex(20);
		Label5.set_Text("Enter Search Date :");
		Label5.set_TextAlign((ContentAlignment)64);
		((ScrollableControl)FlowLayoutPanel1).set_AutoScroll(true);
		((Control)FlowLayoutPanel1).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)FlowLayoutPanel1).set_Location(new Point(12, 39));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(739, 321));
		((Control)FlowLayoutPanel1).set_TabIndex(17);
		((Control)RichTextBox1).set_Location(new Point(12, 387));
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((Control)RichTextBox1).set_Size(new Size(562, 47));
		((Control)RichTextBox1).set_TabIndex(23);
		RichTextBox1.set_Text("");
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(12, 363));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(100, 21));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Remarks");
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(580, 387));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(171, 47));
		((Control)Button1).set_TabIndex(24);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)CheckBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox1).set_Location(new Point(644, 10));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(107, 27));
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("Completed");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(12, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 27));
		((Control)Label2).set_TabIndex(25);
		Label2.set_Text("Patient ID:");
		Label2.set_TextAlign((ContentAlignment)64);
		((Control)TextBox1).set_Location(new Point(374, 12));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(128, 22));
		((Control)TextBox1).set_TabIndex(27);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Location(new Point(118, 12));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(86, 22));
		((Control)TextBox2).set_TabIndex(28);
		CheckBox2.set_Checked(true);
		CheckBox2.set_CheckState((CheckState)1);
		((Control)CheckBox2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox2).set_Location(new Point(534, 10));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(99, 27));
		((Control)CheckBox2).set_TabIndex(29);
		((ButtonBase)CheckBox2).set_Text("Show All");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(769, 446));
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).set_Name("Form15");
		((Form)this).set_Text("Patient Search");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void w2S()
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
				Qo2 qo = new Qo2();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Doctor_Name", false) == 0)
						{
							((ButtonBase)qo).set_Text(" Doctor_Name   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Remarks", false) == 0)
						{
							((ButtonBase)qo).set_Text(((ButtonBase)qo).get_Text() + "        Remarks/Medicines  :  " + dataRow[dataColumn].ToString());
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
				((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)qo);
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

	private void Yy2(object Ay6, EventArgs z9W)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		RichTextBox1.set_Text("Remarks:");
		((TextBoxBase)TextBox1).Clear();
		w2S();
		Flag_control = 1;
	}

	private void En9(object Xk2, EventArgs Ps1)
	{
		if ((Flag_control == 1) & !CheckBox2.get_Checked())
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	internal static bool Tp1()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string t8B in array2)
				{
					if (!Ry2(t8B))
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

	private void g1P(object d1S, EventArgs m9Y)
	{
		w2S();
	}

	private void e1E(object w6C, EventArgs n5P)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckBox1.get_Checked() & (check_flag == 0))
		{
			check_flag = 1;
			MessageBox.Show("Completed check box is not clicked.\r\nThe reamrks added will not be added.");
			return;
		}
		if (!CheckBox1.get_Checked() & (check_flag == 1))
		{
			((Form)this).Close();
			return;
		}
		string text = "Insert into Appointment_DataBase([Remarks]) Values(?)";
		OleDbCommand val = new OleDbCommand(text, con);
		val.get_Parameters().Add(new OleDbParameter("Remarks", (object)RichTextBox1.get_Text()));
		try
		{
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void Wy8(object e2Q, EventArgs Ti5)
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

	internal static bool Ry2(string t8B)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(t8B);
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
}
