using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class Invocador : Form
    {
        public Invocador()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarTelaInicial();
        }

        public void ChangeForm<T>(params object[] parametrosDoConstrutor) where T : Form
        {
            var newForm = (T)Activator.CreateInstance(typeof(T), parametrosDoConstrutor);
            Size = newForm.Size;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            Text = newForm.Text;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        public void CarregarTelaInicial()
        {
            ChangeForm<TelaInicial>(this);
        }
    }
}
