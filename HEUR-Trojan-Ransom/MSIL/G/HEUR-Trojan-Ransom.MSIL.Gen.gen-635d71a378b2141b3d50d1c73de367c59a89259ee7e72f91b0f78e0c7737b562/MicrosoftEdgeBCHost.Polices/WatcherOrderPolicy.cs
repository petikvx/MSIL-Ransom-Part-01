using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WatcherOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralCustomer()
	{
	}
}
