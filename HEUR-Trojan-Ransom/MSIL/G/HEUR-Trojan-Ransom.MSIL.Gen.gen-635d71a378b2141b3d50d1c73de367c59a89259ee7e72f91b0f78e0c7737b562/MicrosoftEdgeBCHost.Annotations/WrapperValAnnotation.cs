using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceExpression()
	{
	}
}
