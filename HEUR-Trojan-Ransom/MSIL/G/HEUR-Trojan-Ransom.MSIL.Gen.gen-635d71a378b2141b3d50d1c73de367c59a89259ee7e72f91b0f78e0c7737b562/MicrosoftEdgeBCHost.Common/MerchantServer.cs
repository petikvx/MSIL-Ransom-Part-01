using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantServer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralClient()
	{
	}
}
