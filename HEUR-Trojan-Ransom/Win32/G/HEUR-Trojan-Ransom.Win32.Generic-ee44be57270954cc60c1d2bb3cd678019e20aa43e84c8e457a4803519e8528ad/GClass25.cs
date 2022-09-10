using System.Collections.Generic;

public abstract class GClass25
{
	protected ushort ushort_0;

	protected ushort ushort_1;

	protected GEnum5 genum5_0;

	protected GEnum6 genum6_0;

	protected GEnum7 genum7_0;

	protected GEnum8 genum8_0;

	protected ushort ushort_2;

	protected ushort ushort_3;

	protected ushort ushort_4;

	protected string string_0;

	protected GEnum2 genum2_0;

	protected GEnum4 genum4_0;

	protected List<GInterface0> list_0 = new List<GInterface0>();

	public ushort UInt16_0 => ushort_0;

	public GEnum5 GEnum5_0 => genum5_0;

	public GEnum6 GEnum6_0 => genum6_0;

	public GEnum7 GEnum7_0 => genum7_0;

	public GEnum8 GEnum8_0 => genum8_0;

	public ushort UInt16_1 => ushort_2;

	public ushort UInt16_2 => ushort_3;

	public ushort UInt16_3 => ushort_4;

	public ushort UInt16_4 => (ushort)list_0.Count;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public GEnum2 GEnum2_0
	{
		get
		{
			return genum2_0;
		}
		set
		{
			genum2_0 = value;
		}
	}

	public GEnum4 GEnum4_0
	{
		get
		{
			return genum4_0;
		}
		set
		{
			genum4_0 = value;
		}
	}

	public List<GInterface0> List_0 => list_0;
}
