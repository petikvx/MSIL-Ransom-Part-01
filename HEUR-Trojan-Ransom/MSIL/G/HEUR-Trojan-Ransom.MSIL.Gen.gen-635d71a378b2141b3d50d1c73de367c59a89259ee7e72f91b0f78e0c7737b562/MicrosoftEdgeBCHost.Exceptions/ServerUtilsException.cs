using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralInterceptor()
	{
	}
}
