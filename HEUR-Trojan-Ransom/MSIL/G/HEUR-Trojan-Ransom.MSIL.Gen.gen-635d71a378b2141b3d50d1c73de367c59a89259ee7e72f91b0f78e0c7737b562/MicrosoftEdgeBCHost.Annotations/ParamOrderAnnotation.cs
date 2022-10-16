using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralItem()
	{
	}
}
