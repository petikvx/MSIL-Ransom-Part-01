using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContextRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareReg()
	{
	}
}
