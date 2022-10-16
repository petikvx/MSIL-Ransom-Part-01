using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralException()
	{
	}
}
