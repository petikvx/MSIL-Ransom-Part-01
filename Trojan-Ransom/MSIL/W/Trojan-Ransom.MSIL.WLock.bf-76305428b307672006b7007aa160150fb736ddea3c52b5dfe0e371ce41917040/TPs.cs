using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class TPs : TabPage
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public TPs()
	{
		TypeObj = "IncludeObj";
		defaultName = peremens.trans("Закладка");
		Props = new Propertys(this);
		LastProp = peremens.trans("Текст");
		LastSobyt = peremens.trans("Клик");
		((Control)this).set_Name(peremens.MyZnak + "none");
	}

	public void MoveToPosition()
	{
		object parent = ((Control)this).get_Parent();
		if (parent == null)
		{
			return;
		}
		int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IndexOf", new object[1] { this }, (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(Props.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), false), (object)(num != -1))))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Remove", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			}
			int num2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
			object obj = NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2];
			object[] array2 = array;
			object obj2 = Props.obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Props", array4, array5, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = this;
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj, (Type)null, "Insert", array7, (string[])null, (Type[])null, array8, true);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array3, array5, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (Operators.ConditionalCompareObjectEqual((object)num2, NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "add", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
			}
			NewLateBinding.LateSet(parent, (Type)null, "SelectedIndex", new object[1] { Props.pos }, (string[])null, (Type[])null);
		}
		int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(parent, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (num = 0; num <= num3; num = checked(num + 1))
		{
			object[] array6 = new object[1] { num };
			object[] array9 = array6;
			bool[] array8 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(parent, (Type)null, "TabPages", array9, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj3, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { num }, (string[])null, (Type[])null, false, true);
		}
	}
}
