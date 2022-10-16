using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CandidateValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralSchema()
	{
	}
}
