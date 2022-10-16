using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceIssuer()
	{
	}
}
