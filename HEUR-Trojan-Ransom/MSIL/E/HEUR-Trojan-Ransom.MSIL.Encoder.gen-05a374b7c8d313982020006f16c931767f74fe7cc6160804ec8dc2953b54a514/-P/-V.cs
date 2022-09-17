using System;
using System.Runtime.CompilerServices;

namespace _0023P;

internal abstract class _0023V : IDisposable
{
	[CompilerGenerated]
	private UIntPtr _0001;

	public UIntPtr HKey
	{
		[CompilerGenerated]
		get
		{
			return _0001;
		}
		[CompilerGenerated]
		set
		{
			_0001 = value;
		}
	}

	public _0023V(UIntPtr _0023W)
	{
		HKey = _0023W;
	}

	public abstract object _0023S(string _0023x);

	public abstract bool _0023T(string _0023x, out object _0023z);

	public abstract void _0023U();

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in #U
		this._0023U();
	}
}
