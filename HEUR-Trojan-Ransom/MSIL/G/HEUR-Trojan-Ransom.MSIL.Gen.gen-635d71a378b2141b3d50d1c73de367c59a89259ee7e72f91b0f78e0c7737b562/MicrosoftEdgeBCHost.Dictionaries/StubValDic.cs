using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralInitializer()
	{
	}
}
