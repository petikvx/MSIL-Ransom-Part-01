using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralField()
	{
	}
}
