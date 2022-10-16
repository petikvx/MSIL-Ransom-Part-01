using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetRepository()
	{
	}
}
