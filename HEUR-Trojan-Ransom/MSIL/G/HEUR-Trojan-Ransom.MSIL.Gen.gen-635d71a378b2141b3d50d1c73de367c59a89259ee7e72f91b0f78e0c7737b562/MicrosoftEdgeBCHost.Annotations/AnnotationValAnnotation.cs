using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceProcess()
	{
	}
}
