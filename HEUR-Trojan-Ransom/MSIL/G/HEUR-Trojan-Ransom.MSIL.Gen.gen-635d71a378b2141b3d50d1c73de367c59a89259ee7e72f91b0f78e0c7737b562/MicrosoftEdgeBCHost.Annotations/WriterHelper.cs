using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralList()
	{
	}
}
