using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ns0;

public abstract class GClass0
{
	public struct GStruct0
	{
		private enum Enum0
		{
			const_0,
			const_1,
			const_2
		}

		private Enum0 enum0_0;

		private Dictionary<string, GClass0>.Enumerator enumerator_0;

		private List<GClass0>.Enumerator enumerator_1;

		public bool Boolean_0 => enum0_0 != Enum0.const_0;

		public KeyValuePair<string, GClass0> KeyValuePair_0
		{
			get
			{
				if (enum0_0 == Enum0.const_1)
				{
					return new KeyValuePair<string, GClass0>(string.Empty, enumerator_1.Current);
				}
				if (enum0_0 == Enum0.const_2)
				{
					return enumerator_0.Current;
				}
				return new KeyValuePair<string, GClass0>(string.Empty, null);
			}
		}

		public GStruct0(List<GClass0>.Enumerator aArrayEnum)
		{
			enum0_0 = Enum0.const_1;
			enumerator_0 = default(Dictionary<string, GClass0>.Enumerator);
			enumerator_1 = aArrayEnum;
		}

		public GStruct0(Dictionary<string, GClass0>.Enumerator aDictEnum)
		{
			enum0_0 = Enum0.const_2;
			enumerator_0 = aDictEnum;
			enumerator_1 = default(List<GClass0>.Enumerator);
		}

		public bool MoveNext()
		{
			if (enum0_0 == Enum0.const_1)
			{
				return enumerator_1.MoveNext();
			}
			if (enum0_0 == Enum0.const_2)
			{
				return enumerator_0.MoveNext();
			}
			return false;
		}
	}

	public struct GStruct1
	{
		private GStruct0 gstruct0_0;

		public GClass0 GClass0_0 => gstruct0_0.KeyValuePair_0.Value;

		public GStruct1(List<GClass0>.Enumerator aArrayEnum)
			: this(new GStruct0(aArrayEnum))
		{
		}

		public GStruct1(Dictionary<string, GClass0>.Enumerator aDictEnum)
			: this(new GStruct0(aDictEnum))
		{
		}

		public GStruct1(GStruct0 aEnumerator)
		{
			gstruct0_0 = aEnumerator;
		}

		public bool MoveNext()
		{
			return gstruct0_0.MoveNext();
		}

		public GStruct1 GetEnumerator()
		{
			return this;
		}
	}

	public struct GStruct2
	{
		private GStruct0 gstruct0_0;

		public string String_0 => gstruct0_0.KeyValuePair_0.Key;

		public GStruct2(List<GClass0>.Enumerator aArrayEnum)
			: this(new GStruct0(aArrayEnum))
		{
		}

		public GStruct2(Dictionary<string, GClass0>.Enumerator aDictEnum)
			: this(new GStruct0(aDictEnum))
		{
		}

		public GStruct2(GStruct0 aEnumerator)
		{
			gstruct0_0 = aEnumerator;
		}

		public bool MoveNext()
		{
			return gstruct0_0.MoveNext();
		}

		public GStruct2 GetEnumerator()
		{
			return this;
		}
	}

	public class GClass7 : IEnumerator<KeyValuePair<string, GClass0>>, IEnumerable<KeyValuePair<string, GClass0>>, IDisposable, IEnumerator, IEnumerable
	{
		private GClass0 gclass0_0;

		private GStruct0 gstruct0_0;

		public KeyValuePair<string, GClass0> Current => gstruct0_0.KeyValuePair_0;

		object IEnumerator.Current => gstruct0_0.KeyValuePair_0;

		internal GClass7(GClass0 aNode)
		{
			gclass0_0 = aNode;
			if (gclass0_0 != null)
			{
				gstruct0_0 = gclass0_0.GetEnumerator();
			}
		}

		public bool MoveNext()
		{
			return gstruct0_0.MoveNext();
		}

		public void Dispose()
		{
			gclass0_0 = null;
			gstruct0_0 = default(GStruct0);
		}

		public IEnumerator<KeyValuePair<string, GClass0>> GetEnumerator()
		{
			return new GClass7(gclass0_0);
		}

		public void Reset()
		{
			if (gclass0_0 != null)
			{
				gstruct0_0 = gclass0_0.GetEnumerator();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new GClass7(gclass0_0);
		}
	}

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static bool bool_2 = true;

	[ThreadStatic]
	private static StringBuilder m_EscapeBuilder;

	public abstract GEnum0 GEnum0_0 { get; }

	public virtual GClass0 this[int int_0]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual GClass0 this[string string_0]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string String_0
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public virtual int Int32_0 => 0;

	public virtual bool Boolean_0 => false;

	public virtual bool Boolean_1 => false;

	public virtual bool Boolean_2 => false;

	public virtual bool Boolean_3 => false;

	public virtual bool Boolean_4 => false;

	public virtual bool Boolean_5 => false;

	public virtual bool Boolean_6
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual IEnumerable<GClass0> Prop_0
	{
		get
		{
			yield break;
		}
	}

