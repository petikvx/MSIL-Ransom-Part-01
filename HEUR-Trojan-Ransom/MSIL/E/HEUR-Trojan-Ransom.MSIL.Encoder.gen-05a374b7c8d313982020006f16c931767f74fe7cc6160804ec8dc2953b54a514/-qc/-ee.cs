using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using _0023ab;

namespace _0023qc;

internal abstract class _0023ee
{
	public const string _0023a = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string _0023b = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool _0023c = Convert.ToBoolean(_0023ab._00239._00237(107393140));

	internal static readonly string _0023d = _0023ab._00239._00237(107394766);

	internal static _0023ee _0023e;

	internal IWebProxy _0023f;

	[CompilerGenerated]
	private EventHandler _0023g;

	[CompilerGenerated]
	private _0023Bd _0023h;

	internal static _0023ee Handler
	{
		get
		{
			if (_0023e == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if (!(type != null) || !(type.BaseType != null) || !(type.BaseType == typeof(_0023ee)))
					{
						continue;
					}
					try
					{
						_0023e = (_0023ee)Activator.CreateInstance(type, nonPublic: true);
						if (_0023e != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return _0023e;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = _0023g;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0023g, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = _0023g;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0023g, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event _0023Bd SendingReportFeedback
	{
		[CompilerGenerated]
		add
		{
			_0023Bd _0023Bd2 = _0023h;
			_0023Bd _0023Bd3;
			do
			{
				_0023Bd3 = _0023Bd2;
				_0023Bd value2 = (_0023Bd)Delegate.Combine(_0023Bd3, value);
				_0023Bd2 = Interlocked.CompareExchange(ref _0023h, value2, _0023Bd3);
			}
			while ((object)_0023Bd2 != _0023Bd3);
		}
		[CompilerGenerated]
		remove
		{
			_0023Bd _0023Bd2 = _0023h;
			_0023Bd _0023Bd3;
			do
			{
				_0023Bd3 = _0023Bd2;
				_0023Bd value2 = (_0023Bd)Delegate.Remove(_0023Bd3, value);
				_0023Bd2 = Interlocked.CompareExchange(ref _0023h, value2, _0023Bd3);
			}
			while ((object)_0023Bd2 != _0023Bd3);
		}
	}

	protected abstract void _0023Wd(_0023fd _0023Rc);

	protected abstract void _0023Xd(_00233c _0023Rc);

	protected abstract void _0023Yd(_0023xd _0023Rc);

	internal void _00231d(object _00232d, ThreadExceptionEventArgs _0023Rc)
	{
		try
		{
			Exception ex = _0023Rc.Exception;
			Type type = ex.GetType();
			if (type.Name == _0023ab._00239._00237(107393836) && type.Namespace == _0023ab._00239._00237(107393843))
			{
				ex = (Exception)type.GetField(_0023ab._00239._00237(107393254))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(_0023d == _0023ab._00239._00237(107394766)) || !_00235d(ex as SecurityException))
			{
				_00236d(ex, _0023zd: true, _00237d: false);
			}
		}
		catch
		{
		}
	}

	internal void _00233d(object _00232d, UnhandledExceptionEventArgs _0023Rc)
	{
		try
		{
			if ((!(_0023Rc.ExceptionObject is SecurityException) || !(_0023d == _0023ab._00239._00237(107394766)) || !_00235d(_0023Rc.ExceptionObject as SecurityException)) && _0023Rc.ExceptionObject is Exception)
			{
				_00236d((Exception)_0023Rc.ExceptionObject, !_0023Rc.IsTerminating, _00237d: false);
			}
		}
		catch
		{
		}
	}

	protected virtual Guid _00234d()
	{
		return Guid.Empty;
	}

	internal bool _00235d(SecurityException _0023hd)
	{
		_0023xd _0023xd2 = new _0023xd(_0023hd);
		_0023Yd(_0023xd2);
		if (_0023xd2._0023d)
		{
			return false;
		}
		if (!_0023xd2._0023c)
		{
			Application.Exit();
		}
		return true;
	}

	internal void _00236d(Exception _0023hd, bool _0023zd, bool _00237d)
	{
		Type type = _0023hd.GetType();
		if (type.Name == _0023ab._00239._00237(107393836) && type.Namespace == _0023ab._00239._00237(107393843))
		{
			_0023hd = (Exception)type.GetField(_0023ab._00239._00237(107393254))!.GetValue(_0023hd);
		}
		bool flag = true;
		if (_0023hd == null || _0023hd is ThreadAbortException)
		{
			return;
		}
		try
		{
			_0023Uc obj = new _0023Uc(_00234d(), _0023hd, _0023f);
			obj.SendingReportFeedback += _0023ce;
			obj.DebuggerLaunched += _0023ae;
			obj.FatalException += _00238d;
			_0023fd _0023fd2 = new _0023fd(obj, _0023hd);
			if (_0023_0023._0023fh() != null)
			{
				_0023fd2._0023c = true;
			}
			if (!_0023zd)
			{
				_0023fd2._0023e = false;
				_0023fd2._0023f = false;
			}
			else if (_00237d || _0023c)
			{
				_0023fd2._0023e = false;
				_0023fd2._0023f = true;
			}
			_0023Wd(_0023fd2);
			flag = !_0023fd2._0023f;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception _00234c)
		{
			_0023Xd(new _00233c(_00234c));
		}
		if (!flag)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			try
			{
				string fullName = assembly.FullName;
				if (fullName.EndsWith(_0023ab._00239._00237(107393229)) && fullName.StartsWith(_0023ab._00239._00237(107393236)))
				{
					object obj2 = assembly.GetType(_0023ab._00239._00237(107393203))!.GetProperty(_0023ab._00239._00237(107393134))!.GetGetMethod()!.Invoke(null, null);
					obj2.GetType().GetMethod(_0023ab._00239._00237(107393121), new Type[0])!.Invoke(obj2, null);
				}
			}
			catch
			{
			}
		}
		try
		{
			Environment.ExitCode = -532462766;
			Application.Exit();
		}
		catch
		{
			try
			{
				Environment.Exit(-532462766);
			}
			catch
			{
			}
		}
	}

	private void _00238d(object _00232d, _00233c _00239d)
	{
		_0023Xd(_00239d);
	}

	private void _0023ae(object _00232d, EventArgs _0023be)
	{
		_0023g?.Invoke(_00232d, _0023be);
	}

	private void _0023ce(object _00232d, _0023Gd _0023de)
	{
		_0023h?.Invoke(_00232d, _0023de);
	}
}
