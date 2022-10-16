using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConsumerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceService()
	{
	}
}
