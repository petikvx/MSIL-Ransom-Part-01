using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallTag()
	{
	}
}
