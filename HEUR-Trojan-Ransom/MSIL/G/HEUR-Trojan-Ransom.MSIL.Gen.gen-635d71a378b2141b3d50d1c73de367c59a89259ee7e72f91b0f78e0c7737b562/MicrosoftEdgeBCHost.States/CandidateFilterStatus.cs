using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CandidateFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceStruct()
	{
	}
}
