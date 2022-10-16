using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralEvent()
	{
	}
}
