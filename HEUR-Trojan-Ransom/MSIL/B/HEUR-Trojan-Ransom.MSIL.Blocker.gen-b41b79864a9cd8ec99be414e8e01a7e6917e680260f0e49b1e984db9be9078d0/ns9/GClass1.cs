using System.Runtime.CompilerServices;

namespace ns9;

public class GClass1
{
	private int D;

	[CompilerGenerated]
	private string Y;

	internal string U;

	internal int h;

	internal int R;

	public int StudentID
	{
		get
		{
			return D;
		}
		set
		{
			D = Value;
		}
	}

	public string StudentName
	{
		get
		{
			return U;
		}
		set
		{
			string text = (U = StringValue);
		}
	}

	public int Age
	{
		get
		{
			return h;
		}
		set
		{
			int num = (h = Value);
		}
	}

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return R;
		}
		[CompilerGenerated]
		private set
		{
			int num = (R = value);
		}
	}

	public string StringValue
	{
		[CompilerGenerated]
		get
		{
			return Y;
		}
		[CompilerGenerated]
		private set
		{
			Y = value;
		}
	}
}
