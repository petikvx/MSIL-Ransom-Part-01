using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdapterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareReponse()
	{
	}
}
