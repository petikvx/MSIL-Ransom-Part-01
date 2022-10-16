using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralVal()
	{
	}
}
