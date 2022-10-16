using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SpecificationServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationServer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralVisitor()
	{
	}
}
