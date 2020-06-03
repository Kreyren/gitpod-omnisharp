using System;
using System.Drawing;
using System.Windows.Forms;

public class HelloWorld : Form
{
    static public void Main()
    {
        Application.Run(new HelloWorld());
    }

    public HelloWorld()
    {
        Label b = new Label() {
            Text = "Hello World From C#",
            AutoSize = false,
            Height = 40,
            Width = 300,
            Location = new Point(96, 54),             
        };
        Controls.Add(b);
    }
}
