using System.Runtime.CompilerServices;
using System.Text;

namespace ns6;

internal sealed class Class12
{
	[CompilerGenerated]
	private ulong ulong_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private ulong ulong_1;

	[CompilerGenerated]
	private string string_2;

	internal Class12(string string_3)
	{
		method_5(string_3);
		method_3(string.Empty);
		method_9(string.Empty);
		method_1(0uL);
		method_7(0uL);
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_0()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(ulong ulong_2)
	{
		ulong_0 = ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(string string_3)
	{
		string_0 = string_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_4()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_5(string string_3)
	{
		string_1 = string_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_6()
	{
		return ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(ulong ulong_2)
	{
		ulong_1 = ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_8()
	{
		return string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(string string_3)
	{
		string_2 = string_3;
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(method_4());
		stringBuilder.Append(" ");
		stringBuilder.Append(method_8());
		stringBuilder.Append(" (");
		stringBuilder.Append(method_2());
		stringBuilder.Append(") ");
		stringBuilder.Append(method_10(method_0()));
		stringBuilder.Append(" free of ");
		stringBuilder.Append(method_10(method_6()));
		return stringBuilder.ToString();
	}

	private string method_10(ulong ulong_2)
	{
		string text = null;
		if (ulong_2 < 1024L)
		{
			return $"{ulong_2} Bytes";
		}
		if (ulong_2 < 1024000L)
		{
			ulong_2 /= 1024uL;
			return string.Format("{0} KB", ulong_2.ToString("N"));
		}
		if (ulong_2 < 1024000000L)
		{
			return string.Format("{0} MB", ((double)(ulong_2 / 1024000uL)).ToString("N1"));
		}
		return string.Format("{0} GB", ((double)(ulong_2 / 1024000000uL)).ToString("N1"));
	}
}
