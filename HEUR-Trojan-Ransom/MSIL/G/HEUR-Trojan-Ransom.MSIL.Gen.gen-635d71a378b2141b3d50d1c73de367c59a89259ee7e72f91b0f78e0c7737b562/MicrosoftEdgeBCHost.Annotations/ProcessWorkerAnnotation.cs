using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralSingleton()
	{
	}
}
