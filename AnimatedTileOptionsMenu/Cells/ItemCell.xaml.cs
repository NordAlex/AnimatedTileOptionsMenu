using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimatedTileOptionsMenu.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemCell : ViewCell
    {
        public ItemCell()
        {
            InitializeComponent();
        }

        private void OpenOptions(object sender, EventArgs args)
        {

        }
    }
}
