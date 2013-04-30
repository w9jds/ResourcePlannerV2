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

namespace ResourcePlannerV2.Controls
{
    /// <summary>
    /// Interaction logic for ResourceTile.xaml
    /// </summary>
    public partial class ResourceTile : UserControl
    {
        public ResourceTile()
        {
            InitializeComponent();
        }





        /// <summary>
        /// Filters the resources based on selected planets
        /// </summary>
        //public void PopulateDesiredProduct()
        //{
        //    try
        //    {
        //        List<Boolean> CheckAll = new List<Boolean>();
        //        for (int i = 1; i < StoredData.Capacity; i += 2)
        //        {
        //            if (StoredData[i].Contains('+') == true)
        //            {
        //                CheckAll.Clear();
        //                String[] MultiPlanets = StoredData[i].Split('+');
        //                Boolean needCheck = new Boolean();
        //                for (int l = 0; l < MultiPlanets.Length; l++)
        //                {
        //                    if (MultiPlanets[l].Length > 1)
        //                        needCheck = true;
        //                }
        //                if (needCheck == true)
        //                {
        //                    for (int j = 0; j < MultiPlanets.Length; j++)
        //                    {

        //                        String[] From = MultiPlanets[j].Split(',');
        //                        List<Boolean> CheckEach = new List<Boolean>();
        //                        for (int m = 0; m < From.Length; m++)
        //                        {
        //                            for (int n = 0; n < Planets.Count; n++)
        //                            {
        //                                if (From[m].Equals(Planets[n]) == true)
        //                                {
        //                                    if (PlanetToggles[n] == true)
        //                                        CheckEach.Add(true);
        //                                    else
        //                                        CheckEach.Add(false);
        //                                }
        //                            }
        //                        }
        //                        if (CheckEach.Contains(true) == true)
        //                            CheckAll.Add(true);
        //                        else
        //                            CheckAll.Add(false);
        //                    }
        //                }
        //                else
        //                {
        //                    for (int m = 0; m < MultiPlanets.Length; m++)
        //                    {
        //                        for (int n = 0; n < Planets.Count; n++)
        //                        {
        //                            if (MultiPlanets[m].Equals(Planets[n]) == true)
        //                            {
        //                                if (PlanetToggles[n] == true)
        //                                    CheckAll.Add(true);
        //                                else
        //                                    CheckAll.Add(false);
        //                            }
        //                        }
        //                    }
        //                }
        //                if (CheckAll.Contains(false) == false)
        //                {
        //                    if (DesiredProduct.FindStringExact(StoredData[i - 1]) == -1)
        //                        DesiredProduct.Items.Add(StoredData[i - 1]);
        //                }
        //            }
        //            else
        //            {
        //                String[] From = StoredData[i].Split(',');
        //                for (int k = 0; k < From.Length; k++)
        //                {
        //                    for (int j = 0; j < Planets.Count; j++)
        //                    {
        //                        if ((From[k] == Planets[j]) && (PlanetToggles[j] == true))
        //                        {
        //                            if (DesiredProduct.FindStringExact(StoredData[i - 1]) == -1)
        //                                DesiredProduct.Items.Add(StoredData[i - 1]);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (ArgumentOutOfRangeException) { }
        //}


    }
}
