using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralReader()
	{
	}
}
