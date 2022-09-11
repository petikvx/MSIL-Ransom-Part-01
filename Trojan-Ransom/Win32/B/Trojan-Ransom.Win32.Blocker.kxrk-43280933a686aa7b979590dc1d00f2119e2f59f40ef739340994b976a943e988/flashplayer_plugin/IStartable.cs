using System.Runtime.CompilerServices;

namespace flashplayer_plugin;

public interface IStartable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	int Begin(string path);
}
