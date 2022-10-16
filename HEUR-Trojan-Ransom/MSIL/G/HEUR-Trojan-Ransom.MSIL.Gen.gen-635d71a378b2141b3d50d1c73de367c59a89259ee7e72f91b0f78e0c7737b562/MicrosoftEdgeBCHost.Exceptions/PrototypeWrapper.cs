using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypeWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterBroadcaster()
	{
	}
}
