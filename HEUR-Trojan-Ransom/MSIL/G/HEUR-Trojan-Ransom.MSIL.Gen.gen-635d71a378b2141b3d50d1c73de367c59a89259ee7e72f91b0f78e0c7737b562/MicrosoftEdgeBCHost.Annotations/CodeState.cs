using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeState()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceTag()
	{
	}
}
