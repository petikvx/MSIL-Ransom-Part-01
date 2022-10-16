using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Printer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Printer()
	{
		WriterPropertyProducer.ResolveStub();
		StopMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopMapping()
	{
	}
}
