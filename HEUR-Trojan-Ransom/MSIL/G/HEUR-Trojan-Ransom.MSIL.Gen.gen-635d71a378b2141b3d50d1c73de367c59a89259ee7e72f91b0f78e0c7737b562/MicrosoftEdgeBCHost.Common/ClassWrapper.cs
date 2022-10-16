using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClassWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CallAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallAlgo()
	{
	}
}
