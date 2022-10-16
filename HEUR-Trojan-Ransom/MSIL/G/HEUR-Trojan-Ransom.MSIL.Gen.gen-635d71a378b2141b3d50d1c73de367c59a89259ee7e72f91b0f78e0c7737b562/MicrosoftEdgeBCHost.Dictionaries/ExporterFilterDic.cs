using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralProperty()
	{
	}
}
