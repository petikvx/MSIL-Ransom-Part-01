using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueVal()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterpreter()
	{
	}
}
