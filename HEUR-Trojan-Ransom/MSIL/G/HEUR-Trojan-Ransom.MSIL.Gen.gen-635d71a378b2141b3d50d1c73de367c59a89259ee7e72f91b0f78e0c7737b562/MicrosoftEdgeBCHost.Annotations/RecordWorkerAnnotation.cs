using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralAttr()
	{
	}
}
