using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceMerchant()
	{
	}
}
