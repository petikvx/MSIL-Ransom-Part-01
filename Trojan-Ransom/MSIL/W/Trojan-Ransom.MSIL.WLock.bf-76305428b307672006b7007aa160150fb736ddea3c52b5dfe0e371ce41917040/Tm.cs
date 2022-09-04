using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Tm : PictureBox
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public object Height
	{
		get
		{
			return ((Control)this).get_Height();
		}
		set
		{
		}
	}

	public object Width
	{
		get
		{
			return ((Control)this).get_Width();
		}
		set
		{
		}
	}

	public Tm()
	{
		TypeObj = "PoluObj";
		defaultName = peremens.trans("Секундомер");
		Props = new Propertys(this);
		LastProp = peremens.trans("Старт");
		LastSobyt = peremens.trans("Тикнул");
		if (peremens2.proj == null)
		{
			((Control)this).set_Name(defaultName + "1");
		}
		else
		{
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			((Control)this).set_Name(Conversions.ToString(obj));
		}
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((Control)this).set_Height(16);
		((Control)this).set_Width(16);
		((Control)this).set_BackColor(Color.Transparent);
		Props.Enabled = peremens.trans("Нет");
	}
}
