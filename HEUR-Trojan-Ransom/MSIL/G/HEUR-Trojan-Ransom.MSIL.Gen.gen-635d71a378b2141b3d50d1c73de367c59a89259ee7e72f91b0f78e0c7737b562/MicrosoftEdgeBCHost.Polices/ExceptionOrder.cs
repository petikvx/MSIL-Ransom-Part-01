using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CompareReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareReponse()
	{
	}
}
