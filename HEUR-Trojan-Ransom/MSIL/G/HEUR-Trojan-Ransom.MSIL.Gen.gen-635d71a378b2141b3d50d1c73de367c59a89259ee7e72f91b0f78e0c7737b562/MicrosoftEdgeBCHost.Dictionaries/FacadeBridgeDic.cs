using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareReader()
	{
	}
}
