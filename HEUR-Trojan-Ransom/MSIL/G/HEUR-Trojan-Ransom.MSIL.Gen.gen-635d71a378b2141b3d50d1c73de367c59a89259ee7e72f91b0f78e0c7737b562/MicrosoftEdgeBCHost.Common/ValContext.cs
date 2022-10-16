using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValContext()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceClient()
	{
	}
}
