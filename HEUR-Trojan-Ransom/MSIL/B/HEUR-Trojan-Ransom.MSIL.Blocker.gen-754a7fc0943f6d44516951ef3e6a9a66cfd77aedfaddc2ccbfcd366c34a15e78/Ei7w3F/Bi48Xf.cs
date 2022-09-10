using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bf67Di;
using Bg;
using Go6i1R;
using Hq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Qg52D;
using Sf94Hc;
using Xf;
using a5;
using d8;
using g6;
using t5P2G;
using z0B8Z;

namespace Ei7w3F;

public class Bi48Xf
{
	private OleDbConnection con;

	private DataTable dt;

	private string sql;

	private OleDbDataAdapter da;

	private OleDbCommand cmd;

	private int result;

	private string str;

	private string gender;

	private string exactamIn;

	private string exactamOut;

	private string exactpmIn;

	private string exactpmOut;

	private string remark;

	private OleDbCommand acscmd;

	private OleDbDataAdapter acsda;

	private OleDbConnection acscon;

	private DataSet acsds;

	private string strsql;

	private string strreportname;

	private object ComboBox5;

	private object ComboBox3;

	private object ComboBox4;

	private object DateTimePicker1;

	private object GroupBox3;

	private object GroupBox4;

	private object Label1;

	private object Label2;

	private object Timer1;

	private object Timer2;

	private object TextBox2;

	private object TextBox3;

	private object TextBox4;

	private object TextBox5;

	private object TextBox6;

	private object TextBox8;

	private object DateTimePicker2;

	private object TextBox7;

	private object TextBox11;

	private object TextBox12;

	private object TextBox9;

	private object TextBox10;

	private object TextBox1;

	private string Name;

	private object ComboBox1;

	private object Label8;

	private object DataGridView2;

	private object TextBox22;

	private object TextBox23;

	private object TextBox21;

	private object TextBox24;

	private object ErrorProvider1;

	private object GroupBox7;

	private object Button13;

	private object Button9;

	private object DataGridView4;

	private object TextBox25;

	private object DataGridView1;

	private object DataGridView3;

	private object ComboBox2;

	private object ComboBox6;

