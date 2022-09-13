namespace youknowcaliber;

internal struct Site
{
	public string sUrl
	{
		get; set
		{
			//Discarded unreachable code: IL_0005, IL_000a, IL_0011, IL_0029
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected F8, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			_ = 2;
			_ = 0;
			/*Error near IL_0004: Unknown opcode: 0xF8*/;
		}
	}

	public string sTitle
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_0007, IL_000e, IL_0026
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected F8, but got I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			/*Error near IL_0001: Unknown opcode: 0xF8*/;
		}
		set
		{
			//Discarded unreachable code: IL_0006, IL_001e
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected F8, but got I4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (uint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}
	}

	public int iCount
	{
		get; set
		{
			_ = 6;
			checked
			{
				_ = (int)unchecked((uint)value);
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
