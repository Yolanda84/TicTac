using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac {
    public partial class TicTacNotToh : Form {

        public string ticTacBtn = "X";


        public TicTacNotToh() {
            InitializeComponent();

        }

	
        private void btnOne_Click(object sender, EventArgs e) {

            btnOne.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnTwo_Click(object sender, EventArgs e) {

            btnTwo.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnThree_Click(object sender, EventArgs e) {

            btnThree.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnFour_Click(object sender, EventArgs e) {

            btnFour.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnFive_Click(object sender, EventArgs e) {

            btnFive.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnSix_Click(object sender, EventArgs e) {

            btnSix.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnSeven_Click(object sender, EventArgs e) {

            btnSeven.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnEight_Click(object sender, EventArgs e) {

            btnEight.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        private void btnNine_Click(object sender, EventArgs e) {

            btnNine.Text = ticTacBtn;
            ValidateTicTaToh();
        }

        public void ValidateTicTaToh() {

            if (btnOne.Text == ticTacBtn && btnTwo.Text == ticTacBtn && btnThree.Text == ticTacBtn) {

                MessageBox.Show("You won");
            }
        }

                        
    }
}
