using System;

namespace Examine;

public abstract class DisposableObject : IDisposable
{
	private bool _disposed;

	private readonly object _locko = new object();

	internal bool Disposed => _disposed;

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~DisposableObject()
	{
		Dispose(disposing: false);
	}

	private void Dispose(bool disposing)
	{
		lock (_locko)
		{
			if (_disposed)
			{
				return;
			}
			_disposed = true;
		}
		DisposeUnmanagedResources();
		if (disposing)
		{
			DisposeResources();
		}
	}

	protected abstract void DisposeResources();

	protected virtual void DisposeUnmanagedResources()
	{
	}
}
