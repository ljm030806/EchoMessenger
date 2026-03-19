using System.Reflection.Emit;

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
            typed_msg = txtMessege.Text.Trim();
            // 1. 글자 수 50자 초과 검사 및 전송 차단
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자를 초과할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMessege.Focus(); // 다시 입력할 수 있도록 포커스 유지
                return; // 메서드를 여기서 종료하여 전송을 차단
            }
            // 공백만 있거나 내용이 없는 문자열은 전송하지 않음
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {

                string formatted_msg = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";
                lstMessege.Items.Add(formatted_msg);
                // 리스트의 하단 라벨에 총 메시지 개수 업데이트 
                lblCount.Text = $"총 메시지 수: {lstMessege.Items.Count}";
            }
            // 텍스트 초기화 및 포커스 유지


            txtMessege.Clear();
            txtMessege.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인 (선택되지 않은 경우 -1을 반환함)
            if (lstMessege.SelectedIndex != -1)
            {
                // 선택된 항목 삭제
                lstMessege.Items.RemoveAt(lstMessege.SelectedIndex);

                // 삭제 후 총 메시지 개수 라벨 업데이트
                lblCount.Text = $"총 메시지 수: {lstMessege.Items.Count}";
            }
            else
            {
                // 선택하지 않고 삭제를 시도했을 때의 예외(오류) 처리
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // 리스트 박스의 모든 항목을 한 번에 삭제
            lstMessege.Items.Clear();

            // 삭제 후 총 메시지 개수 라벨을 0으로 업데이트
            lblCount.Text = $"총 메시지 수: {lstMessege.Items.Count}";
        }
    }
}
