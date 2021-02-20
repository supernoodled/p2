using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace p2 {
	public partial class Form1 : MetroForm {
		public Form1() {
			InitializeComponent();
		}

		private void metroButton1_Click(object sender, EventArgs e) {
			this.output.ResetText();
			UInt64 inputp2 = 1;
			bool shudstop = false;
			try {
				inputp2 = UInt64.Parse(input.Text);
			}
			catch (ArgumentNullException) {
				MessageBox.Show("input blank, pls enter stuff", "input");
				output.ResetText();
				shudstop = true;
			}
			catch (FormatException) {
				MessageBox.Show("numbers only pls", "input");
				output.ResetText();
				shudstop = true;
			}
			if (!shudstop) {
				poweroftwo(inputp2);
			}
		}

		void poweroftwo(UInt64 pow) {
			int shiftby = 1; //1 is best.
			UInt64 pow2 = pow;
			if (lower.Checked) {
				for (int i = 0; i < 16; i++) {
					pow2 >>= shiftby;
					if (pow2 == 0) {
						this.output.AppendText(pow2.ToString());
						break; //only one 0
					}
					if (i == 15) {
						this.output.AppendText(pow2.ToString()); //no comma
					}
					else {
						this.output.AppendText(pow2.ToString() + ", ");
					}
				}
			}
			else if (higher.Checked) {
				for (int i = 0; i < 16; i++) {
					pow2 <<= shiftby;
					if (pow2 == 0) {
						this.output.AppendText(pow2.ToString());
						break; //only one 0
					}
					if (i == 15) {
						this.output.AppendText(pow2.ToString()); //no comma
					}
					else {
						this.output.AppendText(pow2.ToString() + ", ");
					}
				}
			}
			else {
				MessageBox.Show("select a button lol");
			}
		}
	}
}
