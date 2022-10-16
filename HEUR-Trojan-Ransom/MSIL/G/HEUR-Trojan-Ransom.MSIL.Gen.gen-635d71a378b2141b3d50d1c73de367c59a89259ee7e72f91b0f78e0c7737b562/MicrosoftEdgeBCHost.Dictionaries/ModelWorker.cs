using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CloneHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneHelper()
	{
	}
}
