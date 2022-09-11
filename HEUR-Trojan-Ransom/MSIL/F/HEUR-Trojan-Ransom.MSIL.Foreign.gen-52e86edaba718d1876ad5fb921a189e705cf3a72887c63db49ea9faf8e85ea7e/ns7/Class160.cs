using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns20;
using ns21;
using ns26;
using ns4;
using ns5;
using ns6;

namespace ns7;

internal sealed class Class160 : Class159
{
	[NonSerialized]
	internal static GetString getString_1;

	public Class160(Class139 class139_1)
		: base(class139_1)
	{
	}

	protected override Class176 vmethod_10()
	{
		Class176 @class = base.vmethod_10();
		object[][] object_ = new object[5][]
		{
			new object[3]
			{
				getString_1(107350917),
				2,
				3
			},
			new object[3]
			{
				getString_1(107350908),
				3,
				4
			},
			new object[3]
			{
				getString_1(107350923),
				5,
				1
			},
			new object[3]
			{
				getString_1(107350382),
				4,
				3
			},
			new object[3]
			{
				getString_1(107350333),
				2,
				4
			}
		};
		Class159.smethod_6(@class, object_);
		return @class;
	}

	protected override Class176 vmethod_11()
	{
		Class176 @class = base.vmethod_11();
		object[][] object_ = new object[20][]
		{
			new object[4]
			{
				getString_1(107350923),
				getString_1(107350352),
				getString_1(107398265),
				0
			},
			new object[4]
			{
				getString_1(107350923),
				getString_1(107391430),
				getString_1(107398265),
				1
			},
			new object[4]
			{
				getString_1(107350923),
				getString_1(107391454),
				getString_1(107398265),
				2
			},
			new object[4]
			{
				getString_1(107350923),
				getString_1(107391495),
				getString_1(107398265),
				3
			},
			new object[4]
			{
				getString_1(107350923),
				getString_1(107351044),
				getString_1(107398265),
				4
			},
			new object[4]
			{
				getString_1(107350382),
				getString_1(107350352),
				getString_1(107398265),
				0
			},
			new object[4]
			{
				getString_1(107350382),
				getString_1(107391430),
				getString_1(107398265),
				1
			},
			new object[4]
			{
				getString_1(107350382),
				getString_1(107391454),
				getString_1(107398265),
				2
			},
			new object[4]
			{
				getString_1(107350382),
				getString_1(107391495),
				getString_1(107398265),
				3
			},
			new object[4]
			{
				getString_1(107350917),
				getString_1(107350352),
				getString_1(107398265),
				0
			},
			new object[4]
			{
				getString_1(107350917),
				getString_1(107391430),
				getString_1(107398265),
				1
			},
			new object[4]
			{
				getString_1(107350917),
				getString_1(107391428),
				getString_1(107398265),
				2
			},
			new object[4]
			{
				getString_1(107350908),
				getString_1(107350352),
				getString_1(107398265),
				0
			},
			new object[4]
			{
				getString_1(107350908),
				getString_1(107391430),
				getString_1(107398265),
				1
			},
			new object[4]
			{
				getString_1(107350908),
				getString_1(107391428),
				getString_1(107398265),
				2
			},
			new object[4]
			{
				getString_1(107350908),
				getString_1(107410585),
				getString_1(107398265),
				3
			},
			new object[4]
			{
				getString_1(107350333),
				getString_1(107350352),
				getString_1(107398265),
				0
			},
			new object[4]
			{
				getString_1(107350333),
				getString_1(107391430),
				getString_1(107398265),
				1
			},
			new object[4]
			{
				getString_1(107350333),
				getString_1(107391454),
				getString_1(107398265),
				2
			},
			new object[4]
			{
				getString_1(107350333),
				getString_1(107350307),
				getString_1(107398265),
				3
			}
		};
		Class159.smethod_6(@class, object_);
		return @class;
	}

