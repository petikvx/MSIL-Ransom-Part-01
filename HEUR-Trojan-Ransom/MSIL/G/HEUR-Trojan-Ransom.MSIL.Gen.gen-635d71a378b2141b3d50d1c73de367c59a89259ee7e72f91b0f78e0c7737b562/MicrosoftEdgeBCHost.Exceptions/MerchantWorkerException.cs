using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MerchantWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatSchema()
	{
	}
}
