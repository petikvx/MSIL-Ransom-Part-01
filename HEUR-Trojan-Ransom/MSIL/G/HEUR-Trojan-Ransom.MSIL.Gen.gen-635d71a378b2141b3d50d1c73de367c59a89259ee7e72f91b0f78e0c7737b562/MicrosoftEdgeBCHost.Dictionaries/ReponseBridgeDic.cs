using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReponseBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInfo()
	{
	}
}
