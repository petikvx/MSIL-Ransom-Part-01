using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		DefineAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineAlgo()
	{
	}
}
