using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateSystem()
	{
	}
}
