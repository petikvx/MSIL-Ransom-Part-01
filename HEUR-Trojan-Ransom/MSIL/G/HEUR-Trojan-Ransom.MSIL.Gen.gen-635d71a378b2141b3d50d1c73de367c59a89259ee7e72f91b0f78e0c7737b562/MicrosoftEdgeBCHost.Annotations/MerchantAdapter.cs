using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MerchantAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceServer()
	{
	}
}
