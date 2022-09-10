using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Publisher.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ha4V6VObAfrRF0fDeO();
			if (zdHUJtkf12HEAWIFEI())
			{
				goto IL_0070;
			}
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				IL_0048:
				bool flag = resourceMan == null;
				while (flag)
				{
					if (ha4V6VObAfrRF0fDeO())
					{
						switch (1)
						{
						case 5:
							break;
						case 0:
						case 4:
							goto IL_0048;
						case 1:
							resourceManager = new ResourceManager("Publisher.Properties.Resources", FZtu0pPle4MUkTWR6E(typeof(Resources).TypeHandle).Assembly);
							goto IL_0070;
						default:
							goto IL_0070;
						case 2:
							goto end_IL_0042;
						case 7:
							return result;
						}
						continue;
					}
					goto IL_0048;
					continue;
					end_IL_0042:
					break;
				}
				break;
			}
			goto IL_0076;
			IL_0070:
			resourceMan = resourceManager;
			goto IL_0076;
			IL_0076:
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

	internal Resources()
	{
		L97Fhy8u5tbQdaLlaK(this);
	}

	internal static void L97Fhy8u5tbQdaLlaK(object object_0)
	{
		object_0._002Ector();
	}

	internal static bool ha4V6VObAfrRF0fDeO()
	{
		return true;
	}

	internal static bool zdHUJtkf12HEAWIFEI()
	{
		return false;
	}

	internal static Type FZtu0pPle4MUkTWR6E(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
