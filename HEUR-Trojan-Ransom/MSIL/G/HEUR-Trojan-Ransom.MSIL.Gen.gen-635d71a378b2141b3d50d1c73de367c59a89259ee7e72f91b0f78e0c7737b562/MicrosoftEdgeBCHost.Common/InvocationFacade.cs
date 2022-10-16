using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFacade()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralConsumer()
	{
	}
}
