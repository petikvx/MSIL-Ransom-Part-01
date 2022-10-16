using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderHelper()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralHelper()
	{
	}
}
