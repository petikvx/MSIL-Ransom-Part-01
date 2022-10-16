using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralList()
	{
	}
}
