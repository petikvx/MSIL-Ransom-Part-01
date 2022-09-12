using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

public abstract class FD2C728AB : Value
{
	protected IJdwpReferenceType _referenceType;

	protected IJDbg _jdbg;

	protected string _displayType;

	[CompilerGenerated]
	private IJdwpValue D8CD954E4;

	[CompilerGenerated]
	private string B454AD522;

	public F18024EA9 F10784487 => F18024EA9.Object;

	protected IJdwpValue CF06FB109
	{
		[CompilerGenerated]
		get
		{
			return D8CD954E4;
		}
		[CompilerGenerated]
		set
		{
			D8CD954E4 = value;
		}
	}

	public string C78736E72
	{
		[CompilerGenerated]
		get
		{
			return B454AD522;
		}
		[CompilerGenerated]
		protected set
		{
			B454AD522 = value;
		}
	}

	public bool B4BCB5BA9 => true;

	public long A5CC0F68A => CF06FB109.AsObject();

	public string B19B53047()
	{
		if (_displayType == null)
		{
			_displayType = F63D7E302().get_DisplaySignature();
		}
		return _displayType;
	}

	public void CE93796A6(string C1983D501)
	{
		_displayType = C1983D501;
	}

	public IJdwpReferenceType F63D7E302()
	{
		if (_referenceType == null)
		{
			_referenceType = _jdbg.GetReferenceType(CF06FB109.AsObject());
		}
		return _referenceType;
	}

	protected void SetReferenceType(IJdwpReferenceType t)
	{
		_referenceType = t;
	}

	public FD2C728AB(IJDbg jdbg, IJdwpValue value)
	{
		_jdbg = jdbg;
		CF06FB109 = value;
	}
}
