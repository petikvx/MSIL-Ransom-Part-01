using System.Text;

namespace ns0;

internal class Class0 : GClass0
{
	private GClass0 gclass0_0;

	private string string_0;

	public override GEnum0 GEnum0_0 => GEnum0.const_6;

	public override GClass0 this[int int_0]
	{
		get
		{
			return new Class0(this);
		}
		set
		{
			method_0(new GClass1()).Add(value);
		}
	}

	public override GClass0 this[string string_1]
	{
		get
		{
			return new Class0(this, string_1);
		}
		set
		{
			method_0(new GClass2()).Add(string_1, value);
		}
	}

	public override int Int32_1
	{
		get
		{
			method_0(new GClass4(0.0));
			return 0;
		}
		set
		{
			method_0(new GClass4(value));
		}
	}

	public override float Single_0
	{
		get
		{
			method_0(new GClass4(0.0));
			return 0f;
		}
		set
		{
			method_0(new GClass4(value));
		}
	}

	public override double Double_0
	{
		get
		{
			method_0(new GClass4(0.0));
			return 0.0;
		}
		set
		{
			method_0(new GClass4(value));
		}
	}

	public override long Int64_0
	{
		get
		{
			if (GClass0.bool_1)
			{
				method_0(new GClass3("0"));
			}
			else
			{
				method_0(new GClass4(0.0));
			}
			return 0L;
		}
		set
		{
			if (GClass0.bool_1)
			{
				method_0(new GClass3(value.ToString()));
			}
			else
			{
				method_0(new GClass4(value));
			}
		}
	}

	public override bool Boolean_7
	{
		get
		{
			method_0(new GClass5(bool_4: false));
			return false;
		}
		set
		{
			method_0(new GClass5(value));
		}
	}

	public override GClass1 GClass1_0 => method_0(new GClass1());

	public override GClass2 GClass2_0 => method_0(new GClass2());

	public override GStruct0 GetEnumerator()
	{
		return default(GStruct0);
	}

	public Class0(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
		string_0 = null;
	}

	public Class0(GClass0 gclass0_1, string string_1)
	{
		gclass0_0 = gclass0_1;
		string_0 = string_1;
	}

	private T method_0<T>(T gparam_0) where T : GClass0
	{
		if (string_0 == null)
		{
			gclass0_0.Add(gparam_0);
		}
		else
		{
			gclass0_0.Add(string_0, gparam_0);
		}
		gclass0_0 = null;
		return gparam_0;
	}

	public override void Add(GClass0 gclass0_1)
	{
		method_0(new GClass1()).Add(gclass0_1);
	}

	public override void Add(string string_1, GClass0 gclass0_1)
	{
		method_0(new GClass2()).Add(string_1, gclass0_1);
	}

	public static bool operator ==(Class0 class0_0, object object_0)
	{
		if (object_0 == null)
		{
			return true;
		}
		return (object)class0_0 == object_0;
	}

	public static bool operator !=(Class0 class0_0, object object_0)
	{
		return !(class0_0 == object_0);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return true;
		}
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append("null");
	}
}
