using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PolicyAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceFacade()
	{
	}
}
