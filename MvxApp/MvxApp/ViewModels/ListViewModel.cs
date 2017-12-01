using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MvxApp.Core.Models;

using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MvxApp.Core.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        #region プロパティ
        private MvxObservableCollection<ToDo> _list;
        public MvxObservableCollection<ToDo> ToDoList => this._list;

        private IMvxCommand _back;
        public IMvxCommand BackCommand => this._back;
        #endregion

        #region コンストラクタ
        public ListViewModel()
        {
            this._list = new MvxObservableCollection<ToDo>();
            this._back = new MvxCommand(() =>
            {
                Mvx.Resolve<IMvxNavigationService>().Close(this);
            });
        }
        #endregion

        #region メソッド(override)
        public override Task Initialize()
        {
            ToDoList.AddRange(Holders.ToDoHolder.Current.ToDoList);
            return base.Initialize();
        }
        #endregion
    }
}
