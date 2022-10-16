using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceObserver()
	{
	}
}
