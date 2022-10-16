using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterDic()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralRepository()
	{
	}
}
