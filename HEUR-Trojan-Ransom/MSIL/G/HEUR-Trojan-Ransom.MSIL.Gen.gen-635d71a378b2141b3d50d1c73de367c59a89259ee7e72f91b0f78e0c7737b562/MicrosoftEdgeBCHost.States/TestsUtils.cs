using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsUtils()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceResolver()
	{
	}
}
