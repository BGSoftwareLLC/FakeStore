using FreshMvvm;
using System;

namespace SwiftMD.Mobile.App.Services
{
    class AppPageModelMapper : IFreshPageModelMapper
    {
        public string GetPageTypeName(Type pageModelType)
        {
            return pageModelType.AssemblyQualifiedName
                .Replace("ViewModel", "View");
        }
    }
}
