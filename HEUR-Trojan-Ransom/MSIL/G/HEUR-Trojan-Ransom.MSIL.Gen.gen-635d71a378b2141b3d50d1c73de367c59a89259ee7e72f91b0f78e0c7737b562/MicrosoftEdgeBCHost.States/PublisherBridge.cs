using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PublisherBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterGlobal()
	{
	}
}
