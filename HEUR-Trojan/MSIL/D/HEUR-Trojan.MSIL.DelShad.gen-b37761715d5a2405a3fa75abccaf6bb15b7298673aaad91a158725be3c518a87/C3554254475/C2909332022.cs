#define DEBUG
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C3554254475;

public static class C2909332022
{
	internal delegate DialogResult C3554254475(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0);

	private static volatile uint m_C3554254475;

	private const MessageBoxIcon m_C3554254475 = 64;

	private const MessageBoxIcon m_C3904355907 = 48;

	private const MessageBoxIcon m_C1255198513 = 16;

	private const MessageBoxOptions m_C3554254475 = 1572864;

	private const MessageBoxIcon C1908338681 = 32;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static EventHandler<C140662621> m_C3554254475;

	[SpecialName]
	public static string C3554254475()
	{
		return Environment.NewLine;
	}

	[SpecialName]
	public static string C3904355907()
	{
		return Environment.NewLine + Environment.NewLine;
	}

	[SpecialName]
	[CompilerGenerated]
	public static void C3554254475(EventHandler<C140662621> eventHandler_0)
	{
		EventHandler<C140662621> eventHandler = C2909332022.m_C3554254475;
		EventHandler<C140662621> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<C140662621> value = (EventHandler<C140662621>)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref C2909332022.m_C3554254475, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void C3904355907(EventHandler<C140662621> eventHandler_0)
	{
		EventHandler<C140662621> eventHandler = C2909332022.m_C3554254475;
		EventHandler<C140662621> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<C140662621> value = (EventHandler<C140662621>)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref C2909332022.m_C3554254475, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private static string C3554254475(object[] object_0)
	{
		return C3554254475(object_0, bool_0: false);
	}

	private static string C3554254475(object[] object_0, bool bool_0)
	{
		if (object_0 == null)
		{
			return string.Empty;
		}
		string value = C3904355907();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		foreach (object obj in object_0)
		{
			if (obj == null)
			{
				continue;
			}
			string value2 = null;
			Exception ex = obj as Exception;
			string text = obj as string;
			StringCollection stringCollection = obj as StringCollection;
			if (ex != null)
			{
				if (bool_0)
				{
					value2 = C1130791706.C3554254475(ex);
				}
				else if (!string.IsNullOrEmpty(ex.Message))
				{
					value2 = ex.Message;
				}
			}
			else if (stringCollection == null)
			{
				value2 = ((text == null) ? obj.ToString() : text);
			}
			else
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				StringEnumerator enumerator = stringCollection.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						if (stringBuilder2.Length > 0)
						{
							stringBuilder2.AppendLine();
						}
						stringBuilder2.Append(current.TrimEnd(Array.Empty<char>()));
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
				value2 = stringBuilder2.ToString();
			}
			if (!string.IsNullOrEmpty(value2))
			{
				if (flag)
				{
					stringBuilder.Append(value);
				}
				else
				{
					flag = true;
				}
				stringBuilder.Append(value2);
			}
		}
		return stringBuilder.ToString();
	}

	internal static Form C1255198513()
	{
		FormCollection openForms = Application.get_OpenForms();
		if (openForms == null || ((ReadOnlyCollectionBase)(object)openForms).Count == 0)
		{
			return null;
		}
		return openForms.get_Item(((ReadOnlyCollectionBase)(object)openForms).Count - 1);
	}

	internal static DialogResult C3554254475(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		IWin32Window val = null;
		try
		{
			Form val2 = C1255198513();
			if (val2 != null && ((Control)val2).get_InvokeRequired())
			{
				return (DialogResult)((Control)val2).Invoke((Delegate)new C3554254475(C3554254475), new object[6] { val2, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0 });
			}
			val = (IWin32Window)(object)val2;
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		if (val == null)
		{
			if (C1130791706.C3904355907())
			{
				return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, (MessageBoxOptions)1572864);
			}
			return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
		}
		try
		{
			if (C1130791706.C3904355907())
			{
				return MessageBox.Show(val, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, (MessageBoxOptions)1572864);
			}
			return MessageBox.Show(val, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		if (C1130791706.C3904355907())
		{
			return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, (MessageBoxOptions)1572864);
		}
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
	}

	internal static DialogResult C3554254475(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (C1130791706.C3904355907())
		{
			return MessageBox.Show(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, (MessageBoxOptions)1572864);
		}
		return MessageBox.Show(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
	}

	public static void C3554254475(string string_0, params object[] vLines)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		C2909332022.m_C3554254475++;
		string_0 = string_0 ?? global::C3554254475.C3904355907.C3904355907;
		string text = C3554254475(vLines);
		if (C2909332022.m_C3554254475 != null)
		{
			C2909332022.m_C3554254475(null, new C140662621(string_0, text, (MessageBoxButtons)0, (MessageBoxIcon)64));
		}
		C3554254475(text, string_0, (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		C2909332022.m_C3554254475--;
	}

	public static void C3904355907(params object[] vLines)
	{
		C3904355907(vLines, bool_0: false);
	}

	private static void C3904355907(object[] object_0, bool bool_0)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		C2909332022.m_C3554254475++;
		string c3904355907 = global::C3554254475.C3904355907.C3904355907;
		string text = C3554254475(object_0, bool_0);
		if (C2909332022.m_C3554254475 != null)
		{
			C2909332022.m_C3554254475(null, new C140662621(c3904355907, text, (MessageBoxButtons)0, (MessageBoxIcon)48));
		}
		C3554254475(text, c3904355907, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		C2909332022.m_C3554254475--;
	}

	internal static string C3554254475(string string_0, Exception exception_0, bool bool_0)
	{
		string text = string.Empty;
		if (!string.IsNullOrEmpty(string_0))
		{
			text = text + string_0 + C3904355907();
		}
		text += C4110462503.C1993550816();
		if (exception_0 != null && !string.IsNullOrEmpty(exception_0.Message))
		{
			text += C3904355907();
			text = (bool_0 ? (text + C3554254475(new object[1] { exception_0 }, bool_0: true)) : (text + exception_0.Message));
		}
		return text;
	}
}
