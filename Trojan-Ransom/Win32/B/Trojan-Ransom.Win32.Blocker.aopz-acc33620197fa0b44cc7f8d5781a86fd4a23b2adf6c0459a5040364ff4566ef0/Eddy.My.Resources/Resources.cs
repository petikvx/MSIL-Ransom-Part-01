using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eddy.My.Resources;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[HideModuleName]
[StandardModule]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (BdG2xG3kobSLQHRoOl6(resourceMan, null))
			{
				_ = 0;
				ResourceManager resourceManager = default(ResourceManager);
				if (DQ7xtA3aqkOYkLaXQKj())
				{
					resourceManager = new ResourceManager("Eddy.Resources", cKP1I1373qs67DCq0Kj(typeof(Resources).TypeHandle).Assembly);
				}
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] x
	{
		get
		{
			object obj = r8HPPm30FTbfDJJRRLF(W1K5Nh3uw7isKGfaGrb(BogJXn35AwPgFaHxw8l(), "x", resourceCulture));
			return (byte[])obj;
		}
	}

	internal static bool BdG2xG3kobSLQHRoOl6(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type cKP1I1373qs67DCq0Kj(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool DQ7xtA3aqkOYkLaXQKj()
	{
		return true;
	}

	internal static bool z0xUrf3SnUUjO3QOCpw()
	{
		return false;
	}

	internal static object BogJXn35AwPgFaHxw8l()
	{
		return ResourceManager;
	}

	internal static object W1K5Nh3uw7isKGfaGrb(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1, (CultureInfo?)object_2);
	}

	internal static object r8HPPm30FTbfDJJRRLF(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
