using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace XW;

[CompilerGenerated]
[DebuggerDisplay("\\{ Index = {Index}, Value = {Value} }", Type = "<Anonymous Type>")]
internal sealed class pL<Xi, ha>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Xi ha;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ha Tq;

	private static object md;

	public ha Value => Tq;

	[SpecialName]
	public Xi XW()
	{
		return this.ha;
	}

	[DebuggerHidden]
	public pL(Xi Index, ha Value)
	{
		G3.nJ(G3.By);
		base._002Ector();
		this.ha = Index;
		Tq = Value;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		pL<Xi, ha> pL2 = value as pL<Xi, ha>;
		return this == pL2 || (pL2 != null && EqualityComparer<Xi>.Default.Equals(this.ha, pL2.ha) && EqualityComparer<ha>.Default.Equals(Tq, pL2.Tq));
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1381124481 + EqualityComparer<Xi>.Default.GetHashCode(this.ha)) * -1521134295 + EqualityComparer<ha>.Default.GetHashCode(Tq);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		Xi val = this.ha;
		array[0] = ((val != null) ? val.ToString() : null);
		ha tq = Tq;
		array[1] = ((tq != null) ? tq.ToString() : null);
		return AX.nJ(null, "{{ Index = {0}, Value = {1} }}", array, AX.Pc);
	}

	internal static bool jU()
	{
		return md == null;
	}

	internal static object aH()
	{
		return md;
	}
}
