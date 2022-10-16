using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BaseClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseClass()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfacePolicy()
	{
	}
}
