using System;

namespace MvxApp.Core.Models
{
    public class ToDo
    {
        #region プロパティ
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        #endregion

        #region コンストラクタ
        public ToDo()
        {
            this.Date = DateTime.Today;
            this.Title = string.Empty;
            this.Text = string.Empty;
        }
        #endregion
    }
}
