using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceSetter()
	{
	}
}
