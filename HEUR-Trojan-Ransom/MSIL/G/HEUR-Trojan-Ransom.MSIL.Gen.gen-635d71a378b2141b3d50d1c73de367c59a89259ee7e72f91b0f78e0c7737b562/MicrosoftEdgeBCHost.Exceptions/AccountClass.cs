using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountClass()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceClass()
	{
	}
}
