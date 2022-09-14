using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public class YFE0UxHbn9 : IDisposable
{
	private DateTimeOffset JOKxrODgVu;

	private Stopwatch euz9Z0JuyS;

	private Stopwatch QbI6oK8xeV = new Stopwatch();

	private List<Tuple<string, TimeSpan>> aNwDaClzWc;

	[CompilerGenerated]
	private UTUYfUaZ8B _6B2Zc8sD1b;

	[CompilerGenerated]
	private readonly Guid edDuxbRHzS;

	[CompilerGenerated]
	private readonly Guid d7kjCeeY99;

	[CompilerGenerated]
	private static INuGetTelemetryService bn7hP80Kub;

	public UTUYfUaZ8B _7G6ITrynWW
	{
		[CompilerGenerated]
		get
		{
			return _6B2Zc8sD1b;
		}
		[CompilerGenerated]
		set
		{
			_6B2Zc8sD1b = value;
		}
	}

	public Guid lTLJ8EI2qK
	{
		[CompilerGenerated]
		get
		{
			return edDuxbRHzS;
		}
	}

	public Guid yIlxwhun5W
	{
		[CompilerGenerated]
		get
		{
			return d7kjCeeY99;
		}
	}

	public static INuGetTelemetryService dv45WynV21
	{
		[CompilerGenerated]
		get
		{
			return bn7hP80Kub;
		}
		[CompilerGenerated]
		set
		{
			bn7hP80Kub = value;
		}
	}

	public YFE0UxHbn9(Guid parentId)
		: this(parentId, Guid.Empty, null)
	{
	}

	public YFE0UxHbn9(Guid parentId, Guid opeartionId)
		: this(parentId, opeartionId, null)
	{
	}

	public YFE0UxHbn9(Guid parentId, Guid opeartionId, UTUYfUaZ8B telemetryEvent)
	{
		_7G6ITrynWW = telemetryEvent;
		edDuxbRHzS = parentId;
		d7kjCeeY99 = opeartionId;
		JOKxrODgVu = DateTimeOffset.Now;
		euz9Z0JuyS = Stopwatch.StartNew();
		aNwDaClzWc = new List<Tuple<string, TimeSpan>>();
	}

	public void epBbLCATcs()
	{
		QbI6oK8xeV.Restart();
	}

	public void LOc8FqRMOI(string eiKV6gg0Hx)
	{
		QbI6oK8xeV.Stop();
		aNwDaClzWc.Add(new Tuple<string, TimeSpan>(eiKV6gg0Hx, QbI6oK8xeV.Elapsed));
	}

	public void jo1RWbEF0V()
	{
		euz9Z0JuyS.Stop();
		if (dv45WynV21 == null || _7G6ITrynWW == null)
		{
			return;
		}
		DateTimeOffset now = DateTimeOffset.Now;
		_7G6ITrynWW.set_Item("StartTime", (object)JOKxrODgVu.ToString());
		_7G6ITrynWW.set_Item("EndTime", (object)now.ToString());
		_7G6ITrynWW.set_Item("Duration", (object)euz9Z0JuyS.Elapsed.TotalSeconds);
		if (lTLJ8EI2qK != Guid.Empty)
		{
			_7G6ITrynWW.set_Item("ParentId", (object)lTLJ8EI2qK.ToString());
		}
		if (yIlxwhun5W != Guid.Empty)
		{
			_7G6ITrynWW.set_Item("OperationId", (object)yIlxwhun5W.ToString());
		}
		foreach (Tuple<string, TimeSpan> item in aNwDaClzWc)
		{
			_7G6ITrynWW.set_Item(item.Item1, (object)item.Item2.TotalSeconds);
		}
		dv45WynV21.EmitTelemetryEvent(_7G6ITrynWW);
	}

	public static void eTfLlW0qF0(UTUYfUaZ8B LddFeAOFfk)
	{
		dv45WynV21?.EmitTelemetryEvent(LddFeAOFfk);
	}

	public static YFE0UxHbn9 XOhKbqTH2O(Guid _2zwtD0Lk4j, string fkfea9L4mW)
	{
		return new YFE0UxHbn9(_2zwtD0Lk4j, Guid.NewGuid(), null)
		{
			_7G6ITrynWW = new UTUYfUaZ8B(fkfea9L4mW)
		};
	}

	public static YFE0UxHbn9 Tbxmal2ceV(Guid _0whe1m9shd)
	{
		return new YFE0UxHbn9(_0whe1m9shd, Guid.NewGuid(), null);
	}

	public static YFE0UxHbn9 asIcBZ7k5p()
	{
		return new YFE0UxHbn9(Guid.Empty, Guid.NewGuid(), null);
	}
}
