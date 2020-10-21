using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Iscu_Paula_LAB2
{
    class DoughnutMachine
    {
        private DoughnutMachine myDoughnutMachine;
        private void frm_Loaded(object sender, RoutedEventArgs e)
        {
            myDoughnutMachine = newDoughnutMachine();
        }

        private DoughnutMachine newDoughnutMachine()
        {
            throw new NotImplementedException();
        }

        private int mRaisedGlazed;
        private int mRaisedSugar;
        private int mFilledLemon;
        private int mFilledChocolate;
        private int mFilledVanilla;
        private void glazedToolStripMenuItem_Click(object sender,RoutedEventArgs e)
        {
            glazedToolStripMenuItem_Click.IsChecked = true;

        }
       
    }
}