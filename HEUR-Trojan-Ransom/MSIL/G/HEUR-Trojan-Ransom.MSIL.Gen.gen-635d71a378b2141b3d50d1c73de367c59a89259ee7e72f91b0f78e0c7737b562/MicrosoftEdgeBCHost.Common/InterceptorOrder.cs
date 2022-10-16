using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterceptorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CompareStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareStruct()
	{
	}
}
