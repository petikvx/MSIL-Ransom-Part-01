using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Vconsole.My.Resources;

[HideModuleName]
[StandardModule]
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			dfNuKXPeoVTBNHPCYFl();
			if (jxQ6IHPNFg4UlNavYJt())
			{
				goto IL_0047;
			}
			goto IL_005e;
			IL_005e:
			ResourceManager resourceManager = new ResourceManager("Vconsole.Resources", aXJ6XVP8FkLfIN7Zu0T(typeof(Resources).TypeHandle).Assembly);
			goto IL_0056;
			IL_0056:
			resourceMan = resourceManager;
			goto IL_0012;
			IL_0012:
			while (true)
			{
				ResourceManager result = resourceMan;
				if (dfNuKXPeoVTBNHPCYFl())
				{
				}
				switch (6)
				{
				case 0:
				case 5:
					goto end_IL_0012;
				case 4:
					goto IL_0056;
				case 1:
				case 3:
					goto IL_005e;
				case 6:
					return result;
				}
				continue;
				end_IL_0012:
				break;
			}
			goto IL_0047;
			IL_0047:
			if (!lURmDEPakI6w98hDJHa(resourceMan, null))
			{
				goto IL_0012;
			}
			goto IL_005e;
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

	internal static byte[] _5527
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(YKtkEfP6iApxw3wCNi8(gXCf3XPBfOQFaGcqdoD(), "_5527", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static byte[] zlib1
	{
		get
		{
			object obj = ulVHQGPQLgRSXVJBqEi(((ResourceManager)gXCf3XPBfOQFaGcqdoD()).GetObject("zlib1", resourceCulture));
			return (byte[])obj;
		}
	}

	internal static bool lURmDEPakI6w98hDJHa(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type aXJ6XVP8FkLfIN7Zu0T(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool jxQ6IHPNFg4UlNavYJt()
	{
		return true;
	}

	internal static bool dfNuKXPeoVTBNHPCYFl()
	{
		return false;
	}

	internal static object gXCf3XPBfOQFaGcqdoD()
	{
		return ResourceManager;
	}

	internal static object YKtkEfP6iApxw3wCNi8(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1, (CultureInfo?)object_2);
	}

	internal static object ulVHQGPQLgRSXVJBqEi(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
