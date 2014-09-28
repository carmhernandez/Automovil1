using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.fabricas;

namespace AbstractFactoryAutomovil
{
    public partial class Cliente : Form
    {
        private IFabricaDePartes fabrica;
        private IAuto auto;
        private IMotor motor;
        private ICarroceria carroceria;

        public Cliente()
        {
            InitializeComponent();
            lstPartes.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (radMazda.Checked)
                fabrica = new FabricaMazda();
            if (radChevrolet.Checked)
                fabrica = new FabricaChevrolet();
            if (radRenault.Checked)
                fabrica = new FabricaRenault();
            auto = fabrica.crearAuto();
            motor = fabrica.crearMotor();
            carroceria = fabrica.crearCarroceria();
            if (lstPartes.SelectedIndex == 0)
                MessageBox.Show(auto.darNombre());
            else if (lstPartes.SelectedIndex == 1)
                MessageBox.Show(motor.darNombre());
            else if (lstPartes.SelectedIndex == 2)
                MessageBox.Show(carroceria.darNombre());
        }

        private void radMazda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
