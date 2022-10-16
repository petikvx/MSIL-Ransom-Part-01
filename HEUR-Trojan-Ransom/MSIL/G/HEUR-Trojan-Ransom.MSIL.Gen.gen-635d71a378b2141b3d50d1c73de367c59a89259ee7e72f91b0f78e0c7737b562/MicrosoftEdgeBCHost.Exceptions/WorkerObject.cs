using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerObject()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralModel()
	{
	}
}
