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

namespace ResourcePlannerV2
{
    /// <summary>
    /// Interaction logic for ResourcePanel.xaml
    /// </summary>
    public partial class ResourcePanel : UserControl
    {
        public ResourcePanel()
        {
            InitializeComponent();
        }

        private void ProductTierBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CalculateUsingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CalculateUsingBox.SelectedIndex == 0)
                UnitBlock.Text = "u³";
            else if (CalculateUsingBox.SelectedIndex == 1)
                UnitBlock.Text = "m³";
        }
    }
}
