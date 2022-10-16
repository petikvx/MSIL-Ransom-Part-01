using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralPage()
	{
	}
}
