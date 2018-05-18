using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace XB_Configer
{
    public partial class ItemGroupUIGenerator : MetroFramework.Forms.MetroForm
    {
        public ItemGroupUIGenerator()
        {
            InitializeComponent();
        }

        public ItemGroupUIGenerator(IEnumerable<String> singleItems, IEnumerable<String> boolItems, IEnumerable<String> controlItems, Dictionary<String,IEnumerable<String>> groupContents)
        {
            InitializeComponent();
            if (singleItems != null && singleItems.Count() > 0 && boolItems != null && boolItems.Count() > 0 && controlItems!=null && controlItems.Count()>0)
            {
                for (int i = 0; i < singleItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[0].Nodes.Add(singleItems.ElementAt(i));
                }
                for (int i = 0; i < boolItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[1].Nodes.Add(boolItems.ElementAt(i));
                }
                for (int i = 0; i < controlItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[2].Nodes.Add(controlItems.ElementAt(i));
                }
            }
            this.metroComboBoxGroups.SelectedIndex = 0;
        }
    }
}
