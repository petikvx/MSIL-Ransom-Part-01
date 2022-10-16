using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrinterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterVal()
	{
		WriterPropertyProducer.ResolveStub();
		MoveToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveToken()
	{
	}
}
