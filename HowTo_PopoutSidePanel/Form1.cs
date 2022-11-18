using System.Media;

namespace HowTo_PopoutSidePanel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void panel1_MouseLeave(object sender, EventArgs e)
    {
        panel1.Width = 0;
    }

    private void Form1_MouseLeave(object sender, EventArgs e)
    {
        
        if (PointToClient(MousePosition).X < 5)
        {
            panel1.Width = 200;
        }
     }

    private void Form1_MouseEnter(object sender, EventArgs e)
    {
        panel1.Width = 0;
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
        Resize();
    }

    private new void Resize()
    {
        panel1.Height = ClientSize.Height;
    }
}
