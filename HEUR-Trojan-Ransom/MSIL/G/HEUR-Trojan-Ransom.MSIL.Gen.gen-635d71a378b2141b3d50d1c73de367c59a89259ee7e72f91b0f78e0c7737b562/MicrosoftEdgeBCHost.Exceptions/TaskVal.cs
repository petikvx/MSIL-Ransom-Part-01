using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskVal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectProducer()
	{
	}
}
