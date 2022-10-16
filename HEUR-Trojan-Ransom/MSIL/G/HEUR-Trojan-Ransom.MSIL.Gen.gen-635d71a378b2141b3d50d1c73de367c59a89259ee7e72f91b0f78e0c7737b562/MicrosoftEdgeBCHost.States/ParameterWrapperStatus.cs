using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParameterWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableCustomer()
	{
	}
}
