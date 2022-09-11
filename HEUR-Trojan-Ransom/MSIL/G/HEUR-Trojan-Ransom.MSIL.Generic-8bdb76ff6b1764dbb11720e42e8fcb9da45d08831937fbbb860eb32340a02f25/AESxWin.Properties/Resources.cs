using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using WKtExBGrT2f6h026To;

namespace AESxWin.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005, IL_0042
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 1;
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 1;
				goto IL_004f;
			}
			int num2 = 3;
			if (true)
			{
				goto IL_004b;
			}
			goto IL_0099;
			IL_004f:
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 5:
					resourceManager = new ResourceManager("AESxWin.Properties.Resources", Type.GetTypeFromHandle(_0089_008E_008C_008D_0088_0090_008F_0095_008E_0088_0090_0089_0095_0093_0089_008E_008C_008B_0090_0093_008E_0091_0087_0095_0088_0095_0091_0086_008B_008B_008A_0086_0090_0094_0091_0095.e53w34m968awCm9P85taUZe(33554447)).Assembly);
					goto case 6;
				default:
					num = 6;
					continue;
				case 6:
					resourceMan = resourceManager;
					goto case 3;
				case 0:
				case 1:
					break;
				case 3:
				case 4:
					result = resourceMan;
					num = 7;
					continue;
				case 2:
					if (flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 7:
					return result;
				}
				break;
			}
			goto IL_0099;
			IL_0099:
			flag = resourceMan == null;
			num2 = 2;
			goto IL_004b;
			IL_004b:
			num = num2;
			goto IL_004f;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return resourceCulture;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			resourceCulture = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Resources()
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
