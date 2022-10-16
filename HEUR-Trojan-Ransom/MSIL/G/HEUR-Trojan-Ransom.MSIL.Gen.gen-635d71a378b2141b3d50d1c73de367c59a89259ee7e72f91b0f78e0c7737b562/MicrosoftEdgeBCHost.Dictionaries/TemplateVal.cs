using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateVal()
	{
		WriterPropertyProducer.ResolveStub();
		MapInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInfo()
	{
	}
}
