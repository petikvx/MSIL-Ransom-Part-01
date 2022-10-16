using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductHelper()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralCreator()
	{
	}
}
