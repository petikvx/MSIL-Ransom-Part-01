using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExporterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralClass()
	{
	}
}
