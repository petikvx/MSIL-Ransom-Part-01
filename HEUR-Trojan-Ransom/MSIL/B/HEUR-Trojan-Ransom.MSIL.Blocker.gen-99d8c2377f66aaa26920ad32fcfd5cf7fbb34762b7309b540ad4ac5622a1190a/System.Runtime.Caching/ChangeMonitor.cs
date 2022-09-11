using System.Runtime.Caching.Resources;
using System.Threading;

namespace System.Runtime.Caching;

public abstract class ChangeMonitor : IDisposable
{
	private const int INITIALIZED = 1;

	private const int CHANGED = 2;

	private const int INVOKED = 4;

	private const int DISPOSED = 8;

	private static readonly object NOT_SET = new object();

	private SafeBitVector32 _flags;

	private OnChangedCallback _onChangedCallback;

	private object _onChangedState = NOT_SET;

	public bool HasChanged => _flags[2];

	public bool IsDisposed => _flags[8];

	public abstract string UniqueId { get; }

	private void DisposeHelper()
	{
		if (_flags[1] && _flags.ChangeValue(8, value: true))
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}

	private void OnChangedHelper(object state)
	{
		_flags[2] = true;
		Interlocked.CompareExchange(ref _onChangedState, state, NOT_SET);
		OnChangedCallback onChangedCallback = _onChangedCallback;
		if (onChangedCallback != null && _flags.ChangeValue(4, value: true))
		{
			onChangedCallback(_onChangedState);
		}
	}

	protected abstract void Dispose(bool disposing);

	protected void InitializationComplete()
	{
		_flags[1] = true;
		if (_flags[2])
		{
			Dispose();
		}
	}

	protected void OnChanged(object state)
	{
		OnChangedHelper(state);
		if (_flags[1])
		{
			DisposeHelper();
		}
	}

	public void Dispose()
	{
		OnChangedHelper(null);
		if (!_flags[1])
		{
			throw new InvalidOperationException(R.Init_not_complete);
		}
		DisposeHelper();
	}

	public void NotifyOnChanged(OnChangedCallback onChangedCallback)
	{
		if (onChangedCallback == null)
		{
			throw new ArgumentNullException("onChangedCallback");
		}
		if (Interlocked.CompareExchange(ref _onChangedCallback, onChangedCallback, null) != null)
		{
			throw new InvalidOperationException(R.Method_already_invoked);
		}
		if (_flags[2])
		{
			OnChanged(null);
		}
	}
}
