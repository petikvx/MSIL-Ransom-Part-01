#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public sealed class C1255198513
{
	private string m_C3554254475 = string.Empty;

	private bool m_C3554254475 = false;

	private bool m_C3904355907 = true;

	private bool m_C1255198513 = true;

	private bool m_C1908338681 = false;

	private bool m_C1037565863 = true;

	private bool m_C112844655 = true;

	private bool m_C2746444292 = true;

	private bool m_C2564639436 = false;

	private bool m_C3568589458 = true;

	private bool m_C4024072794 = false;

	private bool m_C1304234792 = false;

	private bool m_C1993550816 = false;

	private StringComparison m_C3554254475 = StringComparison.InvariantCultureIgnoreCase;

	private bool m_C985283518 = false;

	private bool m_C30677878 = true;

	private string m_C3904355907 = string.Empty;

	[DefaultValue("")]
	public string C3554254475
	{
		get
		{
			return this.m_C3554254475;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2517025534());
			}
			this.m_C3554254475 = value;
		}
	}

	[DefaultValue(false)]
	public bool C3904355907
	{
		get
		{
			return this.m_C3554254475;
		}
		set
		{
			this.m_C3554254475 = value;
		}
	}

	[DefaultValue(true)]
	public bool C1255198513
	{
		get
		{
			return this.m_C3904355907;
		}
		set
		{
			this.m_C3904355907 = value;
		}
	}

	[DefaultValue(true)]
	public bool C1908338681
	{
		get
		{
			return this.m_C1255198513;
		}
		set
		{
			this.m_C1255198513 = value;
		}
	}

	[DefaultValue(false)]
	public bool C1037565863
	{
		get
		{
			return this.m_C1908338681;
		}
		set
		{
			this.m_C1908338681 = value;
		}
	}

	[DefaultValue(true)]
	public bool C112844655
	{
		get
		{
			return this.m_C1037565863;
		}
		set
		{
			this.m_C1037565863 = value;
		}
	}

	[DefaultValue(true)]
	public bool C2746444292
	{
		get
		{
			return this.m_C112844655;
		}
		set
		{
			this.m_C112844655 = value;
		}
	}

	[DefaultValue(true)]
	public bool C2564639436
	{
		get
		{
			return this.m_C2746444292;
		}
		set
		{
			this.m_C2746444292 = value;
		}
	}

	[DefaultValue(false)]
	public bool C3568589458
	{
		get
		{
			return this.m_C2564639436;
		}
		set
		{
			this.m_C2564639436 = value;
		}
	}

	[DefaultValue(true)]
	public bool C4024072794
	{
		get
		{
			return this.m_C3568589458;
		}
		set
		{
			this.m_C3568589458 = value;
		}
	}

	[DefaultValue(false)]
	public bool C1304234792
	{
		get
		{
			return this.m_C4024072794;
		}
		set
		{
			this.m_C4024072794 = value;
		}
	}

	[DefaultValue(false)]
	public bool C1993550816
	{
		get
		{
			return this.m_C1304234792;
		}
		set
		{
			this.m_C1304234792 = value;
		}
	}

	[DefaultValue(false)]
	public bool C985283518
	{
		get
		{
			return this.m_C1993550816;
		}
		set
		{
			this.m_C1993550816 = value;
		}
	}

	[DefaultValue(false)]
	public bool C30677878
	{
		get
		{
			return this.m_C985283518;
		}
		set
		{
			this.m_C985283518 = value;
		}
	}

	[DefaultValue(true)]
	public bool C2852464175
	{
		get
		{
			return this.m_C30677878;
		}
		set
		{
			this.m_C30677878 = value;
		}
	}

	[DefaultValue("")]
	public string C2439710439
	{
		get
		{
			return this.m_C3904355907;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2517025534());
			}
			this.m_C3904355907 = value;
		}
	}

	[XmlIgnore]
	public static C1255198513 C3707901625
	{
		get
		{
			C1255198513 c = new C1255198513();
			Debug.Assert(c.m_C3554254475.Length == 0);
			Debug.Assert(!c.m_C3554254475);
			c.m_C3904355907 = false;
			c.m_C1255198513 = false;
			Debug.Assert(!c.m_C1908338681);
			c.m_C1037565863 = false;
			c.m_C112844655 = false;
			c.m_C2746444292 = false;
			Debug.Assert(!c.m_C2564639436);
			c.m_C3568589458 = false;
			Debug.Assert(!c.m_C4024072794);
			Debug.Assert(!c.m_C1304234792);
			Debug.Assert(!c.m_C1993550816);
			Debug.Assert(!c.m_C985283518);
			Debug.Assert(c.m_C30677878);
			return c;
		}
	}

	[SpecialName]
	public StringComparison C30677878()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public void C3554254475(StringComparison stringComparison_0)
	{
		this.m_C3554254475 = stringComparison_0;
	}

	public C1255198513 C1141589763()
	{
		return (C1255198513)MemberwiseClone();
	}
}
