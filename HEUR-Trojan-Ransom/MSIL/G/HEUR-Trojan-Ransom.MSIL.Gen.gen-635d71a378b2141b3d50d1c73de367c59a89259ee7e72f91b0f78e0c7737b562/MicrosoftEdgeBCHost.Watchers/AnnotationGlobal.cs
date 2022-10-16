using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceTemplate()
	{
	}
}
