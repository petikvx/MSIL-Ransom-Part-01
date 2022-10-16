using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceInterpreter()
	{
	}
}
