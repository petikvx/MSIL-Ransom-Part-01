using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class CM : PictureBox
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public ContextMenuStrip CnMn;

	public object MyObj;

	public ToolStripItemCollection items => ((ToolStrip)CnMn).get_Items();

	public CM()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		TypeObj = "PoluObj";
		defaultName = peremens.trans("Всплывающее меню");
		Props = new Propertys(this);
		LastProp = peremens.trans("Имя");
		LastSobyt = peremens.trans("Клик");
		CnMn = new ContextMenuStrip();
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
	}
}
