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
    [Activity(Label = "RegisterView")]
    [MvxViewFor(typeof(MvxApp.Core.ViewModels.RegisterViewModel))]
    public class RegisterView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegisterView);

            var date = FindViewById<EditText>(Resource.Id.DateText);
            var title = FindViewById<EditText>(Resource.Id.TitleText);
            var detail = FindViewById<EditText>(Resource.Id.DetailText);
            var clear = FindViewById<Button>(Resource.Id.ClearButton);
            var set = this.CreateBindingSet<RegisterView, Core.ViewModels.RegisterViewModel>();
            set.Bind(date).To(vm => vm.Date);
            set.Bind(title).To(vm => vm.Title);
            set.Bind(detail).To(vm => vm.Text);
            set.Bind(clear).To(vm => vm.ClearCommand);
            set.Apply();
        }
    }
}