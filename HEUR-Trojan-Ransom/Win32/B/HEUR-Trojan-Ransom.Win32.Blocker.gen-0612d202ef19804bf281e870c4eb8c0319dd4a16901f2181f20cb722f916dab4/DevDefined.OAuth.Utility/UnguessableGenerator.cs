using System;

namespace DevDefined.OAuth.Utility;

public class UnguessableGenerator
{
	private const string AllowableCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/^()";

	public static string GenerateUnguessable(int length)
	{
		Random random = new Random();
		char[] array = new char[length];
		int length2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/^()".Length;
		for (int i = 0; i < length; i++)
		{
			array[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/^()"[random.Next(length2)];
		}
		return new string(array);
	}

	public static string GenerateUnguessable()
	{
		return GenerateUnguessable(24);
	}
}
