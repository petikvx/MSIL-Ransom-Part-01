using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class OrderAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceExpression()
	{
	}
}
