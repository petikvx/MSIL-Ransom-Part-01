using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SystemFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralBridge()
	{
	}
}
