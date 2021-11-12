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

namespace Biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro l;
        Biblioteca b;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            string autore=txt_autore.Text;
            string titolo = txt_titolo.Text;
            int annoPubblicazione = int.Parse(txt_annoPubblicazione.Text);
            string editore = txt_editore.Text;
            int numeroPagine= int.Parse(txt_nPagine.Text);

            l = new Libro(autore,titolo,annoPubblicazione,editore,numeroPagine);
            b.RiempiLista();
        }

        private void btn_visualizzaLibri_Click(object sender, RoutedEventArgs e)
        {
            lst_libriPresenti.Items.Add(b.ElencoLibri);
        }
        //commento 
    }
}
