using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralStub()
	{
	}
}
