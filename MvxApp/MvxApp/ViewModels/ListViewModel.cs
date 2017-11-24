using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MvxApp.Core.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        #region プロパティ
        private IMvxCommand _back;
        public IMvxCommand BackCommand => this._back;
        #endregion

        #region コンストラクタ
        public ListViewModel()
        {
            this._back = new MvxCommand(() =>
            {
                Mvx.Resolve<IMvxNavigationService>().Close(this);
            });
        }
        #endregion
    }
}
