using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class DemoCheckBox : Form
	{
		public DemoCheckBox()
		{
			InitializeComponent();
		}

		private void getvalueButton_Click(object sender, EventArgs e)
		{
			bool isChecked = checkBox1.Checked;

			int value = (isChecked == true) ? 1 : 0;

			MessageBox.Show(value.ToString());
		}

		private void setvalueButton_Click(object sender, EventArgs e)
		{
			string valueInDb = textBox1.Text; // 模擬db裡的欄位值是"1"或"0"

			checkBox1.Checked = (valueInDb == "1");
		}
	}
}
