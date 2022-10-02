using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Ag14Na;
using Ag80Sw;
using Kz92Sn;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tp7z2P;
using n4B1Pm;
using p2Y1Em;
using p6F5Wj;
using r7SMc5;
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

namespace Kb0k6R;

public class Dq6e2L
{
	internal sealed class Ck16Bg
	{
		internal sealed class q1N7Ar
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

			internal q1N7Ar()
			{
			}
		}

		public string _0024VB_0024Local_Splitter;

		[SpecialName]
		internal bool c1RJq5(char n2SPj7)
		{
			return Operators.CompareString(Conversions.ToString(n2SPj7), _0024VB_0024Local_Splitter, false) != 0;
		}
	}

	internal sealed class o4GDz2
	{
		internal int int_0;

		internal object object_0;

		internal object object_1;

		internal DataTable dataTable_0;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal object object_9;

		internal o4GDz2()
		{
		}
	}

	internal sealed class n3TWs8
	{
		internal int int_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal n3TWs8()
		{
		}
	}

	private object Form2;

	private object ProgressBar1;

	private object Timer1;

	private object studentwindow;

	private object mysqlConn;

	private object COMMAND;

	private DataTable dt;

	private object Button3;

	private object Button4;

	private object Button5;

	private object studentbirthday;

	private object idnumber;

	private object yrcmb;

	private object MySqlDbType;

	private object Button1;

	private Qf50Jc.k5G1Js k5G1Js_0;

	public Dq6e2L()
	{
		dt = new DataTable();
	}

	private void k2DYc8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			k5G1Js_0.int_0++;
			if (k5G1Js_0.int_0 > 20)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Dw51Hc();
				NewLateBinding.LateCall(Form2, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Dw51Hc()
	{
		throw new NotImplementedException();
	}

	private void b6SHn7(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		k5G1Js_0.int_0 = 1;
	}

	private void Pn2f1M(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		k5G1Js_0.int_0 = 1;
	}

	private void g5F8Nw(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			k5G1Js_0.int_0++;
			if (k5G1Js_0.int_0 > 50)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Dw51Hc();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void La0n5Q(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"IDsdsa",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Nasdfwame",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Phonesdweweg Nusdgmber",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Cousdgsdgrse",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Yecvngyiar",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Birhjlithday",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Aykige",
			100,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		Sc03Dn();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		k5G1Js_0.object_0 = objectValue;
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		object object_ = k5G1Js_0.object_0;
		object[] obj = new object[1] { marshalByValueComponent as DataTable };
		object obj2 = obj;
		bool[] obj3 = new bool[1] { true };
		object obj4 = obj3;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", obj, (string[])null, (Type[])null, obj3, true);
		if (((bool[])obj4)[0])
		{
			marshalByValueComponent = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj2)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = (marshalByValueComponent as DataTable).Rows.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj5 = (DataRow)(enumerator as IEnumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj5)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj5)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj5)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
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

	private void Ci6t2B(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		ICloneable cloneable = (ICloneable)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)cloneable).get_SubItems();
		object obj;
		object[] obj2 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		Array array = obj4;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4, true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)cloneable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)cloneable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(k5G1Js_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)cloneable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(k5G1Js_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }), true);
		if (((bool[])array)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj5 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj6 = new object[2] { "dfdtret", null };
			obj = MySqlDbType;
			obj6[1] = NewLateBinding.LateGet(obj, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj3 = obj6;
			bool[] obj7 = new bool[2] { false, true };
			array = obj7;
			object obj8 = NewLateBinding.LateGet(obj5, (Type)null, "Add", obj6, (string[])null, (Type[])null, obj7);
			if ((array as bool[])[1])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Int64", new object[1] { (obj3 as object[])[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj8, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			e5H4Xc();
			object obj9 = NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj10 = new object[1] { (cloneable is ListViewItem) ? cloneable : null };
			obj3 = obj10;
			bool[] obj11 = new bool[1] { true };
			array = obj11;
			NewLateBinding.LateCall(obj9, (Type)null, "Add", obj10, (string[])null, (Type[])null, obj11, true);
			if (((bool[])array)[0])
			{
				cloneable = (ICloneable)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj3 as object[])[0]), typeof(ListViewItem));
			}
			Bq5m0Z();
			Sc03Dn();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(studentbirthday, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj12 = ex;
			MessageBox.Show(((Exception)obj12).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void e5H4Xc()
	{
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(k5G1Js_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(k5G1Js_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(k5G1Js_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				Interaction.MsgBox((object)"cxvr", (MsgBoxStyle)48, (object)"sdd4");
			}
			else if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "TextLength", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
			{
				Interaction.MsgBox((object)"Edfr", (MsgBoxStyle)48, (object)"Indfeber");
				NewLateBinding.LateCall(k5G1Js_0.object_3, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
			{
				Interaction.MsgBox((object)"Phuo0", (MsgBoxStyle)48, (object)"Ihjl7y7");
				NewLateBinding.LateCall(k5G1Js_0.object_3, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			ISerializable serializable = ex;
			MessageBox.Show((serializable as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Re04Kt(object sender, EventArgs e)
	{
		Bm9i4K();
		Bq5m0Z();
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Bm9i4K()
	{
		NewLateBinding.LateSet(k5G1Js_0.object_2, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(k5G1Js_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Sc03Dn()
	{
		NewLateBinding.LateSet(k5G1Js_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(k5G1Js_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(k5G1Js_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Bq5m0Z()
	{
		NewLateBinding.LateCall(idnumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(k5G1Js_0.object_2, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(k5G1Js_0.object_3, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(k5G1Js_0.object_4, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(k5G1Js_0.object_5, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void r9AYo3(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(k5G1Js_0.object_2, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_3, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Jq37Hc(object sender, EventArgs e)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
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
				object obj = NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1];
				object object_ = k5G1Js_0.object_1;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = 0);
				array[0] = NewLateBinding.LateGet(object_, (Type)null, "SelectedItems", array2, (string[])null, (Type[])null, (bool[])null);
				Array array3 = array;
				bool[] obj3 = new bool[1] { true };
				Array array4 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
				if ((array4 as bool[])[0])
				{
					NewLateBinding.LateSetComplex(object_, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						(array3 as object[])[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Bq5m0Z();
				Sc03Dn();
			}
			else
			{
				Bq5m0Z();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Ns0e9W(object sender, EventArgs e)
	{
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between Unknown and I4
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(k5G1Js_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(k5G1Js_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(k5G1Js_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(k5G1Js_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(k5G1Js_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Bq5m0Z();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Sc03Dn();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Bq5m0Z();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(k5G1Js_0.object_4, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				Sc03Dn();
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj = ex;
			MessageBox.Show(((Exception)obj).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Js92Mo(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void Sf30Kp(object sender, KeyPressEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false) && e.get_KeyChar() != '\b')
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

	private void r1G7Lq(object sender, EventArgs e)
	{
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
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
		if ((array2 as bool[])[1])
		{
			NewLateBinding.LateSetComplex(mySqlDbType, (Type)null, "Int64", new object[1] { ((object[])array)[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj4, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = default(object);
		object obj5 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue3, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj5, ref objectValue3))
		{
			do
			{
				object object_ = k5G1Js_0.object_1;
				object[] obj6 = new object[1] { objectValue3 };
				array = obj6;
				bool[] obj7 = new bool[1] { true };
				array2 = obj7;
				object obj8 = NewLateBinding.LateGet(object_, (Type)null, "Items", obj6, (string[])null, (Type[])null, obj7);
				if ((array2 as bool[])[0])
				{
					objectValue3 = RuntimeHelpers.GetObjectValue((array as object[])[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object object_2 = k5G1Js_0.object_1;
					object[] obj9 = new object[1] { objectValue3 };
					array = obj9;
					bool[] obj10 = new bool[1] { true };
					array2 = obj10;
					object obj11 = NewLateBinding.LateGet(object_2, (Type)null, "Items", obj9, (string[])null, (Type[])null, obj10);
					if (((bool[])array2)[0])
					{
						objectValue3 = RuntimeHelpers.GetObjectValue((array as object[])[0]);
					}
					NewLateBinding.LateSetComplex(obj11, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue3, obj5, ref objectValue3));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(k5G1Js_0.object_2, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_3, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Yx20Ck(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(idnumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_2, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_3, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(k5G1Js_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(k5G1Js_0.object_1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(k5G1Js_0.object_1, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(k5G1Js_0.object_1, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		Sc03Dn();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void d2ERf7(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			Bm9i4K();
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Bq5m0Z();
			Sc03Dn();
		}
	}

	private void Sb45Aa(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void p7N2Sr(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void Zd47Fb(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(k5G1Js_0.object_5, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static object p2AXy3(object c9E1Lj, object o2YTt4)
	{
		object obj = new Ck16Bg();
		object obj2 = string.Format("{0}.{1}.{2}", "WWSWWyWWsWWtWWeWWmWW", "WWRWWeWWfWWlWWeWWcWWtWWiWWoWWnWW", "WWAWWsWWsWWeWWmWWbWWlWWyWW");
		(obj as Ck16Bg)._0024VB_0024Local_Splitter = "W";
		IComparable<string> comparable = string.Format("{0}{1}{2}{3}", "l".ToUpper(), "O".ToLower(), "A".ToLower(), "D".ToLower());
		obj2 = new string((obj2 as string).ToCharArray().Where(((Ck16Bg)obj).c1RJq5).ToArray());
		Type? type = Type.GetType((string)obj2);
		object[] obj3 = new object[5]
		{
			comparable as string,
			256,
			null,
			null,
			new object[1] { o2YTt4 }
		};
		Array array = obj3;
		bool[] obj4 = new bool[5] { true, false, false, false, false };
		Array array2 = obj4;
		object obj5 = NewLateBinding.LateGet((object)type, (Type)null, "InvokeMember", obj3, (string[])null, (Type[])null, obj4);
		if ((array2 as bool[])[0])
		{
			comparable = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(string));
		}
		Nw9r7H.Ass = RuntimeHelpers.GetObjectValue(obj5);
		object result = default(object);
		return result;
	}

	static void i6SZg0()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		object obj4;
		try
		{
			try
			{
				qf50Jc = (Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				_ = (Di35Ts)(object)qf50Jc.ListView1;
				_ = (Di35Ts)(object)Sg5c1M.Default;
				_ = (_003CModule_003E)(object)Sg5c1M.Default;
				Rx3a7Y rx3a7Y = null;
				rx3a7Y = rx3a7Y;
			}
			catch
			{
				Gd43Lj gd43Lj = null;
				gd43Lj = gd43Lj;
			}
		}
		catch
		{
			qf50Jc = qf50Jc;
		}
		finally
		{
			i9XEz8 obj3 = (i9XEz8)Sg5c1M.Default;
			i9XEz8 i9XEz = default(i9XEz8);
			i9XEz = obj3;
			obj4 = null;
			goto IL_0094;
		}
		IL_0094:
		nuint num = (UIntPtr)Sg5c1M.Default;
		if (checked(num * num) == 0)
		{
			if (checked(num + num) == 0)
			{
				qf50Jc = qf50Jc;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (o9A2Ym)(object)Sg5c1M.Default;
		}
		else
		{
			qf50Jc = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
			_ = (Ns12Zw)(object)((Qf50Jc)null).ListView1;
			_ = (Ns12Zw)(object)Sg5c1M.Default;
			s7TYc5 s7TYc = s7TYc;
			s7TYc = s7TYc;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag58Qx ag58Qx);
		while ((object)Sg5c1M.Default != null)
		{
			try
			{
				try
				{
					Sg5c1M sg5c1M = null;
					sg5c1M = sg5c1M;
				}
				finally
				{
					Ag58Qx obj5 = (Ag58Qx)(object)qf50Jc.ListView1;
					ag58Qx = null;
					ag58Qx = obj5;
					goto end_IL_011e;
				}
				end_IL_011e:;
			}
			finally
			{
				_ = (Xe4g3L)(object)Sg5c1M.Default;
				continue;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Wk4s1B)qf50Jc.ListView1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				a2K0Zg a2K0Zg = a2K0Zg;
				a2K0Zg = a2K0Zg;
			}
			catch
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					s7TYc5 s7TYc = (s7TYc5)(object)Sg5c1M.Default;
				}
			}
		}
		else
		{
			_003CModule_003E obj7 = (_003CModule_003E)(object)Sg5c1M.Default;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = obj7;
		}
		_ = (Ns12Zw)(object)qf50Jc.ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gf7z4M gf7z4M);
		if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
		{
			_ = (Wk4s1B)qf50Jc.ListView1;
		}
		else
		{
			Gf7z4M obj8 = (Gf7z4M)(object)((Qf50Jc)null).ListView1;
			gf7z4M = null;
			gf7z4M = obj8;
		}
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				_ = (_003CModule_003E)(object)Sg5c1M.Default;
				continue;
			}
			_003CModule_003E = _003CModule_003E;
			_ = (i9XEz8)qf50Jc.ListView1;
			s7TYc5 s7TYc = (s7TYc5)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
		}
		while (obj4 != null || obj4 != null);
		while (obj4 != null)
		{
			Gd43Lj gd43Lj = (Gd43Lj)(object)Sg5c1M.Default;
		}
		if (num == 0)
		{
			do
			{
				if (checked(num - num) == 0)
				{
					_ = (Rx3a7Y)(object)Sg5c1M.Default;
				}
			}
			while (obj4 != null);
		}
		gf7z4M = gf7z4M;
		do
		{
			Gd43Lj gd43Lj = (Gd43Lj)(object)Sg5c1M.Default;
		}
		while (obj4 != null);
		try
		{
			try
			{
				qf50Jc = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
			}
			finally
			{
				if (num == 0)
				{
					_ = (Qf50Jc)(object)qf50Jc.ListView1;
				}
				goto end_IL_02cf;
			}
			end_IL_02cf:;
		}
		finally
		{
			try
			{
				try
				{
					_ = Sg5c1M.Default;
				}
				finally
				{
					i9XEz8 i9XEz = (i9XEz8)qf50Jc.ListView1;
					goto end_IL_02fb;
				}
				end_IL_02fb:;
			}
			finally
			{
				do
				{
					_ = (Dq6e2L)(object)qf50Jc.ListView1;
				}
				while (obj4 != null);
				goto IL_0374;
			}
		}
		IL_0374:
		while (true)
		{
			if (obj4 != null)
			{
				_ = (z2S7Ta)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				_ = (Cy89Fz)(object)qf50Jc.ListView1;
				_ = (Ag58Qx)(object)qf50Jc.ListView1;
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Cy89Fz cy89Fz = cy89Fz;
					cy89Fz = null;
				}
				else
				{
					_ = (o9A2Ym)(object)Sg5c1M.Default;
				}
			}
			finally
			{
				Wk4s1B wk4s1B = (Wk4s1B)qf50Jc.ListView1;
				wk4s1B = wk4s1B;
				goto end_IL_037d;
			}
			end_IL_037d:;
		}
		catch
		{
			ag58Qx = ag58Qx;
		}
		_ = (Gf7z4M)(object)qf50Jc.ListView1;
		_ = (Xe4g3L)(object)((Qf50Jc)null).ListView1;
		_ = (Rx3a7Y)(object)Sg5c1M.Default;
		_ = (o9A2Ym)(object)qf50Jc.ListView1;
		_ = (f6ASw4)(object)Sg5c1M.Default;
		_003CModule_003E = null;
	}
}
