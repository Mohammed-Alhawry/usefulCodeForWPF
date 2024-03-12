

using ExperimentalThingsUsingWPF.Models;

namespace ExperimentalThingsUsingWPF.Data;

public static class DataProvider
{
    public static List<Material> GetMaterials()
    {
        return new List<Material>
        {
            new Material
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf",
                Price = 1928.1m
            }
            ,new Material
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf",
                Price = 1928.1m
            }
            ,new Material
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf",
                Price = 1928.1m
            },
            new Material
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf",
                Price = 112112128.1m
            }
        };
    }
}
