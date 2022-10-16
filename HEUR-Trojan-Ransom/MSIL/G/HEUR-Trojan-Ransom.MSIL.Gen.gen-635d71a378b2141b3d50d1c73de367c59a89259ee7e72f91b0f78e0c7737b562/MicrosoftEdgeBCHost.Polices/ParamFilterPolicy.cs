using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestSetter()
	{
	}
}
