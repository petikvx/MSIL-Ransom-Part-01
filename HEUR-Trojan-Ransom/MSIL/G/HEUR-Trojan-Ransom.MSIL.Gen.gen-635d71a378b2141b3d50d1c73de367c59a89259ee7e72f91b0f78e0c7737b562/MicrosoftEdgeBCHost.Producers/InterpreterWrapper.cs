using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveMap()
	{
	}
}
