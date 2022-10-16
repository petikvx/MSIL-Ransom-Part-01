using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObjectWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralPredicate()
	{
	}
}
