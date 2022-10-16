using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralDatabase()
	{
	}
}
