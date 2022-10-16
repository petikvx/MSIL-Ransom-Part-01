using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralStatus()
	{
	}
}
