using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic.CompilerServices;

public class MMs : ToolStripMenuItem
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public Point DropLocation
	{
		get
		{
			return ((ToolStripDropDownItem)this).get_DropDownLocation();
		}
		set
		{
		}
	}

	public object Parent
	{
		get
		{
			return ((ToolStripItem)this).get_Parent();
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			((ToolStripItem)this).set_Parent((ToolStrip)value);
		}
	}

	public object Cursor
	{
		get
		{
			return Cursors.get_Default();
		}
		set
		{
		}
	}

	public object Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public object Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MMs()
	{
		TypeObj = "IncludeObj";
		defaultName = peremens.trans("Пункт");
		Props = new Propertys(this);
		LastProp = peremens.trans("Текст");
		LastSobyt = peremens.trans("Клик");
		((ToolStripItem)this).set_Name(peremens.MyZnak + "none");
	}

	public void Refresh()
	{
	}

	public void BringToFront()
	{
	}

	public void SendToBack()
	{
	}

	public void MoveToPosition()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		object obj = this;
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Owner", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (objectValue == null)
		{
			if (Props.Sep == null)
			{
				return;
			}
			obj = RuntimeHelpers.GetObjectValue(Props.Sep);
			objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Owner", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (objectValue == null)
			{
				return;
			}
		}
		ToolStripItemCollection val = (ToolStripItemCollection)NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null);
		int num = val.IndexOf((ToolStripItem)obj);
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), false), (object)(num != -1))))
		{
			val.Remove((ToolStripItem)obj);
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ArrangedElementCollection)val).get_Count(), false))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { ((ArrangedElementCollection)val).get_Count() }, (string[])null, (Type[])null, false, true);
			}
			int count = ((ArrangedElementCollection)val).get_Count();
			val.Insert(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(Props.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null)), (ToolStripItem)obj);
			if (count == ((ArrangedElementCollection)val).get_Count())
			{
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall((object)val, (Type)null, "Add", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}
		checked
		{
			int num2 = ((ArrangedElementCollection)val).get_Count() - 1;
			for (num = 0; num <= num2; num++)
			{
				object obj2 = val.get_Item(num);
				if (Operators.CompareString(obj2.GetType().ToString(), peremens.ClassAplication + "MMs", false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { num }, (string[])null, (Type[])null, false, true);
				}
				else if (NewLateBinding.LateGet(obj2, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[1] { num }, (string[])null, (Type[])null, false, true);
				}
			}
		}
	}
}
