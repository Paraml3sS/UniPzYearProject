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
using System.Windows.Shapes;
using WpfApp.Infrastructure.Mediators;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for EditDialog.xaml
    /// </summary>
    public partial class EditDialog : Window, IDisposable
    {
        private EditUserDialogDirector _mediator;

        public EditDialog(EditUserDialogDirector mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        public void Dispose()
        {
            _mediator.Dispose();
            _mediator = null;
        }
    }
}
