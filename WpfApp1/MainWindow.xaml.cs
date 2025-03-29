using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesores= new List<Profesor>();
            profesores.Add(new Profesor { Apellidos ="poma",  Nombres= "frank"});
            profesores.Add(new Profesor { Apellidos = "canga", Nombres = "good" });
            dgprofesores.ItemsSource = profesores;

            MessageBox.Show(" dale u");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Cursos> cursos = new List<Cursos>();
            cursos.Add(new Cursos {Nombre="mate", Codigo="mat", Color="negor" });
            
            dgcursos.ItemsSource = cursos;
            MessageBox.Show("toda la vida");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            
            
        }
    }
}
