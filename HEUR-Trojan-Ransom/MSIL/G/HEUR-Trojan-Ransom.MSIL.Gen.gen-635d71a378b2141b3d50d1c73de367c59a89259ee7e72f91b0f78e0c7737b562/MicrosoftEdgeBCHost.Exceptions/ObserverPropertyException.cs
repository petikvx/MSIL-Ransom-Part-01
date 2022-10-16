using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObserverPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralClient()
	{
	}
}
