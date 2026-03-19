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
            // Enter 키를 누르면 Send 버튼 클릭 이벤트 실행
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void lstMessege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtMessege.Text;
            // 공백만 있거나 내용이 없는 문자열은 전송하지 않음
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                lstMessege.Items.Add(typed_msg);
            }
            // 텍스트 초기화 및 포커스 유지
            
            
            txtMessege.Clear();
            txtMessege.Focus();
        }
    }
}
