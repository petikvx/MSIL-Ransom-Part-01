using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DxvkMwgEM7WAT7inmO;

[StandardModule]
internal sealed class NkH8ra4bJhMdgCmuso
{
	public static string Bc3HrO8Hlo(string string_0)
	{
		checked
		{
			string result = default(string);
			int num2 = default(int);
			while (true)
			{
				string text = null;
				while (true)
				{
					while (true)
					{
						IL_00a2:
						int num = 0;
						while (true)
						{
							IL_0097:
							int length = string_0.Length;
							while (true)
							{
								if (num < length)
								{
									string text2 = Conversions.ToString(string_0[num]);
									_ = 1;
									if (EoMVFhIzfUPQhMEYIaU())
									{
										if (!LnGORRIlJX34kYUgbt6())
										{
											break;
										}
										switch (1)
										{
										case 4:
										case 7:
											break;
										default:
											goto IL_006f;
										case 1:
										case 6:
											goto IL_0084;
										case 3:
											continue;
										case 5:
											goto IL_0097;
										case 8:
											goto IL_00a2;
										case 2:
											goto end_IL_008a;
										case 0:
											goto end_IL_00a8;
										case 9:
											goto IL_00b1;
										case 11:
											return result;
										}
									}
									num2 = Strings.AscW(text2) - 107;
									goto IL_006f;
								}
								goto IL_00b1;
								IL_00b1:
								return text;
								IL_006f:
								string text3 = (string)fEBN97UmW8jB1WAT81x(Strings.ChrW(num2));
								text += text3;
								goto IL_0084;
								IL_0084:
								num++;
								continue;
								end_IL_008a:
								break;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_00a8:
					break;
				}
			}
		}
	}

	internal static object fEBN97UmW8jB1WAT81x(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	internal static bool LnGORRIlJX34kYUgbt6()
	{
		return true;
	}

	internal static bool EoMVFhIzfUPQhMEYIaU()
	{
		return false;
	}
}
