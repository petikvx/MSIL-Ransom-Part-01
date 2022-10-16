using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeComposer()
	{
	}
}
