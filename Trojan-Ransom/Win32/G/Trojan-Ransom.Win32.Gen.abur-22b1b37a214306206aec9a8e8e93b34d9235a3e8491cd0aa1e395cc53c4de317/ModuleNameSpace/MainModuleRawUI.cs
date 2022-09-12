using System;
using System.Management.Automation.Host;
using System.Runtime.InteropServices;

namespace ModuleNameSpace;

internal class MainModuleRawUI : PSHostRawUserInterface
{
	[StructLayout(LayoutKind.Explicit)]
	public struct CHAR_INFO
	{
		[FieldOffset(0)]
		internal char UnicodeChar;

		[FieldOffset(0)]
		internal char AsciiChar;

		[FieldOffset(2)]
		internal ushort Attributes;
	}

	public struct COORD
	{
		public short X;

		public short Y;
	}

	public struct SMALL_RECT
	{
		public short Left;

		public short Top;

		public short Right;

		public short Bottom;
	}

	private const int STD_OUTPUT_HANDLE = -11;

	public override ConsoleColor BackgroundColor
	{
		get
		{
			return Console.BackgroundColor;
		}
		set
		{
			Console.BackgroundColor = value;
		}
	}

	public override Size BufferSize
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (Console_Info.IsOutputRedirected())
			{
				return new Size(120, 50);
			}
			return new Size(Console.BufferWidth, Console.BufferHeight);
		}
		set
		{
			Console.BufferWidth = ((Size)(ref value)).get_Width();
			Console.BufferHeight = ((Size)(ref value)).get_Height();
		}
	}

	public override Coordinates CursorPosition
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return new Coordinates(Console.CursorLeft, Console.CursorTop);
		}
		set
		{
			Console.CursorTop = ((Coordinates)(ref value)).get_Y();
			Console.CursorLeft = ((Coordinates)(ref value)).get_X();
		}
	}

	public override int CursorSize
	{
		get
		{
			return Console.CursorSize;
		}
		set
		{
			Console.CursorSize = value;
		}
	}

	public override ConsoleColor ForegroundColor
	{
		get
		{
			return Console.ForegroundColor;
		}
		set
		{
			Console.ForegroundColor = value;
		}
	}

	public override bool KeyAvailable => Console.KeyAvailable;

	public override Size MaxPhysicalWindowSize => new Size(Console.LargestWindowWidth, Console.LargestWindowHeight);

	public override Size MaxWindowSize => new Size(Console.BufferWidth, Console.BufferWidth);

	public override Coordinates WindowPosition
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			Coordinates result = default(Coordinates);
			((Coordinates)(ref result)).set_X(Console.WindowLeft);
			((Coordinates)(ref result)).set_Y(Console.WindowTop);
			return result;
		}
		set
		{
			Console.WindowLeft = ((Coordinates)(ref value)).get_X();
			Console.WindowTop = ((Coordinates)(ref value)).get_Y();
		}
	}

	public override Size WindowSize
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			Size result = default(Size);
			((Size)(ref result)).set_Height(Console.WindowHeight);
			((Size)(ref result)).set_Width(Console.WindowWidth);
			return result;
		}
		set
		{
			Console.WindowWidth = ((Size)(ref value)).get_Width();
			Console.WindowHeight = ((Size)(ref value)).get_Height();
		}
	}

	public override string WindowTitle
	{
		get
		{
			return Console.Title;
		}
		set
		{
			Console.Title = value;
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool ReadConsoleOutputW(IntPtr hConsoleOutput, [Out][MarshalAs(UnmanagedType.LPArray)] CHAR_INFO[,] lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool WriteConsoleOutputW(IntPtr hConsoleOutput, [In][MarshalAs(UnmanagedType.LPArray)] CHAR_INFO[,] lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, [In] ref SMALL_RECT lpScrollRectangle, [In] ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, [In] ref CHAR_INFO lpFill);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetStdHandle(int nStdHandle);

	public override void FlushInputBuffer()
	{
		if (!Console_Info.IsInputRedirected())
		{
			while (Console.KeyAvailable)
			{
				Console.ReadKey(intercept: true);
			}
		}
	}

	public override BufferCell[,] GetBufferContents(Rectangle rectangle)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		IntPtr stdHandle = GetStdHandle(-11);
		CHAR_INFO[,] array = new CHAR_INFO[((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top() + 1, ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left() + 1];
		COORD cOORD = default(COORD);
		cOORD.X = (short)(((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left() + 1);
		cOORD.Y = (short)(((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top() + 1);
		COORD dwBufferSize = cOORD;
		COORD cOORD2 = default(COORD);
		cOORD2.X = 0;
		cOORD2.Y = 0;
		COORD dwBufferCoord = cOORD2;
		SMALL_RECT sMALL_RECT = default(SMALL_RECT);
		sMALL_RECT.Left = (short)((Rectangle)(ref rectangle)).get_Left();
		sMALL_RECT.Top = (short)((Rectangle)(ref rectangle)).get_Top();
		sMALL_RECT.Right = (short)((Rectangle)(ref rectangle)).get_Right();
		sMALL_RECT.Bottom = (short)((Rectangle)(ref rectangle)).get_Bottom();
		SMALL_RECT lpReadRegion = sMALL_RECT;
		ReadConsoleOutputW(stdHandle, array, dwBufferSize, dwBufferCoord, ref lpReadRegion);
		BufferCell[,] array2 = new BufferCell[((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top() + 1, ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left() + 1];
		for (int i = 0; i <= ((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top(); i++)
		{
			for (int j = 0; j <= ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left(); j++)
			{
				ref BufferCell reference = ref array2[i, j];
				reference = new BufferCell(array[i, j].AsciiChar, (ConsoleColor)(array[i, j].Attributes & 0xF), (ConsoleColor)((array[i, j].Attributes & 0xF0) / 16), (BufferCellType)0);
			}
		}
		return array2;
	}

	public override KeyInfo ReadKey(ReadKeyOptions options)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		ConsoleKeyInfo consoleKeyInfo = Console.ReadKey((options & 2) != 0);
		ControlKeyStates val = (ControlKeyStates)0;
		if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
		{
			val = (ControlKeyStates)(val | 3);
		}
		if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Control) != 0)
		{
			val = (ControlKeyStates)(val | 0xC);
		}
		if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
		{
			val = (ControlKeyStates)(val | 0x10);
		}
		if (Console.CapsLock)
		{
			val = (ControlKeyStates)(val | 0x80);
		}
		if (Console.NumberLock)
		{
			val = (ControlKeyStates)(val | 0x20);
		}
		return new KeyInfo((int)consoleKeyInfo.Key, consoleKeyInfo.KeyChar, val, (options & 4) != 0);
	}

	public override void ScrollBufferContents(Rectangle source, Coordinates destination, Rectangle clip, BufferCell fill)
	{
		if (((Rectangle)(ref source)).get_Left() <= ((Rectangle)(ref clip)).get_Right() && ((Rectangle)(ref source)).get_Right() >= ((Rectangle)(ref clip)).get_Left() && ((Rectangle)(ref source)).get_Top() <= ((Rectangle)(ref clip)).get_Bottom() && ((Rectangle)(ref source)).get_Bottom() >= ((Rectangle)(ref clip)).get_Top())
		{
			IntPtr stdHandle = GetStdHandle(-11);
			SMALL_RECT sMALL_RECT = default(SMALL_RECT);
			sMALL_RECT.Left = (short)((Rectangle)(ref source)).get_Left();
			sMALL_RECT.Top = (short)((Rectangle)(ref source)).get_Top();
			sMALL_RECT.Right = (short)((Rectangle)(ref source)).get_Right();
			sMALL_RECT.Bottom = (short)((Rectangle)(ref source)).get_Bottom();
			SMALL_RECT lpScrollRectangle = sMALL_RECT;
			SMALL_RECT sMALL_RECT2 = default(SMALL_RECT);
			sMALL_RECT2.Left = (short)((Rectangle)(ref clip)).get_Left();
			sMALL_RECT2.Top = (short)((Rectangle)(ref clip)).get_Top();
			sMALL_RECT2.Right = (short)((Rectangle)(ref clip)).get_Right();
			sMALL_RECT2.Bottom = (short)((Rectangle)(ref clip)).get_Bottom();
			SMALL_RECT lpClipRectangle = sMALL_RECT2;
			COORD cOORD = default(COORD);
			cOORD.X = (short)((Coordinates)(ref destination)).get_X();
			cOORD.Y = (short)((Coordinates)(ref destination)).get_Y();
			COORD dwDestinationOrigin = cOORD;
			CHAR_INFO cHAR_INFO = default(CHAR_INFO);
			cHAR_INFO.AsciiChar = ((BufferCell)(ref fill)).get_Character();
			cHAR_INFO.Attributes = (ushort)(((BufferCell)(ref fill)).get_ForegroundColor() + (int)((BufferCell)(ref fill)).get_BackgroundColor() * 16);
			CHAR_INFO lpFill = cHAR_INFO;
			ScrollConsoleScreenBuffer(stdHandle, ref lpScrollRectangle, ref lpClipRectangle, dwDestinationOrigin, ref lpFill);
		}
	}

	public override void SetBufferContents(Rectangle rectangle, BufferCell fill)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (((Rectangle)(ref rectangle)).get_Left() >= 0)
		{
			int left = ((Rectangle)(ref rectangle)).get_Left();
			int top = ((Rectangle)(ref rectangle)).get_Top();
			int sourceWidth = ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left() + 1;
			int sourceHeight = ((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top() + 1;
			Size bufferSize = ((PSHostRawUserInterface)this).get_BufferSize();
			int width = ((Size)(ref bufferSize)).get_Width();
			Size bufferSize2 = ((PSHostRawUserInterface)this).get_BufferSize();
			Console.MoveBufferArea(left, top, sourceWidth, sourceHeight, width, ((Size)(ref bufferSize2)).get_Height(), ((BufferCell)(ref fill)).get_Character(), ((BufferCell)(ref fill)).get_ForegroundColor(), ((BufferCell)(ref fill)).get_BackgroundColor());
		}
		else
		{
			Size bufferSize3 = ((PSHostRawUserInterface)this).get_BufferSize();
			int width2 = ((Size)(ref bufferSize3)).get_Width();
			Size bufferSize4 = ((PSHostRawUserInterface)this).get_BufferSize();
			int height = ((Size)(ref bufferSize4)).get_Height();
			Size bufferSize5 = ((PSHostRawUserInterface)this).get_BufferSize();
			int width3 = ((Size)(ref bufferSize5)).get_Width();
			Size bufferSize6 = ((PSHostRawUserInterface)this).get_BufferSize();
			Console.MoveBufferArea(0, 0, width2, height, width3, ((Size)(ref bufferSize6)).get_Height(), ((BufferCell)(ref fill)).get_Character(), ((BufferCell)(ref fill)).get_ForegroundColor(), ((BufferCell)(ref fill)).get_BackgroundColor());
		}
	}

	public override void SetBufferContents(Coordinates origin, BufferCell[,] contents)
	{
		IntPtr stdHandle = GetStdHandle(-11);
		CHAR_INFO[,] array = new CHAR_INFO[contents.GetLength(0), contents.GetLength(1)];
		COORD cOORD = default(COORD);
		cOORD.X = (short)contents.GetLength(1);
		cOORD.Y = (short)contents.GetLength(0);
		COORD dwBufferSize = cOORD;
		COORD cOORD2 = default(COORD);
		cOORD2.X = 0;
		cOORD2.Y = 0;
		COORD dwBufferCoord = cOORD2;
		SMALL_RECT sMALL_RECT = default(SMALL_RECT);
		sMALL_RECT.Left = (short)((Coordinates)(ref origin)).get_X();
		sMALL_RECT.Top = (short)((Coordinates)(ref origin)).get_Y();
		sMALL_RECT.Right = (short)(((Coordinates)(ref origin)).get_X() + contents.GetLength(1) - 1);
		sMALL_RECT.Bottom = (short)(((Coordinates)(ref origin)).get_Y() + contents.GetLength(0) - 1);
		SMALL_RECT lpWriteRegion = sMALL_RECT;
		for (int i = 0; i < contents.GetLength(0); i++)
		{
			for (int j = 0; j < contents.GetLength(1); j++)
			{
				ref CHAR_INFO reference = ref array[i, j];
				reference = new CHAR_INFO
				{
					AsciiChar = ((BufferCell)(ref contents[i, j])).get_Character(),
					Attributes = (ushort)(((BufferCell)(ref contents[i, j])).get_ForegroundColor() + (int)((BufferCell)(ref contents[i, j])).get_BackgroundColor() * 16)
				};
			}
		}
		WriteConsoleOutputW(stdHandle, array, dwBufferSize, dwBufferCoord, ref lpWriteRegion);
	}
}