	public IEnumerable<GClass0> IEnumerable_0
	{
		get
		{
			foreach (GClass0 item in Prop_0)
			{
				foreach (GClass0 item2 in item.IEnumerable_0)
				{
					yield return item2;
				}
			}
		}
	}

	public IEnumerable<KeyValuePair<string, GClass0>> IEnumerable_1 => new GClass7(this);

	public GStruct2 GStruct2_0 => new GStruct2(GetEnumerator());

	public GStruct1 GStruct1_0 => new GStruct1(GetEnumerator());

	public virtual double Double_0
	{
		get
		{
			double result = 0.0;
			if (double.TryParse(String_0, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
			{
				return result;
			}
			return 0.0;
		}
		set
		{
			String_0 = value.ToString(CultureInfo.InvariantCulture);
		}
	}

	public virtual int Int32_1
	{
		get
		{
			return (int)Double_0;
		}
		set
		{
			Double_0 = value;
		}
	}

	public virtual float Single_0
	{
		get
		{
			return (float)Double_0;
		}
		set
		{
			Double_0 = value;
		}
	}

	public virtual bool Boolean_7
	{
		get
		{
			bool result = false;
			if (bool.TryParse(String_0, out result))
			{
				return result;
			}
			return !string.IsNullOrEmpty(String_0);
		}
		set
		{
			String_0 = (value ? "true" : "false");
		}
	}

	public virtual long Int64_0
	{
		get
		{
			long result = 0L;
			if (long.TryParse(String_0, out result))
			{
				return result;
			}
			return 0L;
		}
		set
		{
			String_0 = value.ToString();
		}
	}

	public virtual GClass1 GClass1_0 => this as GClass1;

	public virtual GClass2 GClass2_0 => this as GClass2;

	internal static StringBuilder StringBuilder_0
	{
		get
		{
			if (m_EscapeBuilder == null)
			{
				m_EscapeBuilder = new StringBuilder();
			}
			return m_EscapeBuilder;
		}
	}

	public virtual void Add(string string_0, GClass0 gclass0_0)
	{
	}

	public virtual void Add(GClass0 gclass0_0)
	{
		Add("", gclass0_0);
	}

	public virtual GClass0 Remove(string string_0)
	{
		return null;
	}

	public virtual GClass0 Remove(int int_0)
	{
		return null;
	}

	public virtual GClass0 Remove(GClass0 gclass0_0)
	{
		return gclass0_0;
	}

	public virtual GClass0 Clone()
	{
		return null;
	}

	public virtual bool HasKey(string string_0)
	{
		return false;
	}

	public virtual GClass0 GetValueOrDefault(string string_0, GClass0 gclass0_0)
	{
		return gclass0_0;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		WriteToStringBuilder(stringBuilder, 0, 0, GEnum1.const_0);
		return stringBuilder.ToString();
	}

	public virtual string ToString(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		WriteToStringBuilder(stringBuilder, 0, int_0, GEnum1.const_1);
		return stringBuilder.ToString();
	}

	internal abstract void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0);

	public abstract GStruct0 GetEnumerator();

	public static implicit operator GClass0(string string_0)
	{
		return new GClass3(string_0);
	}

	public static implicit operator string(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.String_0;
		}
		return null;
	}

	public static implicit operator GClass0(double double_0)
	{
		return new GClass4(double_0);
	}

	public static implicit operator double(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.Double_0;
		}
		return 0.0;
	}

	public static implicit operator GClass0(float float_0)
	{
		return new GClass4(float_0);
	}

