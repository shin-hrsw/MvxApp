using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvxApp.Core.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        #region プロパティ
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        #endregion

        #region コンストラクタ
        public RegisterViewModel()
        {
            this.Date = DateTime.Today;
            this.Title = string.Empty;
            this.Text = string.Empty;
        }
        #endregion
    }
}
