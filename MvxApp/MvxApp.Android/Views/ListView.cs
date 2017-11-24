using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace MvxApp.Droid.Views
{
    [Activity(Label = "一覧画面")]
    [MvxViewFor(typeof(MvxApp.Core.ViewModels.ListViewModel))]
    public class ListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListView);

            var back = FindViewById<Button>(Resource.Id.BackButton);

            var set = this.CreateBindingSet<ListView, Core.ViewModels.ListViewModel>();
            set.Bind(back).For("Click").To(vm => vm.BackCommand);
            set.Apply();
        }
    }
}