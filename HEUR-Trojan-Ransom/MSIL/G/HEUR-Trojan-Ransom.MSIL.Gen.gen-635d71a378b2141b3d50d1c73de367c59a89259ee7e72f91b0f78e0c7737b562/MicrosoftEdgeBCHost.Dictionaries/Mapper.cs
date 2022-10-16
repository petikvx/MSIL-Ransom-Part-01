using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Mapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Mapper()
	{
		WriterPropertyProducer.ResolveStub();
		EnableProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableProccesor()
	{
	}
}
