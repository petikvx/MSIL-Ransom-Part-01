using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralTests()
	{
	}
}
