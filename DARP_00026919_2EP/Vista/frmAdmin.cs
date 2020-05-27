using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmAdmin : Form
    {
        private AppUser usuario;
        public frmAdmin(AppUser user)
        {
            InitializeComponent();
            usuario = user;
        }
    }
}