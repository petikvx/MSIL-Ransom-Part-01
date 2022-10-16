using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ImporterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		TestAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestAdvisor()
	{
	}
}
