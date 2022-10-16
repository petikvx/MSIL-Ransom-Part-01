using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralAdapter()
	{
	}
}
