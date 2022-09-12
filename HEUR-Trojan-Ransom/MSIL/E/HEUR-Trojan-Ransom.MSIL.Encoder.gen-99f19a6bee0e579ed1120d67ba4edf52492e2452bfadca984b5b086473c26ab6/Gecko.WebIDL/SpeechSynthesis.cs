namespace Gecko.WebIDL;

public class SpeechSynthesis : WebIDLBase
{
	public bool Pending => GetProperty<bool>("pending");

	public bool Speaking => GetProperty<bool>("speaking");

	public bool Paused => GetProperty<bool>("paused");

	public SpeechSynthesis(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Speak(nsISupports utterance)
	{
		CallVoidMethod("speak", utterance);
	}

	public void Cancel()
	{
		CallVoidMethod("cancel");
	}

	public void Pause()
	{
		CallVoidMethod("pause");
	}

	public void Resume()
	{
		CallVoidMethod("resume");
	}

	public nsISupports[] GetVoices()
	{
		return CallMethod<nsISupports[]>("getVoices", new object[0]);
	}

	public void ForceEnd()
	{
		CallVoidMethod("forceEnd");
	}
}
