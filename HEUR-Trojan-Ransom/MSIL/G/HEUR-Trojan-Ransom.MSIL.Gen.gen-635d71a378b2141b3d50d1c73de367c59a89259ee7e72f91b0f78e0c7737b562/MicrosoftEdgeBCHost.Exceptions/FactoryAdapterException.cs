using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FactoryAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceTask()
	{
	}
}
