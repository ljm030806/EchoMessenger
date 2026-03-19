namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMessege_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessege_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void lstMessege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {

            lstMessege.Items.Add(txtMessege.Text);
            txtMessege.Clear();
        }
    }
}
