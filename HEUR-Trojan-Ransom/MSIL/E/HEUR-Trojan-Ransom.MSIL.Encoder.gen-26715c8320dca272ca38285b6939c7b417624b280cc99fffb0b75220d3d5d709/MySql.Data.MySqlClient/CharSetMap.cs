using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class CharSetMap
{
	private static Dictionary<string, string> _defaultCollations;

	private static Dictionary<string, int> _maxLengths;

	private static Dictionary<string, CharacterSet> _mapping;

	private static readonly object LockObject;

	static CharSetMap()
	{
		LockObject = new object();
		InitializeMapping();
	}

	public static CharacterSet GetCharacterSet(DBVersion version, string charSetName)
	{
		if (charSetName == null)
		{
			throw new ArgumentNullException("CharSetName is null");
		}
		CharacterSet characterSet = null;
		if (_mapping.ContainsKey(charSetName))
		{
			characterSet = _mapping[charSetName];
		}
		if (characterSet == null)
		{
			throw new NotSupportedException("Character set '" + charSetName + "' is not supported by .Net Framework.");
		}
		return characterSet;
	}

	public static Encoding GetEncoding(DBVersion version, string charSetName)
	{
		try
		{
			return Encoding.GetEncoding(GetCharacterSet(version, charSetName).name);
		}
		catch (ArgumentException)
		{
			return Encoding.GetEncoding("utf-8");
		}
		catch (NotSupportedException)
		{
			return Encoding.GetEncoding("utf-8");
		}
	}

	private static void InitializeMapping()
	{
		LoadCharsetMap();
	}

	private static void LoadCharsetMap()
	{
		_mapping = new Dictionary<string, CharacterSet>();
		_mapping.Add("latin1", new CharacterSet("windows-1252", 1));
		_mapping.Add("big5", new CharacterSet("big5", 2));
		_mapping.Add("dec8", _mapping["latin1"]);
		_mapping.Add("cp850", new CharacterSet("ibm850", 1));
		_mapping.Add("hp8", _mapping["latin1"]);
		_mapping.Add("koi8r", new CharacterSet("koi8-u", 1));
		_mapping.Add("latin2", new CharacterSet("latin2", 1));
		_mapping.Add("swe7", _mapping["latin1"]);
		_mapping.Add("ujis", new CharacterSet("EUC-JP", 3));
		_mapping.Add("eucjpms", _mapping["ujis"]);
		_mapping.Add("sjis", new CharacterSet("sjis", 2));
		_mapping.Add("cp932", _mapping["sjis"]);
		_mapping.Add("hebrew", new CharacterSet("hebrew", 1));
		_mapping.Add("tis620", new CharacterSet("windows-874", 1));
		_mapping.Add("euckr", new CharacterSet("euc-kr", 2));
		_mapping.Add("euc_kr", _mapping["euckr"]);
		_mapping.Add("koi8u", new CharacterSet("koi8-u", 1));
		_mapping.Add("koi8_ru", _mapping["koi8u"]);
		_mapping.Add("gb2312", new CharacterSet("gb2312", 2));
		_mapping.Add("gbk", _mapping["gb2312"]);
		_mapping.Add("greek", new CharacterSet("greek", 1));
		_mapping.Add("cp1250", new CharacterSet("windows-1250", 1));
		_mapping.Add("win1250", _mapping["cp1250"]);
		_mapping.Add("latin5", new CharacterSet("latin5", 1));
		_mapping.Add("armscii8", _mapping["latin1"]);
		_mapping.Add("utf8", new CharacterSet("utf-8", 3));
		_mapping.Add("ucs2", new CharacterSet("UTF-16BE", 2));
		_mapping.Add("cp866", new CharacterSet("cp866", 1));
		_mapping.Add("keybcs2", _mapping["latin1"]);
		_mapping.Add("macce", new CharacterSet("x-mac-ce", 1));
		_mapping.Add("macroman", new CharacterSet("x-mac-romanian", 1));
		_mapping.Add("cp852", new CharacterSet("ibm852", 2));
		_mapping.Add("latin7", new CharacterSet("iso-8859-7", 1));
		_mapping.Add("cp1251", new CharacterSet("windows-1251", 1));
		_mapping.Add("win1251ukr", _mapping["cp1251"]);
		_mapping.Add("cp1251csas", _mapping["cp1251"]);
		_mapping.Add("cp1251cias", _mapping["cp1251"]);
		_mapping.Add("win1251", _mapping["cp1251"]);
		_mapping.Add("cp1256", new CharacterSet("cp1256", 1));
		_mapping.Add("cp1257", new CharacterSet("windows-1257", 1));
		_mapping.Add("ascii", new CharacterSet("us-ascii", 1));
		_mapping.Add("usa7", _mapping["ascii"]);
		_mapping.Add("binary", _mapping["ascii"]);
		_mapping.Add("latin3", new CharacterSet("latin3", 1));
		_mapping.Add("latin4", new CharacterSet("latin4", 1));
		_mapping.Add("latin1_de", new CharacterSet("iso-8859-1", 1));
		_mapping.Add("german1", new CharacterSet("iso-8859-1", 1));
		_mapping.Add("danish", new CharacterSet("iso-8859-1", 1));
		_mapping.Add("czech", new CharacterSet("iso-8859-2", 1));
		_mapping.Add("hungarian", new CharacterSet("iso-8859-2", 1));
		_mapping.Add("croat", new CharacterSet("iso-8859-2", 1));
		_mapping.Add("latvian", new CharacterSet("iso-8859-13", 1));
		_mapping.Add("latvian1", new CharacterSet("iso-8859-13", 1));
		_mapping.Add("estonia", new CharacterSet("iso-8859-13", 1));
		_mapping.Add("dos", new CharacterSet("ibm437", 1));
		_mapping.Add("utf8mb4", new CharacterSet("utf-8", 4));
		_mapping.Add("utf16", new CharacterSet("utf-16BE", 2));
		_mapping.Add("utf16le", new CharacterSet("utf-16", 2));
		_mapping.Add("utf32", new CharacterSet("utf-32BE", 4));
		_mapping.Add("gb18030", new CharacterSet("gb18030", 4));
	}

	internal static void InitCollections(MySqlConnection connection)
	{
		_defaultCollations = new Dictionary<string, string>();
		_maxLengths = new Dictionary<string, int>();
		using MySqlDataReader mySqlDataReader = new MySqlCommand("SHOW CHARSET", connection).ExecuteReader();
		while (mySqlDataReader.Read())
		{
			_defaultCollations.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(2));
			_maxLengths.Add(mySqlDataReader.GetString(0), Convert.ToInt32(mySqlDataReader.GetValue(3)));
		}
	}

	internal static string GetDefaultCollation(string charset, MySqlConnection connection)
	{
		lock (LockObject)
		{
			if (_defaultCollations == null)
			{
				InitCollections(connection);
			}
		}
		if (_defaultCollations.ContainsKey(charset))
		{
			return _defaultCollations[charset];
		}
		return null;
	}

	internal static int GetMaxLength(string charset, MySqlConnection connection)
	{
		lock (LockObject)
		{
			if (_maxLengths == null)
			{
				InitCollections(connection);
			}
		}
		if (_maxLengths.ContainsKey(charset))
		{
			return _maxLengths[charset];
		}
		return 1;
	}
}
