using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Kb0k6R;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace p6F5Wj;

public class Gf7z4M
{
	private object Timer1;

	private object studentwindow;

	private object mysqlConn;

	private object COMMAND;

	private object adp;

	private object ListView1;

	private object Button3;

	private object studentbirthday;

	private object studentname;

	private object MySqlDbType;

	private Dq6e2L.o4GDz2 o4GDz2_0 = new Dq6e2L.o4GDz2();

	public Gf7z4M()
	{
		ISupportInitialize supportInitialize = new DataTable();
		o4GDz2_0.dataTable_0 = supportInitialize as DataTable;
	}

	private void Jk0b2R(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(o4GDz2_0.object_1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(o4GDz2_0.object_1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			o4GDz2_0.int_0++;
			if (o4GDz2_0.int_0 > 20)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				d8W3Fp();
				NewLateBinding.LateCall(o4GDz2_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void d8W3Fp()
	{
		throw new NotImplementedException();
	}

	private void o8ZGf9(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		o4GDz2_0.int_0 = 1;
	}

	private void a7JQe9(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		o4GDz2_0.int_0 = 1;
	}

	private void m3AEf5(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(o4GDz2_0.object_1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(o4GDz2_0.object_1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			o4GDz2_0.int_0++;
			if (o4GDz2_0.int_0 > 50)
			{
				NewLateBinding.LateSet(Timer1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				d8W3Fp();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void c8HAg5(object sender, EventArgs e)
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
		Pj1e8X();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		adp = RuntimeHelpers.GetObjectValue(new object());
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		object obj = adp;
		object[] obj2 = new object[1] { (DataTable)supportInitializeNotification };
		Array array = obj2;
		bool[] obj3 = new bool[1] { true };
		object obj4 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "Fill", obj2, (string[])null, (Type[])null, obj3, true);
		if ((obj4 as bool[])[0])
		{
			supportInitializeNotification = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = ((DataTable)supportInitializeNotification).Rows.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj5 = (DataRow)(enumerator as IEnumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj5)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj5)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj5 as DataRow)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
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

	private void Cb36Qk(object sender, EventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		ISerializable serializable = (ISerializable)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)serializable).get_SubItems();
		object obj;
		object[] obj2 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		object obj5 = obj4;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4, true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(o4GDz2_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((serializable is ListViewItem) ? serializable : null)).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(o4GDz2_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { ((object[])obj3)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)serializable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)serializable).get_SubItems(), (Type)null, "Add", (object[])(obj3 = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(o4GDz2_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "Trim", new object[1] { (obj3 as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj6 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj7 = new object[2] { "dfdtret", null };
			obj = MySqlDbType;
			obj7[1] = NewLateBinding.LateGet(obj, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			obj3 = obj7;
			bool[] obj8 = new bool[2] { false, true };
			obj5 = obj8;
			object obj9 = NewLateBinding.LateGet(obj6, (Type)null, "Add", obj7, (string[])null, (Type[])null, obj8);
			if ((obj5 as bool[])[1])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Int64", new object[1] { ((object[])obj3)[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj9, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			w5JZf0();
			object obj10 = NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj11 = new object[1] { (serializable is ListViewItem) ? serializable : null };
			obj3 = obj11;
			bool[] obj12 = new bool[1] { true };
			obj5 = obj12;
			NewLateBinding.LateCall(obj10, (Type)null, "Add", obj11, (string[])null, (Type[])null, obj12, true);
			if ((obj5 as bool[])[0])
			{
				serializable = (ISerializable)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(ListViewItem));
			}
			Lj1r4R();
			Pj1e8X();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
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

	private void w5JZf0()
	{
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(o4GDz2_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(o4GDz2_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(o4GDz2_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(o4GDz2_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				Interaction.MsgBox((object)"cxvr", (MsgBoxStyle)48, (object)"sdd4");
			}
			else if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "TextLength", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
			{
				Interaction.MsgBox((object)"Edfr", (MsgBoxStyle)48, (object)"Indfeber");
				NewLateBinding.LateCall(o4GDz2_0.object_5, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
			{
				Interaction.MsgBox((object)"Phuo0", (MsgBoxStyle)48, (object)"Ihjl7y7");
				NewLateBinding.LateCall(o4GDz2_0.object_5, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			MessageBox.Show(((Exception)obj).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void a2CQs3(object sender, EventArgs e)
	{
		m3CKy5();
		Lj1r4R();
		NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void m3CKy5()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_9, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Pj1e8X()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_9, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_8, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Lj1r4R()
	{
		NewLateBinding.LateCall(o4GDz2_0.object_4, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(studentname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(o4GDz2_0.object_5, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(o4GDz2_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(o4GDz2_0.object_7, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(o4GDz2_0.object_8, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void Xm3d9Q(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Ra21Pe(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
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
				Array array4 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
				if ((array4 as bool[])[0])
				{
					NewLateBinding.LateSetComplex(listView, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						((object[])array3)[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Lj1r4R();
				Pj1e8X();
			}
			else
			{
				Lj1r4R();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj4 = ex;
			MessageBox.Show(((Exception)obj4).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void b1CSe3(object sender, EventArgs e)
	{
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		mysqlConn = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(mysqlConn, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(o4GDz2_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(o4GDz2_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(o4GDz2_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Lj1r4R();
				NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Pj1e8X();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Lj1r4R();
				NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(o4GDz2_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(o4GDz2_0.object_7, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				Pj1e8X();
			}
			NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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

	private void Hj8r4J(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void Br76Gm(object sender, KeyPressEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(o4GDz2_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false) && e.get_KeyChar() != '\b')
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

	private void Ys0b3X(object sender, EventArgs e)
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
		object obj4 = obj3;
		object obj5 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3);
		if ((obj4 as bool[])[1])
		{
			NewLateBinding.LateSetComplex(mySqlDbType, (Type)null, "Int64", new object[1] { ((object[])array)[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj5, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = default(object);
		object obj6 = default(object);
		if (ForLoopControl.ForLoopInitObj(objectValue3, (object)0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1, ref obj6, ref objectValue3))
		{
			do
			{
				object listView = ListView1;
				object[] obj7 = new object[1] { objectValue3 };
				array = obj7;
				bool[] obj8 = new bool[1] { true };
				obj4 = obj8;
				object obj9 = NewLateBinding.LateGet(listView, (Type)null, "Items", obj7, (string[])null, (Type[])null, obj8);
				if (((bool[])obj4)[0])
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(((object[])array)[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(o4GDz2_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object listView2 = ListView1;
					object[] obj10 = new object[1] { objectValue3 };
					array = obj10;
					bool[] obj11 = new bool[1] { true };
					obj4 = obj11;
					object obj12 = NewLateBinding.LateGet(listView2, (Type)null, "Items", obj10, (string[])null, (Type[])null, obj11);
					if ((obj4 as bool[])[0])
					{
						objectValue3 = RuntimeHelpers.GetObjectValue((array as object[])[0]);
					}
					NewLateBinding.LateSetComplex(obj12, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue3, obj6, ref objectValue3));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue2, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(mysqlConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Xg9y3L(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(o4GDz2_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_8, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(ListView1, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(ListView1, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		Pj1e8X();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void Xt9m8W(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(o4GDz2_0.object_2, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			m3CKy5();
			NewLateBinding.LateSet(o4GDz2_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(o4GDz2_0.object_9, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Lj1r4R();
			Pj1e8X();
		}
	}

	private void m2MGw1(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void s9LBf7(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void Cx81Td(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(o4GDz2_0.object_8, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static int s0NRo4()
	{
		while (true)
		{
			try
			{
				object obj = new WebClient();
				try
				{
					IDisposable disposable = ((WebClient)obj).OpenRead("https://www.google.com");
					try
					{
						return 100;
					}
					finally
					{
						if (disposable is Stream)
						{
							((IDisposable)(disposable as Stream)).Dispose();
						}
					}
				}
				finally
				{
					if ((WebClient)obj != null)
					{
						((IDisposable)(obj as WebClient)).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
