using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralInitializer()
	{
	}
}
