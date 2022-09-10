using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Gz67Tp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using c6T1;
using e7G6;
using i1ZAj;

namespace r7FGf;

public class p5A6T
{
	private string provider;

	private string datafile;

	private string constring;

	private OleDbConnection myconnection;

	private DataSet ds;

	private OleDbDataAdapter da;

	private object UsernameTextBox;

	private object PasswordTextBox;

	private DataTable dt;

	private string sql;

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

	private object acscon;

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

	private object GroupBox7;

	private object Button13;

	private object Button9;

	private object DataGridView4;

	private object TextBox25;

	private object DataGridView1;

	private object DataGridView3;

	private object ComboBox2;

	private object ComboBox6;

	private object con;

	public object ErrorProvider1
	{
		[CompilerGenerated]
		get
		{
			return _ErrorProvider1;
		}
		[CompilerGenerated]
		set
		{
			_ErrorProvider1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[CompilerGenerated]
		set
		{
			_Button1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[CompilerGenerated]
		set
		{
			_OK = RuntimeHelpers.GetObjectValue(value);
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

	public p5A6T()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		myconnection = new OleDbConnection();
		da = new OleDbDataAdapter();
		dt = new DataTable();
		cmd = new OleDbCommand();
		exactamIn = "7:30:00 AM";
		exactamOut = "11:30:00 AM";
		exactpmIn = "1:30:00 PM";
		exactpmOut = "5:30:00 PM";
		acscmd = new OleDbCommand();
		acsda = new OleDbDataAdapter();
		acsds = new DataSet();
	}

	public void Eo74R()
	{
		NewLateBinding.LateCall(UsernameTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(PasswordTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d5MTb(object sender, EventArgs e)
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(UsernameTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			object errorProvider = ErrorProvider1;
			object[] array = new object[2];
			ref object usernameTextBox = ref UsernameTextBox;
			ref object reference = ref usernameTextBox;
			array[0] = usernameTextBox;
			array[1] = "Please input Username";
			object[] array2 = array;
			bool[] obj = new bool[2] { true, false };
			bool[] array3 = obj;
			NewLateBinding.LateCall(errorProvider, (Type)null, "SetError", array, (string[])null, (Type[])null, obj, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		else
		{
			object errorProvider2 = ErrorProvider1;
			object[] array4 = new object[2];
			ref object usernameTextBox2 = ref UsernameTextBox;
			ref object reference = ref usernameTextBox2;
			array4[0] = usernameTextBox2;
			array4[1] = "Incorrect Username";
			object[] array2 = array4;
			bool[] obj2 = new bool[2] { true, false };
			bool[] array3 = obj2;
			NewLateBinding.LateCall(errorProvider2, (Type)null, "SetError", array4, (string[])null, (Type[])null, obj2, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PasswordTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			object errorProvider3 = ErrorProvider1;
			object[] array5 = new object[2];
			ref object passwordTextBox = ref PasswordTextBox;
			ref object reference = ref passwordTextBox;
			array5[0] = passwordTextBox;
			array5[1] = "Please input Password";
			object[] array2 = array5;
			bool[] obj3 = new bool[2] { true, false };
			bool[] array3 = obj3;
			NewLateBinding.LateCall(errorProvider3, (Type)null, "SetError", array5, (string[])null, (Type[])null, obj3, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		else
		{
			object errorProvider4 = ErrorProvider1;
			object[] array6 = new object[2];
			ref object passwordTextBox2 = ref PasswordTextBox;
			ref object reference = ref passwordTextBox2;
			array6[0] = passwordTextBox2;
			array6[1] = "Incorrect Password";
			object[] array2 = array6;
			bool[] obj4 = new bool[2] { true, false };
			bool[] array3 = obj4;
			NewLateBinding.LateCall(errorProvider4, (Type)null, "SetError", array6, (string[])null, (Type[])null, obj4, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		constring = provider + datafile;
		myconnection.set_ConnectionString(constring);
		myconnection.Open();
		OleDbCommand val = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableUser] WHERE [username] = '", NewLateBinding.LateGet(UsernameTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND [password] = '"), NewLateBinding.LateGet(PasswordTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), myconnection);
		OleDbDataReader val2 = val.ExecuteReader();
		bool flag = false;
		while (val2.Read())
		{
			flag = true;
			val2.get_Item("FirstName").ToString();
			val2.get_Item("LastName").ToString();
		}
		if (flag)
		{
			Eo74R();
			NewLateBinding.LateCall(ErrorProvider1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			t8X7Z();
		}
		myconnection.Close();
	}

	private void k7K3P(object sender, EventArgs e)
	{
		Ja7s6();
	}

	private void Ja7s6()
	{
		throw new NotImplementedException();
	}

	private void Cj80S()
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

	private void o9CNf()
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

	internal static void Mc74H()
	{
		throw new NotImplementedException();
	}

	internal static void Ay79S()
	{
		throw new NotImplementedException();
	}

	private void q7H9C()
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

	private void x8T2Q(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Label1, (Type)null, "Text", new object[1] { ((ServerComputer)z1X8Wt.Computer).get_Clock().get_LocalTime().Date }, (string[])null, (Type[])null);
	}

	private void Jg5i0(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Label2, (Type)null, "Text", new object[1] { DateAndTime.get_TimeOfDay() }, (string[])null, (Type[])null);
	}

	private void e2TXi(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void i7S4T(object sender, EventArgs e)
	{
		gender = "Male";
	}

	private void Pz7o9(object sender, EventArgs e)
	{
		gender = "Female";
	}

	private void Dj7b4(object sender, EventArgs e)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Please fill up the given data", (MsgBoxStyle)32, (object)(MessageBoxDefaultButton)0);
		}
		else
		{
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into TableStudent (YearLevel,StudentID,FirstName,MiddleName,LastName,Gender,Birthdate,Age,Course,Status)values('", NewLateBinding.LateGet(ComboBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)gender), (object)"','"), NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ComboBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ComboBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection((OleDbConnection)con);
			result = cmd.ExecuteNonQuery();
			val = null;
			if (result > 0)
			{
				Interaction.MsgBox((object)"New Student has added", (MsgBoxStyle)0, (object)null);
				Cj80S();
			}
			else
			{
				Interaction.MsgBox((object)"No Student record has been added!", (MsgBoxStyle)16, (object)null);
			}
		}
		NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ks39Z(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)da).Fill(dataSet);
		Interaction.MsgBox((object)"New Event has been Saved", (MsgBoxStyle)0, (object)null);
		NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void x9XLi(object sender, EventArgs e)
	{
		checked
		{
			_ = (int)unchecked(DateAndTime.DateDiff((DateInterval)4, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) % 365L);
			int num = (int)DateAndTime.DateDiff((DateInterval)0, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			int num2 = (int)unchecked(DateAndTime.DateDiff((DateInterval)2, Conversions.ToDate(NewLateBinding.LateGet(DateTimePicker1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) % 12L);
			NewLateBinding.LateSet(TextBox4, (Type)null, "Text", new object[1] { Conversions.ToString(num) + " Years, " + Conversions.ToString(num2) + " Months " }, (string[])null, (Type[])null);
		}
	}

	private void b1NTe(object sender, EventArgs e)
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
		q7H9C();
		Interaction.MsgBox((object)"New User has been added", (MsgBoxStyle)0, (object)null);
	}

	public void m1WZa()
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

	public void Mx2b3()
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

	public void Rq67K()
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

	public void Ee7w1()
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

	private void Ss8n3(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
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
			m1WZa();
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Insert into TableInsert (StudID,Am_In , Am_InRemark , EventName,Encoder) values ('", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" ','"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)remark), (object)"','"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Label8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection((OleDbConnection)con);
			result = val2.ExecuteNonQuery();
			val4 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + Name), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void q1M3K(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
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
			Mx2b3();
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Am_Out ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Am_OutRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection((OleDbConnection)con);
			val4 = null;
			result = val2.ExecuteNonQuery();
			Interaction.MsgBox((object)("Successfully Sign Out " + Name), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (!flag)
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void d3YZq(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
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
			Rq67K();
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_In ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_InRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val5 = val3;
			val5.set_CommandText(sql);
			val5.set_Connection((OleDbConnection)con);
			result = val3.ExecuteNonQuery();
			val5 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + text3), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			Rq67K();
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			string commandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Insert into TableInsert (StudID ,Pm_In , Pm_InRemark , EventName,Encoder) values ('", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" ','"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)remark), (object)"','"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Label8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			OleDbCommand val6 = val2;
			val6.set_CommandText(commandText);
			val6.set_Connection((OleDbConnection)con);
			result = val2.ExecuteNonQuery();
			val6 = null;
			Interaction.MsgBox((object)("Successfully Sign In " + text3), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Xp8m9(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
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
			Mx2b3();
			NewLateBinding.LateSet(con, (Type)null, "ConnectionString", new object[1] { "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TableInsert set  StudID ='", NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_Out ='"), NewLateBinding.LateGet(Label2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Pm_OutRemark ='"), (object)remark), (object)"'Where EventName = '"), NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" '"));
			OleDbCommand val4 = val2;
			val4.set_CommandText(sql);
			val4.set_Connection((OleDbConnection)con);
			val4 = null;
			result = val2.ExecuteNonQuery();
			Interaction.MsgBox((object)("Successfully Sign Out " + Name), (MsgBoxStyle)0, (object)null);
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			Interaction.MsgBox((object)"Student ID Not found or Incorrect", (MsgBoxStyle)16, (object)null);
			NewLateBinding.LateCall(TextBox1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void Hy0x6()
	{
		myconnection.Open();
		dt = new DataTable();
		OleDbCommand val = cmd;
		val.set_CommandText("Select * from TableStudent '");
		val = null;
		da.set_SelectCommand(cmd);
		((DbDataAdapter)(object)da).Fill(dt);
		NewLateBinding.LateSet(DataGridView2, (Type)null, "DataSource", new object[1] { dt }, (string[])null, (Type[])null);
		((Component)(object)da).Dispose();
		myconnection.Close();
	}

	private void e2KQi(object sender, EventArgs e)
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

	private void z7BAq(object sender, EventArgs e)
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
			Mi6t2();
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

	private void Mi6t2()
	{
		throw new NotImplementedException();
	}

	private void o8YPq(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			sql = "DELETE * FROM TableAdmin  WHERE AdminID=" + Text;
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection((OleDbConnection)con);
			val = null;
			result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				Interaction.MsgBox((object)"NEW RECORD HAS BEEN DELETED!", (MsgBoxStyle)0, (object)null);
				NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				t2TCe();
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
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void t2TCe()
	{
		throw new NotImplementedException();
	}

	private void k1ALb(object sender, EventArgs e)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"UPDATE TableAdmin set  Username= '", NewLateBinding.LateGet(TextBox22, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Firstname = '"), NewLateBinding.LateGet(TextBox23, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Lastname = '"), NewLateBinding.LateGet(TextBox21, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'WHERE AdminID = "), (object)Text));
			NewLateBinding.LateCall(con, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			OleDbCommand val = cmd;
			val.set_CommandText(sql);
			val.set_Connection((OleDbConnection)con);
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
			t2TCe();
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
			NewLateBinding.LateCall(con, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void w9T4J(object sender, DataGridViewCellEventArgs e)
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

	private void Qg80F(object sender, EventArgs e)
	{
		Hy0x6();
	}

	private void s6N0K(object sender, EventArgs e)
	{
		o9CNf();
	}

	private void Jy61G(object sender, DataGridViewCellEventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			NewLateBinding.LateSet(TextBox25, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", new object[1] { e.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
			OleDbCommand val = new OleDbCommand();
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val2 = new OleDbDataAdapter();
			myconnection.Open();
			dt = new DataTable();
			OleDbCommand val3 = val;
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

	public void Km27F()
	{
		if (Operators.CompareString(o2FH.message, "all reports", false) == 0)
		{
			Tj58S("SELECT * FROM TableInsert", "Report1");
		}
		else if (Operators.CompareString(o2FH.message, "Stud report", false) == 0)
		{
			Tj58S(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableInsert where StudID = '", NewLateBinding.LateGet(TextBox25, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "Report1");
		}
		else if (Operators.CompareString(o2FH.message, "Course Reports", false) == 0)
		{
			Tj58S(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where Course = '", NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptcourse");
		}
		else if (Operators.CompareString(o2FH.message, "Course Year Reports", false) == 0)
		{
			Tj58S(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where YearLevel = '", NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'and Course = '"), NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptyearlevel");
		}
		else if (Operators.CompareString(o2FH.message, "Year Reports", false) == 0)
		{
			Tj58S(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM TableStudent where YearLevel = '", NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "rptyearlevel");
		}
	}

	private void g1K8W(object sender, EventArgs e)
	{
		o2FH.message = "Stud report";
		Km27F();
	}

	private void y5EZx(object sender, EventArgs e)
	{
		o2FH.message = "all reports";
		Km27F();
	}

	public void Tj58S(string s7SQi, string Ax6r8)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		acsds = new DataSet();
		strsql = s7SQi;
		acscmd.set_CommandText(strsql);
		acscmd.set_Connection((OleDbConnection)acscon);
		acsda.set_SelectCommand(acscmd);
		((DbDataAdapter)(object)acsda).Fill(acsds);
		strreportname = Ax6r8;
		string text = Application.get_StartupPath() + "\\report\\" + strreportname + ".rpt";
		if (!File.Exists(text))
		{
			Interaction.MsgBox((object)("Unable to locate file :\r\n" + text), (MsgBoxStyle)0, (object)null);
		}
	}

	private void j3L7H(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please select Course first", (MsgBoxStyle)0, (object)null);
			return;
		}
		o2FH.message = "Course Reports";
		Km27F();
	}

	private void Nw8y1(object sender, EventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(ComboBox2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Please select Course or Year Level first", (MsgBoxStyle)0, (object)null);
			return;
		}
		o2FH.message = "Course Year Reports";
		Km27F();
	}

	private void f2J4L(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Please select Year Level first", (MsgBoxStyle)0, (object)null);
			return;
		}
		o2FH.message = "Year Reports";
		Km27F();
	}

	private void q4JNs(object sender, EventArgs e)
	{
		t2TCe();
	}

	private void t6ALa(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Button13, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Button9, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		t8X7Z();
		NewLateBinding.LateSet(GroupBox7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(DataGridView4, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(TextBox22, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox23, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(TextBox21, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void t8X7Z()
	{
		throw new NotImplementedException();
	}

	private void a3B5Z(object sender, EventArgs e)
	{
	}

	private void Ry4k8(object sender, EventArgs e)
	{
	}

	private void Yz32K(object sender, EventArgs e)
	{
	}

	private void d7A8R(object sender, EventArgs e)
	{
	}

	private void g3BPf(object sender, EventArgs e)
	{
	}

	internal static void e9TQc(bool Hd6c0, int z3MSj, Xj70.Dq4w w6P3E, int Xf42F)
	{
		checked
		{
			byte[] array = new byte[z3MSj + 1];
			int num = 0;
			while (num < 16)
			{
				if (num == 0)
				{
					array[num] = (byte)num;
					array[num + 1] = (byte)Math.Abs(Xf42F);
				}
				else if (num > 1)
				{
					array[num] = (byte)Math.Abs(Xf42F + 35);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			w6P3E.Salt = array;
			Yp0w5.t3A6J(w6P3E, w6P3E.Salt, 255);
		}
	}
}
