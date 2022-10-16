using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralRecord()
	{
	}
}
