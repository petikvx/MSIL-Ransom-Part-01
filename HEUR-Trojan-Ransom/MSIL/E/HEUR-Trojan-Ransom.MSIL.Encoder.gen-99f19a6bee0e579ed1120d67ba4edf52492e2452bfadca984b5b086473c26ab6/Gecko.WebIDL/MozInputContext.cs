namespace Gecko.WebIDL;

public class MozInputContext : WebIDLBase
{
	public MozInputMethodInputContextTypes Type => GetProperty<MozInputMethodInputContextTypes>("type");

	public MozInputMethodInputContextInputTypes InputType => GetProperty<MozInputMethodInputContextInputTypes>("inputType");

	public string InputMode => GetProperty<string>("inputMode");

	public string Lang => GetProperty<string>("lang");

	public int SelectionStart => GetProperty<int>("selectionStart");

	public int SelectionEnd => GetProperty<int>("selectionEnd");

	public string TextBeforeCursor => GetProperty<string>("textBeforeCursor");

	public string TextAfterCursor => GetProperty<string>("textAfterCursor");

	public MozInputContext(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<string> GetText()
	{
		return CallMethod<Promise<string>>("getText", new object[0]);
	}

	public Promise<string> GetText(int offset)
	{
		return CallMethod<Promise<string>>("getText", new object[1] { offset });
	}

	public Promise<string> GetText(int offset, int length)
	{
		return CallMethod<Promise<string>>("getText", new object[2] { offset, length });
	}

	public Promise<bool> SetSelectionRange(int start, int length)
	{
		return CallMethod<Promise<bool>>("setSelectionRange", new object[2] { start, length });
	}

	public Promise<bool> ReplaceSurroundingText(string text)
	{
		return CallMethod<Promise<bool>>("replaceSurroundingText", new object[1] { text });
	}

	public Promise<bool> ReplaceSurroundingText(string text, int offset)
	{
		return CallMethod<Promise<bool>>("replaceSurroundingText", new object[2] { text, offset });
	}

	public Promise<bool> ReplaceSurroundingText(string text, int offset, int length)
	{
		return CallMethod<Promise<bool>>("replaceSurroundingText", new object[3] { text, offset, length });
	}

	public Promise<bool> DeleteSurroundingText(int offset, int length)
	{
		return CallMethod<Promise<bool>>("deleteSurroundingText", new object[2] { offset, length });
	}

	public Promise<bool> SendKey(WebIDLUnion<object, int> dictOrKeyCode)
	{
		return CallMethod<Promise<bool>>("sendKey", new object[1] { dictOrKeyCode });
	}

	public Promise<bool> SendKey(WebIDLUnion<object, int> dictOrKeyCode, int charCode)
	{
		return CallMethod<Promise<bool>>("sendKey", new object[2] { dictOrKeyCode, charCode });
	}

	public Promise<bool> SendKey(WebIDLUnion<object, int> dictOrKeyCode, int charCode, int modifiers)
	{
		return CallMethod<Promise<bool>>("sendKey", new object[3] { dictOrKeyCode, charCode, modifiers });
	}

	public Promise<bool> SendKey(WebIDLUnion<object, int> dictOrKeyCode, int charCode, int modifiers, bool repeat)
	{
		return CallMethod<Promise<bool>>("sendKey", new object[4] { dictOrKeyCode, charCode, modifiers, repeat });
	}

	public Promise<bool> Keydown(object dict)
	{
		return CallMethod<Promise<bool>>("keydown", new object[1] { dict });
	}

	public Promise<bool> Keyup(object dict)
	{
		return CallMethod<Promise<bool>>("keyup", new object[1] { dict });
	}

	public Promise<bool> SetComposition(string text)
	{
		return CallMethod<Promise<bool>>("setComposition", new object[1] { text });
	}

	public Promise<bool> SetComposition(string text, int cursor)
	{
		return CallMethod<Promise<bool>>("setComposition", new object[2] { text, cursor });
	}

	public Promise<bool> SetComposition(string text, int cursor, object[] clauses)
	{
		return CallMethod<Promise<bool>>("setComposition", new object[3] { text, cursor, clauses });
	}

	public Promise<bool> SetComposition(string text, int cursor, object[] clauses, object dict)
	{
		return CallMethod<Promise<bool>>("setComposition", new object[4] { text, cursor, clauses, dict });
	}

	public Promise<bool> EndComposition()
	{
		return CallMethod<Promise<bool>>("endComposition", new object[0]);
	}

	public Promise<bool> EndComposition(string text)
	{
		return CallMethod<Promise<bool>>("endComposition", new object[1] { text });
	}

	public Promise<bool> EndComposition(string text, object dict)
	{
		return CallMethod<Promise<bool>>("endComposition", new object[2] { text, dict });
	}
}
