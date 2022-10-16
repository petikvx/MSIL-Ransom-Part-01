using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassVal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectVisitor()
	{
	}
}
