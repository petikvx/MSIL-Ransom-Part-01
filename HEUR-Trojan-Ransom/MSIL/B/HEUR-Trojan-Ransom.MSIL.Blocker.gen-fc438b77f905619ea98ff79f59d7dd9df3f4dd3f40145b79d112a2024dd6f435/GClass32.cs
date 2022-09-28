using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

[DataContract]
public class GClass32
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double double_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double double_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_10;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_11;

	[DataMember(Name = "as")]
	public string String_0
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007, IL_0011, IL_0016, IL_001c, IL_0021, IL_0026
			//IL_0017: Incompatible stack heights: 0 vs 1
			/*Error near IL_0002: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	[DataMember(Name = "city")]
	public extern string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "country")]
	public extern string String_2
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "countryCode")]
	public extern string String_3
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "isp")]
	public unsafe string String_4
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0010
			//IL_0003: Expected native int or pointer, but got F8
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected F8, but got I4
			//IL_001c: Expected O, but got F4
			ulong num = (nuint)(nint)(*(float*)(nint)(double)/*Error near IL_0001: Stack underflow*/);
			int num2 = *(int*)(*(short*)(nint)checked(/*Error near IL_0007: Stack underflow*/ * num));
			_ = ((int[])/*Error near IL_000b: Stack underflow*/)[num2];
			/*Error near IL_000b: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
			_ = -5.705528E-32f;
		}
	}

	[DataMember(Name = "lat")]
	public double Double_0
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_000d, IL_0014, IL_001f, IL_0020
			//IL_0010: Expected O, but got I4
			//IL_001a: Invalid comparison between Unknown and I4
			/*Error: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "lon")]
	public extern double Double_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "org")]
	public string String_5
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_000a, IL_000f
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected F4, but got Unknown
			_ = 5.3209867E-11f;
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	[DataMember(Name = "query")]
	public extern string String_6
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "region")]
	public string String_7
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007, IL_0015
			//IL_0009: Expected F4, but got I4
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected I4, but got Unknown
			//IL_0015: Unsupported input type for neg.
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got I4
			/*Error near IL_0002: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "regionName")]
	public extern string String_8
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "status")]
	public extern string String_9
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "timezone")]
	public extern string String_10
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DataMember(Name = "zip")]
	public extern string String_11
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public GClass32()
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0015, IL_0039, IL_003f
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got I8
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}
}
