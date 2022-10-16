using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantObject()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralParams()
	{
	}
}
