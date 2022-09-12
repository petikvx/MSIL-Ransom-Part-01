using System;
using System.Text;
using MySql.Data.MySqlClient.Authentication;
using MySqlX.XDevAPI;

namespace MySqlX.Security;

internal class MySQL41AuthenticationPlugin : MySqlNativePasswordPlugin
{
	private MySqlXConnectionStringBuilder _settings;

	public override string PluginName => "MySQL 4.1 Authentication Plugin";

	public string AuthName => "MYSQL41";

	public MySQL41AuthenticationPlugin(MySqlXConnectionStringBuilder settings)
	{
		_settings = settings;
	}

	public byte[] Continue(byte[] salt)
	{
		Encoding encoding = Encoding.GetEncoding("utf-8");
		byte[] bytes = encoding.GetBytes(_settings.UserID);
		byte[] bytes2 = encoding.GetBytes(_settings.Database);
		byte[] array = new byte[0];
		byte[] array2 = new byte[0];
		if (!string.IsNullOrWhiteSpace(_settings.Password))
		{
			array = Get411Password(_settings.Password, salt);
			Array.Copy(array, 1, array, 0, array.Length - 1);
			Array.Resize(ref array, array.Length - 1);
			array2 = encoding.GetBytes(string.Format("*{0}", BitConverter.ToString(array).Replace("-", string.Empty)));
		}
		byte[] array3 = new byte[bytes2.Length + bytes.Length + array2.Length + 2];
		bytes2.CopyTo(array3, 0);
		int num = bytes2.Length;
		array3[num++] = 0;
		bytes.CopyTo(array3, num);
		num += bytes.Length;
		array3[num++] = 0;
		array2.CopyTo(array3, num);
		return array3;
	}
}
