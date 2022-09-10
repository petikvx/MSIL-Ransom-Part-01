using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using s6KLe4;

namespace c6J5Kz;

public class d3LYm9
{
	private j6FLn1.k7DNq2 k7DNq2_0 = new j6FLn1.k7DNq2();

	private void Gp34Pw(object sender, EventArgs e)
	{
		Mm57Ws();
		NewLateBinding.LateCall(k7DNq2_0.object_0, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = k7DNq2_0.object_1;
		object[] array = new object[1];
		ref object object_2 = ref k7DNq2_0.object_2;
		array[0] = object_2;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((array2 as bool[])[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private void Mm57Ws()
	{
		throw new NotImplementedException();
	}

	private void k3WAo5(object sender, EventArgs e)
	{
		object object_ = k7DNq2_0.object_3;
		object[] array = new object[1];
		object object_2 = k7DNq2_0.object_2;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void n4E7Cp()
	{
		throw new NotImplementedException();
	}
}
