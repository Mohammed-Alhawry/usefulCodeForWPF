

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
                FullName = "laskdflsdkf",
                Price = 1928.1m
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf",
                Price = 1928.1m
            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf",
                Price = 1928.1m
            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf",
                Price = 112112128.1m
            },
            new MaterialModel
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf",
                Price = 1928.1m
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf",
                Price = 1928.1m
            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf",
                Price = 1928.1m
            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf",
                Price = 112112128.1m
            }
        };
    }
}
