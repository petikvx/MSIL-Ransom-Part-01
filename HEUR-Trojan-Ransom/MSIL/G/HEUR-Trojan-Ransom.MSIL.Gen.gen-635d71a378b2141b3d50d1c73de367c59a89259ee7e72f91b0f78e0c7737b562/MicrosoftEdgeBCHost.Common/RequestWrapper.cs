using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RequestWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateBroadcaster()
	{
	}
}
