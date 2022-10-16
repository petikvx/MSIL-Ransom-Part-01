using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RuleAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralDispatcher()
	{
	}
}
