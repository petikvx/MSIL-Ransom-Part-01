using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MerchantState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantState()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceMessage()
	{
	}
}
