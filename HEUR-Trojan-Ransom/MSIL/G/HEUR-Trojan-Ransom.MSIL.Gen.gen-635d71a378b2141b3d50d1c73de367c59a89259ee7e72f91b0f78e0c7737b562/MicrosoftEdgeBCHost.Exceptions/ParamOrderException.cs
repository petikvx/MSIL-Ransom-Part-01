using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceInstance()
	{
	}
}
