using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class OrderVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderVal()
	{
		WriterPropertyProducer.ResolveStub();
		RunPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunPublisher()
	{
	}
}
