using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceTokenizer()
	{
	}
}
