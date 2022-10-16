using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class Struct
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Struct()
	{
		WriterPropertyProducer.ResolveStub();
		CheckValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckValue()
	{
	}
}
