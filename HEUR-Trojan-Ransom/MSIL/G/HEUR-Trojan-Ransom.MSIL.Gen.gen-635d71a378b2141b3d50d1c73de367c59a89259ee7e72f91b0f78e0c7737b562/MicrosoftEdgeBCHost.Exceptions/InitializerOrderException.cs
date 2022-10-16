using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceService()
	{
	}
}
