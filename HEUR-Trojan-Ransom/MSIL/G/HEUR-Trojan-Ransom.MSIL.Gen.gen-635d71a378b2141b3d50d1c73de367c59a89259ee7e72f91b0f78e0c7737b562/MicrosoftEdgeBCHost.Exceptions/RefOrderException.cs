using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RefOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceParam()
	{
	}
}
