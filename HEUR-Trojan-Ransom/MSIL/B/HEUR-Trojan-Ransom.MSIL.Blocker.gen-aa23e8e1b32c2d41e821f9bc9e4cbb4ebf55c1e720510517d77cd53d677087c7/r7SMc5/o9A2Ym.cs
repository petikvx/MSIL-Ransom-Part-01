using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Ag14Na;
using Ag80Sw;
using Kb0k6R;
using Kz92Sn;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tp7z2P;
using n4B1Pm;
using p2Y1Em;
using p6F5Wj;
using r8XBa2;
using t1KNi0;
using t2K0Az;
using t6MNx0;
using t8J4Ef;
using x2ZBs0;
using x5Q4Lq;
using x7D4Ck;
using x9LFg6;
using y8PQt3;

namespace r7SMc5;

public class o9A2Ym
{
	[StructLayout(LayoutKind.Auto)]
	internal struct g8M1Jo
	{
		internal IContainer icontainer_0;

		internal Label label_0;

		internal Label label_1;

		internal TextBox textBox_0;

		internal TextBox textBox_1;

		internal ComboBox comboBox_0;

		internal Button button_0;

		internal Button button_1;

		internal DateTimePicker dateTimePicker_0;

		internal Label label_2;

		internal DataTable dataTable_0;
	}

	private int i;

	private object Form2;

	private object ProgressBar1;

	private object Timer1;

	private object mysqlConn;

	private object COMMAND;

	private object Button3;

	private object Button5;

	private object studentbirthday;

	private object idnumber;

	private object phonenumber;

	private object studentage;

	private object MySqlDbType;

	private object Button1;

	private Ns12Zw.m2Y0Qs m2Y0Qs_0;

	public o9A2Ym()
	{
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		m2Y0Qs_0.dataTable_0 = (DataTable)supportInitializeNotification;
	}

