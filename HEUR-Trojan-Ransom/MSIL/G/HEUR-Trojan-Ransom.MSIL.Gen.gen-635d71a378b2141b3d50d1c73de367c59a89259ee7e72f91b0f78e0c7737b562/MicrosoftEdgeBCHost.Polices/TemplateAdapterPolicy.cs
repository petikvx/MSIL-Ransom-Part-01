using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralSerializer()
	{
	}
}
