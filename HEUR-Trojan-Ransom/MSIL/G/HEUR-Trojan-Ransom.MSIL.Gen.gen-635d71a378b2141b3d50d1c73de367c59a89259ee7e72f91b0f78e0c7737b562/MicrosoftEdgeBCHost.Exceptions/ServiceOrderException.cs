using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServiceOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceStatus()
	{
	}
}
