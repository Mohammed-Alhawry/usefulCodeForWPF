using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.ViewModels;
using System.Collections.ObjectModel;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public static class UsersTransformer
{
    public static ObservableCollection<UserObjectViewModel> TransformToViewModels(IEnumerable<UserModel> users)
    {
        var collection = new ObservableCollection<UserObjectViewModel>();

        foreach (var userModel in users)
            collection.Add(new UserObjectViewModel(userModel));

        return collection;
    }
}
