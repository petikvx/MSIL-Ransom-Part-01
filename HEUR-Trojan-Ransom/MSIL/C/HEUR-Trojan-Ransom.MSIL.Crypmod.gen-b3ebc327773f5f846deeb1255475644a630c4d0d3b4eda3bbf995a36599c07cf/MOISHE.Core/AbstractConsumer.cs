using System;
using System.Collections.Concurrent;

namespace MOISHE.Core;

public abstract class AbstractConsumer<T> : AbstractWorker
{
	protected BlockingCollection<T> source;

	protected AbstractConsumer(BlockingCollection<T> source)
	{
		this.source = source;
	}

	protected override void Execute()
	{
		while (_run)
		{
			try
			{
				T val = source.Take();
				if (val != null)
				{
					OnItemArrived(val);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	protected abstract void OnItemArrived(T item);
}
