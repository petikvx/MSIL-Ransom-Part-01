using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AnnotationOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceMapping()
	{
	}
}
