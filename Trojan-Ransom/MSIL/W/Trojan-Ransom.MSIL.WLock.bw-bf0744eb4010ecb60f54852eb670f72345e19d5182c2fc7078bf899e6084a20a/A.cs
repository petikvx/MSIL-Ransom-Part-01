using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class A : PictureBox
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public A()
	{
		TypeObj = "PoluObj";
		defaultName = peremens.trans("Аудио");
		Props = new Propertys(this);
		LastProp = peremens.trans("Плей");
		LastSobyt = peremens.trans("Конец проигрывания");
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
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((Control)this).set_Height(16);
		((Control)this).set_Width(16);
		((Control)this).set_BackColor(Color.Transparent);
		Props.MediaWindow = (Control)(object)this;
	}
}
