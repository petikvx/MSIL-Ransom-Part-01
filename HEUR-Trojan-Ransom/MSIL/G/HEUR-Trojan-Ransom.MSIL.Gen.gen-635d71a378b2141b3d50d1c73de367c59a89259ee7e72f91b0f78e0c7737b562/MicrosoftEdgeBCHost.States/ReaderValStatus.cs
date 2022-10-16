using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralDic()
	{
	}
}
