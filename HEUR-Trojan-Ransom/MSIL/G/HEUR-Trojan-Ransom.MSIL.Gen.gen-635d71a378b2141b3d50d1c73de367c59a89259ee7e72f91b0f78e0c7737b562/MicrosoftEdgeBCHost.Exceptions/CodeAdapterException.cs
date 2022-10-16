using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceHelper()
	{
	}
}
