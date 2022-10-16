using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectCustomer()
	{
	}
}
