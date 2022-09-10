using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[CompilerGenerated]
[TypeIdentifier("6bf52a50-394a-11d3-b153-00c04f79faa6", "WMPLib.WMPPlayState")]
public enum WMPPlayState
{
	wmppsUndefined,
	wmppsStopped,
	wmppsPaused,
	wmppsPlaying,
	wmppsScanForward,
	wmppsScanReverse,
	wmppsBuffering,
	wmppsWaiting,
	wmppsMediaEnded,
	wmppsTransitioning,
	wmppsReady,
	wmppsReconnecting,
	wmppsLast
}
