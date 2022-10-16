using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenizerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceImporter()
	{
	}
}
