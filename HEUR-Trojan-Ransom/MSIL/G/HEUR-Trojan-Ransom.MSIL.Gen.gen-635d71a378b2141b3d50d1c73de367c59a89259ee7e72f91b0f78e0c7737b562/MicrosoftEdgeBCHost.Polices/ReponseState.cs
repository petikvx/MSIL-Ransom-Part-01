using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseState()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceRecord()
	{
	}
}
