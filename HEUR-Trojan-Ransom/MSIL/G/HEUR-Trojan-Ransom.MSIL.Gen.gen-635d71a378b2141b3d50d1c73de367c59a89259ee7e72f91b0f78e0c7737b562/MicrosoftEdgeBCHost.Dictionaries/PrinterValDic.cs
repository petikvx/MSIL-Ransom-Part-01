using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralThread()
	{
	}
}
