using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Data;
using WpfApp2.Model;
using System.Linq;
using System.Data.Entity.Validation;

namespace WpfApp2

{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        Model1 _db = new Model1();
        public static DataGrid data;
        public MainWindow()

        {
            InitializeComponent();
            Load();
        }

        
      

        private void ImagePicker_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics |.jpg;.jpeg;.png |" +
            "JPEG(.jpg;.jpeg)|.jpg;.jpeg |" +
            "Portable Network Graphic(.png) |.png";
            if (op.ShowDialog() == true)
            {
                PersonPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { }

        /* WpfApp2.BiometricPlusDataSet biometricPlusDataSet = ((WpfApp2.BiometricPlusDataSet)(this.FindResource("biometricPlusDataSet")));
         // Załaduj dane do tabeli People. Możesz modyfikować ten kod w razie potrzeby.
         WpfApp2.BiometricPlusDataSetTableAdapters.PeopleTableAdapter biometricPlusDataSetPeopleTableAdapter = new WpfApp2.BiometricPlusDataSetTableAdapters.PeopleTableAdapter();
         biometricPlusDataSetPeopleTableAdapter.Fill(biometricPlusDataSet.People);
         System.Windows.Data.CollectionViewSource peopleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peopleViewSource")));
         peopleViewSource.View.MoveCurrentToFirst(); */
        private void Load()
        {
            MainData.ItemsSource = _db.MyEntities.ToList();
            data = MainData;
        }

        

        private void AddDB_Click(object sender, RoutedEventArgs e)
        {
            
            Person person = new Person();
            
            person.city = city.Text;
            person.zip = zipc.Text;
            person.street = strt.Text;
            if (isMale.IsChecked ?? false)
            {
                person.sex = "M";
            }
            if (isTrans.IsChecked ?? false)
            {
                person.sex = "T";
            }
            if (isFemale.IsChecked ?? false)
            {
                person.sex = "F";
            }
            person.name = fn.Text;
            person.surname = ln.Text;
            person.height = Convert.ToDouble(hght.Text);
            person.weight = Convert.ToDouble(wgth.Text);
            person.additional = add.Text;
            person.image = Convert.ToString(PersonPhoto.Source);
            person.house = house.Text;
            person.number = hnmb.Text;
            _db.MyEntities.Add(person);
            using (var db = new Model1())
            {
                db.MyEntities.Add(person);
                db.SaveChanges();
            }
            MainData.Items.Refresh();
            Load();

        }
    }
}
