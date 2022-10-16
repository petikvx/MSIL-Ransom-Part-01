using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountProperty()
	{
	}
}
