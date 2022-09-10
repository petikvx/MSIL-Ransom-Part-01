public class _003F90_003F
{
	public _003F90_003F()
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static string _003F91_003F(string _003F91_003F)
	{
		//IL_005b: Incompatible stack heights: 0 vs 1
		int length = _003F91_003F.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = _003F91_003F[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		new string(array);
		return string.Intern((string)/*Error near IL_004a: Stack underflow*/);
	}
}
