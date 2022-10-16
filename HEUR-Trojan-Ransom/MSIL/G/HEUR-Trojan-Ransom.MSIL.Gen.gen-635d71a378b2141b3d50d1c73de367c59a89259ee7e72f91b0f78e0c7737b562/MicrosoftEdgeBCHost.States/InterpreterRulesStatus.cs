using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceContext()
	{
	}
}
