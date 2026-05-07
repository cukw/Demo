namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        sqlWorker worker = new sqlWorker();
        public Form1()
        {
            InitializeComponent();
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
                    if(await worker.authUser(loginText.Text, pwdText.Text))
                    {
                        this.Hide();
                        Form2 form = new Form2();
                        await form.ShowAsync();
                    }
                }
            }
        }
    }
}
