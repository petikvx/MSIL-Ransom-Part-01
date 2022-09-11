using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class F : Panel
{
	public string TypeObj;

	public string defaultName;

	public string LastProp;

	public string LastSobyt;

	public string LastObj;

	public Propertys Props;

	public object MyObj;

	public string StatusTemp;

	public F()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Окно");
		LastProp = peremens.trans("Текст");
		LastSobyt = peremens.trans("Клик");
		LastObj = "";
		Props = new Propertys(this);
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
		Props.Text = Props.Name;
		Props.BackColor = peremens.ToMyColor(SystemColors.ControlLight);
		Props.Width = 500;
		Props.Height = 320;
		((Control)this).set_Left(Conversions.ToInteger(peremens.formX));
		((Control)this).set_Top(peremens.formY);
		if (peremens.isRUN())
		{
			((Control)this).set_Visible(false);
		}
		else if (peremens.isDevelop)
		{
			Propertys props2 = Props;
			object? obj2 = peremens.SkinColors["FormsColor"];
			Color color = default(Color);
			props2.BackColor = peremens.ToMyColor((obj2 != null) ? ((Color)obj2) : color);
		}
	}

	public void Close()
	{
	}
}
