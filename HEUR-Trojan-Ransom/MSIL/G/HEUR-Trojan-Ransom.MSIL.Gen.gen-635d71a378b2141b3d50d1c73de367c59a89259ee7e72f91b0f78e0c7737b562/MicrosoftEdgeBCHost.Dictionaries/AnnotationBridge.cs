using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RunPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunPrototype()
	{
	}
}
