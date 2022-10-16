using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SystemBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateBase()
	{
	}
}
