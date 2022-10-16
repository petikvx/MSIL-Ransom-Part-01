using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceRequest()
	{
	}
}