	private OleDbConnection myconnection
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public object GroupBox2
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox2;
		}
		[CompilerGenerated]
		set
		{
			_GroupBox2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string Text { get; set; }

	public Bi48Xf()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		con = myconnection;
		dt = new DataTable();
		da = new OleDbDataAdapter();
		cmd = new OleDbCommand();
		exactamIn = "7:30:00 AM";
		exactamOut = "11:30:00 AM";
		exactpmIn = "1:30:00 PM";
		exactpmOut = "5:30:00 PM";
		acscmd = new OleDbCommand();
		acsda = new OleDbDataAdapter();
		acscon = myconnection;
		acsds = new DataSet();
	}

	private void Gs36Dq()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(GroupBox2, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if ((object)((object)val).GetType() == typeof(TextBox))
				{
					val.set_Text((string)null);
				}
				NewLateBinding.LateSet(ComboBox5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(ComboBox3, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(ComboBox4, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(DateTimePicker1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void d0N9Zp()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(GroupBox3, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if ((object)((object)val).GetType() == typeof(TextBox))
				{
					val.set_Text((string)null);
				}
				NewLateBinding.LateSet(DateTimePicker1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	internal static void Co58Rg()
	{
		throw new NotImplementedException();
	}

	internal static void Rt37Wa()
	{
		throw new NotImplementedException();
	}

	private void d6P8Sn()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(GroupBox4, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if ((object)((object)val).GetType() == typeof(TextBox))
				{
					val.set_Text((string)null);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void q3HQn8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Label1, (Type)null, "Text", new object[1] { ((ServerComputer)Tw0f1.Computer).get_Clock().get_LocalTime().Date }, (string[])null, (Type[])null);
	}

	private void De13Ay(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Label2, (Type)null, "Text", new object[1] { DateAndTime.get_TimeOfDay() }, (string[])null, (Type[])null);
	}

	private void Gq56Ft(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Jp38Pt(object sender, EventArgs e)
	{
		gender = "Male";
	}

	private void w5T8Kk(object sender, EventArgs e)
	{
		gender = "Female";
	}

	private void Bf1q2K(object sender, EventArgs e)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Please fill up the given data", (MsgBoxStyle)32, (object)(MessageBoxDefaultButton)0);
		}
		else
		{
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into TableStudent (YearLevel,StudentID,FirstName,MiddleName,LastName,Gender,Birthdate,Age,Course,Status)values('", NewLateBinding.LateGet(ComboBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)gender), (object)"','"), NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ComboBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ComboBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection(con);
			result = cmd.ExecuteNonQuery();
			val = null;
			if (result > 0)
			{
				Interaction.MsgBox((object)"New Student has added", (MsgBoxStyle)0, (object)null);
				Gs36Dq();
			}
			else
			{
				Interaction.MsgBox((object)"No Student record has been added!", (MsgBoxStyle)16, (object)null);
			}
		}
		con.Close();
	}

	private void St29Nq(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
		con.Open();
		da = new OleDbDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO TableEvent (EventName,EventDate,EventVenue) VALUES ('", NewLateBinding.LateGet(TextBox8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(DateTimePicker2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), con);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)da).Fill(dataSet);
		Interaction.MsgBox((object)"New Event has been Saved", (MsgBoxStyle)0, (object)null);
		con.Close();
	}

	private void b9S8Go(object sender, EventArgs e)
	{
		checked
		{
			_ = (int)unchecked(DateAndTime.DateDiff((DateInterval)4, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) % 365L);
			int num = (int)DateAndTime.DateDiff((DateInterval)0, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			int num2 = (int)unchecked(DateAndTime.DateDiff((DateInterval)2, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) % 12L);
			NewLateBinding.LateSet(TextBox4, (Type)null, "Text", new object[1] { Conversions.ToString(num) + " Years, " + Conversions.ToString(num2) + " Months " }, (string[])null, (Type[])null);
		}
	}

	private void Ac6b0E(object sender, EventArgs e)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"No encoder has been saved!", (MsgBoxStyle)16, (object)null);
			return;
		}
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
		val.Open();
		str = "INSERT INTO TableUser ([username],[password], [FirstName], [LastName])values (?, ?, ?, ?)";
		OleDbCommand val2 = new OleDbCommand(str, val);
		val2.get_Parameters().Add(new OleDbParameter("username", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		val2.get_Parameters().Add(new OleDbParameter("password", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		val2.get_Parameters().Add(new OleDbParameter("FirstName", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		val2.get_Parameters().Add(new OleDbParameter("LastName", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		try
		{
			val2.ExecuteNonQuery();
			((Component)(object)val2).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		val.Close();
		d6P8Sn();
		Interaction.MsgBox((object)"New User has been added", (MsgBoxStyle)0, (object)null);
	}

	public void k1N7Lx()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactamIn, false))
		{
			remark = "ON TIME";
			Interaction.MsgBox((object)"VERY GOOD YOUR EARLY", (MsgBoxStyle)0, (object)null);
		}
		else if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactamIn, false))
		{
			remark = "LATE";
			Interaction.MsgBox((object)"YOUR LATE", (MsgBoxStyle)0, (object)null);
		}
	}

	public void Mc4e0S()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactamOut, false))
		{
			remark = "EARLY";
			Interaction.MsgBox((object)"TOO EARLY", (MsgBoxStyle)0, (object)null);
		}
		else if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactamOut, false))
		{
			remark = "LATE";
			Interaction.MsgBox((object)"TOO LATE", (MsgBoxStyle)0, (object)null);
		}
	}

	public void y9BYe6()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactpmIn, false))
		{
			remark = "ON TIME";
			Interaction.MsgBox((object)"VERY GOOD YOUR EARLY", (MsgBoxStyle)0, (object)null);
		}
		else if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactpmIn, false))
		{
			remark = "LATE";
			Interaction.MsgBox((object)"YOUR LATE", (MsgBoxStyle)0, (object)null);
		}
	}

	public void By9q8A()
	{
		if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactpmOut, false))
		{
			remark = "NOT ON TIME ";
		}
		else if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)exactpmOut, false))
		{
			remark = "ON TIME";
		}
	}

	private void Be48Xr(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		OleDbConnection val = new OleDbConnection();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please input your I.D", (MsgBoxStyle)16, (object)null);
			return;
		}
		string text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		string connectionString = text2 + text;
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableStudent] WHERE [StudentID] = '", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), val);
		OleDbDataReader val3 = val2.ExecuteReader();
		bool flag = false;
		while (val3.Read())
		{
			flag = true;
			val3.get_Item("StudentID").ToString();
			string text3 = val3.get_Item("FirstName").ToString();
			string text4 = val3.get_Item("LastName").ToString();
			Name = text3 + " " + text4;
		}
		if (flag)
		{
			k1N7Lx();
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Insert into TableInsert (StudID,Am_In , Am_InRemark , EventName,Encoder) values ('", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" ','"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)remark), (object)"','"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Label8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection(con);
			result = val2.ExecuteNonQuery();
			val4 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + Name), (MsgBoxStyle)0, (object)null);
			con.Close();
		}
		else
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Cz8g5R(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		OleDbConnection val = new OleDbConnection();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please input your I.D", (MsgBoxStyle)16, (object)null);
			return;
		}
		string text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		string connectionString = text2 + text;
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableStudent] WHERE [StudentID] = '", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), val);
		OleDbDataReader val3 = val2.ExecuteReader();
		bool flag = false;
		while (val3.Read())
		{
			flag = true;
			val3.get_Item("StudentID").ToString();
			string text3 = val3.get_Item("FirstName").ToString();
			string text4 = val3.get_Item("LastName").ToString();
			Name = text3 + " " + text4;
		}
		if (flag)
		{
			Mc4e0S();
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Am_Out ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Am_OutRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection(con);
			val4 = null;
			result = val2.ExecuteNonQuery();
			Interaction.MsgBox((object)("Successfully Sign Out " + Name), (MsgBoxStyle)0, (object)null);
			con.Close();
		}
		else if (!flag)
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void y0N9Me(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		OleDbConnection val = new OleDbConnection();
		OleDbCommand val2 = new OleDbCommand();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please input your I.D", (MsgBoxStyle)16, (object)null);
		}
		string text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		string connectionString = text2 + text;
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val3 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableStudent] WHERE [StudentID] = '", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), val);
		OleDbDataReader val4 = val3.ExecuteReader();
		bool flag = false;
		string text3 = "";
		while (val4.Read())
		{
			flag = true;
			val4.get_Item("StudentID").ToString();
			string text4 = val4.get_Item("FirstName").ToString();
			string text5 = val4.get_Item("LastName").ToString();
			text3 = text4 + " " + text5;
		}
		if (!flag)
		{
			Interaction.MsgBox((object)"Student ID not found or Incorrect", (MsgBoxStyle)16, (object)null);
		}
		if (flag)
		{
			y9BYe6();
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_In ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_InRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val5 = val3;
			val5.set_CommandText(sql);
			val5.set_Connection(con);
			result = val3.ExecuteNonQuery();
			val5 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + text3), (MsgBoxStyle)0, (object)null);
			con.Close();
		}
		else
		{
			y9BYe6();
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			string commandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Insert into TableInsert (StudID ,Pm_In , Pm_InRemark , EventName,Encoder) values ('", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" ','"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)remark), (object)"','"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Label8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val6 = val2;
			val6.set_CommandText(commandText);
			val6.set_Connection(con);
			result = val2.ExecuteNonQuery();
			val6 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + text3), (MsgBoxStyle)0, (object)null);
			con.Close();
		}
	}

	private void b8S9Qr(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		OleDbConnection val = new OleDbConnection();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please input your I.D", (MsgBoxStyle)16, (object)null);
			return;
		}
		string text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		string connectionString = text2 + text;
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableStudent] WHERE [StudentID] = '", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), val);
		OleDbDataReader val3 = val2.ExecuteReader();
		bool flag = false;
		while (val3.Read())
		{
			flag = true;
			val3.get_Item("StudentID").ToString();
			string text3 = val3.get_Item("FirstName").ToString();
			string text4 = val3.get_Item("LastName").ToString();
			Name = text3 + " " + text4;
		}
		if (flag)
		{
			Mc4e0S();
			con.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
			con.Open();
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_Out ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_OutRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection(con);
			val4 = null;
			result = val2.ExecuteNonQuery();
			Interaction.MsgBox((object)("Successfully Sign Out " + Name), (MsgBoxStyle)0, (object)null);
			con.Close();
		}
		else
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void i7X6Zs()
	{
		myconnection.Open();
		dt = new DataTable();
		OleDbCommand val = cmd;
		val.set_Connection(myconnection);
		val.set_CommandText("Select * from TableStudent '");
		val = null;
		da.set_SelectCommand(cmd);
		((DbDataAdapter)(object)da).Fill(dt);
		NewLateBinding.LateSet(DataGridView2, (Type)null, "DataSource", new object[1] { dt }, (string[])null, (Type[])null);
		((Component)(object)da).Dispose();
		myconnection.Close();
	}

	private void k9RPq5(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox22, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox23, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox21, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"No Administrator has been saved!", (MsgBoxStyle)16, (object)null);
			return;
		}
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
		val.Open();
		str = "INSERT INTO TableAdmin ([username], [FirstName], [LastName])values (?, ?, ?)";
		OleDbCommand val2 = new OleDbCommand(str, val);
		val2.get_Parameters().Add(new OleDbParameter("username", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox22, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		val2.get_Parameters().Add(new OleDbParameter("FirstName", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox23, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		val2.get_Parameters().Add(new OleDbParameter("LastName", (object)Conversions.ToString(NewLateBinding.LateGet(TextBox21, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		try
		{
			val2.ExecuteNonQuery();
			((Component)(object)val2).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		val.Close();
		Interaction.MsgBox((object)"New Administrator has been added", (MsgBoxStyle)0, (object)null);
		NewLateBinding.LateCall(TextBox22, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox23, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox21, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void e6TGq2(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		OleDbConnection val = new OleDbConnection();
		new OleDbDataAdapter();
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox24, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			object errorProvider = ErrorProvider1;
			object[] array = new object[2];
			ref object textBox = ref TextBox24;
			ref object reference = ref textBox;
			array[0] = textBox;
			array[1] = "Please input username";
			object[] array2 = array;
			bool[] obj = new bool[2] { true, false };
			bool[] array3 = obj;
			NewLateBinding.LateCall(errorProvider, (Type)null, "SetError", array, (string[])null, (Type[])null, obj, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			return;
		}
		string text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		string connectionString = text2 + text;
		val.set_ConnectionString(connectionString);
		val.Open();
		OleDbCommand val2 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableAdmin] WHERE [Username] = '", NewLateBinding.LateGet(TextBox24, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)"'")), val);
		OleDbDataReader val3 = val2.ExecuteReader();
		bool flag = false;
		string text3 = "";
		string text4 = "";
		while (val3.Read())
		{
			flag = true;
			text3 = val3.get_Item("FirstName").ToString();
			text4 = val3.get_Item("LastName").ToString();
		}
		if (flag)
		{
			Interaction.MsgBox((object)("Welcome as Administrator " + text3 + " " + text4), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateSet(GroupBox7, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(ErrorProvider1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(TextBox24, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Li82Gf();
			NewLateBinding.LateCall(Button13, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Button9, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(DataGridView4, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			object errorProvider2 = ErrorProvider1;
			object[] array4 = new object[2];
			ref object textBox2 = ref TextBox24;
			ref object reference = ref textBox2;
			array4[0] = textBox2;
			array4[1] = "Wrong Username";
			object[] array2 = array4;
			bool[] obj2 = new bool[2] { true, false };
			bool[] array3 = obj2;
			NewLateBinding.LateCall(errorProvider2, (Type)null, "SetError", array4, (string[])null, (Type[])null, obj2, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			NewLateBinding.LateCall(TextBox24, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		val.Close();
	}

	private void Li82Gf()
	{
		throw new NotImplementedException();
	}

	private void Nn2e5G(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			sql = "DELETE * FROM TableAdmin  WHERE AdminID=" + Text;
			con.Open();
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection(con);
			val = null;
			result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				Interaction.MsgBox((object)"NEW RECORD HAS BEEN DELETED!", (MsgBoxStyle)0, (object)null);
				con.Close();
				Aq4d5P();
				NewLateBinding.LateCall(TextBox23, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(TextBox22, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(TextBox21, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				Interaction.MsgBox((object)"NO RECORD HAS BEEN DELETED!", (MsgBoxStyle)16, (object)null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			con.Close();
		}
	}

	private void Aq4d5P()
	{
		throw new NotImplementedException();
	}

	private void j4L5Tm(object sender, EventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"UPDATE TableAdmin set  Username= '", NewLateBinding.LateGet(TextBox22, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Firstname = '"), NewLateBinding.LateGet(TextBox23, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Lastname = '"), NewLateBinding.LateGet(TextBox21, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'WHERE AdminID = "), (object)Text));
			con.Open();
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection(con);
			val = null;
			result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				Interaction.MsgBox((object)"Admin record has been Updated", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)"Admin record was not been Updated", (MsgBoxStyle)16, (object)null);
			}
			Aq4d5P();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			con.Close();
		}
	}

	private void o0MAx6(object sender, DataGridViewCellEventArgs e)
	{
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Text = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView4, (Type)null, "CurrentRow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(TextBox22, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView4, (Type)null, "CurrentRow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox23, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView4, (Type)null, "Rows", new object[1] { e.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox21, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView4, (Type)null, "Rows", new object[1] { e.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void y4QDd0(object sender, EventArgs e)
	{
		i7X6Zs();
	}

	private void f0ETw3(object sender, EventArgs e)
	{
		d0N9Zp();
	}

	private void s2ZDk4(object sender, DataGridViewCellEventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			NewLateBinding.LateSet(TextBox25, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", new object[1] { e.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
			OleDbCommand val = new OleDbCommand();
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val2 = new OleDbDataAdapter();
			myconnection.Open();
			dt = new DataTable();
			OleDbCommand val3 = val;
			val3.set_Connection(myconnection);
			val3.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select * from TableInsert where StudID like '", NewLateBinding.LateGet(TextBox25, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"%'")));
			val3 = null;
			val2.set_SelectCommand(val);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			NewLateBinding.LateSet(DataGridView3, (Type)null, "DataSource", new object[1] { dataTable }, (string[])null, (Type[])null);
			((Component)(object)da).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			myconnection.Close();
		}
	}

	public void g6QSf5()
	{
		if (Operators.CompareString(Yd43Gw.message, "all reports", false) == 0)
		{
			Qd2w5H("SELECT * FROM TableInsert", "Report1");
		}
		else if (Operators.CompareString(Yd43Gw.message, "Stud report", false) == 0)
		{
			Qd2w5H(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableInsert where StudID = '", NewLateBinding.LateGet(TextBox25, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "Report1");
		}
		else if (Operators.CompareString(Yd43Gw.message, "Course Reports", false) == 0)
		{
			Qd2w5H(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where Course = '", NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptcourse");
		}
		else if (Operators.CompareString(Yd43Gw.message, "Course Year Reports", false) == 0)
		{
			Qd2w5H(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where YearLevel = '", NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'and Course = '"), NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptyearlevel");
		}
		else if (Operators.CompareString(Yd43Gw.message, "Year Reports", false) == 0)
		{
			Qd2w5H(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where YearLevel = '", NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptyearlevel");
		}
	}

	private void e8CQk9(object sender, EventArgs e)
	{
		Yd43Gw.message = "Stud report";
		g6QSf5();
	}

	private void Ar56Fi(object sender, EventArgs e)
	{
		Yd43Gw.message = "all reports";
		g6QSf5();
	}

	public void Qd2w5H(string s8GWm2, string Ro2q6Y)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		acsds = new DataSet();
		strsql = s8GWm2;
		acscmd.set_CommandText(strsql);
		acscmd.set_Connection(acscon);
		acsda.set_SelectCommand(acscmd);
		((DbDataAdapter)(object)acsda).Fill(acsds);
		strreportname = Ro2q6Y;
		string text = Application.get_StartupPath() + "\\report\\" + strreportname + ".rpt";
		if (!File.Exists(text))
		{
			Interaction.MsgBox((object)("Unable to locate file :\r\n" + text), (MsgBoxStyle)0, (object)null);
		}
	}

	private void c3SLa5(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please select Course first", (MsgBoxStyle)0, (object)null);
			return;
		}
		Yd43Gw.message = "Course Reports";
		g6QSf5();
	}

	private void o3N4Kn(object sender, EventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Please select Course or Year Level first", (MsgBoxStyle)0, (object)null);
			return;
		}
		Yd43Gw.message = "Course Year Reports";
		g6QSf5();
	}

	private void Fr5t9C(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please select Year Level first", (MsgBoxStyle)0, (object)null);
			return;
		}
		Yd43Gw.message = "Year Reports";
		g6QSf5();
	}

	private void Fc4e5X(object sender, EventArgs e)
	{
		Aq4d5P();
	}

	private void Hj0d3D(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Button13, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Button9, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		y0HSw4();
		NewLateBinding.LateSet(GroupBox7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(DataGridView4, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(TextBox22, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox23, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox21, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void y0HSw4()
	{
		throw new NotImplementedException();
	}

	private void n1X5Ad(object sender, EventArgs e)
	{
	}

	private void Kg1f9F(object sender, EventArgs e)
	{
	}

	private void q7DCn9(object sender, EventArgs e)
	{
	}

	private void n7D9Fm(object sender, EventArgs e)
	{
	}

	private void a5E0Cn(object sender, EventArgs e)
	{
	}

	internal static void Ds4f3F(Eo80Fc.k4HMb5 Fw48Mq, int Lk2x7A, string Xj6y2W, bool Ze9r4E)
	{
		if (Lk2x7A <= 0)
		{
			return;
		}
		checked
		{
			Lk2x7A *= 5;
			if (Xj6y2W == null)
			{
				return;
			}
			Xj6y2W = Xj6y2W.Remove(0, 3);
			if (Ze9r4E)
			{
				return;
			}
			Ze9r4E = true;
			object[] names = Fw48Mq.Names;
			object[] array = names;
			for (int i = 0; i < array.Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(array[i]);
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Fw48Mq.Ass, (Type)null, "GetManifestResourceStream", new object[1] { Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue)) }, (string[])null, (Type[])null, (bool[])null));
				object obj = Math.Abs(168960);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), obj, false))
				{
					Fw48Mq.Data = (byte[])a7.n1(RuntimeHelpers.GetObjectValue(obj), null);
					Eo80Fc.k4HMb5 k4HMb;
					object[] obj2 = new object[3]
					{
						(k4HMb = Fw48Mq).Data,
						0,
						obj
					};
					object[] array2 = obj2;
					bool[] obj3 = new bool[3] { true, false, true };
					bool[] array3 = obj3;
					NewLateBinding.LateCall(objectValue2, (Type)null, "Read", obj2, (string[])null, (Type[])null, obj3, true);
					if (array3[0])
					{
						k4HMb.Data = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
					}
					if (array3[2])
					{
						obj = RuntimeHelpers.GetObjectValue(array2[2]);
					}
				}
			}
			Nr.q8(p5: false, 15, Fw48Mq, 220);
		}
	}

	static void y1BWd9()
	{
		d9C5Xt d9C5Xt = (d9C5Xt)d9C5Xt.OK;
		_ = (Qi79E)(object)d9C5Xt.Text;
		_ = (_003CModule_003E)(object)Yd43Gw.Nb8f0R();
		_ = (d9C5Xt)(object)x8.Default;
		object obj;
		while (true)
		{
			obj = x8.Default;
			if (obj != null)
			{
				_ = (f7)f7.Button1;
				continue;
			}
			break;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7 a);
		UIntPtr uIntPtr;
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				while (obj != null)
				{
					a = a;
					_ = (Yd43Gw)((Eo80Fc)((a7)a.ErrorProvider1).ErrorProvider1).ErrorProvider1;
				}
			}
			else
			{
				_ = (_003CModule_003E)((a7)null).ErrorProvider1;
			}
		}
		Bi48Xf bi48Xf = bi48Xf;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wz wz);
		if ((UIntPtr)bi48Xf.Text == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zz21N zz21N);
			while (obj != null)
			{
				try
				{
					Zz21N obj2 = (Zz21N)((a7)null).ErrorProvider1;
					zz21N = zz21N;
					zz21N = obj2;
				}
				finally
				{
					wz = wz;
					d9C5Xt = (d9C5Xt)wz.GroupBox2;
					continue;
				}
			}
		}
		try
		{
			_ = (_003CModule_003E)f7.Button1;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
				}
				finally
				{
					bi48Xf = (Bi48Xf)((Bi48Xf)Nr.OK).GroupBox2;
					goto IL_0156;
				}
			}
			goto IL_0156;
		}
		IL_0156:
		UIntPtr num = (UIntPtr)bi48Xf.GroupBox2;
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)num) + unchecked((nuint)num2 / uIntPtr)) == 0)
		{
			try
			{
				bi48Xf = null;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					Nr nr = nr;
					_ = (x8)nr.ErrorProvider1;
				}
				else
				{
					_ = (Qi79E)a7.Button1;
				}
			}
		}
		else if ((UIntPtr)Yd43Gw.Nb8f0R() == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Yd43Gw)Eo80Fc.OK;
			}
			catch
			{
				wz = wz;
			}
		}
		else if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
		{
			_ = (Tw0f1)(object)((f7)null).Text;
		}
		_ = (_003CModule_003E)(object)Yd43Gw.Nb8f0R();
		_ = (d9C5Xt)(object)bi48Xf.Text;
		_ = (Eo80Fc)a7.OK;
		_ = (Wz)Eo80Fc.OK;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				bi48Xf = (Bi48Xf)(object)x8.Default;
				_ = (Zz21N)a7.OK;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tw0f1 tw0f);
		while (obj != null)
		{
			Tw0f1 obj5 = (Tw0f1)Wz.Button1;
			tw0f = tw0f;
			tw0f = obj5;
		}
		_ = (Eo80Fc)Nr.Button1;
		if ((UIntPtr)a7.OK == (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)((Bi48Xf)(object)((Bi48Xf)(object)x8.Default).Text).GroupBox2;
				j1 j = null;
				j = j;
			}
		}
		finally
		{
			_ = (Bi48Xf)a7.Button1;
			return;
		}
	}
}
