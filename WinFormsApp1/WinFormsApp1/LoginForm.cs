namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private readonly SqlService authService;
        public LoginForm()
        {
            InitializeComponent();

            var conf = new Config();
            SqlWorkers worker = new sqlWorker(conf);
            authService = new SqlService(worker);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loginText.Select();
        }

        private async void auth_Click(object sender, EventArgs e)
        {
            if (authService.ErrorHandle(pwdText) && authService.ErrorHandle(loginText))
            {
                if(await authService.authenticate(loginText.Text, pwdText.Text));
                {
                    this.Hide();
                    ShopWin win = new ShopWin(authService);
                    await win.ShowAsync();
                }
            }
        }

        private async void LoginGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopWin win = new ShopWin(authService);
            await win.ShowAsync();
        }
    }
}
