using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateDic()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralField()
	{
	}
}
