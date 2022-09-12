using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class ADB5C0658
{
	private BC94B3E09 BFD08EDEC;

	[CompilerGenerated]
	private string D62C935B2;

	[CompilerGenerated]
	private string EE0C9AF34;

	[CompilerGenerated]
	private DD3247535 E0252A82E;

	[CompilerGenerated]
	private Value E57085A58;

	[CompilerGenerated]
	private bool BA1432EC9;

	public string E5CC7F130
	{
		[CompilerGenerated]
		get
		{
			return D62C935B2;
		}
		[CompilerGenerated]
		protected set
		{
			D62C935B2 = value;
		}
	}

	public string D39A1F445
	{
		[CompilerGenerated]
		get
		{
			return EE0C9AF34;
		}
		[CompilerGenerated]
		protected set
		{
			EE0C9AF34 = value;
		}
	}

	public DD3247535 D6F9ACDFD
	{
		[CompilerGenerated]
		get
		{
			return E0252A82E;
		}
		[CompilerGenerated]
		set
		{
			E0252A82E = value;
		}
	}

	public IJdwpThread E41D59FB7 => D6F9ACDFD.D9B337BB0;

	public IJdwpStackFrame B5C668E48 => D6F9ACDFD.D1F321559;

	public Value FC3E9C6DA
	{
		[CompilerGenerated]
		get
		{
			return E57085A58;
		}
		[CompilerGenerated]
		set
		{
			E57085A58 = value;
		}
	}

	public virtual string F32AC590E
	{
		get
		{
			if (FC3E9C6DA != null)
			{
				return FC3E9C6DA.DisplayType();
			}
			return "unknown";
		}
	}

	public bool A0A6085FD
	{
		[CompilerGenerated]
		get
		{
			return BA1432EC9;
		}
		[CompilerGenerated]
		set
		{
			BA1432EC9 = value;
		}
	}

	public bool F2670EC3C
	{
		get
		{
			if (FC3E9C6DA != null)
			{
				return FC3E9C6DA.HasChildren;
			}
			return false;
		}
	}

	public ADB5C0658(string text, DD3247535 cxt)
	{
		E5CC7F130 = text;
		D39A1F445 = text;
		D6F9ACDFD = cxt;
		BFD08EDEC = null;
	}

	public ADB5C0658(string name, string text, ADB5C0658 context)
		: this(text, context.D6F9ACDFD)
	{
		D39A1F445 = name;
	}

	public ADB5C0658[] CF4481569()
	{
		if (FC3E9C6DA is ParentValue parentValue)
		{
			return parentValue.GetChildValues(this);
		}
		return null;
	}

	public void AF927A510()
	{
		BC94B3E09 bC94B3E = new F5E653472().A44AB4074(this);
		if (bC94B3E is CA49CB647)
		{
			FC3E9C6DA = bC94B3E.A4BA9D8ED(D6F9ACDFD);
			A0A6085FD = true;
		}
		else
		{
			BFD08EDEC = bC94B3E;
		}
	}

	public void B6FE9B085()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFD08EDEC == null)
		{
			throw new ComponentException(-2147467259);
		}
		try
		{
			FC3E9C6DA = BFD08EDEC.A4BA9D8ED(D6F9ACDFD);
		}
		catch (EEA8EDD4A eEA8EDD4A)
		{
			FC3E9C6DA = new A8926EF2A(eEA8EDD4A.Message);
			A0A6085FD = true;
		}
	}

	public virtual void D47B03E76(IJDbg E238D14B0)
	{
	}
}