	public override Class176 vmethod_1(string[] string_1)
	{
		Class176 obj = method_16(string_3: new string[1] { getString_1(107350314) }, string_1: getString_1(107350265), string_2: getString_1(107398265), string_4: string_1);
		obj.Columns[1].Name = getString_1(107350284);
		obj.Name = getString_1(107350231);
		return obj;
	}

	public override Class176 vmethod_2(string[] string_1)
	{
		Class176 obj = method_16(string_3: new string[4]
		{
			getString_1(107350250),
			getString_1(107350229),
			getString_1(107350180),
			getString_1(107350195)
		}, string_1: getString_1(107350146), string_2: getString_1(107350137), string_4: string_1);
		obj.Name = getString_1(107350620);
		return obj;
	}

	public override Class176 vmethod_3(string[] string_1)
	{
		Class176 @class = method_16(string_3: new string[4]
		{
			getString_1(107350250),
			getString_1(107350229),
			getString_1(107350180),
			getString_1(107350643)
		}, string_1: getString_1(107350594), string_2: null, string_4: string_1);
		@class.method_2(getString_1(107350613));
		@class.Name = getString_1(107350580);
		method_0(@class);
		return @class;
	}

	private Class176 method_8(string[] string_1)
	{
		Class176 obj = method_16(string_3: new string[3]
		{
			getString_1(107350250),
			getString_1(107350229),
			getString_1(107350180)
		}, string_1: getString_1(107350567), string_2: null, string_4: string_1);
		obj.Name = getString_1(107350917);
		return obj;
	}

