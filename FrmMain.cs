namespace GUI26101404;
public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
        btnClickMe.MouseEnter += BtnClickMeMouseEnter;
        btnClickMe.Click += BtnClickMeClick;
    }

    private void BtnClickMeClick(object? sender, EventArgs e)
    {
        btnClickMe.Hide();

        pnlMain.BackgroundImage = Image.FromFile("..\\..\\..\\data\\scarry.jpg");
    }

    private void BtnClickMeMouseEnter(object? sender, EventArgs e)
    {
        btnClickMe.Location = new(
            x: Random.Shared.Next(5, pnlMain.Width - btnClickMe.Width - 5),
            y: Random.Shared.Next(5, pnlMain.Height - btnClickMe.Height - 5));
    }
}
