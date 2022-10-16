using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralGlobal()
	{
	}
}
