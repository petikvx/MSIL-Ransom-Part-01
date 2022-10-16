using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceIterator()
	{
	}
}
