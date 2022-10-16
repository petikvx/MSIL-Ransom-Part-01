using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceRole()
	{
	}
}
