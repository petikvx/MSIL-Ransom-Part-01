using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CallbackWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FindAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindAdvisor()
	{
	}
}
