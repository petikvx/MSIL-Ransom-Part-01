using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerDic()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralDatabase()
	{
	}
}
