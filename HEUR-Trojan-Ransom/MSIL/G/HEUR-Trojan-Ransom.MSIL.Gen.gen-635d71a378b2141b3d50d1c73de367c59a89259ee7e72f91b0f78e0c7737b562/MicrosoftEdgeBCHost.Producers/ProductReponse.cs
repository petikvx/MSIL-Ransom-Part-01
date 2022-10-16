using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceProc()
	{
	}
}
