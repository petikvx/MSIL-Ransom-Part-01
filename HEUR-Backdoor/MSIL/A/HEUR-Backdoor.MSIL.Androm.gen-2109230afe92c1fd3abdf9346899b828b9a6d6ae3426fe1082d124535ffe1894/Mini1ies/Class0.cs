using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TemplateEngine.VS;

namespace Mini1ies;

internal class Class0 : IProjectCreationMetadata
{
	[CompilerGenerated]
	private IDictionary<string, string> Re0icles = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	[CompilerGenerated]
	private IDictionary<string, string> Mas0ixes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	[CompilerGenerated]
	private readonly IDictionary<string, object> S6pered = new Dictionary<string, object>();

	public IDictionary<string, string> Levan7ed
	{
		[CompilerGenerated]
		get
		{
			return Re0icles;
		}
		[CompilerGenerated]
		private set
		{
			Re0icles = value;
		}
	}

	public IDictionary<string, string> Dis1ect
	{
		[CompilerGenerated]
		get
		{
			return Mas0ixes;
		}
		[CompilerGenerated]
		set
		{
			Mas0ixes = value;
		}
	}

	protected internal IDictionary<string, object> Brandin7
	{
		[CompilerGenerated]
		get
		{
			return S6pered;
		}
	}

	public string String_0
	{
		get
		{
			return GetValueForKnownProperty<string>("ApplyAuth");
		}
		set
		{
			SetValueForKnownProperty(value, "ApplyAuth");
		}
	}

	public string Bi6ocu6ar
	{
		get
		{
			return GetValueForKnownProperty<string>("Baseline");
		}
		set
		{
			SetValueForKnownProperty(value, "Baseline");
		}
	}

	public bool F8refangs
	{
		get
		{
			return GetValueForKnownProperty<bool>("CanCreate");
		}
		set
		{
			SetValueForKnownProperty(value, "CanCreate");
		}
	}

	public string M5therh55d
	{
		get
		{
			return GetValueForKnownProperty<string>("Context");
		}
		set
		{
			SetValueForKnownProperty(value, "Context");
		}
	}

	public string She44cracker
	{
		get
		{
			return GetValueForKnownProperty<string>("DestinationFolder");
		}
		set
		{
			SetValueForKnownProperty(value, "DestinationFolder");
		}
	}

	public string String_1
	{
		get
		{
			return GetValueForKnownProperty<string>("GroupIdentity");
		}
		set
		{
			SetValueForKnownProperty(value, "GroupIdentity");
		}
	}

	public string String_2
	{
		get
		{
			return GetValueForKnownProperty<string>("Language");
		}
		set
		{
			SetValueForKnownProperty(value, "Language");
		}
	}

	public string Espan2l
	{
		get
		{
			return GetValueForKnownProperty<string>("PlatformVersion");
		}
		set
		{
			SetValueForKnownProperty(value, "PlatformVersion");
		}
	}

	public string U6wept
	{
		get
		{
			return GetValueForKnownProperty<string>("TagFilter");
		}
		set
		{
			SetValueForKnownProperty(value, "TagFilter");
		}
	}

	public string Dr1pt
	{
		get
		{
			return GetValueForKnownProperty<string>("TargetName");
		}
		set
		{
			SetValueForKnownProperty(value, "TargetName");
		}
	}

	public string B4n4lized
	{
		get
		{
			return GetValueForKnownProperty<string>("TemplateIdentity");
		}
		set
		{
			SetValueForKnownProperty(value, "TemplateIdentity");
		}
	}

	public string String_3
	{
		get
		{
			return GetValueForKnownProperty<string>("TemplateType");
		}
		set
		{
			SetValueForKnownProperty(value, "TemplateType");
		}
	}

	public string Mycopla4mal
	{
		get
		{
			return GetValueForKnownProperty<string>("UIHost");
		}
		set
		{
			SetValueForKnownProperty(value, "UIHost");
		}
	}

	public string F2zz2est
	{
		get
		{
			return GetValueForKnownProperty<string>("UIStyle");
		}
		set
		{
			SetValueForKnownProperty(value, "UIStyle");
		}
	}

	public string Blep3arospasm
	{
		get
		{
			return GetValueForKnownProperty<string>("TelemetryErrorDetail");
		}
		set
		{
			SetValueForKnownProperty(value, "TelemetryErrorDetail");
		}
	}

	public Class0()
	{
		F8refangs = false;
	}

	private Class0(Class0 copyFrom)
	{
		foreach (KeyValuePair<string, string> item in copyFrom.Levan7ed)
		{
			Levan7ed[item.Key] = item.Value;
		}
		if (copyFrom.Dis1ect != null)
		{
			foreach (KeyValuePair<string, string> item2 in copyFrom.Dis1ect)
			{
				Dis1ect[item2.Key] = item2.Value;
			}
		}
		foreach (KeyValuePair<string, object> item3 in copyFrom.Brandin7)
		{
			Brandin7[item3.Key] = item3.Value;
		}
	}

	protected T GetValueForKnownProperty<T>([CallerMemberName] string name = null)
	{
		return vmethod_0<T>(name);
	}

	protected void SetValueForKnownProperty<T>(T value, [CallerMemberName] string name = null)
	{
		Monasti3ism(name, value);
	}

	public T Hali6g<T>(string Int3me)
	{
		return (T)Brandin7[Int3me];
	}

	public bool Rec7ndense<T>(string L3gal3s3s, out T Strati7ied)
	{
		Strati7ied = default(T);
		if (Brandin7.TryGetValue(L3gal3s3s, out var value) && value is T)
		{
			Strati7ied = (T)value;
			return true;
		}
		return false;
	}

	public T vmethod_0<T>(string string_0, T Swa55i5g = default(T))
	{
		T result = Swa55i5g;
		if (Brandin7.TryGetValue(string_0, out var value))
		{
			result = (T)value;
		}
		return result;
	}

	public void Monasti3ism<T>(string Plan6twid6, T Rams0ackle)
	{
		Brandin7[Plan6twid6] = Rams0ackle;
	}

	public bool Procrea2ing(string D7g7n7rations)
	{
		return Brandin7.ContainsKey(D7g7n7rations);
	}

	public IProjectCreationMetadata Barra4le()
	{
		return (IProjectCreationMetadata)(object)new Class0(this);
	}
}
