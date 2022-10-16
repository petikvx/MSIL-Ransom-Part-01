using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralDefinition()
	{
	}
}
