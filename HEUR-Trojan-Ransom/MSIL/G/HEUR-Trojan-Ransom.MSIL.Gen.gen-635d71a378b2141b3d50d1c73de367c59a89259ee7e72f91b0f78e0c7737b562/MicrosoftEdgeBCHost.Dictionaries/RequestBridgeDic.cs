using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CloneReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneReg()
	{
	}
}
