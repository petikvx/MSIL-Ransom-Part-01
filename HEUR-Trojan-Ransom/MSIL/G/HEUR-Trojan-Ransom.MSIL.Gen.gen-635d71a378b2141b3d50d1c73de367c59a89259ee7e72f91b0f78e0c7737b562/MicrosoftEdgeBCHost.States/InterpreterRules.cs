using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterRules()
	{
		WriterPropertyProducer.ResolveStub();
		DefineParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineParams()
	{
	}
}
