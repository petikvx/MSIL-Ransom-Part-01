using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MerchantAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceTask()
	{
	}
}
