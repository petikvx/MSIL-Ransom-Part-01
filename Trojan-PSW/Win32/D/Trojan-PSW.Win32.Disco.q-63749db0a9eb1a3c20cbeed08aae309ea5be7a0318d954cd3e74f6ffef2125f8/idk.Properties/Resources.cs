using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns1;

namespace idk.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern ResourceManager ResourceManager { get; }

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal unsafe static CultureInfo Culture
	{
		get
		{
			//IL_0003: Invalid comparison between Unknown and I8
			long num;
			do
			{
				num = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
			}
			while ((long)/*Error near IL_0008: Stack underflow*/ > num);
			_ = *(object*)null;
			/*Error: Unexpected end of block*/;
		}
		set; }

	internal extern Resources();

	static bool smethod_0(object object_0, object object_1)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate4.delegate4_2(object_0, object_1);
	}

	static object smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate0.delegate0_3(runtimeTypeHandle_0);
	}

	static object smethod_2(object object_0)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate6.delegate6_3(object_0);
	}

	static object smethod_3(string string_0, object object_0)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate40.delegate40_1(string_0, object_0);
	}
}
