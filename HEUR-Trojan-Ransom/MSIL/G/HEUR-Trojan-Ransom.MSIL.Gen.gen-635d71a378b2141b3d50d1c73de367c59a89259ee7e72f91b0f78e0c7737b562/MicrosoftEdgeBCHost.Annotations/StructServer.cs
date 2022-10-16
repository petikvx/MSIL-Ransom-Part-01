using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StructServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructServer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralVisitor()
	{
	}
}
