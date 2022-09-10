using System;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal abstract class ConfigurationProvider : IDisposable
{
	internal abstract ConfigurationProvider OpenKey(string subKey);

	internal abstract uint ReadUInt32(string name, uint defaultValue);

	internal abstract string ReadString(string name, string defaultValue);

	internal abstract string[] ReadMultiString(string name, string[] defaultValue);

	internal abstract void WriteUInt32(string name, uint value);

	internal abstract void WriteString(string name, string value);

	internal abstract void WriteMultiString(string name, string[] value);

	internal abstract void AdjustRegKeyPermission();

	public abstract void Dispose();
}
