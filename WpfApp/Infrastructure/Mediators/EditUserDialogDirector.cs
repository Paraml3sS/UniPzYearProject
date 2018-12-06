using WpfApp.Models;
using WpfApp.ViewModels;
using WpfApp.Views;

namespace WpfApp.Infrastructure.Mediators
{
    public class EditUserDialogDirector : EditDialogDirector<EditDialogViewModel>
    {
        public EditUserDialogDirector(User user)
        {
            Dialog = new EditDialog(this);
            (_vm as EditDialogViewModel).User = user;
        }
    }
}
