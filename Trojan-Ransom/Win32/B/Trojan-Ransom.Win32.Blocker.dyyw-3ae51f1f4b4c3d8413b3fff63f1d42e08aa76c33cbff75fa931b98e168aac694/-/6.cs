using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _6
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0005, IL_0013, IL_001c, IL_019c, IL_01a1, IL_01a4, IL_01aa, IL_01b2, IL_01b8, IL_01be, IL_01c3
		//IL_000e: Incompatible stack heights: 1 vs 0
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Incompatible stack heights: 0 vs 1
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Incompatible stack heights: 0 vs 1
		//IL_01be: Incompatible stack heights: 1 vs 0
		lock (_6.m__0020)
		{
			int num = _0020 ^ 0x70F2E30B;
			if (_6.m__0020 != null && _6.m__0020.ContainsKey(num))
			{
				return _6.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("5f02c8ea141d4899a386c0c620fa4838"))
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
				num2 ^= 0x47A556E8;
			}
			int num5 = _0002 ^ 0x26B740D0;
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
			if (_6.m__0020 == null)
			{
				_6.m__0020 = new Dictionary<int, string>();
			}
			_6.m__0020.Add(num, @string);
			return @string;
		}
	}
}
