namespace U;

internal sealed class J
{
	public static void A()
	{
		//IL_0002: Expected O, but got I4
		//IL_000c: Expected O, but got I4
		//IL_001b: Expected O, but got I4
		string text = (string)0;
		do
		{
			if ((nint)text == 1)
			{
				C.s();
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 2);
	}
}
