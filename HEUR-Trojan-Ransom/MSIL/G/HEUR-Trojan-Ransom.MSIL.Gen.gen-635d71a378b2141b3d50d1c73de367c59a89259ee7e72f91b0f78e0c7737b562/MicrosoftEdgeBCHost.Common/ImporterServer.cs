using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ImporterServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterServer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralVisitor()
	{
	}
}
