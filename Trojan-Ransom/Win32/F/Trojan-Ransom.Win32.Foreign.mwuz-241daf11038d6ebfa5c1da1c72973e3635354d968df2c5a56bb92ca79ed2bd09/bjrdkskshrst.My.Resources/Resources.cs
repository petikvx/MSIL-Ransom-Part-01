using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace bjrdkskshrst.My.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[HideModuleName]
[CompilerGenerated]
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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				IL_006b:
				if (object.ReferenceEquals(resourceMan, null))
				{
					_ = 0;
					if (uY3xn8k5PDYS3sYHM9())
					{
						goto IL_0038;
					}
				}
				goto IL_0003;
				IL_0052:
				resourceMan = resourceManager;
				goto IL_0003;
				IL_0003:
				while (true)
				{
					ResourceManager result = resourceMan;
					if (uY3xn8k5PDYS3sYHM9())
					{
						switch (6)
						{
						case 1:
						case 5:
							goto IL_0038;
						case 4:
							goto end_IL_0003;
						case 0:
							goto IL_006b;
						case 6:
							return result;
						}
						continue;
					}
					break;
					continue;
					end_IL_0003:
					break;
				}
				goto IL_0052;
				IL_0038:
				resourceManager = new ResourceManager("bjrdkskshrst.Resources", typeof(Resources).Assembly);
				goto IL_0052;
			}
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

	internal static byte[] bjrdkskshrst
	{
		get
		{
			object obj = T55RYuP7hjbmtYZrj3(seI068AMhJbZR4VDHT(ResourceManager, "bjrdkskshrst", resourceCulture));
			return (byte[])obj;
		}
	}

	internal static bool uY3xn8k5PDYS3sYHM9()
	{
		return true;
	}

	internal static bool efhuQdRo81qd6yHlxH()
	{
		return false;
	}

	internal static object seI068AMhJbZR4VDHT(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1, (CultureInfo?)object_2);
	}

	internal static object T55RYuP7hjbmtYZrj3(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
