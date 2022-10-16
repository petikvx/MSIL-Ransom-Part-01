using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateRepository()
	{
	}
}
