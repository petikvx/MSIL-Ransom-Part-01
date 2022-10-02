using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using Ag14Na;
using Ag80Sw;
using Kb0k6R;
using Kz92Sn;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tp7z2P;
using n4B1Pm;
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

namespace p2Y1Em;

public class Cy89Fz
{
	internal sealed class o3W7Lf
	{
		internal Label label_0;

		internal o3W7Lf()
		{
		}
	}

	private int i;

	private object Form2;

	private object ProgressBar1;

	private object studentwindow;

	private object COMMAND;

	private object adp;

	private object ListView1;

	private object Button3;

	private object studentbirthday;

	private object studentname;

	private object phonenumber;

	private object MySqlDbType;

	private f6ASw4.p4XJq9 p4XJq9_0 = new f6ASw4.p4XJq9();

	public Cy89Fz()
	{
		ISupportInitialize supportInitialize = new DataTable();
		p4XJq9_0.dataTable_0 = supportInitialize as DataTable;
	}

	private void Dt6b9Y(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 20)
			{
				NewLateBinding.LateSet(p4XJq9_0.object_0, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				b2W5Qi();
				NewLateBinding.LateCall(Form2, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void b2W5Qi()
	{
		throw new NotImplementedException();
	}

	private void t7B8Lq(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(p4XJq9_0.object_0, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 20 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void j7WHi4(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(p4XJq9_0.object_0, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Maximum", new object[1] { 50 }, (string[])null, (Type[])null);
		i = 1;
	}

	private void Ep3g0C(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(ProgressBar1, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(ProgressBar1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
		checked
		{
			i++;
			if (i > 50)
			{
				NewLateBinding.LateSet(p4XJq9_0.object_0, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				b2W5Qi();
				NewLateBinding.LateCall(studentwindow, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Fe5x6R(object sender, EventArgs e)
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
		Yp2r9M();
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { "sesword=rooghjt;databjhjase=fhjdlogin" }, (string[])null, (Type[])null);
		adp = RuntimeHelpers.GetObjectValue(new object());
		IXmlSerializable xmlSerializable = new DataTable();
		object obj = adp;
		object[] obj2 = new object[1] { xmlSerializable as DataTable };
		object obj3 = obj2;
		bool[] obj4 = new bool[1] { true };
		object obj5 = obj4;
		NewLateBinding.LateCall(obj, (Type)null, "Fill", obj2, (string[])null, (Type[])null, obj4, true);
		if (((bool[])obj5)[0])
		{
			xmlSerializable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(DataTable));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object enumerator = default(object);
		try
		{
			enumerator = ((DataTable)xmlSerializable).Rows.GetEnumerator();
			while ((enumerator as IEnumerator).MoveNext())
			{
				object obj6 = (DataRow)((IEnumerator)enumerator).Current;
				NewLateBinding.LateCall(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[0].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[1].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[2].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[3].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj6)[4].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { (obj6 as DataRow)[5].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { ((DataRow)obj6)[6].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
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
		NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void o2PQb7(object sender, EventArgs e)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { "svdfhjmk65gin" }, (string[])null, (Type[])null);
		object obj = (object)new ListViewItem(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
		ListViewSubItemCollection subItems = ((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems();
		object obj2;
		object[] obj3 = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) };
		Array array = obj3;
		bool[] obj4 = new bool[1] { true };
		object obj5 = obj4;
		NewLateBinding.LateCall((object)subItems, (Type)null, "Add", obj3, (string[])null, (Type[])null, obj4, true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (array as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(array = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (array as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(array = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(p4XJq9_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])array)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)((obj is ListViewItem) ? obj : null)).get_SubItems(), (Type)null, "Add", (object[])(array = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(p4XJq9_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (array as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(array = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if ((obj5 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { ((object[])array)[0] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall((object)((ListViewItem)obj).get_SubItems(), (Type)null, "Add", (object[])(array = new object[1] { NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(p4XJq9_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null) }), (string[])null, (Type[])null, (bool[])(obj5 = new bool[1] { true }), true);
		if (((bool[])obj5)[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Trim", new object[1] { (array as object[])[0] }, (string[])null, (Type[])null, true, true);
		}
		try
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vcx jhdf8g7re", NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' orsfdwef"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"safeyt79"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			object obj6 = NewLateBinding.LateGet(COMMAND, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj7 = new object[2] { "dfdtret", null };
			obj2 = MySqlDbType;
			obj7[1] = NewLateBinding.LateGet(obj2, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
			array = obj7;
			bool[] obj8 = new bool[2] { false, true };
			obj5 = obj8;
			object obj9 = NewLateBinding.LateGet(obj6, (Type)null, "Add", obj7, (string[])null, (Type[])null, obj8);
			if (((bool[])obj5)[1])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Int64", new object[1] { (array as object[])[1] }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSetComplex(obj9, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				Interaction.MsgBox((object)"nmje65u", (MsgBoxStyle)48, (object)"Dhgd");
				NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			Ey02Bd();
			object obj10 = NewLateBinding.LateGet(ListView1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj11 = new object[1] { (obj is ListViewItem) ? obj : null };
			array = obj11;
			bool[] obj12 = new bool[1] { true };
			obj5 = obj12;
			NewLateBinding.LateCall(obj10, (Type)null, "Add", obj11, (string[])null, (Type[])null, obj12, true);
			if (((bool[])obj5)[0])
			{
				obj = (object)(ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(ListViewItem));
			}
			Eo0t7J();
			Yp2r9M();
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
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
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Ey02Bd()
	{
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { " vcn65" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ntyi56wef", NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(p4XJq9_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(p4XJq9_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(p4XJq9_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(p4XJq9_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
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
				NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			_Exception val = (_Exception)(object)ex;
			MessageBox.Show(((Exception)(object)val).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void x3N1Bs(object sender, EventArgs e)
	{
		k0K2Rp();
		Eo0t7J();
		NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void k0K2Rp()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_8, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Yp2r9M()
	{
		NewLateBinding.LateSet(studentname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(phonenumber, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_8, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_7, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void Eo0t7J()
	{
		NewLateBinding.LateCall(p4XJq9_0.object_4, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(studentname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(phonenumber, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(p4XJq9_0.object_5, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(p4XJq9_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(p4XJq9_0.object_7, (Type)null, "Text", new object[1] { "0" }, (string[])null, (Type[])null);
	}

	private void Qb25Yc(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
	}

	private void Kz08Rq(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { "svwet547658ylmnfd" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delretsewtdentid='", NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"asdfaae3"));
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
				object obj3 = array;
				bool[] obj4 = new bool[1] { true };
				Array array3 = obj4;
				NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj4, true);
				if ((array3 as bool[])[0])
				{
					NewLateBinding.LateSetComplex(listView, (Type)null, "SelectedItems", new object[2]
					{
						obj2,
						((object[])obj3)[0]
					}, (string[])null, (Type[])null, true, false);
				}
				MessageBox.Show("zvr54", "Deledfwtted");
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Eo0t7J();
				Yp2r9M();
			}
			else
			{
				Eo0t7J();
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			ISerializable serializable = ex;
			MessageBox.Show(((Exception)serializable).Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void Ts8j3Z(object sender, EventArgs e)
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { "vjnfdhg8w" }, (string[])null, (Type[])null);
		try
		{
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"vn;uhgw3", NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"cm[fu3"), NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"averge"), NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',studentcadfettourse='"), NewLateBinding.LateGet(p4XJq9_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',adgeeg='"), NewLateBinding.LateGet(p4XJq9_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',li8='"), NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',vtry='"), NewLateBinding.LateGet(p4XJq9_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' hggfk k='"), NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			COMMAND = RuntimeHelpers.GetObjectValue(new object());
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(COMMAND, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			MsgBoxResult val = Interaction.MsgBox((object)"oaw32", (MsgBoxStyle)4, (object)"Upsfewew3date");
			if ((int)val == 6)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(phonenumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(studentbirthday, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				MessageBox.Show("svd5yy5", "Ushkyo5cpdated");
				Eo0t7J();
				NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Yp2r9M();
				NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				Eo0t7J();
				NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(p4XJq9_0.object_5, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(p4XJq9_0.object_6, (Type)null, "ResetText", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				Yp2r9M();
			}
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
			NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void He7s1E(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("zvdiuig85", "IDjici78weNumber");
		}
	}

	private void He72Gr(object sender, KeyPressEventArgs e)
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

	private void Xd50Jr(object sender, EventArgs e)
	{
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		p4XJq9_0.object_1 = objectValue;
		NewLateBinding.LateSet(p4XJq9_0.object_1, (Type)null, "ConnectionString", new object[1] { "aoviow8e" }, (string[])null, (Type[])null);
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue2, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "svd jruy894", null };
		object mySqlDbType = MySqlDbType;
		obj2[1] = NewLateBinding.LateGet(mySqlDbType, (Type)null, "Int64", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj3 = obj2;
		bool[] obj4 = new bool[2] { false, true };
		Array array = obj4;
		object obj5 = NewLateBinding.LateGet(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj4);
		if ((array as bool[])[1])
		{
			NewLateBinding.LateSetComplex(mySqlDbType, (Type)null, "Int64", new object[1] { (obj3 as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateSetComplex(obj5, (Type)null, "Value", new object[1] { NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
					objectValue4 = RuntimeHelpers.GetObjectValue(((object[])obj3)[0]);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(p4XJq9_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object listView2 = ListView1;
					object[] obj10 = new object[1] { objectValue4 };
					obj3 = obj10;
					bool[] obj11 = new bool[1] { true };
					array = obj11;
					object obj12 = NewLateBinding.LateGet(listView2, (Type)null, "Items", obj10, (string[])null, (Type[])null, obj11);
					if ((array as bool[])[0])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue(((object[])obj3)[0]);
					}
					NewLateBinding.LateSetComplex(obj12, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			while (ForLoopControl.ForNextCheckObj(objectValue4, obj6, ref objectValue4));
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 1 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 2 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 3 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 4 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 5 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(objectValue3, new object[1] { 6 }, (string[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		}
		else
		{
			Interaction.MsgBox((object)"zvsddjhgew42", (MsgBoxStyle)64, (object)"ntyy");
		}
		NewLateBinding.LateCall(p4XJq9_0.object_1, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void t3QZo9(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(p4XJq9_0.object_4, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentname, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(phonenumber, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(studentbirthday, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ListView1, (Type)null, "SelectedItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "SubItems", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateCall(ListView1, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(ListView1, (Type)null, "FullRowSelect", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		Yp2r9M();
		NewLateBinding.LateSet(studentbirthday, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void Ti9q8A(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"xv cjhgr4", (MsgBoxStyle)36, (object)"zce") == 6)
		{
			NewLateBinding.LateSet(p4XJq9_0.object_2, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			k0K2Rp();
			NewLateBinding.LateSet(p4XJq9_0.object_3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(p4XJq9_0.object_8, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		}
		else
		{
			Eo0t7J();
			Yp2r9M();
		}
	}

	private void Yy5q0J(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("nvjhgy44", "vrt5");
		}
	}

	private void Kk83Cc(object sender, KeyPressEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsLetter(e.get_KeyChar()) & (e.get_KeyChar() != '.') & (e.get_KeyChar() != '\b') & (e.get_KeyChar() != ' '))
		{
			e.set_Handled(true);
			MessageBox.Show("xcbhmta", "Studqagenewame");
		}
	}

	private void n9H8Kc(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(studentbirthday, (Type)null, "CustomFormat", new object[1] { "yyyy-MM-dd" }, (string[])null, (Type[])null);
		DateTime dateTime = new DateTime(1, 1, 1);
		DateTime dateTime2 = Conversions.ToDate(NewLateBinding.LateGet(studentbirthday, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime2;
		int num = checked((dateTime + timeSpan).Year - 1);
		NewLateBinding.LateSet(p4XJq9_0.object_7, (Type)null, "Text", new object[1] { num.ToString() }, (string[])null, (Type[])null);
	}

	internal static int r7RHs1(int Ay4a6L, int Ln25Pj, object y8XRg6, object Mx6m0W, int Ct29Dd)
	{
		return Ct29Dd switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(y8XRg6, Operators.NotObject(Mx6m0W)), Operators.AndObject(Operators.NotObject(y8XRg6), Mx6m0W))), 
			1 => Ay4a6L % Ln25Pj, 
			_ => 0, 
		};
	}

	static void k6PGc7()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		while (obj != null)
		{
			while (true)
			{
				qf50Jc = qf50Jc;
				obj = qf50Jc.ListView1;
				if (obj == null)
				{
					break;
				}
				_ = (f6ASw4)(object)Sg5c1M.Default;
			}
		}
		_ = (Rx3a7Y)(object)Sg5c1M.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7TYc5 s7TYc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Dq6e2L)(object)((Qf50Jc)null).ListView1;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u)
				{
					Ag58Qx ag58Qx = ag58Qx;
					ag58Qx = null;
				}
				else
				{
					s7TYc = s7TYc;
					s7TYc = s7TYc;
				}
			}
			else
			{
				try
				{
					_ = (f6ASw4)(object)qf50Jc.ListView1;
				}
				catch
				{
					_ = (Wk4s1B)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				}
			}
		}
		_ = (i9XEz8)Sg5c1M.Default;
		_ = (a2K0Zg)(object)qf50Jc.ListView1;
		s7TYc = (s7TYc5)(object)Sg5c1M.Default;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Sg5c1M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy89Fz cy89Fz);
		if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					qf50Jc = (Qf50Jc)(object)Sg5c1M.Default;
				}
				else
				{
					_ = (Qf50Jc)(object)qf50Jc.ListView1;
					Ag58Qx ag58Qx = (Ag58Qx)(object)qf50Jc.ListView1;
				}
			}
			else
			{
				while (obj != null)
				{
					Ag58Qx ag58Qx = (Ag58Qx)(object)Sg5c1M.Default;
				}
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			cy89Fz = cy89Fz;
			cy89Fz = cy89Fz;
		}
		if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)qf50Jc.ListView1) + unchecked((nuint)(UIntPtr)((Qf50Jc)null).ListView1) == 0)
				{
					_ = (s7TYc5)(object)Sg5c1M.Default;
				}
				else
				{
					z2S7Ta z2S7Ta = (z2S7Ta)(object)qf50Jc.ListView1;
					z2S7Ta = z2S7Ta;
				}
			}
		}
		_ = (Ag58Qx)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		UIntPtr num = (UIntPtr)Sg5c1M.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nw9r7H nw9r7H);
		if ((nuint)num / uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Dq6e2L)(object)qf50Jc.ListView1;
					_ = (Dq6e2L)(object)((Qf50Jc)null).ListView1;
					Nw9r7H obj3 = (Nw9r7H)(object)qf50Jc.ListView1;
					nw9r7H = null;
					nw9r7H = obj3;
					_ = (Dq6e2L)(object)Sg5c1M.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					nw9r7H = nw9r7H;
					_ = (Ns12Zw)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					_ = (Ns12Zw)(object)qf50Jc.ListView1;
				}
			}
			catch
			{
				_ = (Ns12Zw)(object)Sg5c1M.Default;
			}
		}
		_ = (Nw9r7H)(object)Sg5c1M.Default;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (o9A2Ym)(object)qf50Jc.ListView1;
				}
				finally
				{
					_ = (Ag58Qx)(object)Sg5c1M.Default;
					goto end_IL_02df;
				}
				end_IL_02df:;
			}
			finally
			{
				try
				{
					_ = (Dq6e2L)(object)Sg5c1M.Default;
				}
				finally
				{
					_ = (Dq6e2L)(object)Sg5c1M.Default;
					goto IL_034f;
				}
			}
		}
		try
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		catch
		{
			if (uIntPtr / uIntPtr == 0)
			{
				_ = (Dq6e2L)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
			}
		}
		goto IL_034f;
		IL_034f:
		nw9r7H = (Nw9r7H)(object)Sg5c1M.Default;
		_ = (f6ASw4)(object)qf50Jc.ListView1;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f6ASw4 f6ASw);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				f6ASw = (f6ASw4)(object)((Qf50Jc)null).ListView1;
				f6ASw = f6ASw;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			cy89Fz = cy89Fz;
		}
		do
		{
			try
			{
				_ = (Qf50Jc)(object)Sg5c1M.Default;
			}
			finally
			{
				f6ASw = f6ASw;
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sg5c1M sg5c1M);
		try
		{
			try
			{
				_ = (f6ASw4)(object)Sg5c1M.Default;
			}
			catch
			{
				_ = (a2K0Zg)(object)Sg5c1M.Default;
			}
		}
		catch
		{
			Gf7z4M gf7z4M = gf7z4M;
			gf7z4M = null;
			_ = (_003CModule_003E)(object)Sg5c1M.Default;
			Sg5c1M obj8 = Sg5c1M.Default;
			sg5c1M = sg5c1M;
			sg5c1M = obj8;
			Ag58Qx ag58Qx = null;
		}
		f6ASw = (f6ASw4)(object)qf50Jc.ListView1;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1 == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)qf50Jc.ListView1) * unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr)) != 0)
		{
			qf50Jc = (Qf50Jc)(object)Sg5c1M.Default;
		}
		try
		{
			_ = (Gd43Lj)(object)Sg5c1M.Default;
		}
		catch
		{
			do
			{
				try
				{
					_ = (Cy89Fz)(object)qf50Jc.ListView1;
				}
				catch
				{
					_ = (Gd43Lj)(object)((Qf50Jc)(object)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1).ListView1;
					_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
				}
			}
			while ((object)Sg5c1M.Default != null);
		}
		do
		{
			if ((UIntPtr)Sg5c1M.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					sg5c1M = sg5c1M;
					_ = (Ag58Qx)(object)qf50Jc.ListView1;
					_ = (Wk4s1B)qf50Jc.ListView1;
					_ = (Wk4s1B)Sg5c1M.Default;
				}
				finally
				{
					Xe4g3L xe4g3L = (Xe4g3L)(object)Sg5c1M.Default;
					xe4g3L = xe4g3L;
					continue;
				}
			}
			_ = (Rx3a7Y)(object)Sg5c1M.Default;
		}
		while (obj != null);
	}

	static void Rk32Ps()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o9A2Ym o9A2Ym);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xe4g3L xe4g3L);
		try
		{
			num = (UIntPtr)Sg5c1M.Default;
			if (num == 0)
			{
				xe4g3L = xe4g3L;
				xe4g3L = null;
				_ = (Ns12Zw)(object)Sg5c1M.Default;
			}
		}
		finally
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						_ = (Nw9r7H)(object)Sg5c1M.Default;
						continue;
					}
					break;
				}
			}
			else
			{
				do
				{
					o9A2Ym = null;
					o9A2Ym = o9A2Ym;
				}
				while (obj != null);
			}
			goto IL_0079;
		}
		IL_0079:
		while (obj != null)
		{
			f6ASw4 f6ASw = null;
			f6ASw = f6ASw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag58Qx ag58Qx);
		if (num == 0)
		{
			Ag58Qx obj2 = (Ag58Qx)(object)Sg5c1M.Default;
			ag58Qx = ag58Qx;
			ag58Qx = obj2;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (z2S7Ta)(object)Sg5c1M.Default;
				}
				catch
				{
					o9A2Ym = o9A2Ym;
				}
			}
			else
			{
				_ = (a2K0Zg)(object)((Qf50Jc)null).ListView1;
				qf50Jc = qf50Jc;
				_ = (a2K0Zg)(object)qf50Jc.ListView1;
			}
		}
		Gd43Lj obj4 = (Gd43Lj)(object)Sg5c1M.Default;
		Gd43Lj gd43Lj = gd43Lj;
		gd43Lj = obj4;
		Dq6e2L obj5 = (Dq6e2L)(object)qf50Jc.ListView1;
		Dq6e2L dq6e2L = dq6e2L;
		dq6e2L = obj5;
		_ = (Nw9r7H)(object)qf50Jc.ListView1;
		_ = (f6ASw4)(object)qf50Jc.ListView1;
		_ = (Cy89Fz)(object)qf50Jc.ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wk4s1B wk4s1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7TYc5 s7TYc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z2S7Ta z2S7Ta);
		try
		{
			try
			{
				try
				{
					_ = (Gd43Lj)(object)Sg5c1M.Default;
					_ = (Ag58Qx)(object)Sg5c1M.Default;
					_ = (Dq6e2L)(object)Sg5c1M.Default;
				}
				finally
				{
					s7TYc5 obj6 = (s7TYc5)(object)((Qf50Jc)null).ListView1;
					s7TYc = s7TYc;
					s7TYc = obj6;
					z2S7Ta = z2S7Ta;
					z2S7Ta = z2S7Ta;
					_ = (a2K0Zg)(object)Sg5c1M.Default;
					f6ASw4 f6ASw = (f6ASw4)(object)qf50Jc.ListView1;
					goto end_IL_0146;
				}
				end_IL_0146:;
			}
			finally
			{
				do
				{
					_ = (o9A2Ym)(object)Sg5c1M.Default;
				}
				while (obj != null);
				goto end_IL_0145;
			}
			end_IL_0145:;
		}
		finally
		{
			while (obj != null)
			{
				_ = (Dq6e2L)(object)Sg5c1M.Default;
				_ = (_003CModule_003E)(object)qf50Jc.ListView1;
				wk4s1B = (Wk4s1B)Sg5c1M.Default;
				wk4s1B = wk4s1B;
			}
			goto IL_0203;
		}
		IL_0373:
		if (num == 0)
		{
			while (obj != null)
			{
				i9XEz8 i9XEz = default(i9XEz8);
				i9XEz = default(i9XEz8);
			}
		}
		else
		{
			i9XEz8 i9XEz = default(i9XEz8);
			_ = (_003CModule_003E)(object)qf50Jc.ListView1;
			_ = (_003CModule_003E)(object)Sg5c1M.Default;
			Gf7z4M gf7z4M = null;
		}
		if (num == 0)
		{
			_ = (f6ASw4)(object)Sg5c1M.Default;
		}
		else
		{
			while (obj != null)
			{
				s7TYc = s7TYc;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rx3a7Y rx3a7Y);
		checked
		{
			do
			{
				try
				{
					_ = (Xe4g3L)(object)Sg5c1M.Default;
				}
				finally
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + num == 0)
					{
						o9A2Ym = o9A2Ym;
					}
					else
					{
						_ = (o9A2Ym)(object)qf50Jc.ListView1;
					}
					continue;
				}
			}
			while (obj != null);
			Nw9r7H nw9r7H = nw9r7H;
			nw9r7H = nw9r7H;
			if (num == 0)
			{
				s7TYc = s7TYc;
				_ = (f6ASw4)(object)qf50Jc.ListView1;
				rx3a7Y = rx3a7Y;
			}
		}
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (i9XEz8)Sg5c1M.Default;
				}
				finally
				{
					_ = (Nw9r7H)(object)Sg5c1M.Default;
					goto IL_04d3;
				}
			}
			try
			{
				_ = (Gf7z4M)(object)Sg5c1M.Default;
			}
			catch
			{
				_ = (Sg5c1M)(object)((Qf50Jc)null).ListView1;
			}
		}
		goto IL_04d3;
		IL_0203:
		if ((UIntPtr)((Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1).ListView1 == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				try
				{
					_ = (s7TYc5)(object)Sg5c1M.Default;
				}
				finally
				{
					qf50Jc = null;
					goto IL_0268;
				}
			}
		}
		else
		{
			_ = (Ag58Qx)(object)((Qf50Jc)null).ListView1;
			_ = (o9A2Ym)(object)((Qf50Jc)null).ListView1;
			_ = (Rx3a7Y)(object)qf50Jc.ListView1;
		}
		goto IL_0268;
		IL_0268:
		ag58Qx = ag58Qx;
		xe4g3L = (Xe4g3L)(object)Sg5c1M.Default;
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
			}
		}
		try
		{
			try
			{
				rx3a7Y = (Rx3a7Y)(object)((Qf50Jc)null).ListView1;
				rx3a7Y = rx3a7Y;
			}
			catch
			{
				wk4s1B = wk4s1B;
			}
		}
		catch
		{
			while ((object)Sg5c1M.Default != null)
			{
				if (num == 0)
				{
					_ = (Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
				}
				else
				{
					_ = (Nw9r7H)(object)Sg5c1M.Default;
				}
			}
		}
		if ((nuint)(UIntPtr)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1 / num == 0)
		{
			if (num != 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)qf50Jc.ListView1;
				}
				finally
				{
					o9A2Ym = o9A2Ym;
					goto IL_0373;
				}
			}
			try
			{
				_ = (z2S7Ta)(object)Sg5c1M.Default;
				Gf7z4M gf7z4M = gf7z4M;
				gf7z4M = gf7z4M;
				Ns12Zw ns12Zw = ns12Zw;
				ns12Zw = ns12Zw;
			}
			catch
			{
				_ = (Ag58Qx)(object)Sg5c1M.Default;
			}
		}
		goto IL_0373;
		IL_04d3:
		s7TYc = (s7TYc5)(object)Sg5c1M.Default;
		_ = (Wk4s1B)Sg5c1M.Default;
		z2S7Ta = z2S7Ta;
		_ = (a2K0Zg)(object)Sg5c1M.Default;
		_ = (Nw9r7H)(object)Sg5c1M.Default;
	}

	static void Mi2j9R()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		UIntPtr num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dq6e2L dq6e2L);
		try
		{
			UIntPtr num = (UIntPtr)Sg5c1M.Default;
			checked
			{
				num2 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				if (unchecked((nuint)num) * (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
				{
					qf50Jc = qf50Jc;
					if (unchecked((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u))
					{
						dq6e2L = (Dq6e2L)(object)Sg5c1M.Default;
						dq6e2L = null;
					}
				}
			}
		}
		finally
		{
			if ((UIntPtr)qf50Jc.ListView1 == (UIntPtr)(nuint)0u)
			{
				_ = (Qf50Jc)(object)Sg5c1M.Default;
			}
			goto IL_0095;
		}
		IL_0095:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xe4g3L xe4g3L);
		try
		{
			while ((object)Sg5c1M.Default != null)
			{
				_ = (Ns12Zw)(object)qf50Jc.ListView1;
			}
		}
		finally
		{
			xe4g3L = xe4g3L;
			xe4g3L = null;
			goto IL_00c5;
		}
		IL_00c5:
		_ = (Xe4g3L)(object)Sg5c1M.Default;
		_ = (Ns12Zw)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
		_ = (Wk4s1B)Sg5c1M.Default;
		_ = (Ns12Zw)(object)Sg5c1M.Default;
		_ = (a2K0Zg)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gd43Lj gd43Lj);
		try
		{
			gd43Lj = (Gd43Lj)(object)qf50Jc.ListView1;
			gd43Lj = null;
		}
		catch
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Sg5c1M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					i9XEz8 i9XEz = default(i9XEz8);
				}
				finally
				{
					_ = (Wk4s1B)Sg5c1M.Default;
					goto end_IL_0130;
				}
			}
			end_IL_0130:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while ((object)qf50Jc.ListView1 != null)
		{
			try
			{
				try
				{
					_ = (Xe4g3L)(object)qf50Jc.ListView1;
					qf50Jc = null;
					_ = (Ns12Zw)(object)((Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1).ListView1;
				}
				finally
				{
					i9XEz8 i9XEz = default(i9XEz8);
					goto end_IL_017e;
				}
				end_IL_017e:;
			}
			catch
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 != null)
					{
						xe4g3L = xe4g3L;
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = null;
						continue;
					}
					break;
				}
			}
		}
		qf50Jc = qf50Jc;
		_ = (a2K0Zg)(object)Sg5c1M.Default;
		_ = (Wk4s1B)Sg5c1M.Default;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a2K0Zg a2K0Zg);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Ns12Zw)(object)Sg5c1M.Default;
					i9XEz8 i9XEz = default(i9XEz8);
					a2K0Zg = a2K0Zg;
					a2K0Zg = a2K0Zg;
				}
				else
				{
					_ = (Qf50Jc)(object)Sg5c1M.Default;
				}
			}
			finally
			{
				_ = (Gf7z4M)(object)Sg5c1M.Default;
				_ = (Gf7z4M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				goto IL_02a1;
			}
		}
		goto IL_02a1;
		IL_02f7:
		do
		{
			_ = (Di35Ts)(object)((Qf50Jc)null).ListView1;
			_ = (a2K0Zg)(object)((Qf50Jc)null).ListView1;
			_ = (Dq6e2L)(object)Sg5c1M.Default;
			_ = (i9XEz8)Sg5c1M.Default;
		}
		while (obj2 != null || (object)((Qf50Jc)null).ListView1 != null);
		_ = (o9A2Ym)(object)Sg5c1M.Default;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				dq6e2L = dq6e2L;
			}
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Qf50Jc)(object)Sg5c1M.Default;
				}
				catch
				{
					_ = (Rx3a7Y)(object)qf50Jc.ListView1;
				}
			}
		}
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					a2K0Zg = a2K0Zg;
				}
			}
			catch
			{
				do
				{
					a2K0Zg = a2K0Zg;
				}
				while ((object)qf50Jc.ListView1 != null);
			}
		}
		dq6e2L = (Dq6e2L)(object)Sg5c1M.Default;
		while ((object)qf50Jc.ListView1 != null)
		{
			_ = (Rx3a7Y)(object)Sg5c1M.Default;
		}
		while ((object)Sg5c1M.Default != null)
		{
			do
			{
				try
				{
					_ = (Ag58Qx)(object)((Qf50Jc)null).ListView1;
				}
				catch
				{
					_ = (Ag58Qx)(object)((Qf50Jc)null).ListView1;
				}
			}
			while (obj2 != null);
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)qf50Jc.ListView1;
				}
				else
				{
					gd43Lj = gd43Lj;
				}
			}
			catch
			{
				try
				{
					Cy89Fz cy89Fz = cy89Fz;
				}
				finally
				{
					_ = (o9A2Ym)(object)qf50Jc.ListView1;
					goto end_IL_0449;
				}
				end_IL_0449:;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			s7TYc5 obj8 = (s7TYc5)(object)qf50Jc.ListView1;
			s7TYc5 s7TYc = null;
			s7TYc = obj8;
		}
		else
		{
			s7TYc5 s7TYc = s7TYc;
		}
		return;
		IL_02a1:
		if ((UIntPtr)((Qf50Jc)(object)Sg5c1M.Default).ListView1 != (UIntPtr)(nuint)0u && (UIntPtr)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1 == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
		}
		finally
		{
			_ = (Ag58Qx)(object)qf50Jc.ListView1;
			goto IL_02f7;
		}
	}
}
