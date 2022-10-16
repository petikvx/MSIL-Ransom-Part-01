using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrder()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyFilter()
	{
	}
}
