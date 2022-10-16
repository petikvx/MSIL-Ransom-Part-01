using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceParameter()
	{
	}
}
