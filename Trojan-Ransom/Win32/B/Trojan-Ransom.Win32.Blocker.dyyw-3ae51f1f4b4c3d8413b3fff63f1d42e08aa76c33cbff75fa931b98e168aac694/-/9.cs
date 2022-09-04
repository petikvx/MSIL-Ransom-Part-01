using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _9
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_000b, IL_0017, IL_0028, IL_01a4, IL_01a9, IL_01ac, IL_01b2, IL_01b6, IL_01bb, IL_01c1
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_001e: Incompatible stack heights: 1 vs 0
		//IL_0029: Incompatible stack heights: 0 vs 1
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Incompatible stack heights: 1 vs 0
		//IL_01b6: Incompatible stack heights: 0 vs 1
		//IL_01bc: Incompatible stack heights: 1 vs 0
		lock (_9.m__0020)
		{
			int num = _0020 ^ 0x48C24A32;
			if (_9.m__0020 != null && _9.m__0020.ContainsKey(num))
			{
				return _9.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("8e684e881a784830b2b122da628b18a5"))
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
				num2 ^= 0x50564919;
			}
			int num5 = _0002 ^ 0x4B6EDC5;
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
			if (_9.m__0020 == null)
			{
				_9.m__0020 = new Dictionary<int, string>();
			}
			_9.m__0020.Add(num, @string);
			return @string;
		}
	}
}
