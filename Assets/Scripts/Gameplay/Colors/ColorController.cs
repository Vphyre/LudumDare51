using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    [SerializeField] private ColorEnum _color;
    public ColorEnum _Color { get => _color; set => _color = value; }
    private int colorIndex;

    private void Awake()
    {
        colorIndex = ((int)_color);
    }

    public Color GetColor()
    {
        if (_color == ColorEnum.Red)
        {
            return Color.red;
        }
        if (_color == ColorEnum.Blue)
        {
            return Color.blue;
        }
        if (_color == ColorEnum.Yellow)
        {
            return Color.yellow;
        }
        if (_color == ColorEnum.Orange)
        {
            return new Color(1.0f, 0.64f, 0.0f);
        }
        if (_color == ColorEnum.Purple)
        {
            return Color.magenta;
        }
        if (_color == ColorEnum.Green)
        {
            return Color.green;
        }
        return Color.white;
    }
    public void ChangeColorOnPrism()
    {
        if (_color + 1 == ColorEnum.Purple)
        {
            _color = ColorEnum.Red;
        }
        else
        {
            _color = _color + 1;
        }
    }
    public void SetColor(Color currentColor)
    {
        if (currentColor == Color.red)
        {
            _color = ColorEnum.Red;
        }
        if (currentColor == Color.blue)
        {
            _color = ColorEnum.Blue;
        }
        if (currentColor == Color.yellow)
        {
            _color = ColorEnum.Yellow;
        }
        if (currentColor == Color.green)
        {
            _color = ColorEnum.Green;
        }
        if (currentColor == new Color(1.0f, 0.64f, 0.0f))
        {
            _color = ColorEnum.Orange;
        }
        if (currentColor == Color.magenta)
        {
            _color = ColorEnum.Purple;
        }
    }
    public void MixColors(ColorEnum one, ColorEnum two)
    {
        if (one == ColorEnum.Red && two == ColorEnum.Red || one == ColorEnum.Red && two == ColorEnum.Red)
        {
            SetColor(Color.red);
        }
        if (one == ColorEnum.Red && two == ColorEnum.Yellow || one == ColorEnum.Yellow && two == ColorEnum.Red)
        {
            SetColor(new Color(1.0f, 0.64f, 0.0f));
        }
        if (one == ColorEnum.Red && two == ColorEnum.Blue || one == ColorEnum.Blue && two == ColorEnum.Red)
        {
            SetColor(Color.magenta);
        }
        if (one == ColorEnum.Red && two == ColorEnum.Green || one == ColorEnum.Green && two == ColorEnum.Red)
        {
            SetColor(new Color(1.0f, 0.64f, 0.0f));
        }
        if (one == ColorEnum.Red && two == ColorEnum.Purple || one == ColorEnum.Purple && two == ColorEnum.Red)
        {
            SetColor(Color.magenta);
        }
        if (one == ColorEnum.Red && two == ColorEnum.Orange || one == ColorEnum.Orange && two == ColorEnum.Red)
        {
            SetColor(new Color(1.0f, 0.64f, 0.0f));
        }

        if (one == ColorEnum.Blue && two == ColorEnum.Blue || one == ColorEnum.Blue && two == ColorEnum.Blue)
        {
            SetColor(Color.blue);
        }
        if (one == ColorEnum.Blue && two == ColorEnum.Red || one == ColorEnum.Red && two == ColorEnum.Blue)
        {
            SetColor(Color.magenta);
        }
        if (one == ColorEnum.Blue && two == ColorEnum.Yellow || one == ColorEnum.Yellow && two == ColorEnum.Blue)
        {
            SetColor(Color.green);
        }
        if (one == ColorEnum.Blue && two == ColorEnum.Green || one == ColorEnum.Green && two == ColorEnum.Blue)
        {
            SetColor(Color.green);
        }
        if (one == ColorEnum.Blue && two == ColorEnum.Purple || one == ColorEnum.Purple && two == ColorEnum.Blue)
        {
            SetColor(Color.magenta);
        }
        if (one == ColorEnum.Blue & two == ColorEnum.Orange || one == ColorEnum.Orange && two == ColorEnum.Blue)
        {
            SetColor(Color.green);
        }

        if (one == ColorEnum.Yellow && two == ColorEnum.Yellow || one == ColorEnum.Yellow && two == ColorEnum.Yellow)
        {
            SetColor(Color.yellow);
        }
        if (one == ColorEnum.Yellow && two == ColorEnum.Red || one == ColorEnum.Red && two == ColorEnum.Yellow)
        {
            SetColor(new Color(1.0f, 0.64f, 0.0f));
        }
        if (one == ColorEnum.Yellow && two == ColorEnum.Blue || one == ColorEnum.Blue && two == ColorEnum.Yellow)
        {
            SetColor(Color.green);
        }
        if (one == ColorEnum.Yellow && two == ColorEnum.Green || one == ColorEnum.Green && two == ColorEnum.Yellow)
        {
            SetColor(Color.green);
        }
        if (one == ColorEnum.Yellow && two == ColorEnum.Orange || one == ColorEnum.Orange && two == ColorEnum.Yellow)
        {
            SetColor(new Color(1.0f, 0.64f, 0.0f));
        }
        if (one == ColorEnum.Yellow && two == ColorEnum.Purple || one == ColorEnum.Purple && two == ColorEnum.Yellow)
        {
            SetColor(Color.magenta);
        }


    }
}
