using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RequestAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceAccount()
	{
	}
}
