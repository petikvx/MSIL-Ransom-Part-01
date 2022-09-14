using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

[StandardModule]
internal sealed class Common
{
	private static ConsoleKeyInfo key;

	private static bool STANDALONE = true;

	public static readonly object lLOG = null;

	public static void initLog()
	{
	}

	public static void oldlog(string msg, bool wait)
	{
		if (STANDALONE)
		{
			Console.WriteLine(msg);
			object obj = lLOG;
			object[] obj2 = new object[1] { msg };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Debug", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				msg = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (wait)
			{
				Console.WriteLine("press any key to continue");
				key = Console.ReadKey();
			}
		}
		else if (wait)
		{
		}
	}

	public static void populateMessageArray(ref ArrayList listMsg, object level)
	{
	}
}
