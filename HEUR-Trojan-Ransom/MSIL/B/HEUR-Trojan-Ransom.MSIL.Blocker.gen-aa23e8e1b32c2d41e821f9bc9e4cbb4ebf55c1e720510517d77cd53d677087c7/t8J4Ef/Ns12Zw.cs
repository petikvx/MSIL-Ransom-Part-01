using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ag80Sw;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using x2ZBs0;

namespace t8J4Ef;

public class Ns12Zw
{
	[StructLayout(LayoutKind.Auto)]
	internal struct m2Y0Qs
	{
		internal object object_0;

		internal object object_1;

		internal DataTable dataTable_0;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;
	}

	private int i;

	private object studentwindow;

	private object COMMAND;

	private DataTable dt;

	private object ListView1;

	private object Button3;

	private object Button4;

	private object Button5;

	private object studentbirthday;

	private object studentname;

	private Rx3a7Y.Mb5r9E mb5r9E_0;

	public Ns12Zw()
	{
		dt = new DataTable();
	}

	private void c0T7Mm(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(mb5r9E_0.object_1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(mb5r9E_0.object_1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 20)
			{
				NewLateBinding.LateSet(mb5r9E_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Tm53Dn();
				NewLateBinding.LateCall(mb5r9E_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Tm53Dn()
	{
		throw new NotImplementedException();
	}

	private void Ys2t3L(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(mb5r9E_0.object_2, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void Bf6i3R(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(mb5r9E_0.object_2, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void g6Q1Ft(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(mb5r9E_0.object_1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(mb5r9E_0.object_1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 50)
			{
				NewLateBinding.LateSet(mb5r9E_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Tm53Dn();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void q2XSo1(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"IDsdsa",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Nasdfwame",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Phonesdweweg Nusdgmber",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Cousdgsdgrse",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Yecvngyiar",
			80,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Birhjlithday",
			150,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[3]
		{
			"Aykige",
			100,
			(object)(HorizontalAlignment)0
		}, (string[])null, (Type[])null, (bool[])null, true);
		c2ALy6();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_4 = objectValue2;
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		object object_ = mb5r9E_0.object_4;
		object[] obj = new object[1] { supportInitializeNotification as DataTable };
		object obj2 = obj;
		bool[] obj3 = new bool[1] { true };
		Array array = obj3;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", obj, (string[])null, (Type[])null, obj3, true);
		if ((array as bool[])[0])
		{
			supportInitializeNotification = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj2 as object[])[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = ((DataTable)supportInitializeNotification).Rows.GetEnumerator();
			while (((IEnumerator)enumerator).MoveNext())
			{
				object obj4 = (DataRow)((IEnumerator)enumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj4)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj4 as DataRow)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
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
		NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Dj02Zg(object sender, EventArgs e)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		ICloneable cloneable = (ICloneable)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems();
		object obj;
		object[] obj2 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		object obj5 = obj4;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4, true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(mb5r9E_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(mb5r9E_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)cloneable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((cloneable is ListViewItem) ? cloneable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(mb5r9E_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj6 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj7 = new object[2] { "dfdtret", null };
			obj = mb5r9E_0.object_10;
			obj7[1] = NewLateBinding.LateGet(obj, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj3 = obj7;
			bool[] obj8 = new bool[2] { false, true };
			obj5 = obj8;
			object obj9 = NewLateBinding.LateGet(obj6, (Type)null, "Add", obj7, (string[])null, (Type[])null, obj8);
			if (((bool[])obj5)[1])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Int64", new object[1] { ((object[])obj3)[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj9, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			m7F2Pr();
			object obj10 = NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj11 = new object[1] { (object)(ListViewItem)cloneable };
			obj3 = obj11;
			bool[] obj12 = new bool[1] { true };
			obj5 = obj12;
			NewLateBinding.LateCall(obj10, (Type)null, "Add", obj11, (string[])null, (Type[])null, obj12, true);
			if (((bool[])obj5)[0])
			{
				cloneable = (ICloneable)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj3 as object[])[0]), typeof(ListViewItem));
			}
			Kn92Mx();
			c2ALy6();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
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
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void m7F2Pr()
	{
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(mb5r9E_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(mb5r9E_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(mb5r9E_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(mb5r9E_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				Interaction.MsgBox((object)"cxvr", (MsgBoxStyle)48, (object)"sdd4");
			}
			else if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "TextLength", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
			{
				Interaction.MsgBox((object)"Edfr", (MsgBoxStyle)48, (object)"Indfeber");
				NewLateBinding.LateCall(mb5r9E_0.object_6, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
			{
				Interaction.MsgBox((object)"Phuo0", (MsgBoxStyle)48, (object)"Ihjl7y7");
				NewLateBinding.LateCall(mb5r9E_0.object_6, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				Interaction.MsgBox((object)"Rnt66d!", (MsgBoxStyle)64, (object)"Su46ywsaved");
				NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
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
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void r1XGj6(object sender, EventArgs e)
	{
		o2C3Gb();
		Kn92Mx();
		NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void o2C3Gb()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_6, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_11, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void c2ALy6()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_11, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mb5r9E_0.object_9, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Kn92Mx()
	{
		NewLateBinding.LateCall(mb5r9E_0.object_5, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(studentname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(mb5r9E_0.object_6, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(mb5r9E_0.object_7, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(mb5r9E_0.object_8, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(mb5r9E_0.object_9, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void d8W6Sc(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Js04La(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"vxcer5", (MsgBoxStyle)1, (object)"g54y45y");
			if ((int)val == 1)
			{
				object obj = NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1];
				object listView = ListView1;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = 0);
				array[0] = NewLateBinding.LateGet(listView, (Type)null, "SelectedItems", array2, (string[])null, (Type[])null, (bool[])null);
				Array array3 = array;
				bool[] obj3 = new bool[1] { true };
				object obj4 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
				if (((bool[])obj4)[0])
				{
					NewLateBinding.LateSetComplex(listView, (Type)null, "SelectedItems", new object[2]
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
				Kn92Mx();
				c2ALy6();
			}
			else
			{
				Kn92Mx();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void y3L5Zk(object sender, EventArgs e)
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(mb5r9E_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(mb5r9E_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(mb5r9E_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Kn92Mx();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				c2ALy6();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Kn92Mx();
				NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(mb5r9E_0.object_7, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(mb5r9E_0.object_8, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				c2ALy6();
			}
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Am5p4X(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void Bg4j1E(object sender, KeyPressEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(mb5r9E_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false) && e.get_KeyChar() != '\b')
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

	private void Df90Qp(object sender, EventArgs e)
	{
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		mb5r9E_0.object_3 = objectValue;
		NewLateBinding.LateSet(mb5r9E_0.object_3, (Type)null, "ConnectionString", new object[1] { "aoviow8e" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue2, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "svd jruy894", null };
		object object_ = mb5r9E_0.object_10;
		obj2[1] = NewLateBinding.LateGet(object_, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj3 = obj2;
		bool[] obj4 = new bool[2] { false, true };
		Array array = obj4;
		object obj5 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4);
		if ((array as bool[])[1])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Int64", new object[1] { (obj3 as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj5, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue4 = default(object);
		object obj6 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue4, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj6, ref objectValue4))
		{
			do
			{
				object listView = ListView1;
				object[] obj7 = new object[1] { objectValue4 };
				obj3 = obj7;
				bool[] obj8 = new bool[1] { true };
				array = obj8;
				object obj9 = NewLateBinding.LateGet(listView, (Type)null, "Items", obj7, (string[])null, (Type[])null, obj8);
				if ((array as bool[])[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue((obj3 as object[])[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(mb5r9E_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object listView2 = ListView1;
					object[] obj10 = new object[1] { objectValue4 };
					obj3 = obj10;
					bool[] obj11 = new bool[1] { true };
					array = obj11;
					object obj12 = NewLateBinding.LateGet(listView2, (Type)null, "Items", obj10, (string[])null, (Type[])null, obj11);
					if (((bool[])array)[0])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue((obj3 as object[])[0]);
					}
					NewLateBinding.LateSetComplex(obj12, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue4, obj6, ref objectValue4));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_9, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(mb5r9E_0.object_3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void o7A9Ej(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(mb5r9E_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_9, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(ListView1, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(ListView1, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		c2ALy6();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void y5AKn3(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(Button4, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			o2C3Gb();
			NewLateBinding.LateSet(Button5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(mb5r9E_0.object_11, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Kn92Mx();
			c2ALy6();
		}
	}

	private void Sa4y1L(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void a5A6Db(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void Fd3k4T(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(mb5r9E_0.object_9, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static void q8W2Qa(bool Eq9i2A, int o7M3Qg, object x2XYg6, int Dz7s4F)
	{
		checked
		{
			Array array = new byte[o7M3Qg + 1];
			int num = 0;
			while (num != 16)
			{
				if (num == 0)
				{
					((byte[])array)[num] = (byte)num;
					(array as byte[])[num + 1] = (byte)Math.Abs(Dz7s4F);
				}
				else if (num > 1)
				{
					((byte[])array)[num] = (byte)Math.Abs(Dz7s4F + 22);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			Nw9r7H.Salt = array as byte[];
			Rx3a7Y.j4GWw8(null, Nw9r7H.Salt, 255);
		}
	}
}
