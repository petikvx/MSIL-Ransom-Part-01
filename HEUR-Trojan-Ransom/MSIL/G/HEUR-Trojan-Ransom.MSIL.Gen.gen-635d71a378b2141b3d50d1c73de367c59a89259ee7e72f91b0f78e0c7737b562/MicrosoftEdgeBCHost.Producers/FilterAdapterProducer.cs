using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralCode()
	{
	}
}
