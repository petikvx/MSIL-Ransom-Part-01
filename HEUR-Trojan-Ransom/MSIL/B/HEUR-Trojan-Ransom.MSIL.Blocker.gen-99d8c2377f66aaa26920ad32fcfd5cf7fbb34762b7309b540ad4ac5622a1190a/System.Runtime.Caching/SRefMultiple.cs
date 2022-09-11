namespace System.Runtime.Caching;

internal class SRefMultiple
{
	private SRef[] _srefs;

	private long[] _sizes;

	internal long ApproximateSize
	{
		get
		{
			long num = 0L;
			for (int i = 0; i < _srefs.Length; i++)
			{
				num += (_sizes[i] = _srefs[i].ApproximateSize);
			}
			return num;
		}
	}

	internal SRefMultiple(object[] targets)
	{
		_srefs = new SRef[targets.Length];
		_sizes = new long[targets.Length];
		for (int i = 0; i < targets.Length; i++)
		{
			_srefs[i] = new SRef(targets[i]);
		}
	}

	internal void Dispose()
	{
		SRef[] srefs = _srefs;
		foreach (SRef sRef in srefs)
		{
			sRef.Dispose();
		}
	}
}
