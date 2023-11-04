using SwitchController.Switch;

namespace SwitchController
{
    public partial class Controller : Form
    {
        public SysbotBase Bot { get; set; }
        public Controller()
        {
            Bot = new SysbotBase("192.168.86.42");
            InitializeComponent();
            KeyPreview = true;
        }
        private void Controller_Load(object sender, EventArgs e)
        {
            IPAddress.Text = Bot.Address;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            var address = IPAddress.Text.Trim();
            var bot = new SysbotBase(address);

            try
            {
                bot.Connect();
            }
            catch (Exception)
            {
                throw;
            }

            if (bot.IsConnected)
                MessageBox.Show("Connected!");
            IsConnectedTextBox.BackColor = Color.Green;
            Bot = bot;
        }
        private void TrySend(Buttons.SwitchButton b, byte i)
        {
            if (!Bot.IsConnected)
            {
                MessageBox.Show("Not connected!");
            }
            else
                switch (i)
                {
                    case 0:
                        Bot.Socket.Send(Commands.Click(b));
                        break;
                    case 1:
                        Bot.Socket.Send(Commands.Hold(b));
                        break;
                    case 2:
                        Bot.Socket.Send(Commands.Release(b));
                        break;
                }
        }
        private void CAPUTREButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.CAPTURE, 0);
        private void HOMEButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.HOME, 0);
        private void LButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.L, 0);
        private void RButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.R, 0);
        private void DUPButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.DUP, 0);
        private void DRIGHTButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.DRIGHT, 0);
        private void DLEFTButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.DLEFT, 0);
        private void DDOWNButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.DDOWN, 0);
        private void XButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.X, 0);
        private void YButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.Y, 0);
        private void BButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.B, 0);
        private void AButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.A, 0);
        private void MINUSButton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.MINUS, 0);
        private void PLUSBUtton_Click(object sender, EventArgs e) => TrySend(Buttons.SwitchButton.PLUS, 0);

        private void DUPButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DUP, 1);
        private void DUPButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DUP, 2);

        private void DLEFTButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DLEFT, 1);
        private void DLEFTButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DLEFT, 2);

        private void DRIGHTButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DRIGHT, 1);
        private void DRIGHTButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DRIGHT, 2);

        private void DDOWNButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DDOWN, 1);
        private void DDOWNButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.DDOWN, 2);

        private void XButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.X, 1);
        private void XButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.X, 2);

        private void YButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.Y, 1);
        private void YButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.Y, 2);

        private void BButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.B, 1);
        private void BButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.B, 2);

        private void AButton_MouseDown(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.A, 1);
        private void AButton_MouseUp(object sender, MouseEventArgs e) => TrySend(Buttons.SwitchButton.A, 2);

        private void Controller_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (int)Keys.W:
                case (int)Keys.Up:
                    TrySend(Buttons.SwitchButton.DUP, 1);
                    break;
                case (int)Keys.S:
                case (int)Keys.Down:
                    TrySend(Buttons.SwitchButton.DDOWN, 1);
                    break;
                case (int)Keys.D:
                case (int)Keys.Right:
                    TrySend(Buttons.SwitchButton.DRIGHT, 1);
                    break;
                case (int)Keys.A:
                case (int)Keys.Left:
                    TrySend(Buttons.SwitchButton.DLEFT, 1);
                    break;
                case (int)Keys.X:
                    TrySend(Buttons.SwitchButton.A, 1);
                    break;
                case (int)Keys.Z:
                    TrySend(Buttons.SwitchButton.B, 1);
                    break;
                case (int)Keys.C:
                    TrySend(Buttons.SwitchButton.Y, 1);
                    break;
                case (int)Keys.V:
                    TrySend(Buttons.SwitchButton.X, 1);
                    break;
                case (int)Keys.Q:
                    TrySend(Buttons.SwitchButton.L, 1);
                    break;
                case (int)Keys.E:
                    TrySend(Buttons.SwitchButton.R, 1);
                    break;
                case (int)Keys.R:
                    TrySend(Buttons.SwitchButton.HOME, 1);
                    break;
                default:
                    break;
            }
        }

        private void Controller_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (int)Keys.W:
                case (int)Keys.Up:
                    TrySend(Buttons.SwitchButton.DUP, 2);
                    break;
                case (int)Keys.S:
                case (int)Keys.Down:
                    TrySend(Buttons.SwitchButton.DDOWN, 2);
                    break;
                case (int)Keys.D:
                case (int)Keys.Right:
                    TrySend(Buttons.SwitchButton.DRIGHT, 2);
                    break;
                case (int)Keys.A:
                case (int)Keys.Left:
                    TrySend(Buttons.SwitchButton.DLEFT, 2);
                    break;
                case (int)Keys.X:
                    TrySend(Buttons.SwitchButton.A, 2);
                    break;
                case (int)Keys.Z:
                    TrySend(Buttons.SwitchButton.B, 2);
                    break;
                case (int)Keys.C:
                    TrySend(Buttons.SwitchButton.Y, 2);
                    break;
                case (int)Keys.V:
                    TrySend(Buttons.SwitchButton.X, 2);
                    break;
                case (int)Keys.Q:
                    TrySend(Buttons.SwitchButton.L, 2);
                    break;
                case (int)Keys.E:
                    TrySend(Buttons.SwitchButton.R, 2);
                    break;
                case (int)Keys.R:
                    TrySend(Buttons.SwitchButton.HOME, 2);
                    break;
                default:
                    break;
            }
        }
    }
}