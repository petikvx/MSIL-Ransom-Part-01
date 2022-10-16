using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CustomerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceTests()
	{
	}
}
