using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ErrorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		OrderMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderMapper()
	{
	}
}
