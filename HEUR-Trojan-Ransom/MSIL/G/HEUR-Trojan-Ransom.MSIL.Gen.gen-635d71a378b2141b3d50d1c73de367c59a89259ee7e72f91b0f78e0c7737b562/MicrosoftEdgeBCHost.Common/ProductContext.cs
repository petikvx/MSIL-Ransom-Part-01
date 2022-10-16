using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductContext()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceVisitor()
	{
	}
}
