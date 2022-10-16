using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SetupImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupImporter()
	{
	}
}
