using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordContext()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceVisitor()
	{
	}
}