	public static implicit operator float(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.Single_0;
		}
		return 0f;
	}

	public static implicit operator GClass0(int int_0)
	{
		return new GClass4(int_0);
	}

	public static implicit operator int(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.Int32_1;
		}
		return 0;
	}

	public static implicit operator GClass0(long long_0)
	{
		if (bool_1)
		{
			return new GClass3(long_0.ToString());
		}
		return new GClass4(long_0);
	}

	public static implicit operator long(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.Int64_0;
		}
		return 0L;
	}

	public static implicit operator GClass0(bool bool_3)
	{
		return new GClass5(bool_3);
	}

	public static implicit operator bool(GClass0 gclass0_0)
	{
		if (!(gclass0_0 == null))
		{
			return gclass0_0.Boolean_7;
		}
		return false;
	}

	public static implicit operator GClass0(KeyValuePair<string, GClass0> keyValuePair_0)
	{
		return keyValuePair_0.Value;
	}

	public static bool operator ==(GClass0 gclass0_0, object object_0)
	{
		if ((object)gclass0_0 == object_0)
		{
			return true;
		}
		bool flag = gclass0_0 is GClass6 || (object)gclass0_0 == null || gclass0_0 is Class0;
		bool flag2 = object_0 is GClass6 || object_0 == null || object_0 is Class0;
		if (flag && flag2)
		{
			return true;
		}
		if (!flag)
		{
			return gclass0_0.Equals(object_0);
		}
		return false;
	}

	public static bool operator !=(GClass0 gclass0_0, object object_0)
	{
		return !(gclass0_0 == object_0);
	}

	public override bool Equals(object obj)
	{
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	internal static string smethod_0(string string_0)
	{
		StringBuilder stringBuilder_ = StringBuilder_0;
		stringBuilder_.Length = 0;
		if (stringBuilder_.Capacity < string_0.Length + string_0.Length / 10)
		{
			stringBuilder_.Capacity = string_0.Length + string_0.Length / 10;
		}
		foreach (char c in string_0)
		{
			switch (c)
			{
			case '\\':
				stringBuilder_.Append("\\\\");
				continue;
			case '"':
				stringBuilder_.Append("\\\"");
				continue;
			case '\b':
				stringBuilder_.Append("\\b");
				continue;
			case '\t':
				stringBuilder_.Append("\\t");
				continue;
			case '\n':
				stringBuilder_.Append("\\n");
				continue;
			case '\f':
				stringBuilder_.Append("\\f");
				continue;
			case '\r':
				stringBuilder_.Append("\\r");
				continue;
			}
			if (c >= ' ' && (!bool_0 || c <= '\u007f'))
			{
				stringBuilder_.Append(c);
				continue;
			}
			ushort num = c;
			stringBuilder_.Append("\\u").Append(num.ToString("X4"));
		}
		string result = stringBuilder_.ToString();
		stringBuilder_.Length = 0;
		return result;
	}

	private static GClass0 smethod_1(string string_0, bool bool_3)
	{
		if (bool_3)
		{
			return string_0;
		}
		string text = string_0.ToLower();
		switch (text)
		{
		case "null":
			return GClass6.smethod_3();
		default:
		{
			if (double.TryParse(string_0, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}
			return string_0;
		}
		case "false":
		case "true":
			return text == "true";
		}
	}

	public static GClass0 smethod_2(string string_0)
	{
		Stack<GClass0> stack = new Stack<GClass0>();
		GClass0 gClass = null;
		int i = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string string_ = "";
		bool flag = false;
		bool flag2 = false;
		for (; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case '\t':
			case ' ':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
				}
				break;
			case '/':
				if (bool_2 && !flag && i + 1 < string_0.Length && string_0[i + 1] == '/')
				{
					while (++i < string_0.Length && string_0[i] != '\n' && string_0[i] != '\r')
					{
					}
				}
				else
				{
					stringBuilder.Append(string_0[i]);
				}
				break;
			case ',':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
					break;
				}
				if (stringBuilder.Length > 0 || flag2)
				{
					gClass.Add(string_, smethod_1(stringBuilder.ToString(), flag2));
				}
				flag2 = false;
				string_ = "";
				stringBuilder.Length = 0;
				flag2 = false;
				break;
			case '"':
				flag = !flag;
				flag2 = flag2 || flag;
				break;
			case '[':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
					break;
				}
				stack.Push(new GClass1());
				if (gClass != null)
				{
					gClass.Add(string_, stack.Peek());
				}
				string_ = "";
				stringBuilder.Length = 0;
				gClass = stack.Peek();
				break;
			case '\\':
				i++;
				if (flag)
				{
					char c = string_0[i];
					switch (c)
					{
					case 'f':
						stringBuilder.Append('\f');
						break;
					case 'b':
						stringBuilder.Append('\b');
						break;
					case 'r':
						stringBuilder.Append('\r');
						break;
					default:
						stringBuilder.Append(c);
						break;
					case 't':
						stringBuilder.Append('\t');
						break;
					case 'u':
					{
						string s = string_0.Substring(i + 1, 4);
						stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
						i += 4;
						break;
					}
					case 'n':
						stringBuilder.Append('\n');
						break;
					}
				}
				break;
			case ':':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
					break;
				}
				string_ = stringBuilder.ToString();
				stringBuilder.Length = 0;
				flag2 = false;
				break;
			default:
				stringBuilder.Append(string_0[i]);
				break;
			case ']':
			case '}':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
					break;
				}
				if (stack.Count != 0)
				{
					stack.Pop();
					if (stringBuilder.Length > 0 || flag2)
					{
						gClass.Add(string_, smethod_1(stringBuilder.ToString(), flag2));
					}
					flag2 = false;
					string_ = "";
					stringBuilder.Length = 0;
					if (stack.Count > 0)
					{
						gClass = stack.Peek();
					}
					break;
				}
				throw new Exception("JSON Parse: Too many closing brackets");
			case '{':
				if (flag)
				{
					stringBuilder.Append(string_0[i]);
					break;
				}
				stack.Push(new GClass2());
				if (gClass != null)
				{
					gClass.Add(string_, stack.Peek());
				}
				string_ = "";
				stringBuilder.Length = 0;
				gClass = stack.Peek();
				break;
			case '\n':
			case '\r':
			case '\ufeff':
				break;
			}
		}
		if (flag)
		{
			throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
		}
		if (gClass == null)
		{
			return smethod_1(stringBuilder.ToString(), flag2);
		}
		return gClass;
	}
}
