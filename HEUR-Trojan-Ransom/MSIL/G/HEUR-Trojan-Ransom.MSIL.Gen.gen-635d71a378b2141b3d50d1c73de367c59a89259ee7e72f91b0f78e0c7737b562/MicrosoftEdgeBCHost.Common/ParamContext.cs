using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamContext()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceVisitor()
	{
	}
}
