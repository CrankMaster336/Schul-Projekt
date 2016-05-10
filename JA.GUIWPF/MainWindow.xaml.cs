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
using System.Globalization;

namespace JA.GUIWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private netzwerkKomponenteList l = new netzwerkKomponenteList();
        private netzwerkKomponenteList l2 = new netzwerkKomponenteList();
        private CultureInfo ci = new CultureInfo("de-DE");
        private string ext = " ";
        public MainWindow()
        {
            InitializeComponent();
            listViewKomponente.ItemsSource = this.l;
            listView1.ItemsSource = this.l2;
            
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxKomponente.Text != "" && datePicker1.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                netzwerkKomponente newItem = new netzwerkKomponente();
                newItem.Komponente = textBoxKomponente.Text;
                newItem.Gebaude = comboBox1.Text;
                newItem.Raum = comboBox2.Text;
                DateTime utcdt = Convert.ToDateTime(datePicker1.Text);
                newItem.Date = utcdt.ToString("d", ci);
                this.l.Add(newItem);
                textBlockOutput.Text = "Erfolgreich eingetragen";
                listViewKomponente.Items.Refresh();
            }
            else
            {
                textBlockOutput.Text = "Inkorrekte eingaben";
            }  
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Datei (*.xml)|*.xml|JSON Datei (*.json)|*.json";
            if(saveFileDialog.ShowDialog() == true){
                string pname = saveFileDialog.FileName;                
                FileInfo fi = new FileInfo(pname);
                ext = fi.Extension;
                if (ext == ".json")
                {
                    serialisierungsserver s1 = new json();
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
            openFileDialog.Filter = "XML Datei (*.xml)|*.xml|JSON Datei (*.json)|*.json";
            
            if (openFileDialog.ShowDialog() == true)
            {
                string pname = openFileDialog.FileName;
                FileInfo fi = new FileInfo(pname);
                ext = fi.Extension;
                if (ext == ".json")
                {
                    serialisierungsserver s2 = new json();
                    l.deser(s2, pname);

                    listViewKomponente.ItemsSource = this.l;
                    listViewKomponente.Items.Refresh();
                }
                if (ext == ".xml")
                {
                    serialisierungsserver s2 = new xml();
                    l.deser(s2, pname);

                    listViewKomponente.ItemsSource = this.l;
                    listViewKomponente.Items.Refresh();
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
        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox3.SelectedIndex.Equals(0))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Raum 101");
                comboBox4.Items.Add("Raum 102");
                comboBox4.Items.Add("Raum 103");
                comboBox4.Items.Add("Raum 104");
                comboBox4.Items.Add("Raum 105");
            }
            else if (comboBox3.SelectedIndex.Equals(1))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Raum 201");
                comboBox4.Items.Add("Raum 202");
                comboBox4.Items.Add("Raum 203");
                comboBox4.Items.Add("Raum 204");
            }
            else if (comboBox3.SelectedIndex.Equals(2))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Raum 301");
                comboBox4.Items.Add("Raum 302");
                comboBox4.Items.Add("Raum 303");
                comboBox4.Items.Add("Raum 304");
                comboBox4.Items.Add("Raum 305");
                comboBox4.Items.Add("Raum 306");
                comboBox4.Items.Add("Raum 307");
                comboBox4.Items.Add("Raum 308");
            }
            else if (comboBox3.SelectedIndex.Equals(3))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Raum 401");
                comboBox4.Items.Add("Raum 402");
                comboBox4.Items.Add("Raum 403");
                comboBox4.Items.Add("Raum 404");
            }
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox4.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                listeKomponentenInRaum();
            }
            else
            {
                sucheText.Text = "Bitte korrekte Suchkriterien wählen.";
            }
            
        }

        private void listeKomponentenInRaum()
        {
            int foundCount = 0;
            this.l2.Clear();
            foreach (netzwerkKomponente prime in l)
            {
                if (prime.Raum == comboBox4.SelectedItem.ToString() && prime.Gebaude == comboBox3.SelectedItem.ToString().Remove(0, 38))
                {
                    this.l2.Add(prime);
                    foundCount++;
                }
            }
            if (foundCount > 0)
            {
                listView1.Items.Refresh();
                sucheText.Text = foundCount + " Ergebniss/e gefunden.";
            }
            else
            {
                this.l2.Clear();
                listView1.Items.Refresh();
                sucheText.Text = "Keine Ergebnisse gefunden.";
            }
        }
    }
}
