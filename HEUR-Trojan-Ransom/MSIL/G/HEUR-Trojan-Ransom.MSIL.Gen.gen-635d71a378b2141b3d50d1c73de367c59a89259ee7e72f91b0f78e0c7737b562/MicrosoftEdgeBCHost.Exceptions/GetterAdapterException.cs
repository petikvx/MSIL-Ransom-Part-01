using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GetterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralBroadcaster()
	{
	}
}
