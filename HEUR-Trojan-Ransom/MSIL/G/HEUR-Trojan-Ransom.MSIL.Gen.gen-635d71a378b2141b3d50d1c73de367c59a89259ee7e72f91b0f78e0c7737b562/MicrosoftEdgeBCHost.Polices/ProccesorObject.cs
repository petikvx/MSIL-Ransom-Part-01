using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorObject()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralComparator()
	{
	}
}
