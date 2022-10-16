using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralIndexer()
	{
	}
}
