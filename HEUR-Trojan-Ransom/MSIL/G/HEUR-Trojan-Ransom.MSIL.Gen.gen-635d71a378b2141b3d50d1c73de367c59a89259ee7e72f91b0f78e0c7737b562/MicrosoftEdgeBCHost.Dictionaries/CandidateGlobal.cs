using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceMock()
	{
	}
}
