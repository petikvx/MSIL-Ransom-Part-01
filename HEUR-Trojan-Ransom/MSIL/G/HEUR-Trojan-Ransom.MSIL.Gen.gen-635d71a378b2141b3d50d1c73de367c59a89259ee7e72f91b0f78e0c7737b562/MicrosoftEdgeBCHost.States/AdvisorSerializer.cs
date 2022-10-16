using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralAttribute()
	{
	}
}
