using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BaseOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceRole()
	{
	}
}
