using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class PrB : ProgressBar
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public PrB()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Полоса загрузки");
		Props = new Propertys(this);
		LastProp = peremens.trans("Значение");
		LastSobyt = peremens.trans("Клик");
		bool[] array3;
		if (peremens2.proj == null)
		{
			Props.Name = defaultName + "1";
		}
		else
		{
			Propertys props = Props;
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			props.Name = Conversions.ToString(obj);
		}
		((Control)this).set_AutoSize(false);
		Propertys props2 = Props;
		object proj2 = peremens2.proj;
		object[] array4 = new object[1] { defaultName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GiveName", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		props2.Name = Conversions.ToString(obj2);
		Props.Width = 250;
		Props.Height = 20;
		Props.Value = "0";
		Props.BackColor = peremens.ToMyColor(((Control)this).get_BackColor());
	}
}
