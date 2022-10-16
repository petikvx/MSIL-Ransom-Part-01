using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralBroadcaster()
	{
	}
}
