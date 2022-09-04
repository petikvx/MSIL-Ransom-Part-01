using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class DP : SplitContainer
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public object ParentPanelLeft
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Invalid comparison between Unknown and I4
			object obj2 = 0;
			int num = 0;
			if ((int)((SplitContainer)this).get_BorderStyle() == 1)
			{
				num = 1;
			}
			if ((int)((SplitContainer)this).get_BorderStyle() == 2)
			{
				num = 2;
			}
			if (NewLateBinding.LateGet(obj, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return 0;
			}
			checked
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Panel2", false))
				{
					if (unchecked((int)((SplitContainer)this).get_Orientation()) == 1)
					{
						obj2 = ((SplitContainer)this).get_SplitterDistance() + ((SplitContainer)this).get_SplitterRectangle().Width;
					}
					return Operators.AddObject((object)(((Control)this).get_Left() + num), obj2);
				}
				return ((Control)this).get_Left() + num;
			}
		}
	}

	public object ParentPanelTop
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Invalid comparison between Unknown and I4
			object obj2 = 0;
			int num = 0;
			if ((int)((SplitContainer)this).get_BorderStyle() == 1)
			{
				num = 1;
			}
			if ((int)((SplitContainer)this).get_BorderStyle() == 2)
			{
				num = 2;
			}
			if (NewLateBinding.LateGet(obj, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return 0;
			}
			checked
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Panel2", false))
				{
					if (unchecked((int)((SplitContainer)this).get_Orientation()) == 0)
					{
						obj2 = ((SplitContainer)this).get_SplitterDistance() + ((SplitContainer)this).get_SplitterRectangle().Height;
					}
					return Operators.AddObject((object)(((Control)this).get_Top() + num), obj2);
				}
				return ((Control)this).get_Top() + num;
			}
		}
	}

	public DP()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Двойная панель");
		Props = new Propertys(this);
		LastProp = peremens.trans("Расстояние разделителя");
		LastSobyt = peremens.trans("Разделитель перемещен");
		if (peremens2.proj == null)
		{
			((Control)this).set_Name(defaultName + "1");
		}
		else
		{
			Propertys props = Props;
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			props.Name = Conversions.ToString(obj);
		}
		Props.Text = ((Control)this).get_Name();
		Props.BorderStyle = peremens.trans("Линия");
		Props.Width = 200;
		Props.Height = 150;
		Props.SplitterDistance = checked((int)Math.Round((double)((Control)this).get_Width() / 2.0));
		((SplitContainer)this).get_Panel1().set_Name("Panel1");
		((SplitContainer)this).get_Panel2().set_Name("Panel2");
		((Control)((SplitContainer)this).get_Panel1()).set_Tag((object)"Panel1");
		((Control)((SplitContainer)this).get_Panel2()).set_Tag((object)"Panel2");
		((Control)this).set_DoubleBuffered(true);
	}
}
