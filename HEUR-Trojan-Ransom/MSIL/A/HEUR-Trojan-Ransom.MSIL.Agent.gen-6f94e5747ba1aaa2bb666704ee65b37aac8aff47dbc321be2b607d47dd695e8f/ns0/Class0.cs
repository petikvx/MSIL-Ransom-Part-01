using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns0;

[CompilerGenerated]
internal sealed class Class0<T, U>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	public T file => gparam_0;

	public U ext => gparam_1;

	[DebuggerHidden]
	public Class0(T gparam_2, U gparam_3)
	{
		gparam_0 = gparam_2;
		gparam_1 = gparam_3;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value is Class0<T, U> @class && EqualityComparer<T>.Default.Equals(gparam_0, @class.gparam_0))
		{
			return EqualityComparer<U>.Default.Equals(gparam_1, @class.gparam_1);
		}
		return false;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (295203957 * -1521134295 + EqualityComparer<T>.Default.GetHashCode(gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(gparam_1);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		return string.Format(null, "{{ file = {0}, ext = {1} }}", new object[2]
		{
			gparam_0?.ToString(),
			gparam_1?.ToString()
		});
	}
}
