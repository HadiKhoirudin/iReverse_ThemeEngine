using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public static class ThemeEngine
{
    public static bool isDebbugging = false;

    public enum Styles
    {
        Dark = 0,
        Light = 1
    }

    public static IEnumerable<Control> GetAllComponents(Control container)
    {
        foreach (Control c in container.Controls)
        {
            foreach (Control child in GetAllComponents(c))
            {
                yield return child;
            }
            yield return c;
        }
    }

    public static void ThemeSet(object sender, Styles styles)
    {
        Console.WriteLine($"Set Style to : {styles}");

        if (sender is Form form)
        {
            ApplyTheme(form, styles);
        }
        else if (sender is UserControl userControl)
        {
            ApplyTheme(userControl, styles);
        }
    }

    private static void ApplyTheme(Control container, Styles styles)
    {
        bool enableButtonSetDark;

        switch(styles)
        {
            case Styles.Dark :
                container.BackColor = Color.FromArgb(38, 38, 38);
                container.ForeColor = Color.Azure;
                enableButtonSetDark = false;
                break;
            case Styles.Light:
                container.BackColor = SystemColors.Window;
                container.ForeColor = SystemColors.ControlText;
                enableButtonSetDark = true;
                break;
            default:
                return;
        }

        var allComponents = GetAllComponents(container).ToList();

        if (isDebbugging) Console.WriteLine($"Found Component : {allComponents.Count}");

        foreach (var item in allComponents)
        {
            if (isDebbugging) Console.WriteLine($"Found : {item.GetType()}");
            if (item is Button)
            {
                switch (item.Text)
                {
                    case "Set Dark" : item.Enabled =  enableButtonSetDark; break;
                    case "Set Light": item.Enabled = !enableButtonSetDark; break;
                    default: break;
                }
            }
            else
            {
                item.BackColor = container.BackColor;
                item.ForeColor = container.ForeColor;
            }
        }

        if (isDebbugging) Console.WriteLine(" ");
    }
}
