using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class OrderUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralReponse()
	{
	}
}
