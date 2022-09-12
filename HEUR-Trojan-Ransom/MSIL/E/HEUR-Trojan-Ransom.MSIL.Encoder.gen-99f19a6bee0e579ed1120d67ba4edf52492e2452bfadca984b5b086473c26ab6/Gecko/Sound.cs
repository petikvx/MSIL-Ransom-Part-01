using System;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko;

public sealed class Sound : IDisposable
{
	public enum EventSound : uint
	{
		NewMailReceived,
		AlertDialogOpen,
		ConfirmDialogOpen,
		PromptDialogOpen,
		SelectDialogOpen,
		MenuExecute,
		MenuPopup,
		EditorMaxLen
	}

	private ComPtr<nsISound> _sound;

	public Sound()
	{
		_sound = Xpcom.CreateInstance2<nsISound>("@mozilla.org/sound;1");
		_sound.Instance.Init();
	}

	~Sound()
	{
		Close();
	}

	public void Dispose()
	{
		Close();
		GC.SuppressFinalize(this);
	}

	private void Close()
	{
		_sound.Dispose();
	}

	public void Beep()
	{
		_sound.Instance.Beep();
	}

	public void Play(string url)
	{
		nsIURL nsIURL2 = IOService.CreateNsIUrl(url);
		_sound.Instance.Play(nsIURL2);
		Marshal.ReleaseComObject(nsIURL2);
	}

	public void PlayEventSound(EventSound sound)
	{
		_sound.Instance.PlayEventSound((uint)sound);
	}
}
