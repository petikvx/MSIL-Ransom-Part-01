using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConnectionValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushCallback()
	{
	}
}
