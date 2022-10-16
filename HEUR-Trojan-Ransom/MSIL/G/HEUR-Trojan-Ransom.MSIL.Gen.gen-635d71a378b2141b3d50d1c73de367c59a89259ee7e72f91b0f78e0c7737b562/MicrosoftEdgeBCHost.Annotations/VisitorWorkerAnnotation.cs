using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class VisitorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralRecord()
	{
	}
}
