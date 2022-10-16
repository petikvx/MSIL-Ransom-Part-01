using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CloneComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneComparator()
	{
	}
}
