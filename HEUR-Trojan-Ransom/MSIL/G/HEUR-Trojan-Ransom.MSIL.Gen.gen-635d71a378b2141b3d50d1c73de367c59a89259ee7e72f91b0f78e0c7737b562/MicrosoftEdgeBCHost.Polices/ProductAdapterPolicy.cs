using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralPage()
	{
	}
}
