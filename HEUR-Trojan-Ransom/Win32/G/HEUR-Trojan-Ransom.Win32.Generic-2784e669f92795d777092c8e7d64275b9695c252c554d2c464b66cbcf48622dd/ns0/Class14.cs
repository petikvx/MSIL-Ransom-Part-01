using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[HideModuleName]
[CompilerGenerated]
internal sealed class Class14
{
	private static object object_0;

	private static object object_1;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (smethod_0(object_0, null))
			{
				_ = 0;
				ResourceManager resourceManager = default(ResourceManager);
				if (smethod_2())
				{
					resourceManager = new ResourceManager("PackageIO.Resources", smethod_1(typeof(Class14).TypeHandle).Assembly);
				}
				object_0 = resourceManager;
			}
			return (ResourceManager)object_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return (CultureInfo)object_1;
		}
		set
		{
			object_1 = value;
		}
	}

	internal static bool smethod_0(object object_2, object object_3)
	{
		return object.ReferenceEquals(object_2, object_3);
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}
}
