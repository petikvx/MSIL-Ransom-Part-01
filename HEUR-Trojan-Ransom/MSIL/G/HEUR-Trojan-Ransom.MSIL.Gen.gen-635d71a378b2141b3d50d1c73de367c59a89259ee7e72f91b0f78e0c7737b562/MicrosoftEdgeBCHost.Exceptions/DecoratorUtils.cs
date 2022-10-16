using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceVal()
	{
	}
}
