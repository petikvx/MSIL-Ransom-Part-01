using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProducerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyMock()
	{
	}
}
