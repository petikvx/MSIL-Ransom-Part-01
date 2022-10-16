using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObjectRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveRule()
	{
	}
}
