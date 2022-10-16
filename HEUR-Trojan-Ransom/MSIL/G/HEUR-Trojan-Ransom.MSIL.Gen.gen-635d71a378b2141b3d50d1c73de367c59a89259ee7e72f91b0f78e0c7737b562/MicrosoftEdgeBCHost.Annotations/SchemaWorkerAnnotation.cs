using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SchemaWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralMock()
	{
	}
}
