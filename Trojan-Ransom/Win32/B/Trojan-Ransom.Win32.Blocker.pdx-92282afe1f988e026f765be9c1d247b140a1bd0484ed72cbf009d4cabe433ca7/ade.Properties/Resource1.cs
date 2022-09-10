using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ade.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resource1
{
	private static ResourceManager m__E000;

	private static CultureInfo m__E001;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager _E000
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_0003, IL_0006
			//IL_0007: Incompatible stack heights: 0 vs 1
			if (_E089._E000(Resource1.m__E000, null) || 1 == 0)
			{
				ResourceManager resourceManager = default(ResourceManager);
				while (true)
				{
					int num = Installer8._E001(24);
					while (true)
					{
						switch (num ^ _E008._E000(7))
						{
						case -34:
							resourceManager = _E08B._E000("ade.Properties.Resource1", _E08A._E000(_E01C._E000(typeof(Resource1).TypeHandle)));
							num = -63;
							continue;
						case -33:
							/*OpCode not supported: LdMemberToken*/;
							num = -2;
							continue;
						case -32:
							Resource1.m__E000 = resourceManager;
							num = Installer8._E001(25);
							continue;
						case -31:
							goto end_IL_0035;
						}
						break;
					}
					continue;
					end_IL_0035:
					break;
				}
			}
			return Resource1.m__E000;
		}
	}

	internal static string _E001 => _E08D._E000(_E08C._E000(), "String6", Resource1.m__E001);

	internal Resource1()
	{
	}//Discarded unreachable code: IL_0002, IL_0003, IL_0006
	//IL_0007: Incompatible stack heights: 0 vs 1


	static Resource1()
	{
		_E009._E000();
	}
}
