using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class Class20
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern ResourceManager ResourceManager_0 { get; }

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0008, IL_0016, IL_001c, IL_0027
			//IL_0003: Expected O, but got I4
			//IL_000c: Expected F4, but got I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Invalid comparison between Unknown and I4
			_ = ((Array)3).LongLength;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	internal static extern Bitmap Bitmap_0 { get; }

	internal static extern UnmanagedMemoryStream UnmanagedMemoryStream_0 { get; }

	static bool smethod_0(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static object smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static object smethod_2(object object_0)
	{
		return ((Type)object_0).Assembly;
	}

	static object smethod_3(string string_0, object object_0)
	{
		return new ResourceManager(string_0, (Assembly)object_0);
	}

	static object smethod_4()
	{
		return ResourceManager_0;
	}

	static string smethod_5()
	{
		return Class22.smethod_254();
	}

	static object smethod_6(object object_0, string string_0, object object_1)
	{
		return ((ResourceManager)object_0).GetObject(string_0, (CultureInfo?)object_1);
	}

	static object smethod_7(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static string smethod_8()
	{
		return Class22.smethod_255();
	}

	static object smethod_9(object object_0, string string_0, object object_1)
	{
		return ((ResourceManager)object_0).GetStream(string_0, (CultureInfo?)object_1);
	}
}
