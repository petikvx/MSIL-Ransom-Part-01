using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hy6rase;
using ns13;

namespace ns14;

public class Spatialitie2 : IDisposable
{
	private DateTimeOffset dateTimeOffset_0;

	private Stopwatch Gallo0er;

	private Stopwatch Meg4st4rs = new Stopwatch();

	private List<Tuple<string, TimeSpan>> Du6nium;

	[CompilerGenerated]
	private Viscositi1s Fo0geable;

	[CompilerGenerated]
	private readonly Guid D1ad1ns;

	[CompilerGenerated]
	private readonly Guid guid_0;

	[CompilerGenerated]
	private static INuGetTelemetryService F4mili4l;

	public Viscositi1s Exuv6al
	{
		[CompilerGenerated]
		get
		{
			return Fo0geable;
		}
		[CompilerGenerated]
		set
		{
			Fo0geable = value;
		}
	}

	public Guid Se0eno0ogists
	{
		[CompilerGenerated]
		get
		{
			return D1ad1ns;
		}
	}

	public Guid Jus7ifica7ions
	{
		[CompilerGenerated]
		get
		{
			return guid_0;
		}
	}

	public static INuGetTelemetryService Homop2erans
	{
		[CompilerGenerated]
		get
		{
			return F4mili4l;
		}
		[CompilerGenerated]
		set
		{
			F4mili4l = value;
		}
	}

	public Spatialitie2(Guid parentId)
		: this(parentId, Guid.Empty, null)
	{
	}

	public Spatialitie2(Guid parentId, Guid opeartionId)
		: this(parentId, opeartionId, null)
	{
	}

	public Spatialitie2(Guid parentId, Guid opeartionId, Viscositi1s telemetryEvent)
	{
		Exuv6al = telemetryEvent;
		D1ad1ns = parentId;
		guid_0 = opeartionId;
		dateTimeOffset_0 = DateTimeOffset.Now;
		Gallo0er = Stopwatch.StartNew();
		Du6nium = new List<Tuple<string, TimeSpan>>();
	}

	public void method_0()
	{
		Meg4st4rs.Restart();
	}

	public void I8tra8sige8tly(string Genera6ive)
	{
		Meg4st4rs.Stop();
		Du6nium.Add(new Tuple<string, TimeSpan>(Genera6ive, Meg4st4rs.Elapsed));
	}

	public void Ar2ificialness()
	{
		Gallo0er.Stop();
		if (Homop2erans == null || Exuv6al == null)
		{
			return;
		}
		DateTimeOffset now = DateTimeOffset.Now;
		Exuv6al.set_Sa7oriness("StartTime", (object)dateTimeOffset_0.ToString());
		Exuv6al.set_Sa7oriness("EndTime", (object)now.ToString());
		Exuv6al.set_Sa7oriness("Duration", (object)Gallo0er.Elapsed.TotalSeconds);
		if (Se0eno0ogists != Guid.Empty)
		{
			Exuv6al.set_Sa7oriness("ParentId", (object)Se0eno0ogists.ToString());
		}
		if (Jus7ifica7ions != Guid.Empty)
		{
			Exuv6al.set_Sa7oriness("OperationId", (object)Jus7ifica7ions.ToString());
		}
		foreach (Tuple<string, TimeSpan> item in Du6nium)
		{
			Exuv6al.set_Sa7oriness(item.Item1, (object)item.Item2.TotalSeconds);
		}
		Homop2erans.EmitTelemetryEvent(Exuv6al);
	}

	public static void Utilisi0g(Viscositi1s An6rily)
	{
		Homop2erans?.EmitTelemetryEvent(An6rily);
	}

	public static Spatialitie2 Coun6ersho6s(Guid Garn7sher, string Ov5rmant5l)
	{
		return new Spatialitie2(Garn7sher, Guid.NewGuid(), null)
		{
			Exuv6al = new Viscositi1s(Ov5rmant5l)
		};
	}

	public static Spatialitie2 Reglue7(Guid M7usetrapped)
	{
		return new Spatialitie2(M7usetrapped, Guid.NewGuid(), null);
	}

	public static Spatialitie2 smethod_0()
	{
		return new Spatialitie2(Guid.Empty, Guid.NewGuid(), null);
	}
}
