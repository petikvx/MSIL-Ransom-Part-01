using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConnectionFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewBridge()
	{
	}
}
