using System;
using System.Windows;
using WpfApp.Infrastructure.Mediators.Interfaces;

namespace WpfApp.Infrastructure.Mediators
{
    public abstract class EditDialogDirector<T> : IDisposable, IDialogDirector<T> where T : IDialogViewModel, new()
    {
        private Window _dlg;
        protected T _vm;

        public Window Dialog {
            get => _dlg;
            protected set {
                _dlg = value;

                if (_dlg != null)
                {
                    Dispose();

                    _vm = new T();
                    _vm.IsEditComplete = false;
                    _vm.RequestClose += OnRequestClose;

                    _dlg.DataContext = _vm;
                }
            }
        }


        public T Result {
            get => _vm;
        }


        public bool? ShowDialog()
        {
            if (Dialog != null)
            {
                return Dialog.ShowDialog();
            } else { return false; }
        }

        private void OnRequestClose(object sender, EventArgs e)
        {
            if (Dialog != null)
            {
                Dialog.DialogResult = this.Result.IsEditComplete;
            }
        }

        public void Dispose()
        {
            if (_vm != null)
            {
                _vm.RequestClose -= OnRequestClose;
            }
        }
    }
}
