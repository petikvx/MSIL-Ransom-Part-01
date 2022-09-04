namespace DarthRevan;

public class Rotate
{
	private static byte[] pass = new byte[30]
	{
		98, 84, 35, 110, 60, 121, 111, 47, 38, 118,
		37, 95, 70, 83, 55, 78, 53, 116, 80, 40,
		75, 44, 107, 45, 49, 101, 111, 113, 73, 81
	};

	public static void RotateIt(ref byte[] input)
	{
		for (int i = 0; i < input.Length; i++)
		{
			input[i] = (byte)(input[i] ^ pass[i % pass.Length]);
		}
	}
}
