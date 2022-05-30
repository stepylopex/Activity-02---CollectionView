using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOD04_PDC03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionView : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public CollectionView()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Anthony Taberde", Image = "avatar.png" });
            employees.Add(new Employee { DisplayName = "Melvin Tiangge",  Image = "avatar2.png" });
            employees.Add(new Employee { DisplayName = "John Cee", Image = "avatar3.png" });
            employees.Add(new Employee { DisplayName = "Paul Doe",  Image = "avatar4.png" });
            employees.Add(new Employee { DisplayName = "Peter River", Image = "avatar5.png" });
        }
    }
}
