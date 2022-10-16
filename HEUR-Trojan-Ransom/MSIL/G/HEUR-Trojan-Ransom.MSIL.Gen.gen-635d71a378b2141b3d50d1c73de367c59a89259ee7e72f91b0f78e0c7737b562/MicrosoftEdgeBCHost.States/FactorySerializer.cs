using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactorySerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactorySerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralProccesor()
	{
	}
}
