using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class QueueDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueDic()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralTask()
	{
	}
}
