using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TemplateRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LoginItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginItem()
	{
	}
}
