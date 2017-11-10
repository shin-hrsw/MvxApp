using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxApp.Core.Holders
{
    public class ToDoHolder
    {
        #region プロパティ
        private static ToDoHolder _instance = new ToDoHolder();
        /// <summary>
        /// インスタンス
        /// </summary>
        public static ToDoHolder Current { get => _instance; }

        private List<Models.ToDo> _list = new List<Models.ToDo>();
        /// <summary>
        /// ToDoリスト
        /// </summary>
        public List<Models.ToDo> ToDoList { get => this._list; }
        #endregion

        #region コンストラクタ
        // Singletonなのでコンストラクタはprivateにしておく
        private ToDoHolder() { }
        #endregion
    }
}
