using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InitExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitExpression()
	{
	}
}
