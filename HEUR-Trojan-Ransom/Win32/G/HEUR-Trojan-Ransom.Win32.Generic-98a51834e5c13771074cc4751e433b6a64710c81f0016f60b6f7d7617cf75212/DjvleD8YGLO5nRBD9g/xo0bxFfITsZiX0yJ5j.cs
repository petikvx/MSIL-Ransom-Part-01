using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DjvleD8YGLO5nRBD9g;

[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class xo0bxFfITsZiX0yJ5j
{
	private static ResourceManager l5vZSjdLaV;

	private static CultureInfo tUGZEcgUHJ;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager smOZv7BDOt
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				bool flag = QdWGHWILpLDqZ8pITLx(l5vZSjdLaV, null);
				int num = 1;
				if (!xLSMBeIsCDKpNmJPu0i())
				{
					while (true)
					{
						switch (num)
						{
						case 1:
							if (!flag)
							{
								goto end_IL_0049;
							}
							nDKcsWIixHY69GxbmgL();
							if (!xLSMBeIsCDKpNmJPu0i())
							{
								num = 6;
								if (!xLSMBeIsCDKpNmJPu0i())
								{
									continue;
								}
								goto end_IL_0049;
							}
							goto IL_0084;
						case 4:
							break;
						case 2:
						case 6:
							goto IL_006a;
						default:
							goto IL_0084;
						case 0:
							goto end_IL_0049;
						case 7:
							return result;
						}
						break;
					}
					continue;
				}
				goto IL_006a;
				IL_0084:
				l5vZSjdLaV = resourceManager;
				break;
				IL_006a:
				resourceManager = new ResourceManager("QWDFVB.Resources", typeof(xo0bxFfITsZiX0yJ5j).Assembly);
				goto IL_0084;
				continue;
				end_IL_0049:
				break;
			}
			return l5vZSjdLaV;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo bnsZxQbZmV
	{
		get
		{
			return tUGZEcgUHJ;
		}
		set
		{
			tUGZEcgUHJ = value;
		}
	}

	internal static bool QdWGHWILpLDqZ8pITLx(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static bool nDKcsWIixHY69GxbmgL()
	{
		return true;
	}

	internal static bool xLSMBeIsCDKpNmJPu0i()
	{
		return false;
	}
}
