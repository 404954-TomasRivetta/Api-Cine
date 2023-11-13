using prueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "SALIR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private int Usuario1;

        string usuario1 = "admin";
        string contraseña1 = "admin";

        string usuario2 = "toto";
        string contraseña2 = "toto";

        string usuario3 = "admin";
        string contraseña3 = "1234";

        string usuario4 = "rodri";
        string contraseña4 = "rodri";

        private void OpenChildForm(Form childForm, object btnSender)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();


        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == usuario1 && txtpass.Text == contraseña1)
            {

                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide();

            }
            else if (txtuser.Text == usuario2 && txtpass.Text == contraseña2)
            {
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide();

            }
            else if (txtuser.Text == usuario3 && txtpass.Text == contraseña3)
            {
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide();

            }
            else if (txtuser.Text == usuario4 && txtpass.Text == contraseña4)
            {
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                txtpass.Text = "Contraseña";
                txtuser.Text = "Usuario";
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "SALIR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
