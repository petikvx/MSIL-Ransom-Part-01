using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValueRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceProccesor()
	{
	}
}
