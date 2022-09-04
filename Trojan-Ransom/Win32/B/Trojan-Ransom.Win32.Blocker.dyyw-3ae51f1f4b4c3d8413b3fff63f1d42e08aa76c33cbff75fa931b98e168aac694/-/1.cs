using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _1
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0005, IL_001a, IL_0021, IL_019d, IL_01a2, IL_01a8, IL_01ac, IL_01b2, IL_01b8, IL_01bd, IL_01c4, IL_01ca
		//IL_000f: Incompatible stack heights: 1 vs 0
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Incompatible stack heights: 1 vs 0
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Incompatible stack heights: 0 vs 1
		//IL_01ce: Expected O, but got I4
		lock (_1.m__0020)
		{
			int num = _0020 ^ 0x31C0A350;
			if (_1.m__0020 != null && _1.m__0020.ContainsKey(num))
			{
				return _1.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("8784f44c712e4c02b3561e79c18842c2"))
			{
				array = new byte[stream.Length];
				stream.Read(array, 0, Convert.ToInt32(stream.Length));
			}
			int num2 = _0001;
			byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length == 8)
			{
				int num3 = BitConverter.ToInt32(publicKeyToken, 0);
				int num4 = BitConverter.ToInt32(publicKeyToken, 4);
				num2 ^= num3 ^ num4;
			}
			else
			{
				num2 ^= 0x5F8E6AC4;
			}
			int num5 = _0002 ^ 0x51484976;
			byte[] array2 = new byte[num5];
			int num6 = 0;
			for (int i = num2; i < num2 + num5; i++)
			{
				array2[num6++] = array[i];
			}
			byte[] array3 = new byte[num5];
			Random random = new Random(num);
			random.NextBytes(array3);
			for (int j = 0; j < num5; j++)
			{
				array2[j] ^= array3[j];
			}
			string @string = Encoding.Unicode.GetString(array2);
			if (_1.m__0020 == null)
			{
				_1.m__0020 = new Dictionary<int, string>();
			}
			_1.m__0020.Add(num, @string);
			return @string;
		}
	}
}
