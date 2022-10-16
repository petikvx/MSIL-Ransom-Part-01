using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AccountAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralTag()
	{
	}
}
