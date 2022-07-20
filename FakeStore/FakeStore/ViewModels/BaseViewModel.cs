using FakeStore.Exceptions;
using FakeStore.Services;
using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FakeStore.ViewModels
{
    public class BaseViewModel : FreshBasePageModel
    {
        private IFakeStoreApi fakeStoreApi;
        protected IFakeStoreApi FakeStoreApi { get => fakeStoreApi; set => fakeStoreApi = value; }
        public bool isBusy { get; set; } = false;

        public ICommand LogoutCommand
        {
            get
            {
                return new Command(() =>
                {
                    CoreMethods.SwitchOutRootNavigation("LoginNavigationContainer");
                    CoreMethods.PopToRoot(false);
                });
            }
        }
        protected void Validate<T, U>(U model) where T : AbstractValidator<U>, new()
        {
            var validator = new T();
            var results = validator.Validate(model);
            bool success = results.IsValid;
            IList<ValidationFailure> failures = results.Errors;

            if (failures.Count > 0)
            {
                throw new FakeStoreApiException(failures[0].ErrorMessage);
            }
        }
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }
        public BaseViewModel()
        {

        }
    }
}
