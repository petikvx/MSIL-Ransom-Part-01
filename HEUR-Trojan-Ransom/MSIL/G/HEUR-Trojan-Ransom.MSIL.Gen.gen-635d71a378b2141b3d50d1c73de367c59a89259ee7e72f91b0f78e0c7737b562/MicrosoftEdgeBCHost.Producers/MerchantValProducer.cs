using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MerchantValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AddRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddRecord()
	{
	}
}
