using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareImporter()
	{
	}
}
