using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralTokenizer()
	{
	}
}
