using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralRecord()
	{
	}
}