	private Class176 method_9(string[] string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder(getString_1(107350526));
		stringBuilder2.Append(getString_1(107350465));
		stringBuilder2.Append(getString_1(107350452));
		if (string_1 != null && string_1.Length >= 2 && string_1[1] != null)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349823), new object[1] { string_1[1] });
		}
		if (string_1 != null && string_1.Length >= 3 && string_1[2] != null)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(getString_1(107349794));
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349785), new object[1] { string_1[2] });
		}
		if (string_1 != null && string_1.Length == 4 && string_1[3] != null)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(getString_1(107349794));
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349756), new object[1] { string_1[3] });
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder2.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349727), new object[1] { stringBuilder });
		}
		Class176 @class = method_17(stringBuilder2.ToString());
		@class.Name = getString_1(107350908);
		@class.Columns[0].Name = getString_1(107349742);
		@class.Columns[1].Name = getString_1(107349693);
		@class.Columns[2].Name = getString_1(107349708);
		method_0(@class);
		return @class;
	}

	private Class176 method_10(string[] string_1)
	{
		Class176 obj = method_16(string_3: new string[4]
		{
			getString_1(107349663),
			getString_1(107349674),
			getString_1(107349653),
			getString_1(107350108)
		}, string_1: getString_1(107350123), string_2: null, string_4: string_1);
		obj.Name = getString_1(107350333);
		return obj;
	}

	public override Class176 vmethod_9(string[] string_1)
	{
		try
		{
			if (class139_0.Settings.HasProcAccess)
			{
				return base.vmethod_9(string_1);
			}
		}
		catch (MySqlException ex)
		{
			if (ex.Number != 1142)
			{
				throw;
			}
			class139_0.Settings.HasProcAccess = false;
		}
		Class176 obj = method_16(string_3: new string[4]
		{
			getString_1(107350078),
			getString_1(107350089),
			getString_1(107350068),
			getString_1(107350019)
		}, string_1: getString_1(107350034), string_2: null, string_4: string_1);
		obj.Name = getString_1(107350382);
		return obj;
	}

	private Class176 method_11(string[] string_1)
	{
		Class176 @class = vmethod_9(string_1);
		@class.method_0(getString_1(107349989), typeof(string));
		foreach (Class177 row in @class.Rows)
		{
			row[getString_1(107349989)] = method_12(row);
		}
		return @class;
	}

	private string method_12(Class177 class177_0)
	{
		using Class142 @class = new MySqlCommand(string.Format(getString_1(107350000), class177_0[getString_1(107350019)], class177_0[getString_1(107350089)], class177_0[getString_1(107350068)]), class139_0).method_6();
		@class.Read();
		if (@class.IsDBNull(2))
		{
			return null;
		}
		string @string = @class.GetString(1);
		string string2 = @class.GetString(2);
		Class127 class2 = new Class127(string2);
		class2.AnsiQuotes = @string.IndexOf(getString_1(107354413)) != -1;
		class2.BackslashEscapes = @string.IndexOf(getString_1(107354364)) == -1;
		string text = class2.method_1();
		while (text != getString_1(107409820))
		{
			text = class2.method_1();
		}
		int num = class2.StartIndex + 1;
		text = class2.method_1();
		while (text != getString_1(107409815) || class2.Quoted)
		{
			text = class2.method_1();
			if (text == getString_1(107409820) && !class2.Quoted)
			{
				while (text != getString_1(107409815) || class2.Quoted)
				{
					text = class2.method_1();
				}
				text = class2.method_1();
			}
		}
		return string2.Substring(num, class2.StartIndex - num);
	}

	private Class176 method_13(string[] string_1)
	{
		string[] string_2 = new string[5]
		{
			getString_1(107349963),
			getString_1(107349938),
			getString_1(107349885),
			getString_1(107350019),
			getString_1(107352079)
		};
		StringBuilder stringBuilder = new StringBuilder(getString_1(107349896));
		string text = smethod_8(null, string_2, string_1);
		if (!string.IsNullOrEmpty(text))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349727), new object[1] { text });
		}
		Class176 @class = method_7(getString_1(107382091), stringBuilder.ToString());
		if (@class.Rows.Count != 0 && (string)@class.Rows[0][getString_1(107382042)] == getString_1(107382057))
		{
			@class.Rows[0][getString_1(107382012)] = getString_1(107357285);
			@class.Rows[0][getString_1(107382023)] = getString_1(107382002);
		}
		return @class;
	}

	private Class176 method_14(string[] string_1, Class176 class176_0)
	{
		Class176 @class = null;
		if (class176_0 == null || class176_0.Rows.Count == 0)
		{
			@class = ((string_1 != null) ? method_13(string_1) : method_7(getString_1(107382091), getString_1(107381953)));
		}
		else
		{
			foreach (Class177 row in class176_0.Rows)
			{
				if (string_1 != null && string_1.Length >= 3)
				{
					string_1[2] = row[getString_1(107350068)].ToString();
				}
				@class = method_13(string_1);
			}
		}
		@class.Name = getString_1(107350923);
		return @class;
	}

	internal Class176 method_15()
	{
		Class176 @class = new Class176(getString_1(107350923));
		@class.method_0(getString_1(107349963), typeof(string));
		@class.method_0(getString_1(107349938), typeof(string));
		@class.method_0(getString_1(107349885), typeof(string));
		@class.method_0(getString_1(107352026), typeof(int));
		@class.method_0(getString_1(107351340), typeof(string));
		@class.method_0(getString_1(107352079), typeof(string));
		@class.method_0(getString_1(107351944), typeof(string));
		@class.method_0(getString_1(107351387), typeof(int));
		@class.method_0(getString_1(107350613), typeof(int));
		@class.method_0(getString_1(107351354), typeof(byte));
		@class.method_0(getString_1(107351329), typeof(int));
		@class.method_0(getString_1(107381880), typeof(string));
		@class.method_0(getString_1(107382367), typeof(string));
		@class.method_0(getString_1(107352012), typeof(string));
		@class.method_0(getString_1(107350019), typeof(string));
		return @class;
	}

	public virtual Class176 vmethod_14(string[] string_1, Class176 class176_0)
	{
		bool flag = class139_0.class143_0.Version.method_0(5, 5, 3);
		try
		{
			Class176 @class = method_15();
			method_18(@class, string_1, class176_0);
			return @class;
		}
		catch (Exception)
		{
			if (!flag)
			{
				throw;
			}
			return method_14(string_1, class176_0);
		}
	}

	protected override Class176 vmethod_13(string string_1, string[] string_2)
	{
		Class176 @class = base.vmethod_13(string_1, string_2);
		if (@class != null)
		{
			return @class;
		}
		if (!(string_1 == getString_1(107350567)))
		{
			if (!(string_1 == getString_1(107382378)))
			{
				if (!(string_1 == getString_1(107382329)))
				{
					if (!(string_1 == getString_1(107382324)))
					{
						if (!(string_1 == getString_1(107350123)))
						{
							if (!(string_1 == getString_1(107382263)))
							{
								return null;
							}
							return method_9(string_2);
						}
						return method_10(string_2);
					}
					return vmethod_14(string_2, null);
				}
				return method_11(string_2);
			}
			return vmethod_9(string_2);
		}
		return method_8(string_2);
	}

	private static string smethod_8(string string_1, string[] string_2, string[] string_3)
	{
		StringBuilder stringBuilder = new StringBuilder(string_1);
		if (string_3 != null)
		{
			for (int i = 0; i < string_2.Length && i < string_3.Length; i++)
			{
				if (string_3[i] != null && !(string_3[i] == string.Empty))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(getString_1(107382278));
					}
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107382237), new object[2]
					{
						string_2[i],
						string_3[i]
					});
				}
			}
		}
		return stringBuilder.ToString();
	}

	private Class176 method_16(string string_1, string string_2, string[] string_3, string[] string_4)
	{
		StringBuilder stringBuilder = new StringBuilder(getString_1(107382248));
		stringBuilder.Append(string_1);
		string text = smethod_8(string_2, string_3, string_4);
		if (text.Length > 0)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107349727), new object[1] { text });
		}
		return method_17(stringBuilder.ToString());
	}

	private Class176 method_17(string string_1)
	{
		Class176 @class = new Class176();
		Class142 class2 = new MySqlCommand(string_1, class139_0).method_6();
		for (int i = 0; i < class2.FieldCount; i++)
		{
			@class.method_0(class2.GetName(i), class2.GetFieldType(i));
		}
		using (class2)
		{
			while (class2.Read())
			{
				Class177 class3 = @class.method_4();
				for (int j = 0; j < class2.FieldCount; j++)
				{
					class3[j] = class2.GetValue(j);
				}
			}
			return @class;
		}
	}

	public override Class176 vmethod_6(string[] string_1)
	{
		if (!class139_0.class143_0.Version.method_0(5, 1, 16))
		{
			return base.vmethod_6(string_1);
		}
		string text = getString_1(107382171);
		StringBuilder stringBuilder = new StringBuilder();
		if (string_1.Length >= 2 && !string.IsNullOrEmpty(string_1[1]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107381237), new object[1] { string_1[1] });
		}
		if (string_1.Length >= 3 && !string.IsNullOrEmpty(string_1[2]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107381156), new object[1] { string_1[2] });
		}
		if (string_1.Length >= 4 && !string.IsNullOrEmpty(string_1[3]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107381115), new object[1] { string_1[2] });
		}
		text += stringBuilder.ToString();
		return method_17(text);
	}

	public override Class176 vmethod_7(string[] string_1)
	{
		if (!class139_0.class143_0.Version.method_0(5, 0, 6))
		{
			return base.vmethod_7(string_1);
		}
		string text = getString_1(107380586);
		StringBuilder stringBuilder = new StringBuilder();
		if (string_1.Length >= 2 && !string.IsNullOrEmpty(string_1[1]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107380424), new object[1] { string_1[1] });
		}
		if (string_1.Length >= 3 && !string.IsNullOrEmpty(string_1[2]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107380371), new object[1] { string_1[2] });
		}
		if (string_1.Length >= 4 && !string.IsNullOrEmpty(string_1[3]))
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107380842), new object[1] { string_1[3] });
		}
		text += stringBuilder.ToString();
		return method_17(text);
	}

	internal void method_18(Class176 class176_0, string[] string_1, Class176 class176_1)
	{
		if (class176_1 == null)
		{
			class176_1 = vmethod_0(getString_1(107380761), string_1);
		}
		MySqlCommand mySqlCommand = class139_0.method_5();
		foreach (Class177 row in class176_1.Rows)
		{
			string text2 = (mySqlCommand.CommandText = string.Format(getString_1(107350000), row[getString_1(107350019)], row[getString_1(107350089)], row[getString_1(107350068)]));
			try
			{
				string string_2 = null;
				if (string_1 != null && string_1.Length == 5 && string_1[4] != null)
				{
					string_2 = string_1[4];
				}
				using Class142 @class = mySqlCommand.method_6();
				@class.Read();
				string @string = @class.GetString(2);
				@class.Close();
				method_19(class176_0, @string, row, string_2);
			}
			catch (SqlNullValueException innerException)
			{
				throw new InvalidOperationException(string.Format(Class121.UnableToRetrieveParameters, row[getString_1(107350068)]), innerException);
			}
		}
	}

	private void method_19(Class176 class176_0, string string_1, Class177 class177_0, string string_2)
	{
		List<string> list = new List<string>(new string[3]
		{
			getString_1(107357285),
			getString_1(107351287),
			getString_1(107380776)
		});
		string text = class177_0[getString_1(107351978)].ToString();
		int num = 1;
		Class127 @class = new Class127(string_1);
		@class.AnsiQuotes = text.IndexOf(getString_1(107354413)) != -1;
		@class.BackslashEscapes = text.IndexOf(getString_1(107354364)) == -1;
		@class.ReturnComments = false;
		string text2 = @class.method_1();
		while (text2 != getString_1(107409820))
		{
			if (string.Compare(text2, getString_1(107382057), StringComparison.OrdinalIgnoreCase) == 0 && string_2 == null)
			{
				class176_0.method_4();
				smethod_9(class177_0, class176_0.Rows[0]);
			}
			text2 = @class.method_1();
		}
		text2 = @class.method_1();
		while (text2 != getString_1(107409815))
		{
			Class177 class2 = class176_0.method_5();
			smethod_9(class177_0, class2);
			class2[getString_1(107352026)] = num++;
			string text3 = Class135.smethod_0(text2);
			if (!@class.Quoted && list.Contains(text3))
			{
				class2[getString_1(107351340)] = text3;
				text2 = @class.method_1();
			}
			if (@class.Quoted)
			{
				text2 = text2.Substring(1, text2.Length - 2);
			}
			class2[getString_1(107352079)] = text2;
			text2 = method_20(class2, @class);
			if (text2 == getString_1(107405243))
			{
				text2 = @class.method_1();
			}
			if (string_2 == null || string.Compare(class2[getString_1(107352079)].ToString(), string_2, StringComparison.OrdinalIgnoreCase) == 0)
			{
				class176_0.Rows.Add(class2);
			}
		}
		text2 = Class135.smethod_0(@class.method_1());
		if (string.Compare(text2, getString_1(107380735), StringComparison.OrdinalIgnoreCase) == 0)
		{
			Class177 class3 = class176_0.Rows[0];
			class3[getString_1(107352079)] = getString_1(107380754);
			method_20(class3, @class);
		}
	}

	private static void smethod_9(Class177 class177_0, Class177 class177_1)
	{
		class177_1[getString_1(107349963)] = null;
		class177_1[getString_1(107349938)] = class177_0[getString_1(107350089)];
		class177_1[getString_1(107349885)] = class177_0[getString_1(107350068)];
		class177_1[getString_1(107351340)] = getString_1(107357285);
		class177_1[getString_1(107352026)] = 0;
		class177_1[getString_1(107350019)] = class177_0[getString_1(107350019)];
	}

	private string method_20(Class177 class177_0, Class127 class127_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class135.smethod_0(class127_0.method_1()));
		class177_0[getString_1(107351944)] = stringBuilder.ToString();
		string text = class177_0[getString_1(107351944)].ToString();
		string text2 = class127_0.method_1();
		if (text2 == getString_1(107409820))
		{
			text2 = class127_0.method_4();
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107358420), new object[1] { text2 });
			if (text != getString_1(107359588) && text != getString_1(107360137))
			{
				smethod_11(class177_0, text2);
			}
			text2 = class127_0.method_1();
		}
		else
		{
			stringBuilder.Append(smethod_10(text, class177_0));
		}
		while (text2 != getString_1(107409815) && text2 != getString_1(107405243) && string.Compare(text2, getString_1(107380635), StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(text2, getString_1(107380658), StringComparison.OrdinalIgnoreCase) != 0)
		{
			if (string.Compare(text2, getString_1(107380705), StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(text2, getString_1(107359448), StringComparison.OrdinalIgnoreCase) != 0)
			{
				if (string.Compare(text2, getString_1(107360137), StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(text2, getString_1(107380724), StringComparison.OrdinalIgnoreCase) != 0)
				{
					if (string.Compare(text2, getString_1(107380711), StringComparison.OrdinalIgnoreCase) == 0)
					{
						class177_0[getString_1(107381880)] = getString_1(107356538);
					}
					else if (string.Compare(text2, getString_1(107380670), StringComparison.OrdinalIgnoreCase) == 0)
					{
						class177_0[getString_1(107381880)] = getString_1(107356241);
					}
					else if (string.Compare(text2, getString_1(107380689), StringComparison.OrdinalIgnoreCase) == 0)
					{
						class177_0[getString_1(107382367)] = class127_0.method_1();
					}
					else
					{
						stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_1(107380644), new object[1] { text2 });
					}
				}
				else
				{
					class177_0[getString_1(107381880)] = class127_0.method_1();
				}
			}
			text2 = class127_0.method_1();
		}
		if (stringBuilder.Length > 0)
		{
			class177_0[getString_1(107352012)] = stringBuilder.ToString();
		}
		if (string.IsNullOrEmpty((string)class177_0[getString_1(107382367)]) && !string.IsNullOrEmpty((string)class177_0[getString_1(107381880)]))
		{
			class177_0[getString_1(107382367)] = Class137.smethod_5(class177_0[getString_1(107381880)].ToString(), class139_0);
		}
		if (class177_0[getString_1(107351387)] != null)
		{
			if (class177_0[getString_1(107381880)] == null)
			{
				class177_0[getString_1(107381880)] = getString_1(107398265);
			}
			class177_0[getString_1(107350613)] = Class137.smethod_6((string)class177_0[getString_1(107381880)], class139_0) * (int)class177_0[getString_1(107351387)];
		}
		return text2;
	}

	private static string smethod_10(string string_1, Class177 class177_0)
	{
		string format = getString_1(107380649);
		_ = class177_0[getString_1(107351354)];
		if (Class123.smethod_0(string_1) && string.IsNullOrEmpty((string)class177_0[getString_1(107351354)]))
		{
			class177_0[getString_1(107351354)] = 10;
			class177_0[getString_1(107351329)] = 0;
			if (!Class123.smethod_2(string_1))
			{
				format = getString_1(107357850);
			}
			return string.Format(format, class177_0[getString_1(107351354)], class177_0[getString_1(107351329)]);
		}
		return string.Empty;
	}

	private static void smethod_11(Class177 class177_0, string string_1)
	{
		string_1 = string_1.Trim('(', ')');
		string[] array = string_1.Split(new char[1] { ',' });
		if (!Class123.smethod_0(class177_0[getString_1(107351944)].ToString()))
		{
			class177_0[getString_1(107351387)] = int.Parse(array[0]);
			return;
		}
		class177_0[getString_1(107351354)] = int.Parse(array[0]);
		if (array.Length == 2)
		{
			class177_0[getString_1(107351329)] = int.Parse(array[1]);
		}
	}

	static Class160()
	{
		Strings.CreateGetStringDelegate(typeof(Class160));
	}
}
