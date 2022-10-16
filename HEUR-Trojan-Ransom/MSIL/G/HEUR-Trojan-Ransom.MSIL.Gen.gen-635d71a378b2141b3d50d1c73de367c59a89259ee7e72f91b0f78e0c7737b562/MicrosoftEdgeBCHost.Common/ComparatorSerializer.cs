using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralProccesor()
	{
	}
}
