using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrinterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralTokenizer()
	{
	}
}
