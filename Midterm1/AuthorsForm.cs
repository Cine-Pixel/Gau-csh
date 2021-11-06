using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm1 {
    public partial class AuthorsForm : Form {
        public AuthorsForm() {
            InitializeComponent();
        }
        public AuthorsForm(DataTable source) {
            InitializeComponent();
            dtgAuthors.DataSource = source;
        }
    }
}
