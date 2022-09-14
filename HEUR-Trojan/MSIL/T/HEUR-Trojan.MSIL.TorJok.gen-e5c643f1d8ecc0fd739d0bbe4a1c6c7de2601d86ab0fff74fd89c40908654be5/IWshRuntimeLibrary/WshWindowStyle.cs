using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[Guid("F935DC1F-1CF0-11D0-ADB9-00C04FD58A0B")]
public enum WshWindowStyle
{
	WshHide = 0,
	WshNormalFocus = 1,
	WshMinimizedFocus = 2,
	WshMaximizedFocus = 3,
	WshNormalNoFocus = 4,
	WshMinimizedNoFocus = 6
}
