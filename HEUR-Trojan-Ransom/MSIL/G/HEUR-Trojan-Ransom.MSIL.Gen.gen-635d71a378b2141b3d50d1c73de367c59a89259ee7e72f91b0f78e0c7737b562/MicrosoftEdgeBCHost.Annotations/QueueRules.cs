using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueRules()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeDispatcher()
	{
	}
}
