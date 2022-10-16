using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcessHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralPool()
	{
	}
}
