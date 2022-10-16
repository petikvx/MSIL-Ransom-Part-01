using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PopGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopGlobal()
	{
	}
}
