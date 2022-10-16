using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponseFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceCandidate()
	{
	}
}
