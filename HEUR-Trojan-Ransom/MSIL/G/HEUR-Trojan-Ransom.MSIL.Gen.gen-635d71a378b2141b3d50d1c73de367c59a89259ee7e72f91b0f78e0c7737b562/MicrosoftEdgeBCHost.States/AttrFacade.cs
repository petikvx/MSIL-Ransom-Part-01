using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralRegistry()
	{
	}
}
