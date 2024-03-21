

using ExperimentalThingsUsingWPF.Models;

namespace ExperimentalThingsUsingWPF.Data;

public static class DataProvider
{
    public static List<MaterialModel> GetMaterials()
    {
        return new List<MaterialModel>
        {
            new MaterialModel
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf"
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf"

            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf"

            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf"
            },
            new MaterialModel
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf"
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf"
            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf"
            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf"
            }
        };
    }
}
