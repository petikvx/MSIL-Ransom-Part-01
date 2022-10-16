using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MerchantAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralException()
	{
	}
}
