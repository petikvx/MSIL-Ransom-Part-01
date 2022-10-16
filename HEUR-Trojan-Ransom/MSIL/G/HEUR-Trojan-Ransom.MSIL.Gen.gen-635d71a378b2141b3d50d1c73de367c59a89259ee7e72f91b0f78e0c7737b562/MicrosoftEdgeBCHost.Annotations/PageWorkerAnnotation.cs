using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PageWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralSingleton()
	{
	}
}
