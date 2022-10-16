using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateRules()
	{
		WriterPropertyProducer.ResolveStub();
		CancelConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelConfiguration()
	{
	}
}
