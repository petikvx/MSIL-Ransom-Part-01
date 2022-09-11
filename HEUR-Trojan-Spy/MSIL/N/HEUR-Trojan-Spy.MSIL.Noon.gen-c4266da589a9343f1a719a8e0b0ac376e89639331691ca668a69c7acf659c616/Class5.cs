using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
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
				ResourceManager resourceManager = (resourceManager_0 = Class5.smethod_3("FlappyBird.Resources", Class5.smethod_2(Class5.smethod_1(typeof(Class5).TypeHandle))));
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

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Class5.smethod_5(Class5.smethod_4(ResourceManager_0, "cdoS", cultureInfo_0));
			return (Bitmap)obj;
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

	static object smethod_4(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetObject(string_0, cultureInfo_1);
	}

	static object smethod_5(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