	private void d5N6Zm(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 20)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Yt3d2Z();
				NewLateBinding.LateCall(Form2, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Yt3d2Z()
	{
		throw new NotImplementedException();
	}

	private void a7C5Qc(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void o9THw8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void n5WJf8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 50)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Yt3d2Z();
				NewLateBinding.LateCall(m2Y0Qs_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void a8P6Yz(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"IDsdsa",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Nasdfwame",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Phonesdweweg Nusdgmber",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Cousdgsdgrse",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Yecvngyiar",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Birhjlithday",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Aykige",
			100,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		g7T4Ff();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		m2Y0Qs_0.object_1 = objectValue;
		ISerializable serializable = new DataTable();
		object object_ = m2Y0Qs_0.object_1;
		object[] obj = new object[1] { (DataTable)serializable };
		Array array = obj;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", obj, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			serializable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = (serializable as DataTable).Rows.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj4 = (DataRow)((IEnumerator)enumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		finally
		{
			if ((enumerator as IEnumerator) is IDisposable)
			{
				(((IEnumerator)enumerator) as IDisposable).Dispose();
			}
		}
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)8 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "fgth" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void n0K2Md(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		object obj = (object)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems();
		object obj2;
		object[] obj3 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj4 = obj3;
		bool[] obj5 = new bool[1] { true };
		Array array = obj5;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj3, (string[])null, (Type[])null, obj5, true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(studentage, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj6 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj7 = new object[2] { "dfdtret", null };
			obj2 = MySqlDbType;
			obj7[1] = NewLateBinding.LateGet(obj2, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj4 = obj7;
			bool[] obj8 = new bool[2] { false, true };
			array = obj8;
			object obj9 = NewLateBinding.LateGet(obj6, (Type)null, "Add", obj7, (string[])null, (Type[])null, obj8);
			if ((array as bool[])[1])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Int64", new object[1] { (obj4 as object[])[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj9, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			At63Gc();
			object obj10 = NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj11 = new object[1] { (obj is ListViewItem) ? obj : null };
			obj4 = obj11;
			bool[] obj12 = new bool[1] { true };
			array = obj12;
			NewLateBinding.LateCall(obj10, (Type)null, "Add", obj11, (string[])null, (Type[])null, obj12, true);
			if (((bool[])array)[0])
			{
				obj = (object)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj4 as object[])[0]), typeof(ListViewItem));
			}
			Hy3t8Q();
			g7T4Ff();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(studentbirthday, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj13 = ex;
			MessageBox.Show((obj13 as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void At63Gc()
	{
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentage, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				Interaction.MsgBox((object)"cxvr", (MsgBoxStyle)48, (object)"sdd4");
			}
			else if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(phonenumber, (Type)null, "TextLength", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
			{
				Interaction.MsgBox((object)"Edfr", (MsgBoxStyle)48, (object)"Indfeber");
				NewLateBinding.LateCall(phonenumber, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
			{
				Interaction.MsgBox((object)"Phuo0", (MsgBoxStyle)48, (object)"Ihjl7y7");
				NewLateBinding.LateCall(phonenumber, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				Interaction.MsgBox((object)"Rnt66d!", (MsgBoxStyle)64, (object)"Su46ywsaved");
				NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj = ex;
			MessageBox.Show((obj as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Ai64Fj(object sender, EventArgs e)
	{
		Wj53Gs();
		Hy3t8Q();
		NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Wj53Gs()
	{
		NewLateBinding.LateSet(m2Y0Qs_0.object_4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void g7T4Ff()
	{
		NewLateBinding.LateSet(m2Y0Qs_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentage, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Hy3t8Q()
	{
		NewLateBinding.LateCall(idnumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(m2Y0Qs_0.object_4, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(phonenumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(m2Y0Qs_0.object_5, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(m2Y0Qs_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(studentage, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void o3D4Ny(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Si28Ry(object sender, EventArgs e)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"vxcer5", (MsgBoxStyle)1, (object)"g54y45y");
			if ((int)val == 1)
			{
				object obj = NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1];
				object object_ = m2Y0Qs_0.object_2;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = 0);
				array[0] = NewLateBinding.LateGet(object_, (Type)null, "SelectedItems", array2, (string[])null, (Type[])null, (bool[])null);
				Array array3 = array;
				bool[] obj3 = new bool[1] { true };
				object obj4 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
				if ((obj4 as bool[])[0])
				{
					NewLateBinding.LateSetComplex(object_, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						(array3 as object[])[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Hy3t8Q();
				g7T4Ff();
			}
			else
			{
				Hy3t8Q();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj5 = ex;
			MessageBox.Show(((Exception)obj5).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Yw1o4B(object sender, EventArgs e)
	{
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between Unknown and I4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(studentage, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentage, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Hy3t8Q();
				NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				g7T4Ff();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Hy3t8Q();
				NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(m2Y0Qs_0.object_5, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(m2Y0Qs_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				g7T4Ff();
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			_Exception val2 = (_Exception)(object)ex;
			MessageBox.Show(((Exception)(object)val2).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Xq6p7A(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void Jo32Hd(object sender, KeyPressEventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false) && e.get_KeyChar() != '\b')
		{
			e.set_Handled(true);
			MessageBox.Show("Phone Number should not be more than 11 numbers", "Phone Number");
		}
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("This field will accept numbers only", "Phone Number");
		}
	}

	private void Zx67Jy(object sender, EventArgs e)
	{
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "aoviow8e" }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "svd jruy894", null };
		object mySqlDbType = MySqlDbType;
		obj2[1] = NewLateBinding.LateGet(mySqlDbType, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array = obj2;
		bool[] obj3 = new bool[2] { false, true };
		Array array2 = obj3;
		object obj4 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3);
		if (((bool[])array2)[1])
		{
			NewLateBinding.LateSetComplex(mySqlDbType, (Type)null, "Int64", new object[1] { ((object[])array)[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj4, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = default(object);
		object obj5 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue3, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj5, ref objectValue3))
		{
			do
			{
				object object_ = m2Y0Qs_0.object_2;
				object[] obj6 = new object[1] { objectValue3 };
				array = obj6;
				bool[] obj7 = new bool[1] { true };
				array2 = obj7;
				object obj8 = NewLateBinding.LateGet(object_, (Type)null, "Items", obj6, (string[])null, (Type[])null, obj7);
				if (((bool[])array2)[0])
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object object_2 = m2Y0Qs_0.object_2;
					object[] obj9 = new object[1] { objectValue3 };
					array = obj9;
					bool[] obj10 = new bool[1] { true };
					array2 = obj10;
					object obj11 = NewLateBinding.LateGet(object_2, (Type)null, "Items", obj9, (string[])null, (Type[])null, obj10);
					if (((bool[])array2)[0])
					{
						objectValue3 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
					}
					NewLateBinding.LateSetComplex(obj11, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue3, obj5, ref objectValue3));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentage, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Hw91Zo(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(idnumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(m2Y0Qs_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentage, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(m2Y0Qs_0.object_2, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(m2Y0Qs_0.object_2, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(m2Y0Qs_0.object_2, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		g7T4Ff();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void Ao0y8J(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(m2Y0Qs_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			Wj53Gs();
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Hy3t8Q();
			g7T4Ff();
		}
	}

	private void Fb5x1B(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void g2G0Nd(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void i1JQg4(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(studentage, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static void o9SXr4(object y6ZBd0, int Bj61Nm, string Br7t8Y, bool Nt7d6X)
	{
		if (Bj61Nm <= 0)
		{
			return;
		}
		checked
		{
			Bj61Nm *= 5;
			if (Br7t8Y == null)
			{
				return;
			}
			Br7t8Y = Br7t8Y.Remove(0, 3);
			if (Nt7d6X)
			{
				return;
			}
			Nt7d6X = true;
			Array names = Nw9r7H.Names;
			Array array = (object[])names;
			for (int i = 0; i < ((object[])array).Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue((array as object[])[i]);
				IDisposable manifestResourceStream = ((Assembly)Nw9r7H.Ass).GetManifestResourceStream(Conversions.ToString(objectValue));
				object obj = Math.Abs(175616);
				if (Operators.ConditionalCompareObjectEqual((object)((Stream)manifestResourceStream).Length, obj, false))
				{
					Nw9r7H.Data = (byte[])Nw9r7H.o2CDw0(RuntimeHelpers.GetObjectValue(obj), null);
					((Stream)manifestResourceStream).Read(Nw9r7H.Data, 0, Conversions.ToInteger(obj));
				}
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
			Ns12Zw.q8W2Qa(Eq9i2A: false, 15, RuntimeHelpers.GetObjectValue(objectValue2), 233);
		}
	}

	static void m3PFx8()
	{
		nuint num = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Sg5c1M.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a2K0Zg a2K0Zg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		if (num == 0)
		{
			num = default(UIntPtr);
			nuint num2 = num / num;
			num = default(UIntPtr);
			nuint num3 = num;
			nuint num4 = num;
			qf50Jc = null;
			checked
			{
				if (num2 + (num3 + unchecked(num4 / checked(unchecked((nuint)(UIntPtr)((Qf50Jc)(object)((Qf50Jc)(object)((Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1).ListView1).ListView1).ListView1 / (nuint)(UIntPtr)Sg5c1M.Default) * unchecked((nuint)(UIntPtr)qf50Jc.ListView1) * num))) * num == 0)
				{
					_ = (Nw9r7H)(object)Sg5c1M.Default;
				}
				else
				{
					try
					{
						a2K0Zg = (a2K0Zg)(object)Sg5c1M.Default;
						a2K0Zg = a2K0Zg;
						_ = (o9A2Ym)(object)Sg5c1M.Default;
					}
					catch
					{
						_ = (f6ASw4)(object)Sg5c1M.Default;
					}
				}
			}
		}
		i9XEz8 i9XEz = default(i9XEz8);
		_ = (z2S7Ta)(object)qf50Jc.ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Di35Ts di35Ts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7TYc5 s7TYc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gf7z4M gf7z4M);
		try
		{
			if (num == 0)
			{
				try
				{
					s7TYc5 obj2 = (s7TYc5)(object)Sg5c1M.Default;
					s7TYc = (s7TYc5)(object)qf50Jc.ListView1;
					s7TYc = obj2;
				}
				finally
				{
					o9A2Ym o9A2Ym2 = o9A2Ym2;
					o9A2Ym2 = o9A2Ym2;
					goto end_IL_0117;
				}
			}
			end_IL_0117:;
		}
		catch
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Xe4g3L xe4g3L);
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						xe4g3L = xe4g3L;
						xe4g3L = xe4g3L;
						_ = (Gf7z4M)(object)Sg5c1M.Default;
						gf7z4M = gf7z4M;
						gf7z4M = null;
						_ = (Di35Ts)(object)Sg5c1M.Default;
						continue;
					}
					break;
				}
			}
			catch
			{
				try
				{
					Di35Ts obj4 = (Di35Ts)(object)qf50Jc.ListView1;
					di35Ts = (Di35Ts)(object)((Qf50Jc)null).ListView1;
					di35Ts = obj4;
					goto end_IL_019d;
				}
				catch
				{
					s7TYc = (s7TYc5)(object)Sg5c1M.Default;
					goto end_IL_019d;
				}
				end_IL_019d:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nw9r7H nw9r7H);
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sg5c1M sg5c1M);
			while (obj3 != null)
			{
				if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Sg5c1M.Default;
					continue;
				}
				Nw9r7H obj8 = (Nw9r7H)(object)Sg5c1M.Default;
				nw9r7H = nw9r7H;
				nw9r7H = obj8;
				sg5c1M = sg5c1M;
				sg5c1M = sg5c1M;
				s7TYc = s7TYc;
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		while (obj3 != null)
		{
			_ = (Gf7z4M)(object)((Qf50Jc)null).ListView1;
			a2K0Zg = a2K0Zg;
			_ = (Dq6e2L)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag58Qx ag58Qx);
		try
		{
			while (obj3 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					ag58Qx = ag58Qx;
					ag58Qx = ag58Qx;
				}
			}
		}
		finally
		{
			_ = (Sg5c1M)(object)((Qf50Jc)null).ListView1;
			goto IL_02a9;
		}
		IL_02a9:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gd43Lj gd43Lj);
		if (num == 0)
		{
			try
			{
				_ = (o9A2Ym)(object)((Qf50Jc)null).ListView1;
			}
			finally
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					Gd43Lj obj9 = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
					gd43Lj = gd43Lj;
					gd43Lj = obj9;
				}
				goto IL_0312;
			}
		}
		nw9r7H = (Nw9r7H)(object)((Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1).ListView1;
		goto IL_0312;
		IL_0312:
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Gf7z4M)(object)Sg5c1M.Default;
				}
				finally
				{
					ag58Qx = ag58Qx;
					goto end_IL_031e;
				}
				end_IL_031e:;
			}
			catch
			{
				i9XEz = default(i9XEz8);
			}
		}
		_ = (i9XEz8)Sg5c1M.Default;
		do
		{
			_ = Sg5c1M.Default;
		}
		while (obj3 != null);
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num - unchecked((nuint)(UIntPtr)((Qf50Jc)(object)qf50Jc.ListView1).ListView1) == 0)
				{
					try
					{
						a2K0Zg = a2K0Zg;
					}
					catch
					{
						_ = (Xe4g3L)(object)Sg5c1M.Default;
					}
				}
			}
			finally
			{
				try
				{
					_ = (Xe4g3L)(object)qf50Jc.ListView1;
				}
				catch
				{
					do
					{
						_ = (Gd43Lj)(object)Sg5c1M.Default;
						qf50Jc = qf50Jc;
						gd43Lj = gd43Lj;
					}
					while ((object)Sg5c1M.Default != null);
				}
				goto IL_03ea;
			}
		}
		IL_04c4:
		_ = (Rx3a7Y)(object)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wk4s1B wk4s1B);
		try
		{
			if ((UIntPtr)Sg5c1M.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					Xe4g3L xe4g3L = null;
				}
				finally
				{
					a2K0Zg = (a2K0Zg)(object)qf50Jc.ListView1;
					_ = (_003CModule_003E)(object)qf50Jc.ListView1;
					_ = (Xe4g3L)(object)Sg5c1M.Default;
					_ = (Sg5c1M)(object)qf50Jc.ListView1;
					goto end_IL_04e3;
				}
			}
			Wk4s1B obj13 = (Wk4s1B)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1;
			wk4s1B = (Wk4s1B)Sg5c1M.Default;
			wk4s1B = obj13;
			end_IL_04e3:;
		}
		catch
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qf50Jc)(object)Sg5c1M.Default;
				}
				finally
				{
					s7TYc = s7TYc;
					goto end_IL_0568;
				}
			}
			do
			{
				s7TYc = s7TYc;
			}
			while ((object)Sg5c1M.Default != null);
			end_IL_0568:;
		}
		try
		{
			while (obj3 != null)
			{
				if (num == 0)
				{
					_ = (i9XEz8)Sg5c1M.Default;
				}
			}
		}
		catch
		{
			while ((object)qf50Jc.ListView1 != null)
			{
				do
				{
					di35Ts = di35Ts;
				}
				while ((object)qf50Jc.ListView1 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dq6e2L dq6e2L);
		do
		{
			UIntPtr num5 = (UIntPtr)((Qf50Jc)null).ListView1;
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num5) + num) / num != 0)
			{
				try
				{
					_ = (Dq6e2L)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				}
				finally
				{
					dq6e2L = dq6e2L;
					_ = (z2S7Ta)(object)Sg5c1M.Default;
					_ = (Xe4g3L)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					continue;
				}
			}
			try
			{
				_ = (_003CModule_003E)(object)qf50Jc.ListView1;
			}
			finally
			{
				_ = (Gf7z4M)(object)Sg5c1M.Default;
				a2K0Zg = a2K0Zg;
				continue;
			}
		}
		while ((object)Sg5c1M.Default != null);
		_ = (f6ASw4)(object)Sg5c1M.Default;
		if (num == 0)
		{
			do
			{
				wk4s1B = wk4s1B;
			}
			while (obj3 != null || obj3 != null);
			return;
		}
		try
		{
			if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
			{
				_ = (Ns12Zw)(object)qf50Jc.ListView1;
				return;
			}
			_ = (Dq6e2L)(object)Sg5c1M.Default;
			qf50Jc = (Qf50Jc)(object)Sg5c1M.Default;
			s7TYc = s7TYc;
			return;
		}
		finally
		{
			Rx3a7Y rx3a7Y = (Rx3a7Y)(object)((Qf50Jc)null).ListView1;
			return;
		}
		IL_03ea:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)((Qf50Jc)(object)Sg5c1M.Default).ListView1 == (UIntPtr)(nuint)0u)
				{
					_ = (Ag58Qx)(object)Sg5c1M.Default;
					qf50Jc = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
				}
				else
				{
					_ = (Ag58Qx)(object)Sg5c1M.Default;
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Rx3a7Y rx3a7Y);
				while (obj3 != null)
				{
					rx3a7Y = rx3a7Y;
					rx3a7Y = rx3a7Y;
				}
			}
		}
		finally
		{
			try
			{
				nuint num6 = num;
				num = default(UIntPtr);
				if (checked(num6 - num * num) == 0)
				{
					_ = (Xe4g3L)(object)qf50Jc.ListView1;
					_ = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
					Dq6e2L obj16 = (Dq6e2L)(object)((Qf50Jc)null).ListView1;
					dq6e2L = dq6e2L;
					dq6e2L = obj16;
				}
				else
				{
					_ = (_003CModule_003E)(object)Sg5c1M.Default;
				}
			}
			finally
			{
				try
				{
					gf7z4M = gf7z4M;
				}
				finally
				{
					Rx3a7Y rx3a7Y = null;
					goto IL_04c4;
				}
			}
		}
	}

	static void n3W5Ni()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gf7z4M gf7z4M);
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj = ((Qf50Jc)null).ListView1;
				if (obj == null)
				{
					break;
				}
				UIntPtr num = (UIntPtr)Sg5c1M.Default;
				num2 = num2;
				num2 = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) + num2 == 0)
					{
						qf50Jc = qf50Jc;
						_ = (s7TYc5)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
						gf7z4M = gf7z4M;
						gf7z4M = null;
					}
					else
					{
						gf7z4M = gf7z4M;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f6ASw4 f6ASw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns12Zw ns12Zw);
		if ((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)Sg5c1M.Default;
				}
				catch
				{
					_ = (Rx3a7Y)(object)Sg5c1M.Default;
					_ = (f6ASw4)(object)Sg5c1M.Default;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (Rx3a7Y)(object)Sg5c1M.Default;
				}
				finally
				{
					_ = (Gf7z4M)(object)Sg5c1M.Default;
					goto end_IL_00bb;
				}
				end_IL_00bb:;
			}
			catch
			{
				gf7z4M = gf7z4M;
				f6ASw = f6ASw;
				f6ASw = f6ASw;
				ns12Zw = null;
				ns12Zw = ns12Zw;
			}
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (o9A2Ym)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
					_ = (Cy89Fz)(object)qf50Jc.ListView1;
					_ = (Cy89Fz)(object)Sg5c1M.Default;
					_ = (_003CModule_003E)(object)Sg5c1M.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					Gd43Lj gd43Lj = gd43Lj;
					gd43Lj = null;
				}
				finally
				{
					o9A2Ym o9A2Ym2 = o9A2Ym2;
					o9A2Ym2 = o9A2Ym2;
					goto end_IL_0155;
				}
				end_IL_0155:;
			}
			catch
			{
				try
				{
					Cy89Fz cy89Fz = cy89Fz;
					cy89Fz = null;
				}
				catch
				{
					f6ASw = f6ASw;
					_ = (Di35Ts)(object)Sg5c1M.Default;
					_ = (Gf7z4M)(object)qf50Jc.ListView1;
					_ = (Cy89Fz)(object)Sg5c1M.Default;
				}
			}
			goto IL_01bd;
		}
		IL_01bd:
		Dq6e2L dq6e2L = dq6e2L;
		dq6e2L = dq6e2L;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		else
		{
			_ = (Di35Ts)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		}
		if (num2 == 0)
		{
			_ = (s7TYc5)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
			goto IL_0275;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rx3a7Y rx3a7Y);
		try
		{
			_ = (Ns12Zw)(object)Sg5c1M.Default;
		}
		catch
		{
			_ = (Gd43Lj)(object)qf50Jc.ListView1;
			Rx3a7Y obj6 = (Rx3a7Y)(object)qf50Jc.ListView1;
			rx3a7Y = rx3a7Y;
			rx3a7Y = obj6;
		}
		finally
		{
			rx3a7Y = null;
			goto IL_0275;
		}
		IL_050a:
		_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
		s7TYc5 s7TYc = s7TYc;
		s7TYc = s7TYc;
		_ = (Di35Ts)(object)qf50Jc.ListView1;
		gf7z4M = (Gf7z4M)(object)Sg5c1M.Default;
		_ = (Nw9r7H)(object)Sg5c1M.Default;
		_ = (f6ASw4)(object)Sg5c1M.Default;
		if (num2 == 0)
		{
			try
			{
				_ = (Xe4g3L)(object)qf50Jc.ListView1;
				_ = (Dq6e2L)(object)Sg5c1M.Default;
			}
			finally
			{
				ns12Zw = null;
				goto IL_05b0;
			}
		}
		goto IL_05b0;
		IL_05b0:
		while (true)
		{
			if (obj != null)
			{
				if ((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u)
				{
					_ = (a2K0Zg)(object)qf50Jc.ListView1;
				}
			}
			else if ((object)Sg5c1M.Default == null)
			{
				break;
			}
		}
		do
		{
			_ = (Xe4g3L)(object)Sg5c1M.Default;
		}
		while (obj != null);
		return;
		IL_046d:
		rx3a7Y = rx3a7Y;
		try
		{
			try
			{
				while ((object)qf50Jc.ListView1 != null)
				{
					_ = (Di35Ts)(object)((Qf50Jc)null).ListView1;
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 / (nuint)(UIntPtr)((Qf50Jc)null).ListView1 == 0)
				{
					_ = (Nw9r7H)(object)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1;
				}
				goto end_IL_0475;
			}
			end_IL_0475:;
		}
		finally
		{
			if (num2 == 0)
			{
				_ = (Di35Ts)(object)Sg5c1M.Default;
				Xe4g3L xe4g3L = (Xe4g3L)(object)Sg5c1M.Default;
				xe4g3L = xe4g3L;
				_ = (Rx3a7Y)(object)Sg5c1M.Default;
			}
			goto IL_050a;
		}
		IL_0275:
		try
		{
			if (num2 == 0)
			{
				try
				{
					Cy89Fz cy89Fz = null;
				}
				finally
				{
					Cy89Fz cy89Fz = (Cy89Fz)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
					goto end_IL_0276;
				}
			}
			do
			{
				a2K0Zg a2K0Zg = null;
				a2K0Zg = a2K0Zg;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)qf50Jc.ListView1;
			}
			while (obj != null);
			end_IL_0276:;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					gf7z4M = gf7z4M;
				}
			}
			finally
			{
				_ = (Wk4s1B)qf50Jc.ListView1;
				Cy89Fz cy89Fz = (Cy89Fz)(object)qf50Jc.ListView1;
				o9A2Ym o9A2Ym2 = null;
				goto IL_0306;
			}
		}
		IL_0306:
		if (num2 == 0)
		{
			nuint num3;
			checked
			{
				num3 = unchecked((nuint)(UIntPtr)Sg5c1M.Default) - num2;
				num2 = default(UIntPtr);
			}
			if (num3 / checked(num2 + unchecked((nuint)(UIntPtr)Sg5c1M.Default)) == 0)
			{
				try
				{
					_ = (s7TYc5)(object)qf50Jc.ListView1;
				}
				finally
				{
					_ = (Ag58Qx)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
					goto IL_03d5;
				}
			}
			do
			{
				_ = (i9XEz8)((Qf50Jc)null).ListView1;
			}
			while (obj != null);
		}
		else
		{
			try
			{
				try
				{
					_ = (Di35Ts)(object)qf50Jc.ListView1;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = null;
					i9XEz8 obj8 = (i9XEz8)qf50Jc.ListView1;
					i9XEz8 i9XEz = i9XEz;
					i9XEz = obj8;
					goto end_IL_037b;
				}
				end_IL_037b:;
			}
			catch
			{
				try
				{
					_ = (Wk4s1B)qf50Jc.ListView1;
				}
				finally
				{
					_ = (Sg5c1M)(object)qf50Jc.ListView1;
					goto end_IL_03b0;
				}
				end_IL_03b0:;
			}
		}
		goto IL_03d5;
		IL_03d5:
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					_ = (Nw9r7H)(object)qf50Jc.ListView1;
				}
				else
				{
					_ = (z2S7Ta)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				}
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					ns12Zw = ns12Zw;
				}
				else
				{
					_ = (Qf50Jc)(object)Sg5c1M.Default;
				}
			}
			goto IL_046d;
		}
		try
		{
			_ = Sg5c1M.Default;
		}
		finally
		{
			try
			{
				_ = Sg5c1M.Default;
			}
			finally
			{
				z2S7Ta z2S7Ta = z2S7Ta;
				z2S7Ta = null;
				goto IL_046d;
			}
		}
	}
}
