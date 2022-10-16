using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GetterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralProcess()
	{
	}
}
