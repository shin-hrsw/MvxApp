using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;

namespace MvxApp.Core.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        #region プロパティ
        private DateTime _date;
        public DateTime Date
        {
            get => this._date;
            set { SetProperty(ref _date, value); }
        }

        private string _title;
        public string Title
        {
            get => this._title;
            set { SetProperty(ref _title, value); }
        }

        private string _detail;
        public string Detail
        {
            get => this._detail;
            set { SetProperty(ref _detail, value); }
        }

        private IMvxCommand _register;
        public IMvxCommand RegisterCommand => this._register;

        private IMvxCommand _clear;
        public IMvxCommand ClearCommand => this._clear;

        private IMvxCommand _list;
        public IMvxCommand ListCommand => this._list;
        #endregion

        #region コンストラクタ
        public RegisterViewModel()
        {
            this.Date = DateTime.Today;
            this.Title = string.Empty;
            this.Detail = string.Empty;
            this._register = new MvxCommand(Register);
            this._clear = new MvxCommand(Clear);
            this._list = new MvxCommand(List);
        }
        #endregion

        #region メソッド(private)
        private void Register()
        {
            var todo = new Models.ToDo()
            {
                Date = this.Date,
                Title = this.Title,
                Text = this.Detail
            };

            Holders.ToDoHolder.Current.ToDoList.Add(todo);
            Clear();
        }

        private void Clear()
        {
            this.Date = DateTime.Now;
            this.Title = string.Empty;
            this.Detail = string.Empty;
        }

        private void List()
        {
            Mvx.Resolve<IMvxNavigationService>().Navigate<ListViewModel>();
        }
        #endregion
    }
}
