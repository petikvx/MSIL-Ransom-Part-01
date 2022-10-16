using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MerchantUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantUtils()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceAttr()
	{
	}
}
