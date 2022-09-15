using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[CompilerGenerated]
[StandardModule]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class5
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class5.smethod_0((object)resourceManager_0, (object)null))
			{
				ResourceManager resourceManager = (resourceManager_0 = Class5.smethod_3("Annabelle.Resources", Class5.smethod_2(Class5.smethod_1(typeof(Class5).TypeHandle))));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static UnmanagedMemoryStream UnmanagedMemoryStream_0 => Class5.smethod_4(ResourceManager_0, "annabelle", cultureInfo_0);

	internal static UnmanagedMemoryStream UnmanagedMemoryStream_1 => Class5.smethod_4(ResourceManager_0, "child", cultureInfo_0);

	internal static UnmanagedMemoryStream UnmanagedMemoryStream_2 => Class5.smethod_4(ResourceManager_0, "childsound", cultureInfo_0);

	internal static byte[] Byte_0
	{
		get
		{
			object obj = Class5.smethod_6(Class5.smethod_5(ResourceManager_0, "MBRiCoreX", cultureInfo_0));
			return (byte[])obj;
		}
	}

	static bool smethod_0(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly smethod_2(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager smethod_3(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static UnmanagedMemoryStream smethod_4(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetStream(string_0, cultureInfo_1);
	}

	static object smethod_5(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetObject(string_0, cultureInfo_1);
	}

	static object smethod_6(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
