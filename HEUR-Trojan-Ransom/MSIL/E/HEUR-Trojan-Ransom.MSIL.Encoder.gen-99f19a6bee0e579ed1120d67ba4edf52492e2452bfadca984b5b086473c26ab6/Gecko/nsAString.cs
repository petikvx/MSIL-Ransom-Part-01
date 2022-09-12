using System;

namespace Gecko;

public sealed class nsAString : nsAStringBase
{
	private bool _isNative;

	public nsAString()
		: base(Xpcom.moz_xmalloc(new IntPtr(nsStringContainer.Size)))
	{
		nsAStringBase.NS_StringContainerInit(base.Container);
	}

	public nsAString(IntPtr container)
		: base(container)
	{
		_isNative = true;
	}

	public nsAString(string value)
		: this()
	{
		base.SetData(value);
	}

	protected override void Dispose(bool disposing)
	{
		if (!_isNative && !base.IsDisposed)
		{
			nsAStringBase.NS_StringContainerFinish(base.Container);
			Xpcom.free(base.Container);
			base.Dispose(disposing);
		}
	}
}
