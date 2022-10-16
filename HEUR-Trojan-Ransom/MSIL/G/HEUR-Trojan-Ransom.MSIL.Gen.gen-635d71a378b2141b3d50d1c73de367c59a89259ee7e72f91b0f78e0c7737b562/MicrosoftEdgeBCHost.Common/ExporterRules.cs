using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExporterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterRules()
	{
		WriterPropertyProducer.ResolveStub();
		PublishParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishParameter()
	{
	}
}
