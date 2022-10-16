using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TemplatePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplatePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralInvocation()
	{
	}
}
