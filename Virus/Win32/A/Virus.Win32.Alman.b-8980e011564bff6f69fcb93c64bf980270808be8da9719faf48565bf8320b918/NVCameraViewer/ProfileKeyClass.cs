using System;
using System.Diagnostics;

namespace NVCameraViewer;

[Serializable]
public class ProfileKeyClass
{
	public int KeyCode;

	public bool CtrlKey;

	public bool AltKey;

	public bool ShiftKey;

	[DebuggerNonUserCode]
	public ProfileKeyClass()
	{
	}
}
