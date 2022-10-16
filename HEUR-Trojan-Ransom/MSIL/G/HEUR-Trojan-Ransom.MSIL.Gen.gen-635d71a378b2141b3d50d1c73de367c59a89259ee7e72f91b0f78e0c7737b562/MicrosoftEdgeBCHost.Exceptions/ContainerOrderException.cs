using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceException()
	{
	}
}
