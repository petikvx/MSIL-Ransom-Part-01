using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PrintAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintAccount()
	{
	}
}
