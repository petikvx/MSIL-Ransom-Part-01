using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TagValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceIssuer()
	{
	}
}
