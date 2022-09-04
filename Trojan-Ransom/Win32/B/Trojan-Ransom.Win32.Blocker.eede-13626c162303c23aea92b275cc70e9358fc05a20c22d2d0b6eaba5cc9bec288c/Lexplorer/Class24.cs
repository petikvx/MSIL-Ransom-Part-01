using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CoreAudioKludge;

namespace Lexplorer;

internal static class Class24
{
	private const int APPCOMMAND_VOLUME_MUTE = 524288;

	private const int WM_APPCOMMAND = 793;

	private static Form dummy = new Form();

	private static CoreAudioVolume coreAudio = null;

	private static uint _volume = 256u;

	public static bool Mute
	{
		get
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				if (coreAudio == null)
				{
					coreAudio = new CoreAudioVolume();
				}
				return coreAudio.Mute;
			}
			waveOutGetVolume(IntPtr.Zero, out var dwVolume);
			return dwVolume == 0;
		}
		set
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				if (coreAudio == null)
				{
					coreAudio = new CoreAudioVolume();
				}
				coreAudio.Mute = value;
			}
			else if (value)
			{
				waveOutGetVolume(IntPtr.Zero, out var dwVolume);
				if (dwVolume != 0)
				{
					_volume = dwVolume;
				}
				waveOutSetVolume(IntPtr.Zero, 0u);
			}
			else if (_volume != 0)
			{
				waveOutSetVolume(IntPtr.Zero, _volume);
			}
		}
	}

	[DllImport("winmm.dll")]
	public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

	[DllImport("winmm.dll")]
	public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

	public static bool Toggle()
	{
		Class25.SendMessage((int)((Control)dummy).get_Handle(), 793, (int)((Control)dummy).get_Handle(), 524288);
		return false;
	}
}
