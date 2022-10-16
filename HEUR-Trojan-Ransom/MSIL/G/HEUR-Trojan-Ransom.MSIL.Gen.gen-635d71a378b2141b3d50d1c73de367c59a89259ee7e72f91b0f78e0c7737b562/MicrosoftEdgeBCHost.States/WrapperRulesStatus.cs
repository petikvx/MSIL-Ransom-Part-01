using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WrapperRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareSerializer()
	{
	}
}
