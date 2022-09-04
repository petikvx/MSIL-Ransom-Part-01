using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _2
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0011, IL_0021, IL_019f, IL_01a4, IL_01ac, IL_01b2, IL_01b5, IL_01bb, IL_01c1, IL_01c6, IL_01cc
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Incompatible stack heights: 0 vs 1
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Incompatible stack heights: 2 vs 1
		//IL_01c1: Incompatible stack heights: 0 vs 2
		//IL_01c7: Incompatible stack heights: 1 vs 0
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got I
		lock (_2.m__0020)
		{
			int num = _0020 ^ 0x4BE78E42;
			if (_2.m__0020 != null && _2.m__0020.ContainsKey(num))
			{
				return _2.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("5579f7d43a7e4dda9a1a52eec8682bce"))
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
				num2 ^= 0x4571F1E1;
			}
			int num5 = _0002 ^ 0x52D9E686;
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
			if (_2.m__0020 == null)
			{
				_2.m__0020 = new Dictionary<int, string>();
			}
			_2.m__0020.Add(num, @string);
			return @string;
		}
	}
}
