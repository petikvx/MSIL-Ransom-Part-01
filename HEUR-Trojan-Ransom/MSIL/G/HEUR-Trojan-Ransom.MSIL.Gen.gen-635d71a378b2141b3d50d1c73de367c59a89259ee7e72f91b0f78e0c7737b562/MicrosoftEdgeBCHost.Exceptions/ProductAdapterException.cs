using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProductAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceProducer()
	{
	}
}
