using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class3
{
	internal static char[] char_0;

	internal static string smethod_0()
	{
		return Class3.YQgcorSyLdSoBiZEkPRqOAfwDqgKA(char_0);
	}

	static Class3()
	{
		char[] array = new char[4];
		Class3.DMjysqVUUYXRGBfmOsPIgUzUCWjg((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		array[3] = Class0.smethod_0();
		char_0 = array;
	}

	static string YQgcorSyLdSoBiZEkPRqOAfwDqgKA(char[] char_1)
	{
		return new string(char_1);
	}

	static void DMjysqVUUYXRGBfmOsPIgUzUCWjg(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
