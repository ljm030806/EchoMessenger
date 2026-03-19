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


        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtMessege.Text;
            lstMessege.Items.Add(typed_msg);
            txtMessege.Clear();
        }
    }
}
