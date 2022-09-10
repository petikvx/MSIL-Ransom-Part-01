using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace gfSB4uXRvfqbqvypxy;

[_0089_0089_0094_0086_008F_0092_0094_0087_0089_008F_0087_0090_0091_0093_0088_0094_0091_008A_0092_008C_0091_0092_0089_0088_0086_008D_0092_0089_0088_008F_0089_008D_0093_0093_008E_008F(Exclude = true, ApplyToMembers = true, StripAfterObfuscation = true)]
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
internal sealed class _0089_0089_0094_0086_008F_0092_0094_0087_0089_008F_0087_0090_0091_0093_0088_0094_0091_008A_0092_008C_0091_0092_0089_0088_0086_008D_0092_0089_0088_008F_0089_008D_0093_0093_008E_008F : Attribute
{
	private bool applyToMembers;

	private bool exclude;

	private bool strip;

	private string feature;

	public bool ApplyToMembers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return applyToMembers;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			applyToMembers = value;
		}
	}

	public bool Exclude
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return exclude;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			exclude = value;
		}
	}

	public string Feature
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return feature;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			feature = value;
		}
	}

	public bool StripAfterObfuscation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return strip;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			strip = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _0089_0089_0094_0086_008F_0092_0094_0087_0089_008F_0087_0090_0091_0093_0088_0094_0091_008A_0092_008C_0091_0092_0089_0088_0086_008D_0092_0089_0088_008F_0089_008D_0093_0093_008E_008F()
	{
		//Discarded unreachable code: IL_0005, IL_002d
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 2;
			goto IL_0032;
		}
		int num2 = 3;
		goto IL_003a;
		IL_0036:
		int num3;
		num2 = num3;
		goto IL_003a;
		IL_0032:
		num3 = num;
		goto IL_0036;
		IL_003a:
		while (true)
		{
			switch (num2)
			{
			case 4:
				strip = true;
				goto case 6;
			default:
				num2 = 6;
				break;
			case 0:
			case 2:
				applyToMembers = true;
				goto case 1;
			case 1:
			case 3:
				exclude = true;
				num2 = 4;
				break;
			case 6:
				feature = "";
				num3 = 5;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto end_IL_003a;
				}
				goto case 5;
			case 5:
				base._002Ector();
				num = 7;
				goto IL_0032;
			case 7:
				return;
			}
			continue;
			end_IL_003a:
			break;
		}
		goto IL_0036;
	}

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
