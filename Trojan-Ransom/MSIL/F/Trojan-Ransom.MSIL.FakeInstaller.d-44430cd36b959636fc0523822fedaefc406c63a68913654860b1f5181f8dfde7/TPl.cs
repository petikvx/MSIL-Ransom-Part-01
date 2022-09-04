using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class TPl : ToolStrip
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public TPl()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Панель инструментов");
		Props = new Propertys(this);
		LastProp = peremens.trans("Ширина");
		LastSobyt = peremens.trans("Клик");
		bool[] array3;
		if (peremens2.proj == null)
		{
			((Control)this).set_Name(defaultName + "1");
		}
		else
		{
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			((Control)this).set_Name(Conversions.ToString(obj));
		}
		object proj2 = peremens2.proj;
		object[] array4 = new object[1] { defaultName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GiveName", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		((Control)this).set_Name(Conversions.ToString(obj2));
		((Control)this).set_Text(((Control)this).get_Name());
		((ToolStrip)this).set_GripStyle((ToolStripGripStyle)0);
		((ToolStrip)this).set_AutoSize(false);
		Props.Width = 150;
		Props.Height = 30;
		Props.BackColor = peremens.ToMyColor(SystemColors.Control);
		((ToolStrip)this).set_Dock((DockStyle)0);
		((ToolStrip)this).set_RenderMode((ToolStripRenderMode)2);
	}
}
