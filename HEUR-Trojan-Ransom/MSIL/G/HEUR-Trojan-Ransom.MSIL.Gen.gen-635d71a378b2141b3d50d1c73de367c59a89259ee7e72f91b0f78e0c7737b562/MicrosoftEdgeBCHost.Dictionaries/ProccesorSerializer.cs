using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralAttribute()
	{
	}
}
