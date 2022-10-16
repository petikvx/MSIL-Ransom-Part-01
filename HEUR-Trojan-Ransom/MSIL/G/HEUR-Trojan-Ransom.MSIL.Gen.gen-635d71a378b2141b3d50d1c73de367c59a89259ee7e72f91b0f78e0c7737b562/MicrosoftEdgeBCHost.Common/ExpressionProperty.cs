using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionProperty()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceCustomer()
	{
	}
}
