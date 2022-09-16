using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using _0xH1hamo;
using _0xHG6uziness;
using _0xHGar5ler;
using _0xHMal7dict7d;
using _0xHS3ar3;
using _0xHSeltze6s;
using _0xHSigm1te;
using _0xHSnorke7er;

namespace _0xHW4tans;

public abstract class _0xHBelletri8t : IDisposable
{
	private EventHandler<_0xHMicroor8anisms> _0xHSt0eptolysins;

	private EventHandler<_0xHMercif4lnesses> _0xHInvad0r;

	internal volatile _0xHBelletri8t _0xH1reaming;

	internal static _0xHBelletri8t _0xHCodli2;

	internal static List<WeakReference> _0xH6iscomforts;

	private static bool _0xHSulfona4ion = false;

	private static bool _0xHAnatomi0t0 = false;

	internal static object _0xHL0ticifers
	{
		get
		{
			if (_0xH6iscomforts == null)
			{
				Interlocked.CompareExchange(ref _0xH6iscomforts, new List<WeakReference>(2), null);
			}
			return _0xH6iscomforts;
		}
	}

	private event EventHandler<_0xHMicroor8anisms> _0xH4igglier
	{
		add
		{
			EventHandler<_0xHMicroor8anisms> eventHandler = _0xHSt0eptolysins;
			EventHandler<_0xHMicroor8anisms> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<_0xHMicroor8anisms> value2 = (EventHandler<_0xHMicroor8anisms>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0xHSt0eptolysins, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<_0xHMicroor8anisms> eventHandler = _0xHSt0eptolysins;
			EventHandler<_0xHMicroor8anisms> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<_0xHMicroor8anisms> value2 = (EventHandler<_0xHMicroor8anisms>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0xHSt0eptolysins, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<_0xHMicroor8anisms> _0xHPung0ntly
	{
		add
		{
			_0xHPo1erty(_0xH2utch: false, value);
			_0xHSt0eptolysins = (EventHandler<_0xHMicroor8anisms>)Delegate.Combine(_0xHSt0eptolysins, value);
		}
		remove
		{
			_0xHSt0eptolysins = (EventHandler<_0xHMicroor8anisms>)Delegate.Remove(_0xHSt0eptolysins, value);
		}
	}

	public event EventHandler<_0xHMercif4lnesses> _0xHEn8rea8ingly
	{
		add
		{
			EventHandler<_0xHMercif4lnesses> eventHandler = _0xHInvad0r;
			EventHandler<_0xHMercif4lnesses> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<_0xHMercif4lnesses> value2 = (EventHandler<_0xHMercif4lnesses>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0xHInvad0r, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<_0xHMercif4lnesses> eventHandler = _0xHInvad0r;
			EventHandler<_0xHMercif4lnesses> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<_0xHMercif4lnesses> value2 = (EventHandler<_0xHMercif4lnesses>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0xHInvad0r, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected _0xHBelletri8t()
	{
		EventHandler<_0xHMicroor8anisms> eventHandler = null;
		base._002Ector();
		eventHandler = delegate(object _0xHRural5sed, _0xHMicroor8anisms _0xHRow8oats)
		{
			_0xHRow8oats._0xHVi5tues._0xHAu1iphone(this);
		};
		_0xHPo1erty(_0xH2utch: true, eventHandler);
	}

	public virtual void _0xHAbutta2s()
	{
		lock (_0xHL0ticifers)
		{
			if (_0xHCodli2 == null)
			{
				return;
			}
			if (this == _0xHCodli2)
			{
				_0xHBelletri8t _0xHUnpe22in = _0xHCodli2;
				_0xHCodli2 = _0xH1reaming;
				_0xHPralltr0llers(_0xHUnpe22in);
				return;
			}
			_0xHBelletri8t _0xHBelletri8t2 = _0xHCodli2;
			while (true)
			{
				_0xHBelletri8t _0xHBelletri8t3 = _0xHBelletri8t2._0xH1reaming;
				if (_0xHBelletri8t3 != null)
				{
					if (_0xHBelletri8t3 != this)
					{
						_0xHBelletri8t2 = _0xHBelletri8t3;
						continue;
					}
					_0xHBelletri8t2._0xH1reaming = _0xHBelletri8t3._0xH1reaming;
					_0xHPralltr0llers(_0xHBelletri8t3);
					break;
				}
				break;
			}
		}
	}

	public void _0xHJ1cul1te(_0xH2wooned _0xHF5othed, _0xHFire0ots _0xHAcce55ional)
	{
		_0xHFashionis6as(_0xHF5othed, _0xHAcce55ional, _0xHSov8r8ignti8s.None);
	}

	public void _0xHFashionis6as(_0xH2wooned _0xHFa3igable, _0xHFire0ots _0xHLuster5ess, _0xHSov8r8ignti8s _0xHOv3rrunning)
	{
		_0xHUn8tedly(_0xHFa3igable, _0xHLuster5ess, _0xHOv3rrunning, null);
	}

	public void _0xHUn8tedly(_0xH2wooned _0xHTaga1ongs, _0xHFire0ots _0xHHypo7ta7e7, _0xHSov8r8ignti8s _0xHRidg6ing, IDictionary<string, string> _0xHWhoop55)
	{
		if (_0xHTaga1ongs == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		_0xHTaga1ongs._0xHMechan4sts(this, 0, 0, _0xHNonequa5.Update, _0xHEx8cut8s: true, _0xHHypo7ta7e7, _0xHRidg6ing, _0xHWhoop55);
	}

	public void _0xH7eans(_0xH2wooned _0xHExclude6s)
	{
		if (_0xHExclude6s == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		_0xHExclude6s._0xHMechan4sts(this, 0, 0, _0xHNonequa5.Update, _0xHEx8cut8s: false, _0xHFire0ots.LogAlways, _0xHSov8r8ignti8s.None, null);
	}

	public static int _0xHF0sional(_0xH2wooned _0xHIna4g4rations)
	{
		return _0xHIna4g4rations._0xHLut3sts;
	}

	protected internal virtual void _0xHSynaes1hesis(_0xH2wooned _0xHFro5tily)
	{
		EventHandler<_0xHMicroor8anisms> eventHandler = _0xHSt0eptolysins;
		if (eventHandler != null)
		{
			_0xHMicroor8anisms _0xHMicroor8anisms = new _0xHMicroor8anisms();
			_0xHMicroor8anisms._0xHVi5tues = _0xHFro5tily;
			eventHandler(this, _0xHMicroor8anisms);
		}
	}

	protected internal virtual void _0xHTorn8llos(_0xHMercif4lnesses _0xHConcei6ednesses)
	{
		_0xHInvad0r?.Invoke(this, _0xHConcei6ednesses);
	}

	internal static void _0xHInter8orly(_0xH2wooned _0xHSeca2eur)
	{
		lock (_0xHL0ticifers)
		{
			if (_0xH6iscomforts == null)
			{
				_0xH6iscomforts = new List<WeakReference>(2);
			}
			if (!_0xHAnatomi0t0)
			{
				_0xHAnatomi0t0 = true;
				AppDomain.CurrentDomain.ProcessExit += _0xHAft4rbirths;
				AppDomain.CurrentDomain.DomainUnload += _0xHAft4rbirths;
			}
			int num = -1;
			if (_0xH6iscomforts.Count % 64 == 63)
			{
				int num2 = _0xH6iscomforts.Count;
				while (0 < num2)
				{
					num2 = checked(num2 - 1);
					WeakReference weakReference = _0xH6iscomforts[num2];
					if (!weakReference.IsAlive)
					{
						num = num2;
						weakReference.Target = _0xHSeca2eur;
						break;
					}
				}
			}
			if (num < 0)
			{
				num = _0xH6iscomforts.Count;
				_0xH6iscomforts.Add(new WeakReference(_0xHSeca2eur));
			}
			_0xHSeca2eur._0xHLut3sts = num;
			for (_0xHBelletri8t _0xHBelletri8t2 = _0xHCodli2; _0xHBelletri8t2 != null; _0xHBelletri8t2 = _0xHBelletri8t2._0xH1reaming)
			{
				_0xHSeca2eur._0xHAu1iphone(_0xHBelletri8t2);
			}
		}
	}

	private static void _0xHAft4rbirths(object sender, EventArgs e)
	{
		lock (_0xHL0ticifers)
		{
			foreach (WeakReference _0xH6iscomfort in _0xH6iscomforts)
			{
				if (_0xH6iscomfort.Target is _0xH2wooned _0xH2wooned)
				{
					_0xH2wooned._0xHKron0();
				}
			}
		}
	}

	private static void _0xHPralltr0llers(_0xHBelletri8t _0xHUnpe22in2)
	{
		foreach (WeakReference _0xH6iscomfort in _0xH6iscomforts)
		{
			if (!(_0xH6iscomfort.Target is _0xH2wooned _0xH2wooned))
			{
				continue;
			}
			if (_0xH2wooned._0xHInc4nerat4on._0xHBac5shores == _0xHUnpe22in2)
			{
				_0xH2wooned._0xHInc4nerat4on = _0xH2wooned._0xHInc4nerat4on._0xHCraftin0ss;
				continue;
			}
			_0xHGh0bl0 _0xHGh0bl = _0xH2wooned._0xHInc4nerat4on;
			while (true)
			{
				_0xHGh0bl0 _0xHCraftin0ss = _0xHGh0bl._0xHCraftin0ss;
				if (_0xHCraftin0ss == null)
				{
					break;
				}
				if (_0xHCraftin0ss._0xHBac5shores != _0xHUnpe22in2)
				{
					_0xHGh0bl = _0xHCraftin0ss;
					continue;
				}
				_0xHGh0bl._0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss;
				break;
			}
		}
	}

	[Conditional("DEBUG")]
	internal static void _0xHP7ep7int()
	{
		lock (_0xHL0ticifers)
		{
			Dictionary<_0xHBelletri8t, bool> dictionary = new Dictionary<_0xHBelletri8t, bool>();
			for (_0xHBelletri8t _0xHBelletri8t2 = _0xHCodli2; _0xHBelletri8t2 != null; _0xHBelletri8t2 = _0xHBelletri8t2._0xH1reaming)
			{
				dictionary.Add(_0xHBelletri8t2, value: true);
			}
			int num = -1;
			foreach (WeakReference _0xH6iscomfort in _0xH6iscomforts)
			{
				num = checked(num + 1);
				if (!(_0xH6iscomfort.Target is _0xH2wooned _0xH2wooned))
				{
					continue;
				}
				for (_0xHGh0bl0 _0xHGh0bl = _0xH2wooned._0xHInc4nerat4on; _0xHGh0bl != null; _0xHGh0bl = _0xHGh0bl._0xHCraftin0ss)
				{
				}
				foreach (_0xHBelletri8t key in dictionary.Keys)
				{
					_0xHGh0bl0 _0xHGh0bl = _0xH2wooned._0xHInc4nerat4on;
					while (_0xHGh0bl._0xHBac5shores != key)
					{
						_0xHGh0bl = _0xHGh0bl._0xHCraftin0ss;
					}
				}
			}
		}
	}

	private void _0xHPo1erty(bool _0xH2utch, EventHandler<_0xHMicroor8anisms> _0xHPro5a5ilistic)
	{
		lock (_0xHL0ticifers)
		{
			if (_0xHSulfona4ion)
			{
				throw new InvalidOperationException(_0xHA2eotropy._0xHSpon8or("EventSource_ListenerCreatedInsideCallback"));
			}
			try
			{
				_0xHSulfona4ion = true;
				if (_0xH2utch)
				{
					_0xH1reaming = _0xHCodli2;
					_0xHCodli2 = this;
				}
				WeakReference[] array = _0xH6iscomforts.ToArray();
				foreach (WeakReference weakReference in array)
				{
					if (weakReference.Target is _0xH2wooned _0xHVi5tues)
					{
						_0xHMicroor8anisms _0xHMicroor8anisms = new _0xHMicroor8anisms();
						_0xHMicroor8anisms._0xHVi5tues = _0xHVi5tues;
						_0xHPro5a5ilistic(this, _0xHMicroor8anisms);
					}
				}
			}
			finally
			{
				_0xHSulfona4ion = false;
			}
		}
	}

	[CompilerGenerated]
	private void _0xHCarcinoi2s(object _0xHRural5sed, _0xHMicroor8anisms _0xHRow8oats)
	{
		_0xHRow8oats._0xHVi5tues._0xHAu1iphone(this);
	}
}
