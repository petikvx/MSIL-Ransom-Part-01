using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InvocationBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		NewProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewProc()
	{
	}
}
