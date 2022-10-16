using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AnnotationAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceToken()
	{
	}
}
