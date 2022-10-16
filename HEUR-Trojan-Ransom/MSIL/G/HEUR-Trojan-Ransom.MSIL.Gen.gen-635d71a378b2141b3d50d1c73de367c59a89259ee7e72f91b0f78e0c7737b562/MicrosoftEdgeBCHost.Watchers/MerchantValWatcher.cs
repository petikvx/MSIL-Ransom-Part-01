using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceParser()
	{
	}
}
