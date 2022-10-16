using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceAdvisor()
	{
	}
}
