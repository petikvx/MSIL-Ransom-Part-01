using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Vindows.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			int num = 0;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					resourceManager_0 = new ResourceManager("Vindows.Properties.Resources", typeof(Resources).Assembly);
					num = 2;
					num2 = num;
					continue;
				case 0:
				{
					num = 8817;
					int num3 = num;
					num = 8817;
					switch (num3 == num)
					{
					case false:
					case true:
						goto end_IL_00a6;
					}
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					num = 0;
					goto default;
				}
				default:
					if (resourceManager_0 == null)
					{
						num = 1;
						num2 = num;
						continue;
					}
					break;
				case 2:
					break;
					end_IL_00a6:
					break;
				}
				break;
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			int num = 0;
			num = 25975;
			int num2 = num;
			num = 25975;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return cultureInfo_0;
			}
		}
		set
		{
			int num = 0;
			num = -21051;
			int num2 = num;
			num = -21051;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap vindows
	{
		get
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			int num = 0;
			num = 19638;
			int num2 = num;
			num = 19638;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return (Bitmap)ResourceManager.GetObject("vindows", cultureInfo_0);
			}
		}
	}

	internal Resources()
	{
	}
}
