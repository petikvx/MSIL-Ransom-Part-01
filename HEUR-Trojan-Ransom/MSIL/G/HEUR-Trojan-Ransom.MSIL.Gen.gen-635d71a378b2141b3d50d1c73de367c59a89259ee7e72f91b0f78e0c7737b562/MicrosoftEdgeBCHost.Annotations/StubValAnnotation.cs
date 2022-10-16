using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceExpression()
	{
	}
}
