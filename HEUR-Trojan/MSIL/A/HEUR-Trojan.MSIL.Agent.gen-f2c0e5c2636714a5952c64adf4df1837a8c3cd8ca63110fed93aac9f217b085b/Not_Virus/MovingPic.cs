using System;
using System.Drawing;
using System.IO;

namespace Not_Virus;

internal class MovingPic
{
	private int _x;

	private int _y;

	private int _width;

	private int _height;

	private int _xSpeed;

	private int _ySpeed;

	private Pen _pen;

	private static int _formWidth;

	private static int _formHeight;

	private Image _img;

	public int formWidth
	{
		set
		{
			_formWidth = value;
		}
	}

	public int formHeight
	{
		set
		{
			_formHeight = value;
		}
	}

	public Color color
	{
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			_pen = new Pen(value);
		}
	}

	public MovingPic(int x, int y, int formWidth, int formHeight, int xSpeed, int ySpeed, Color color, int width, int height)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		_x = x;
		_y = y;
		_xSpeed = xSpeed;
		_ySpeed = ySpeed;
		_formWidth = formWidth;
		_formHeight = formHeight;
		_pen = new Pen(color);
		_width = width;
		_height = height;
		Random random = new Random();
		string[] files = Directory.GetFiles("images", "*.*");
		string text = files[random.Next(files.Length)];
		_img = Image.FromFile(text);
	}

	public void Draw(Graphics gr)
	{
		_x += _xSpeed;
		_y += _ySpeed;
		if (_x + _width >= _formWidth)
		{
			_xSpeed *= -1;
			_x = _formWidth - _width;
		}
		if (_x <= 0)
		{
			_xSpeed *= -1;
			_x = 1;
		}
		if (_y + _height >= _formHeight)
		{
			_ySpeed *= -1;
			_y = _formHeight - _height;
		}
		if (_y <= 0)
		{
			_ySpeed *= -1;
			_y = 1;
		}
		gr.DrawImage(_img, _x, _y, _width, _height);
	}
}
