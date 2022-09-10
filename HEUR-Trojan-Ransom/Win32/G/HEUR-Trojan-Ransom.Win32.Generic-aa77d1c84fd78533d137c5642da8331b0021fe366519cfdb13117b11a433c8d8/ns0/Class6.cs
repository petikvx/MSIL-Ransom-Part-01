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

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[StandardModule]
[HideModuleName]
[CompilerGenerated]
internal sealed class Class6
{
	private static object object_0;

	private static object object_1;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				bool flag = smethod_6(object_0, null);
				while (true)
				{
					if (flag)
					{
						smethod_8();
						if (smethod_9())
						{
							if (smethod_9())
							{
							}
							switch (5)
							{
							case 6:
								break;
							case 1:
								goto end_IL_0043;
							case 0:
							case 2:
								goto IL_0057;
							default:
								goto IL_0071;
							case 4:
								goto IL_0077;
							case 7:
								return result;
							}
							continue;
						}
						goto IL_0057;
					}
					goto IL_0077;
					IL_0057:
					resourceManager = new ResourceManager("GOL.Resources", smethod_7(typeof(Class6).TypeHandle).Assembly);
					goto IL_0071;
					IL_0071:
					object_0 = resourceManager;
					goto IL_0077;
					IL_0077:
					return (ResourceManager)object_0;
					continue;
					end_IL_0043:
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
		object obj = smethod_12(smethod_11(smethod_10(), "vzZOLFXUqNl", object_1));
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
		object obj = smethod_12(smethod_11(smethod_10(), "rnyDRmnx", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = smethod_12(smethod_11(smethod_10(), "OiCvl", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	[SpecialName]
	internal static Bitmap smethod_3()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = smethod_12(smethod_11(smethod_10(), "zmNjwLrK", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	[SpecialName]
	internal static Bitmap smethod_4()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = smethod_12(smethod_11(smethod_10(), "HCfv", object_1));
		Bitmap result = default(Bitmap);
		for (int num = 0; num == 0; num = 1)
		{
			result = (Bitmap)obj;
		}
		return result;
	}

	[SpecialName]
	internal static string smethod_5()
	{
		return (string)smethod_13(smethod_10(), "RaaYdPIP", object_1);
	}

	internal static bool smethod_6(object object_2, object object_3)
	{
		return object.ReferenceEquals(object_2, object_3);
	}

	internal static Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool smethod_8()
	{
		return true;
	}

	internal static bool smethod_9()
	{
		return false;
	}

	internal static object smethod_10()
	{
		return ResourceManager_0;
	}

	internal static object smethod_11(object object_2, object object_3, object object_4)
	{
		return ((ResourceManager)object_2).GetObject((string)object_3, (CultureInfo?)object_4);
	}

	internal static object smethod_12(object object_2)
	{
		return RuntimeHelpers.GetObjectValue(object_2);
	}

	internal static object smethod_13(object object_2, object object_3, object object_4)
	{
		return ((ResourceManager)object_2).GetString((string)object_3, (CultureInfo?)object_4);
	}
}
