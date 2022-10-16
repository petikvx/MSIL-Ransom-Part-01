using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdvisorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RateList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateList()
	{
	}
}
