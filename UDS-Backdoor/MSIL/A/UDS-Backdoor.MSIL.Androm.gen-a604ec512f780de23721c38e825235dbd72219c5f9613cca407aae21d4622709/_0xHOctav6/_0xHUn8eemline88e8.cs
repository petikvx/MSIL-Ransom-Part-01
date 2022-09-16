using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

namespace _0xHOctav6;

internal class _0xHUn8eemline88e8 : INotifyCollectionChanged, IDisposable, IWeakEventListener
{
	private INotifyCollectionChanged _0xHSen8uo8ity;

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = _0xHBeg3ine;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref _0xHBeg3ine, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = _0xHBeg3ine;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref _0xHBeg3ine, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	public _0xHUn8eemline88e8(INotifyCollectionChanged source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		_0xHSen8uo8ity = source;
		CollectionChangedEventManager.AddListener(_0xHSen8uo8ity, (IWeakEventListener)(object)this);
	}

	private bool _0xHOutpourin5(Type _0xHRo3es, object _0xHTher5ofor5able, EventArgs _0xH4ishandle)
	{
		if (_0xHRo3es == typeof(CollectionChangedEventManager))
		{
			_0xHBeg3ine?.Invoke(_0xHTher5ofor5able, (NotifyCollectionChangedEventArgs)_0xH4ishandle);
			return true;
		}
		return false;
	}

	public void _0xHOverdosi6g()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && _0xHSen8uo8ity != null)
		{
			CollectionChangedEventManager.RemoveListener(_0xHSen8uo8ity, (IWeakEventListener)(object)this);
			_0xHSen8uo8ity = null;
		}
	}
}
