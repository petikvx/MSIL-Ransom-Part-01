using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadServer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralVisitor()
	{
	}
}
