using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StructAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceReg()
	{
	}
}
