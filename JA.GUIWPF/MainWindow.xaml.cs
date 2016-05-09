using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JA.netzwerkPlanBib;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace JA.GUIWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private netzwerkKomponenteList l = new netzwerkKomponenteList();
        private string ext = " ";
        public MainWindow()
        {
            InitializeComponent();
            listViewHandy.ItemsSource = this.l;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            /*if (textBoxHersteller.Text != "" || textBoxSNr.Text != "" || textBoxPreis.Text != "" || textBoxModell.Text != "")
            {*/
                netzwerkKomponente newItem = new netzwerkKomponente();
                newItem.Komponente = textBoxKomponente.Text;
                newItem.Gebaude = comboBox1.Text;
                newItem.Raum = comboBox2.Text;
                newItem.Date = datePicker1.Text;
                this.l.Add(newItem);
                textBlockOutput.Text = "Handy Hinzugefügt";
                listViewHandy.Items.Refresh();
            /*}
            else
            {
                textBlockOutput.Text = "Inkorrekte eingaben";
            }  */
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Datei (*.xml)|*.xml|DAT Datei (*.dat)|*.dat";
            if(saveFileDialog.ShowDialog() == true){
                string pname = saveFileDialog.FileName;                
                FileInfo fi = new FileInfo(pname);
                ext = fi.Extension;
                if (ext == ".dat")
                {
                    serialisierungsserver s1 = new binary();
                    l.ser(s1, pname, l);
                }
                if (ext == ".xml")
                {
                    serialisierungsserver s1 = new xml();
                    l.ser(s1, pname, l);
                }                
            }
        }

        private void buttonLaden_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Datei (*.xml)|*.xml|DAT Datei (*.dat)|*.dat";
            
            if (openFileDialog.ShowDialog() == true)
            {
                string pname = openFileDialog.FileName;
                FileInfo fi = new FileInfo(pname);
                ext = fi.Extension;
                if (ext == ".dat")
                {
                    serialisierungsserver s2 = new binary();
                    l.deser(s2, pname);

                    listViewHandy.ItemsSource = this.l;
                    listViewHandy.Items.Refresh();
                }
                if (ext == ".xml")
                {
                    serialisierungsserver s2 = new xml();
                    l.deser(s2, pname);

                    listViewHandy.ItemsSource = this.l;
                    listViewHandy.Items.Refresh();
                }                
                textBlockOutput.Text = "Geladen.";
            }            
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            if (comboBox1.SelectedIndex.Equals(0))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Raum 101");
                comboBox2.Items.Add("Raum 102");
                comboBox2.Items.Add("Raum 103");
                comboBox2.Items.Add("Raum 104");
                comboBox2.Items.Add("Raum 105");
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Raum 201");
                comboBox2.Items.Add("Raum 202");
                comboBox2.Items.Add("Raum 203");
                comboBox2.Items.Add("Raum 204");
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Raum 301");
                comboBox2.Items.Add("Raum 302");
                comboBox2.Items.Add("Raum 303");
                comboBox2.Items.Add("Raum 304");
                comboBox2.Items.Add("Raum 305");
                comboBox2.Items.Add("Raum 306");
                comboBox2.Items.Add("Raum 307");
                comboBox2.Items.Add("Raum 308");
            }
            else if (comboBox1.SelectedIndex.Equals(3))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Raum 401");
                comboBox2.Items.Add("Raum 402");
                comboBox2.Items.Add("Raum 403");
                comboBox2.Items.Add("Raum 404");
            }
        }

    }
}
