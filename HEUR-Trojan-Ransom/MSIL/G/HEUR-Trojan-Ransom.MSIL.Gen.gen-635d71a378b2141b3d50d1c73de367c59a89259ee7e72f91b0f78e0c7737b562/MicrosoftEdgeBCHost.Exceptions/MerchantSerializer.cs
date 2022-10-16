using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MerchantSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralProccesor()
	{
	}
}
