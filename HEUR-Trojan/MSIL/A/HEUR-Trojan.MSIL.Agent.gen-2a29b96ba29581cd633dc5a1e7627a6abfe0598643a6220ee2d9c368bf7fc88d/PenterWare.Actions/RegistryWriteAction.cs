using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class RegistryWriteAction : SubAction<RegistryKeysWriteResult>
{
	public static string Name = "RegistryWrite";

	public static Dictionary<string, RegistryKey> HiveMap = new Dictionary<string, RegistryKey>
	{
		{
			"HKLM",
			Registry.LocalMachine
		},
		{
			"HKCC",
			Registry.CurrentConfig
		},
		{
			"HKCU",
			Registry.CurrentUser
		},
		{
			"HKU",
			Registry.Users
		}
	};

	public override string ActionName => Name;

	protected override void Run()
	{
		string value = Convert.ToBase64String(RunRegistry.Cipher.GetKey());
		foreach (string registryPath in Policy.RegistryPaths)
		{
			RegistryKeysWriteResult.RegistryKeyWritten item = WriteKeyRegPath(registryPath, value);
			try
			{
				base.Result.KeysWritten.Add(item);
			}
			catch (Exception ex)
			{
				GeneralUtils.Log("Exception when adding " + registryPath + " result: " + ex.Message);
			}
		}
	}

	private RegistryKeysWriteResult.RegistryKeyWritten WriteKeyRegPath(string regpath, string value)
	{
		Random random = new Random();
		byte[] array = new byte[32];
		random.NextBytes(array);
		byte[] array2 = RunRegistry.Cipher.Encrypt(Convert.ToBase64String(array));
		string[] array3 = regpath.Split(new char[1] { '\\' });
		string text = string.Empty;
		string text2 = array3[^1];
		RegistryKey registryKey = HiveMap[array3[0]];
		for (int i = 1; i < array3.Length - 1; i++)
		{
			text = text + array3[i] + "\\";
		}
		RegistryKeysWriteResult.RegistryKeyWritten registryKeyWritten = new RegistryKeysWriteResult.RegistryKeyWritten
		{
			Data = Encoding.Default.GetString(array2),
			Value = text2,
			Key = array3[0] + "\\" + text,
			SuccessfullyWritten = false,
			Type = RegistryKeysWriteResult.RegistryValueType.BINARY
		};
		try
		{
			registryKey.CreateSubKey(text).SetValue(text2, array2, RegistryValueKind.Binary);
			registryKeyWritten.SuccessfullyWritten = true;
			return registryKeyWritten;
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Key {regpath} write unsuccessful: {arg}");
			registryKeyWritten.SuccessfullyWritten = false;
			return registryKeyWritten;
		}
	}
}
