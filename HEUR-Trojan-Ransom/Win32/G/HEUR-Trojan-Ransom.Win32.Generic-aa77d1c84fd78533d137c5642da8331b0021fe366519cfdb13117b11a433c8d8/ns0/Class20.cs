using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[HideModuleName]
[CompilerGenerated]
internal sealed class Class20
{
	private static object object_0;

	private static object object_1;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				bool flag = smethod_2(object_0, null);
				while (true)
				{
					if (flag)
					{
						_ = 1;
						int num;
						if (!smethod_5())
						{
							num = 0;
							if (smethod_5())
							{
							}
						}
						else
						{
							num = 4;
							if (!smethod_4())
							{
								goto IL_008a;
							}
						}
						switch (num)
						{
						case 1:
							break;
						case 5:
							goto end_IL_004e;
						case 0:
						case 2:
							resourceManager = new ResourceManager("SpiritMagnifier.Resources", smethod_3(typeof(Class20).TypeHandle).Assembly);
							goto default;
						default:
							object_0 = resourceManager;
							goto IL_0084;
						case 6:
							goto IL_0084;
						case 7:
							goto IL_008a;
						}
						continue;
					}
					goto IL_0084;
					IL_0084:
					return (ResourceManager)object_0;
					IL_008a:
					return result;
					continue;
					end_IL_004e:
					break;
				}
			}
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

	[SpecialName]
	internal static Bitmap smethod_0()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = smethod_8(smethod_7(smethod_6(), "Magnify", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = smethod_8(smethod_7(smethod_6(), "Magnifying_Glass", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	internal static bool smethod_2(object object_2, object object_3)
	{
		return object.ReferenceEquals(object_2, object_3);
	}

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return false;
	}

	internal static object smethod_6()
	{
		return ResourceManager_0;
	}

	internal static object smethod_7(object object_2, object object_3, object object_4)
	{
		return ((ResourceManager)object_2).GetObject((string)object_3, (CultureInfo?)object_4);
	}

	internal static object smethod_8(object object_2)
	{
		return RuntimeHelpers.GetObjectValue(object_2);
	}
}
