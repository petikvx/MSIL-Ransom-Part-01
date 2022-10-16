using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralMapping()
	{
	}
}
