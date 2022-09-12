using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp48.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager _Predicate;

	private static CultureInfo token;

	internal static Resources AwakeDefinition;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				bool flag = _Predicate == null;
				int num = 0;
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_2d1ecc138da54e46b94622af6e629ce1 == 0)
				{
					goto IL_0003;
				}
				goto IL_0035;
				IL_0035:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto end_IL_004c;
				case 3:
					return result;
				}
				goto IL_0003;
				IL_0003:
				if (!flag)
				{
					break;
				}
				ResourceManager resourceManager = (_Predicate = new ResourceManager("WindowsFormsApp48.Properties.Resources", typeof(Resources).Assembly));
				num = 2;
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_f03aed2051e54ac4992ef1535043cda6 == 0)
				{
					break;
				}
				goto IL_0035;
				continue;
				end_IL_004c:
				break;
			}
			return _Predicate;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result;
			while (true)
			{
				result = token;
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_d9811961e6eb44fd92df7d74afcd6171 != 0)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			return result;
		}
		set
		{
			token = value;
		}
	}

	internal Resources()
	{
	}

	internal static bool VisitDefinition()
	{
		return AwakeDefinition == null;
	}

	internal static Resources CollectDefinition()
	{
		return AwakeDefinition;
	}
}
