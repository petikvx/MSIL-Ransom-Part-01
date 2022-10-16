using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class EventValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralStatus()
	{
	}
}
