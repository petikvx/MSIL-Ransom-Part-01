using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductClass()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceTokenizer()
	{
	}
}
