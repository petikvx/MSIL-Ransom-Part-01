using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Kb0k6R;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace t6MNx0;

public class a2K0Zg
{
	private object ProgressBar1;

	private object studentwindow;

	private object COMMAND;

	private DataTable dt;

	private object Button4;

	private object Button5;

	private object idnumber;

	private object studentname;

	private object phonenumber;

	private object coursecmb;

	private object yrcmb;

	private object Button1;

	private Dq6e2L.n3TWs8 n3TWs8_0 = new Dq6e2L.n3TWs8();

	public a2K0Zg()
	{
		dt = new DataTable();
	}

	private void z5DEw8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			n3TWs8_0.int_0++;
			if (n3TWs8_0.int_0 > 20)
			{
				NewLateBinding.LateSet(n3TWs8_0.object_1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				So6k2Q();
				NewLateBinding.LateCall(n3TWs8_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void So6k2Q()
	{
		throw new NotImplementedException();
	}

	private void Zp2y3H(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(n3TWs8_0.object_1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		n3TWs8_0.int_0 = 1;
	}

	private void Kj86Ei(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(n3TWs8_0.object_1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		n3TWs8_0.int_0 = 1;
	}

	private void Sp3j4F(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			n3TWs8_0.int_0++;
			if (n3TWs8_0.int_0 > 50)
			{
				NewLateBinding.LateSet(n3TWs8_0.object_1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				So6k2Q();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void z0M1Yd(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"IDsdsa",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Nasdfwame",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Phonesdweweg Nusdgmber",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Cousdgsdgrse",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Yecvngyiar",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Birhjlithday",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Aykige",
			100,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		Aa10Fe();
		NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_3 = objectValue2;
		ISerializable serializable = new DataTable();
		object object_ = n3TWs8_0.object_3;
		object[] obj = new object[1] { (DataTable)serializable };
		Array array = obj;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", obj, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			serializable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = (serializable as DataTable).Rows.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj4 = (DataRow)(enumerator as IEnumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		finally
		{
			if ((enumerator as IEnumerator) is IDisposable)
			{
				((enumerator as IEnumerator) as IDisposable).Dispose();
			}
		}
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)8 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "CustomFormat", new object[1] { "fgth" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Cr5w2K(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		object obj = (object)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems();
		object obj2;
		object[] obj3 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj4 = obj3;
		bool[] obj5 = new bool[1] { true };
		object obj6 = obj5;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj3, (string[])null, (Type[])null, obj5, true);
		if ((obj6 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj6 = new bool[1] { true }), true);
		if (((bool[])obj6)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(coursecmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj6 = new bool[1] { true }), true);
		if ((obj6 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj6 = new bool[1] { true }), true);
		if (((bool[])obj6)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(n3TWs8_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj6 = new bool[1] { true }), true);
		if (((bool[])obj6)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(obj4 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(n3TWs8_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj6 = new bool[1] { true }), true);
		if ((obj6 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (obj4 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj7 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj8 = new object[2] { "dfdtret", null };
			obj2 = n3TWs8_0.object_8;
			obj8[1] = NewLateBinding.LateGet(obj2, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj4 = obj8;
			bool[] obj9 = new bool[2] { false, true };
			obj6 = obj9;
			object obj10 = NewLateBinding.LateGet(obj7, (Type)null, "Add", obj8, (string[])null, (Type[])null, obj9);
			if (((bool[])obj6)[1])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Int64", new object[1] { (obj4 as object[])[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj10, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			z9DJx2();
			object obj11 = NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj12 = new object[1] { (object)(ListViewItem)obj };
			obj4 = obj12;
			bool[] obj13 = new bool[1] { true };
			obj6 = obj13;
			NewLateBinding.LateCall(obj11, (Type)null, "Add", obj12, (string[])null, (Type[])null, obj13, true);
			if ((obj6 as bool[])[0])
			{
				obj = (object)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj4)[0]), typeof(ListViewItem));
			}
			Px0n7Q();
			Aa10Fe();
			NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(coursecmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(n3TWs8_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj14 = ex;
			MessageBox.Show((obj14 as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void z9DJx2()
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(coursecmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(n3TWs8_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(n3TWs8_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(coursecmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
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
				NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void g8HNy4(object sender, EventArgs e)
	{
		Ec3j5G();
		Px0n7Q();
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Ec3j5G()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(coursecmb, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Aa10Fe()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(coursecmb, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(yrcmb, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Px0n7Q()
	{
		NewLateBinding.LateCall(idnumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(studentname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(phonenumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(coursecmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(n3TWs8_0.object_7, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void Bb12Pz(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(coursecmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void j9M0Bz(object sender, EventArgs e)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"vxcer5", (MsgBoxStyle)1, (object)"g54y45y");
			if ((int)val == 1)
			{
				object obj = NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1];
				object object_ = n3TWs8_0.object_4;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = 0);
				array[0] = NewLateBinding.LateGet(object_, (Type)null, "SelectedItems", array2, (string[])null, (Type[])null, (bool[])null);
				Array array3 = array;
				bool[] obj3 = new bool[1] { true };
				object obj4 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
				if (((bool[])obj4)[0])
				{
					NewLateBinding.LateSetComplex(object_, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						(array3 as object[])[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Px0n7Q();
				Aa10Fe();
			}
			else
			{
				Px0n7Q();
				NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj5 = ex;
			MessageBox.Show((obj5 as Exception).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Qm1f4S(object sender, EventArgs e)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(coursecmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(n3TWs8_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(n3TWs8_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(coursecmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(yrcmb, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(n3TWs8_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(n3TWs8_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Px0n7Q();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(coursecmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Aa10Fe();
				NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Px0n7Q();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(coursecmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(yrcmb, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				Aa10Fe();
			}
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Nf0r1R(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void y9ETb5(object sender, KeyPressEventArgs e)
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

	private void j0DCd3(object sender, EventArgs e)
	{
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		n3TWs8_0.object_2 = objectValue;
		NewLateBinding.LateSet(n3TWs8_0.object_2, (Type)null, "ConnectionString", new object[1] { "aoviow8e" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue2, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "svd jruy894", null };
		object object_ = n3TWs8_0.object_8;
		obj2[1] = NewLateBinding.LateGet(object_, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array = obj2;
		bool[] obj3 = new bool[2] { false, true };
		Array array2 = obj3;
		object obj4 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3);
		if ((array2 as bool[])[1])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Int64", new object[1] { (array as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj4, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue4 = default(object);
		object obj5 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue4, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj5, ref objectValue4))
		{
			do
			{
				object object_2 = n3TWs8_0.object_4;
				object[] obj6 = new object[1] { objectValue4 };
				array = obj6;
				bool[] obj7 = new bool[1] { true };
				array2 = obj7;
				object obj8 = NewLateBinding.LateGet(object_2, (Type)null, "Items", obj6, (string[])null, (Type[])null, obj7);
				if (((bool[])array2)[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(idnumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object object_3 = n3TWs8_0.object_4;
					object[] obj9 = new object[1] { objectValue4 };
					array = obj9;
					bool[] obj10 = new bool[1] { true };
					array2 = obj10;
					object obj11 = NewLateBinding.LateGet(object_3, (Type)null, "Items", obj9, (string[])null, (Type[])null, obj10);
					if ((array2 as bool[])[0])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
					}
					NewLateBinding.LateSetComplex(obj11, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue4, obj5, ref objectValue4));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(coursecmb, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(n3TWs8_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(n3TWs8_0.object_2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ls19Mk(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(idnumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(coursecmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(yrcmb, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(n3TWs8_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(n3TWs8_0.object_4, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(n3TWs8_0.object_4, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(n3TWs8_0.object_4, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(n3TWs8_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		Aa10Fe();
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void f5N4Mp(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			Ec3j5G();
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Px0n7Q();
			Aa10Fe();
		}
	}

	private void j9P7Sd(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void a6W0Ht(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void Ks0j6R(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(n3TWs8_0.object_6, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(n3TWs8_0.object_6, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(n3TWs8_0.object_7, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}
}
