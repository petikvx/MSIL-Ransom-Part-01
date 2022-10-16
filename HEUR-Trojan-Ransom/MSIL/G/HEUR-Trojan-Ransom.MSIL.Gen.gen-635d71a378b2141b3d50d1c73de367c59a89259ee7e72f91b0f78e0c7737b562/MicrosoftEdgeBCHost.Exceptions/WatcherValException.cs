using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WatcherValException : Attribute
{
	private static object CalculateWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WatcherValException(string info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValException()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SetWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WatcherValException PopWorker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareWorker()
	{
	}
}
