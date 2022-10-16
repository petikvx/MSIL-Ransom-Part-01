using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralBroadcaster()
	{
	}
}
