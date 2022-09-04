using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace _0023Ye;

internal sealed class _0023mb
{
	internal sealed class _0023ub
	{
		public override bool _0023qb(object P_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		public override int _0023rb()
		{
			return base.GetHashCode();
		}

		public override string _0023sb()
		{
			return base.ToString();
		}
	}

	internal sealed class _0023wb<_0023pb> where _0023pb : new()
	{
		[ThreadStatic]
		private static _0023pb _00234F;

		[SpecialName]
		internal _0023pb _0023vb()
		{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
		}
	}

	private static readonly _0023wb<_0023ib> _00230F = new _0023wb<_0023ib>();

	private static readonly _0023wb<_0023gb> _00231F = new _0023wb<_0023gb>();

	private static readonly _0023wb<User> _00232F = new _0023wb<User>();

	private static readonly _0023wb<_0023ub> _00233F = new _0023wb<_0023ub>();

	[SpecialName]
	internal static _0023ib _0023jb()
	{
		return _00230F._0023vb();
	}
}
