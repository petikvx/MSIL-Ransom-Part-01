using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _4
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0022, IL_01a9, IL_01ae, IL_01b1, IL_01b7, IL_01c2, IL_01c8, IL_01cc, IL_01d2, IL_01d7
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Incompatible stack heights: 0 vs 1
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Incompatible stack heights: 1 vs 2
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Incompatible stack heights: 0 vs 1
		//IL_01cd: Incompatible stack heights: 1 vs 0
		//IL_01d2: Incompatible stack heights: 0 vs 1
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		lock (_4.m__0020)
		{
			int num = _0020 ^ 0x149798D5;
			if (_4.m__0020 != null && _4.m__0020.ContainsKey(num))
			{
				return _4.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("4bd3254ccb6a41e9ba20a46509767ae1"))
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
				num2 ^= 0x42C00893;
			}
			int num5 = _0002 ^ 0x160121F4;
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
			if (_4.m__0020 == null)
			{
				_4.m__0020 = new Dictionary<int, string>();
			}
			_4.m__0020.Add(num, @string);
			return @string;
		}
	}
}
