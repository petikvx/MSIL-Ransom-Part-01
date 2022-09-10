using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class QvNjdzKPYNENxUiwuiEqtqvQFigr
{
	private static ResourceManager umJPeAJHdIapyVbaBAThfzrEchcT;

	private static CultureInfo UCCWoqaKBiepwBXZJdjcClckDvBDA;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager vOrmMymlgiJivTVlqqyIDrVGrdmn
	{
		get
		{
			if (QvNjdzKPYNENxUiwuiEqtqvQFigr.TeEAkYuJnuacIGhiAujJFZsddxLk((object)umJPeAJHdIapyVbaBAThfzrEchcT, (object)null))
			{
				ResourceManager resourceManager = default(ResourceManager);
				while (true)
				{
					int num = -1982301587;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(~(num2 + 1296379499) * 1232060749) * -226138815)) % 4u)
						{
						case 2u:
							umJPeAJHdIapyVbaBAThfzrEchcT = resourceManager;
							num = ((int)num3 * -1146879651) ^ -1668140654;
							continue;
						case 1u:
							resourceManager = QvNjdzKPYNENxUiwuiEqtqvQFigr.NGBLShMWZlOhyZPCJOgxcQOdzgRW(_003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<string>(2213622724u), QvNjdzKPYNENxUiwuiEqtqvQFigr.UFDUCEkQgSxnXdMjIaCHgLppwTSA(QvNjdzKPYNENxUiwuiEqtqvQFigr.dIybFjGrjZgHeEjEGPNIRusKlaGJB(typeof(QvNjdzKPYNENxUiwuiEqtqvQFigr).TypeHandle)));
							num = (int)(num3 * 2096536358) ^ -1635346568;
							continue;
						case 3u:
							break;
						default:
							goto end_IL_0081;
						}
						break;
					}
					continue;
					end_IL_0081:
					break;
				}
			}
			return umJPeAJHdIapyVbaBAThfzrEchcT;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo KEOAtTdHXSpyqiPmsojjiswrWfEAb
	{
		get
		{
			return UCCWoqaKBiepwBXZJdjcClckDvBDA;
		}
		set
		{
			UCCWoqaKBiepwBXZJdjcClckDvBDA = value;
		}
	}

	internal QvNjdzKPYNENxUiwuiEqtqvQFigr()
	{
	}

	static bool TeEAkYuJnuacIGhiAujJFZsddxLk(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static Type dIybFjGrjZgHeEjEGPNIRusKlaGJB(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly UFDUCEkQgSxnXdMjIaCHgLppwTSA(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager NGBLShMWZlOhyZPCJOgxcQOdzgRW(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}
}
