using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceMapping()
	{
	}
}
