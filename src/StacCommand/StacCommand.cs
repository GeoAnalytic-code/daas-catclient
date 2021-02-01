using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Stac;

namespace StacCommand
{
    class StacCommand
    {
        public static void ListChildrensItemsAndAssets(IStacCatalog catalog, string prefix = "", int limit = 2)
        {
            // Get children first (sub catalogs and collections)
            foreach (var child_any_version in catalog.GetChildren().Values.Take(limit) )
            {
                IStacCatalog child = child_any_version.UpgradeToCurrentVersion();
                Console.Out.WriteLine(prefix + child.Id + ": " + child.Description);

                foreach (var item_any_version in child.GetItems().Values.Take(limit))
                {
                    IStacItem item = item_any_version.UpgradeToCurrentVersion();
                    Console.Out.WriteLine(prefix + " " + item.Id);
                    foreach (var asset in item.Assets.Values)
                    {
                        Console.Out.WriteLine(prefix + " *[" + asset.MediaType + "] " + asset.Uri);
                    }
                }

                ListChildrensItemsAndAssets(child, prefix + " ");
            }
        }

        static void Main(string[] args)
        {
            IStacCatalog catalog_any_version;
            IStacCatalog catalog;

            if ( args.Length <= 0) 
            {
                Console.Out.WriteLine("usage: ");
                Console.Out.WriteLine("staccommand <stac Uri> ");
                return;
            }

            catalog_any_version = (IStacCatalog)StacFactory.Load(args[0]);
            catalog = catalog_any_version.UpgradeToCurrentVersion();

            Console.Out.WriteLine("STAC URI: " + catalog_any_version.Uri);
            Console.Out.WriteLine("Catalog ID:" + catalog_any_version.Id);
            Console.Out.WriteLine("Description: " + catalog_any_version.Description);
            Console.Out.WriteLine("STAC Version: " + catalog_any_version.StacVersion);


            ListChildrensItemsAndAssets(catalog);

        }


    }
}
