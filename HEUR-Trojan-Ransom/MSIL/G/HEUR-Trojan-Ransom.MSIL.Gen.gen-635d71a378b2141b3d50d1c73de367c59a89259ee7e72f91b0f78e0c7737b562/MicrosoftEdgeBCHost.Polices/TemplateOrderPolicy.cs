using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralRecord()
	{
	}
}
