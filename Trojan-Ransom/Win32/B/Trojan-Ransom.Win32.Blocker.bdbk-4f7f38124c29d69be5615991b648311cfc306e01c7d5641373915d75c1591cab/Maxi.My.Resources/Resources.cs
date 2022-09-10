using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Maxi.My.Resources;

[CompilerGenerated]
[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
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
			int num = 0;
			if (YAnSPooCZfGKDddfKEb())
			{
				ResourceManager result = default(ResourceManager);
				while (true)
				{
					switch (num)
					{
					default:
						num = 6;
						if (!ild5knoe8WPvDNoOgrp())
						{
							continue;
						}
						goto IL_007c;
					case 0:
						break;
					case 3:
						goto IL_0051;
					case 2:
					case 5:
						goto IL_0062;
					case 6:
						goto IL_007c;
					case 1:
					case 4:
						goto IL_0082;
					case 7:
						return result;
					}
					break;
				}
			}
			bool flag = G9TlEHoOlt7aEsjQ36G(resourceMan, null);
			goto IL_0051;
			IL_0062:
			ResourceManager resourceManager = new ResourceManager("Maxi.Resources", OBMuf5odCA0pRWubqbi(typeof(Resources).TypeHandle).Assembly);
			goto IL_007c;
			IL_0082:
			return resourceMan;
			IL_007c:
			resourceMan = resourceManager;
			goto IL_0082;
			IL_0051:
			if (flag)
			{
				_ = 0;
				if (YAnSPooCZfGKDddfKEb())
				{
					goto IL_0062;
				}
			}
			goto IL_0082;
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

	internal static bool G9TlEHoOlt7aEsjQ36G(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type OBMuf5odCA0pRWubqbi(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool YAnSPooCZfGKDddfKEb()
	{
		return true;
	}

	internal static bool ild5knoe8WPvDNoOgrp()
	{
		return false;
	}
}
