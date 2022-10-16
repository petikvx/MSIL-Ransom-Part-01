using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralRule()
	{
	}
}
