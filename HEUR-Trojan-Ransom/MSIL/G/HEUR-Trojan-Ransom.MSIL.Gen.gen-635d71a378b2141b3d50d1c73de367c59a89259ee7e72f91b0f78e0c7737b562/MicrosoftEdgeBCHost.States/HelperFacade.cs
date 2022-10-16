using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralClass()
	{
	}
}
