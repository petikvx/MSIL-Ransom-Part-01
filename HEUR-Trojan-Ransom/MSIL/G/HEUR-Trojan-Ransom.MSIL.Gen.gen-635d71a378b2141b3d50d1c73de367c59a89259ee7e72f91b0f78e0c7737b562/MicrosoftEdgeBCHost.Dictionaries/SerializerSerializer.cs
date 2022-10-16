using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralCode()
	{
	}
}
