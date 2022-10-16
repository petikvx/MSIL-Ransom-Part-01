using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralManager()
	{
	}
}
