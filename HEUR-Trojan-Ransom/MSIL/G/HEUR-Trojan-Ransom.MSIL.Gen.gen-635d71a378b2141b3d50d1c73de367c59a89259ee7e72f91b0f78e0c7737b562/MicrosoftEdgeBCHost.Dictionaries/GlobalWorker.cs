using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GlobalWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorker()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateProcess()
	{
	}
}
