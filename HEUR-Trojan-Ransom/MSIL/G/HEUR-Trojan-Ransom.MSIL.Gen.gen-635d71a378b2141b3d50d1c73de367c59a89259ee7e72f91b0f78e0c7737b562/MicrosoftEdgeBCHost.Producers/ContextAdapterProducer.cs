using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralCustomer()
	{
	}
}
