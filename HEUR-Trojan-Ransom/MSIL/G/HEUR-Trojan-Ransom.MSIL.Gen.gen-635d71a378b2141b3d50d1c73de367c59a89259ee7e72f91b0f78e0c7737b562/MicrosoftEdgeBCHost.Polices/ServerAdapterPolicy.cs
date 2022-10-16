using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralContext()
	{
	}
}
