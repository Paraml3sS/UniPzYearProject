using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Infrastructure.Mediators.Interfaces
{
    public interface IDialogViewModel
    {
        event EventHandler RequestClose;
        bool IsEditComplete { get; set; }
    }
}
