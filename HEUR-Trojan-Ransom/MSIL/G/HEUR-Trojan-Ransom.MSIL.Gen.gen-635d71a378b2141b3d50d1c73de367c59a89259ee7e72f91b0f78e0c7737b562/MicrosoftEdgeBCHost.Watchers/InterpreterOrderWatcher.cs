using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterpreterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralDatabase()
	{
	}
}
