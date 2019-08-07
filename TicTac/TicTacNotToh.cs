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
            

        }

        private void btnTwo_Click(object sender, EventArgs e) {

            btnTwo.Text = ticTacBtn;
        }

        private void btnThree_Click(object sender, EventArgs e) {

            btnThree.Text = ticTacBtn;
        }

        private void btnFour_Click(object sender, EventArgs e) {

            btnFour.Text = ticTacBtn;
        }

        private void btnFive_Click(object sender, EventArgs e) {

            btnFive.Text = ticTacBtn;
        }

        private void btnSix_Click(object sender, EventArgs e) {

            btnSix.Text = ticTacBtn;
        }

        private void btnSeven_Click(object sender, EventArgs e) {

            btnSeven.Text = ticTacBtn;
        }

        private void btnEight_Click(object sender, EventArgs e) {

            btnEight.Text = ticTacBtn;
        }

        private void btnNine_Click(object sender, EventArgs e) {

            btnNine.Text = ticTacBtn;
        }

       
                
    }
}
