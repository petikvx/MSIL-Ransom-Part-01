using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralAlgo()
	{
	}
}
