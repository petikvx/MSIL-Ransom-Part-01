using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ClonePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ClonePrototype()
	{
	}
}
