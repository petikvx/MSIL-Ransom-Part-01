using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterpreterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindFacade()
	{
	}
}
