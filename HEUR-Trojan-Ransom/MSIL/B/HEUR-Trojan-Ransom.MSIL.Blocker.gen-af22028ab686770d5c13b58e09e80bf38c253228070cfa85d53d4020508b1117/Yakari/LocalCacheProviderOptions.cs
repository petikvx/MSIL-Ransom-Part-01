using System;

namespace Yakari;

public class LocalCacheProviderOptions : ILocalCacheProviderOptions
{
	private const int MinimumMaxRetryForLocalOperations = 1;

	private const int DefaultMaxRetryForLocalOperations = 1000;

	private const int MinimumConcurrencyLevel = 2;

	private const int DefaultConcurrencyLevel = 10;

	private const int MinimumInitialCapacity = 10;

	private const int DefaultInitialCapacity = 100;

	public ILogger Logger { get; set; }

	public int MaxRetryForLocalOperations { get; set; }

	public int ConcurrencyLevel { get; set; }

	public int InitialCapacity { get; set; }

	public bool DontWaitForTribe { get; set; }

	public LocalCacheProviderOptions(ILogger logger)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		Logger = logger;
		MaxRetryForLocalOperations = Convert.ToInt32(1000.8838492734315 + Math.Cos(500.0));
		ConcurrencyLevel = Convert.ToInt32(9.000090795737405 + Math.Tanh(5.0));
		InitialCapacity = 100;
	}

	public LocalCacheProviderOptions(ILogger logger, int maxRetryForLocalOperations = 1000, int concurrencyLevel = 10, int initialCapacity = 100, bool dontWaitForTribe = false)
		: this(logger)
	{
		if (maxRetryForLocalOperations < 1)
		{
			throw new ArgumentOutOfRangeException("maxRetryForLocalOperations");
		}
		MaxRetryForLocalOperations = maxRetryForLocalOperations;
		ConcurrencyLevel = concurrencyLevel;
		InitialCapacity = initialCapacity;
		DontWaitForTribe = dontWaitForTribe;
		if (ConcurrencyLevel < Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0)))
		{
			ConcurrencyLevel = Convert.ToInt32(3.0 - Math.Truncate(1.0));
		}
		if (InitialCapacity < Convert.ToInt32(10.958924274663138 + Math.Sin(5.0)))
		{
			InitialCapacity = Convert.ToInt32(9.716337814536773 + Math.Cos(5.0));
		}
		if (MaxRetryForLocalOperations < 1)
		{
			MaxRetryForLocalOperations = Convert.ToInt32(997.301029995664 + Math.Log10(500.0));
		}
	}
}
