using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskServer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralPublisher()
	{
	}
}
