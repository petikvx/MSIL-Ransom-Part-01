using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceMethod()
	{
	}
}
