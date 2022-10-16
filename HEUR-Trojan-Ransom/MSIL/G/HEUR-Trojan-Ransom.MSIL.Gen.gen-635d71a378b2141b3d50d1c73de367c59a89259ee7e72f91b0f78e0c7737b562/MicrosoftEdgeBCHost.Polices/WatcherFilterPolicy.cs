using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WatcherFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotRecord()
	{
	}
}
