using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MethodServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodServer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralWrapper()
	{
	}
}
