using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceCandidate()
	{
	}
}
