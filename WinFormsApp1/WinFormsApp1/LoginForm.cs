using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private readonly SqlService authService;
        public LoginForm()
        {
            InitializeComponent();

            var conf = new Config();
            var worker = new sqlWorker(conf);
            authService = new SqlService(worker);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private async void auth_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pwdText.Text))
            {
                if (!string.IsNullOrEmpty(loginText.Text))
                {
                    if(await authService.authenticate(loginText.Text, pwdText.Text))
                    {
                        this.Hide();
                        ShomWin form = new ShomWin(authService);
                        await form.ShowAsync();
                    }
                }
            }
        }
    }
}
