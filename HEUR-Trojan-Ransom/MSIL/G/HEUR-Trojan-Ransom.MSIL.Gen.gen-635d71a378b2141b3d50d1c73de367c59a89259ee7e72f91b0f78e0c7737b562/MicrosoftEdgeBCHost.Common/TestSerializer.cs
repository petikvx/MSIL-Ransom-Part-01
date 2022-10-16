using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralProccesor()
	{
	}
}
