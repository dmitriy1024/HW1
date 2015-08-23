using System;
using System.Windows.Forms;

namespace HW1.MachineMathematics.Task1
{
    public partial class MinMaxValuesForm : Form
    {
        public MinMaxValuesForm()
        {
            InitializeComponent();
        }

        private void ByteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Byte: MinValue = {0}, MaxValue = {1}", Byte.MinValue, Byte.MaxValue));
        }

        private void SByteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("SByte: MinValue = {0}, MaxValue = {1}", SByte.MinValue, SByte.MaxValue));
        }

        private void Int16Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Int16: MinValue = {0}, MaxValue = {1}", Int16.MinValue, Int16.MaxValue));
        }

        private void UInt16Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("UInt16: MinValue = {0}, MaxValue = {1}", UInt16.MinValue, UInt16.MaxValue));
        }

        private void Int32Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Int32: MinValue = {0}, MaxValue = {1}", Int32.MinValue, Int32.MaxValue));
        }

        private void UInt32Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("UInt32: MinValue = {0}, MaxValue = {1}", UInt32.MinValue, UInt32.MaxValue));
        }

        private void Int64Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Int64: MinValue = {0}, MaxValue = {1}", Int64.MinValue, Int64.MaxValue));
        }

        private void UInt64Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("UInt64: MinValue = {0}, MaxValue = {1}", UInt64.MinValue, UInt64.MaxValue));
        }
    }
}
