using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralServer()
	{
	}
}
