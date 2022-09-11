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
		//Discarded unreachable code: IL_0005, IL_0033
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_009f: Incompatible stack heights: 0 vs 1
		int num = 0;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					applyToMembers = true;
					num2 = 5;
					continue;
				case 2:
				case 4:
					strip = true;
					goto default;
				default:
					feature = "";
					num2 = 6;
					continue;
				case 5:
					exclude = true;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 1 : 4);
					break;
				case 6:
					base._002Ector();
					num = 7;
					break;
				case 7:
					return;
				}
				break;
			}
		}
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
