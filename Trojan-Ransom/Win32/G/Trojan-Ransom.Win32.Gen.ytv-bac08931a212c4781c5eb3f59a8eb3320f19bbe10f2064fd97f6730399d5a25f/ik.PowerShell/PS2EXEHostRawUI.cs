using System;
using System.Management.Automation.Host;
using System.Windows.Forms;

namespace ik.PowerShell;

internal class PS2EXEHostRawUI : PSHostRawUserInterface
{
	private ConsoleColor ncBackgroundColor = ConsoleColor.White;

	private ConsoleColor ncForegroundColor;

	private Form InvisibleForm;

	public override ConsoleColor BackgroundColor
	{
		get
		{
			return ncBackgroundColor;
		}
		set
		{
			ncBackgroundColor = value;
		}
	}

	public override Size BufferSize
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return new Size(120, 50);
		}
		set
		{
		}
	}

	public override Coordinates CursorPosition
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return new Coordinates(0, 0);
		}
		set
		{
		}
	}

	public override int CursorSize
	{
		get
		{
			return 25;
		}
		set
		{
		}
	}

	public override ConsoleColor ForegroundColor
	{
		get
		{
			return ncForegroundColor;
		}
		set
		{
			ncForegroundColor = value;
		}
	}

	public override bool KeyAvailable => true;

	public override Size MaxPhysicalWindowSize => new Size(240, 84);

	public override Size MaxWindowSize => new Size(120, 84);

	public override Coordinates WindowPosition
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			Coordinates result = default(Coordinates);
			((Coordinates)(ref result)).set_X(0);
			((Coordinates)(ref result)).set_Y(0);
			return result;
		}
		set
		{
		}
	}

	public override Size WindowSize
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Size result = default(Size);
			((Size)(ref result)).set_Height(50);
			((Size)(ref result)).set_Width(120);
			return result;
		}
		set
		{
		}
	}

	public override string WindowTitle
	{
		get
		{
			return AppDomain.CurrentDomain.FriendlyName;
		}
		set
		{
		}
	}

	public override void FlushInputBuffer()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (InvisibleForm != null)
		{
			InvisibleForm.Close();
			InvisibleForm = null;
			return;
		}
		InvisibleForm = new Form();
		InvisibleForm.set_Opacity(0.0);
		InvisibleForm.set_ShowInTaskbar(false);
		((Control)InvisibleForm).set_Visible(true);
	}

	public override BufferCell[,] GetBufferContents(Rectangle rectangle)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		BufferCell[,] array = new BufferCell[((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top() + 1, ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left() + 1];
		for (int i = 0; i <= ((Rectangle)(ref rectangle)).get_Bottom() - ((Rectangle)(ref rectangle)).get_Top(); i++)
		{
			for (int j = 0; j <= ((Rectangle)(ref rectangle)).get_Right() - ((Rectangle)(ref rectangle)).get_Left(); j++)
			{
				ref BufferCell reference = ref array[i, j];
				reference = new BufferCell(' ', ncForegroundColor, ncBackgroundColor, (BufferCellType)0);
			}
		}
		return array;
	}

	public override KeyInfo ReadKey(ReadKeyOptions options)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if ((options & 4) != 0)
		{
			return ReadKeyBox.Show("", "", bIncludeKeyDown: true);
		}
		return ReadKeyBox.Show("", "", bIncludeKeyDown: false);
	}

	public override void ScrollBufferContents(Rectangle source, Coordinates destination, Rectangle clip, BufferCell fill)
	{
	}

	public override void SetBufferContents(Rectangle rectangle, BufferCell fill)
	{
	}

	public override void SetBufferContents(Coordinates origin, BufferCell[,] contents)
	{
	}
}
