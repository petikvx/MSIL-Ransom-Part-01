using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralConfiguration()
	{
	}
}
