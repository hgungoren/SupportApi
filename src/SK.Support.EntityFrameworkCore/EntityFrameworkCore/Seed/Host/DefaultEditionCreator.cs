using Abp.Application.Editions;
using Abp.Application.Features;
using Microsoft.EntityFrameworkCore;
using SK.Support.Editions;
using SK.Support.ProductModels;
using SK.Support.Products;
using SK.Support.TechnicalServices;
using System.Collections.Generic;
using System.Linq;

namespace SK.Support.EntityFrameworkCore.Seed.Host
{
    public class DefaultEditionCreator
    {
        private readonly SupportDbContext _context;

        public DefaultEditionCreator(SupportDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                /* Add desired features to the standard edition, if wanted... */
            }
        }

        private void CreateFeatureIfNotExists(int editionId, string featureName, bool isEnabled)
        {
            if (_context.EditionFeatureSettings.IgnoreQueryFilters().Any(ef => ef.EditionId == editionId && ef.Name == featureName))
            {
                return;
            }

            _context.EditionFeatureSettings.Add(new EditionFeatureSetting
            {
                Name = featureName,
                Value = isEnabled.ToString(),
                EditionId = editionId
            });
            _context.SaveChanges();
        }


    }
    public class ProductSeed
    {
        private readonly SupportDbContext _context;

        public ProductSeed(SupportDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            _context.Products.RemoveRange(_context.Products);
            _context.SaveChanges(); 
            _context.ProductModels.RemoveRange(_context.ProductModels);
            _context.SaveChanges();

            List<Product> products = new List<Product>
                {

                    new Product {
                        ProductName = "ACCESS POINT",
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel { ModelName = "CISCO"},
                            new ProductModel { ModelName = "CISCO 898787"},
                            new ProductModel { ModelName = "D-LINK"}
                        }
                    },

                    new Product {
                        ProductName = "BARKOT OKUYUCU",
                        ProductModels =new List<ProductModel>
                        {
                            new ProductModel {ModelName="DS-3478"},
                            new ProductModel {ModelName="DS-3578 H�PS"},
                            new ProductModel {ModelName="DS-3578 H�PS-SR"},
                            new ProductModel {ModelName="DS-3578 SR"},
                            new ProductModel {ModelName="GRAN�T -G1911�"},
                            new ProductModel {ModelName="GRAN�T P�L 3.75V-2400.MAH"},
                            new ProductModel {ModelName="GS-SCAN 1695 USB"},
                            new ProductModel {ModelName="HAND HELD 4600G-USB"},
                            new ProductModel {ModelName="HONEYWELL XENON-1902"}
                        }

                    },

                    new Product {
                        ProductName = "BARKOT YAZICI" ,
                        ProductModels =new List<ProductModel>
                        {
                            new ProductModel {ModelName="DA-402"},
                            new ProductModel {ModelName="GC420T"},
                            new ProductModel {ModelName="GK420d"},
                            new ProductModel {ModelName="ZEBRA GC420d"},
                            new ProductModel {ModelName="ZEBRA LP-2844"},
                            new ProductModel {ModelName="ZEBRA TLP-2844"},
                            new ProductModel {ModelName="ZEBRA ZM 400"}
                        }

                    },

                    new Product {
                        ProductName = "BLACKBERRY" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="8100"},
                            new ProductModel {ModelName="8120"},
                            new ProductModel {ModelName="8520"},
                            new ProductModel {ModelName="8900"},
                            new ProductModel {ModelName="9000"},
                            new ProductModel {ModelName="9300"},
                            new ProductModel {ModelName="9360"},
                            new ProductModel {ModelName="9500"},
                            new ProductModel {ModelName="9700"},
                            new ProductModel {ModelName="9800"},
                            new ProductModel {ModelName="9860"}
                        }
                    },

                    new Product {
                        ProductName = "B�LGE DESTEK" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="B�LGE DESTEK"}
                        }
                    },

                    new Product {
                        ProductName = "CISCO IP PHONE" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="CISCO IP 7941"},
                            new ProductModel{ModelName="CISCO IP 7961"},
                            new ProductModel{ModelName="CISCO IP 7911"},
                            new ProductModel{ModelName="CISCO IP 7912"},
                            new ProductModel{ModelName="CISCO IP 7921"},
                            new ProductModel{ModelName="CISCO IP 7940"},
                            new ProductModel{ModelName="CISCO IP 7960"},
                            new ProductModel{ModelName="CISCO IP 7970"}
                        }
                    },

                    new Product {  ProductName = "deneme" },

                    new Product {
                        ProductName = "D��ER" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="D��ER"}
                        }
                    },

                    new Product {
                        ProductName = "DOME KAMERA" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="SAMSUNG"},
                            new ProductModel {ModelName ="VITEC"}
                        }
                    },

                    new Product {
                        ProductName = "DVR" ,
                        ProductModels =new List<ProductModel>
                        {
                            new ProductModel {ModelName="DAHUA 0404LE-AN"},
                            new ProductModel {ModelName="DAHUA -XVR5104HS-4PORT"},
                            new ProductModel {ModelName="M-BOX2"},
                            new ProductModel {ModelName="M�CEA ANALOG"},
                            new ProductModel {ModelName="M�CEA DVR C1604"},
                            new ProductModel {ModelName="M�CEA DVR0404LE-AS"},
                            new ProductModel {ModelName="M�CEA IP"},
                            new ProductModel {ModelName="M�CEA NVR 1600P"},
                            new ProductModel {ModelName="NEUTRON AHD 6104 5+1"},
                            new ProductModel {ModelName="NEUTRON AHD 9204 5+1"},
                            new ProductModel {ModelName="NEUTRON IP"},
                            new ProductModel {ModelName="NEUTRON TRA-7110 HD"},
                            new ProductModel {ModelName="NEUTROUN ANALOG"},
                            new ProductModel {ModelName="VITEC"}
                        }
                    },

                    new Product {
                        ProductName = "EL TERM�NAL" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="MOTOROLA MC-65-P�L�"},
                            new ProductModel {ModelName="MOTOROLA MC-65-CRADLE"},
                            new ProductModel {ModelName="HONEYWELL 9950-BATARYA"},
                            new ProductModel {ModelName="MOTOROLA MC-65 EL TERM�NAL�"},
                            new ProductModel {ModelName="HONEYWELL 9500-HBE TEKL�"},
                            new ProductModel {ModelName="HONEYWELL 9500-QC 4.L�"},
                            new ProductModel {ModelName="HONEYWELL 1902 XEON USB"},
                            new ProductModel {ModelName="HONEYWELL 9900 EL TERM�NAL�"},
                            new ProductModel {ModelName="HONEYWELL 9550 EL TERM�NAL�"},
                            new ProductModel {ModelName="HONEYWELL 99XX EL TERM�NAL�"},
                            new ProductModel {ModelName="MOTOROLA MC-65 ARA� USB �ARJ 5V"},
                            new ProductModel {ModelName="HONEYWELL EDA-51"},
                            new ProductModel {ModelName="HONEYWELL EDA-51 CRADLE"},
                            new ProductModel {ModelName="HONEYWELL EDA-51 P�L�"}
                        }
                    },

                    new Product {
                        ProductName = "FAKS C�HAZI" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="KAREL FM-111"},
                            new ProductModel {ModelName="KAREL-FM110"},
                            new ProductModel {ModelName="PANASONIC"}
                        }
                    },

                    new Product {
                        ProductName = "FOTO�RAF MAK�NASI" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="CANON"},
                            new ProductModel {ModelName="CASIO EXILIM"},
                            new ProductModel {ModelName="FUJIFILM"},
                            new ProductModel {ModelName="NIKON S6100"},
                            new ProductModel {ModelName="OLYMPUS D-700"},
                            new ProductModel {ModelName="OLYMPUS H-550WP"},
                            new ProductModel {ModelName="OLYMPUS N705"},
                            new ProductModel {ModelName="OLYMPUS T-3000"},
                            new ProductModel {ModelName="OLYMPUS U-5010"},
                            new ProductModel {ModelName="POLAROID I1237"},
                            new ProductModel {ModelName="PRAKTICA LM12-13"},
                            new ProductModel {ModelName="SAMSUNG ES95"}
                        }
                    },

                    new Product {
                        ProductName = "G�� KAYNA�I" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="SINUS SERIES RM"}
                        }
                    },

                    new Product {
                        ProductName = "HDD" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="K�NGSTON 120-SDD 2.5"},
                            new ProductModel {ModelName="SAMSUNG 500 HDD 2.5"},
                            new ProductModel {ModelName="SEAGATE 120-SDD 2.5"},
                            new ProductModel {ModelName="SEAGATE 1TB- BARRACUDA PC"},
                            new ProductModel {ModelName="SEAGATE 2TB- SKYHAWK 7-24"},
                            new ProductModel {ModelName="SEAGATE 500-HDD 2.5"},
                            new ProductModel {ModelName="TOSH�BA 2TB HDD 3,5 BARRACUDA"},
                            new ProductModel {ModelName="TOSH�BA 4TB- SKYHAWK 7-24"},
                            new ProductModel {ModelName="WD- 2TB-REL�AB�L�TY 7-24"}
                        }
                    },

                    new Product {
                        ProductName = "KA�IT ���T�C�",
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="EVEREST"}
                        }
                    },

                    new Product {
                        ProductName = "KAMERA ANOLOG",
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="DAHUA HFW1200RP"},
                            new ProductModel {ModelName="NEUTRON 7106 HD 1.3 MGP"},
                            new ProductModel {ModelName="NEUTRON 7110 HD 1.3 MGP"},
                            new ProductModel {ModelName="SAMSUNG"},
                            new ProductModel {ModelName="VITEC"}
                        }
                    },

                    new Product { ProductName = "KAMERA IP " },

                    new Product { ProductName = "KAMERA KORUYUCU" },

                    new Product {
                        ProductName = "LASER YAZICI",
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel {ModelName="CANON PIXMA G1400"},
                            new ProductModel {ModelName="BROTHER MFC-J220"},
                            new ProductModel {ModelName="DEVELOP"},
                            new ProductModel {ModelName="EPSON 4015"},
                            new ProductModel {ModelName="HP 1010"},
                            new ProductModel {ModelName="HP 1015"},
                            new ProductModel {ModelName="HP 1018"},
                            new ProductModel {ModelName="HP 1102"},
                            new ProductModel {ModelName="HP 1120 MFP"},
                            new ProductModel {ModelName="HP 1160"},
                            new ProductModel {ModelName="HP 1300N"},
                            new ProductModel {ModelName="HP 1320"},
                            new ProductModel {ModelName="HP 1536 MFP"},
                            new ProductModel {ModelName="HP 2420N"},
                            new ProductModel {ModelName="HP 3015"},
                            new ProductModel {ModelName="HP M 1132 MFP"},
                            new ProductModel {ModelName="HP M 1212NF"},
                            new ProductModel {ModelName="HP M 1217"},
                            new ProductModel {ModelName="HP PSC 2210"},
                            new ProductModel {ModelName="IMAGE RUNNER 1435�F"},
                            new ProductModel {ModelName="KYOCERA FS1128"},
                            new ProductModel {ModelName="LBP251DW"},
                            new ProductModel {ModelName="OKI B-6200"},
                            new ProductModel {ModelName="OKI MB451"},
                            new ProductModel {ModelName="SAMSUNG"},
                            new ProductModel {ModelName="XEROX"}
                        }
                    },

                    new Product {
                        ProductName = "LOCAL DESTEK" ,
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel {ModelName="CISCO IP PHONE"},
                            new ProductModel {ModelName="MOB�L AYGIT"},
                            new ProductModel {ModelName="MON�T�R"},
                            new ProductModel {ModelName="NETWORK"},
                            new ProductModel {ModelName="NOTEBOOK"},
                            new ProductModel {ModelName="PC KASA"},
                            new ProductModel {ModelName="YAZICI"},
                            new ProductModel {ModelName="YAZILIM"}
                        }
                    },

                    new Product {
                        ProductName = "MOB�L AYGIT",
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel {ModelName="APPLE IPAD"},
                            new ProductModel {ModelName="ASUS ZENFONE2 LAZER"},
                            new ProductModel {ModelName="BB MOBILE"},
                            new ProductModel {ModelName="BLACKBERRY 8100"},
                            new ProductModel {ModelName="BLACKBERRY 8120"},
                            new ProductModel {ModelName="BLACKBERRY 8520"},
                            new ProductModel {ModelName="BLACKBERRY 8900"},
                            new ProductModel {ModelName="BLACKBERRY 9000"},
                            new ProductModel {ModelName="BLACKBERRY 9300"},
                            new ProductModel {ModelName="BLACKBERRY 9360"},
                            new ProductModel {ModelName="BLACKBERRY 9500"},
                            new ProductModel {ModelName="BLACKBERRY 9700"},
                            new ProductModel {ModelName="BLACKBERRY 9800"},
                            new ProductModel {ModelName="BLACKBERRY 9860"},
                            new ProductModel {ModelName="Galaxy Xcover 2"},
                            new ProductModel {ModelName="GENARAL MOB�LE DISCOVERY"},
                            new ProductModel {ModelName="GENARAL MOB�LE ELITE"},
                            new ProductModel {ModelName="IPHONE 4"},
                            new ProductModel {ModelName="IPHONE 4 S"},
                            new ProductModel {ModelName="IPHONE 5"},
                            new ProductModel {ModelName="IPHONE 5 S"},
                            new ProductModel {ModelName="IPOD"},
                            new ProductModel {ModelName="LENOVO K920"},
                            new ProductModel {ModelName="NOKIA 113"},
                            new ProductModel {ModelName="NOKIA 1680"},
                            new ProductModel {ModelName="NOKIA 2330"},
                            new ProductModel {ModelName="NOKIA C1"},
                            new ProductModel {ModelName="SAMSUNG A7"},
                            new ProductModel {ModelName="SAMSUNG GT-E-1205Y"},
                            new ProductModel {ModelName="SAMSUNG S3"},
                            new ProductModel {ModelName="SAMSUNG S4"},
                            new ProductModel {ModelName="SAMSUNG S5"},
                            new ProductModel {ModelName="SAMSUNG TAB4"}
                        }
                    },

                    new Product {
                        ProductName = "MODEM",
                        ProductModels= new List<ProductModel>
                        {
                            new ProductModel {ModelName="HP"},
                            new ProductModel {ModelName="JUN�PER"},
                            new ProductModel {ModelName="TP L�NK"}
                        }
                    },

                    new Product {
                        ProductName = "MON�T�R",
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel {ModelName="15 inch LCD BENQ"},
                            new ProductModel {ModelName="17 inch ACER"},
                            new ProductModel {ModelName="17 inch HP"},
                            new ProductModel {ModelName="17 inch IBM"},
                            new ProductModel {ModelName="17 inch LG"},
                            new ProductModel {ModelName="17 inch PHILIPS"},
                            new ProductModel {ModelName="17 inch SAMSUNG"},
                            new ProductModel {ModelName="19 inch VESTEL"},
                            new ProductModel {ModelName="19 inch LG"},
                            new ProductModel {ModelName="ACER AF712"},
                            new ProductModel {ModelName="AOC"},
                            new ProductModel {ModelName="CBOX"},
                            new ProductModel {ModelName="COMPAQ"},
                            new ProductModel {ModelName="DELL"},
                            new ProductModel {ModelName="EXPER"},
                            new ProductModel {ModelName="NEC"},
                            new ProductModel {ModelName="VIEWSONIC"}
                        }
                    },

                    new Product {
                        ProductName = "NAVIGASYON" ,
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel {ModelName="NAVKING"}
                        }
                    },

                    new Product {
                        ProductName = "NOKTA VURU�LU YAZICI" ,
                        ProductModels= new List<ProductModel>
                        {
                            new ProductModel {ModelName="EPSON FX-890"},
                        }
                    },

                    new Product {
                        ProductName = "NOTEBOOK"
                    },

                    new Product {
                        ProductName = "PC KASASI" ,
                        ProductModels=new List<ProductModel> {
                            new ProductModel{ModelName="DELL"},
                            new ProductModel{ModelName ="D��ER"},
                            new ProductModel{ModelName ="HP"},
                            new ProductModel{ModelName ="IBM"},
                            new ProductModel{ModelName ="LENOVO"}
                        }
                    },

                    new Product {
                        ProductName = "PROJEKT�R",
                        ProductModels= new List<ProductModel> {
                            new ProductModel { ModelName="EPSON"},
                            new ProductModel { ModelName="LG"},
                            new ProductModel { ModelName="NEC"},
                            new ProductModel { ModelName="PANASONIC"},
                            new ProductModel { ModelName="SONY"}
                        }
                    },

                    new Product {
                        ProductName = "ROUTER" ,
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel { ModelName="CISCO 1721"},
                            new ProductModel { ModelName="CISCO 1751"},
                            new ProductModel { ModelName="CISCO 1760"},
                            new ProductModel { ModelName="CISCO 2801"},
                            new ProductModel { ModelName="CISCO 800 SERIES"},
                            new ProductModel { ModelName="CISCO 867 VAE"},
                            new ProductModel { ModelName="CISCO 870 SERIES"},
                            new ProductModel { ModelName="CISCO 877"},
                            new ProductModel { ModelName="CISCO 1700"},
                            new ProductModel { ModelName="GLOBESURFER III+"},
                            new ProductModel { ModelName="JUNIPER"}
                        }
                    },

                    new Product { ProductName = "SAMSUNG" },

                    new Product {
                        ProductName = "SWITCH" ,
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel { ModelName="CISCO EZXS16W"},
                            new ProductModel { ModelName="Di�er"},
                            new ProductModel { ModelName="EVEREST"},
                            new ProductModel { ModelName="HP"},
                            new ProductModel { ModelName="JUNIPER"},
                            new ProductModel { ModelName="SURECOM"}
                        }
                    },

                    new Product {
                        ProductName = "�AHS� ��LER",
                        ProductModels = new List<ProductModel>
                        {
                            new ProductModel { ModelName="MOB�L AYGIT"},
                            new ProductModel { ModelName="NOTEBOOK"},
                            new ProductModel { ModelName="PC KASA"}
                        }
                    },

                    new Product {
                        ProductName = "TABLET",
                        ProductModels= new List<ProductModel>
                        {
                            new ProductModel{ ModelName="SAMSUNG SM T532"}
                        }
                    },

                    new Product {
                        ProductName = "TARAYICI",
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel{ModelName="DEVELOP 4050" },
                            new ProductModel{ModelName="MICROTEK Artix Scan DI 2015C" },
                            new ProductModel{ModelName="OKI 451 MB" },
                        }
                    },

                    new Product {
                        ProductName = "THIN CLIENT",
                        ProductModels=new List<ProductModel>
                        {
                            new ProductModel{ ModelName="HP"},
                            new ProductModel{ ModelName="T5000"},
                            new ProductModel{ ModelName="T510"},
                            new ProductModel{ ModelName="T520"},
                            new ProductModel{ ModelName="T530"},
                            new ProductModel{ ModelName="T5510"},
                            new ProductModel{ ModelName="T5520"},
                            new ProductModel{ ModelName="T5540"},
                            new ProductModel{ ModelName="T5570"},
                            new ProductModel{ ModelName="T5570e"},
                            new ProductModel{ ModelName="T5710"},
                            new ProductModel{ ModelName="T5720"},
                            new ProductModel{ ModelName="T5730"},
                            new ProductModel{ ModelName="T5740"},
                            new ProductModel{ ModelName="T620"},
                            new ProductModel{ ModelName="WYSE DXOD"},
                            new ProductModel{ ModelName="WYSE H12V"},
                            new ProductModel{ ModelName="WYSE VX0"},
                            new ProductModel{ ModelName="ZX0"}
                        }
                    },
                };

            _context.Products.AddRangeAsync(products);
            _context.SaveChanges();

            /* Add desired features to the standard edition, if wanted... */

        }
    }


    public class TechnicalServiceSeed
    {
        private readonly SupportDbContext _context;

        public TechnicalServiceSeed(SupportDbContext context)
        {
            _context = context;
        }
        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            _context.TechnicalServices.RemoveRange(_context.TechnicalServices);
            _context.SaveChanges(); 

            List<TechnicalService> services = new List<TechnicalService>
                {

                    new TechnicalService {  Name="Bilgi Teknolojileri"},
                    new TechnicalService {  Name="Luna Bili�im" },
                    new TechnicalService {  Name="Perkon" },
                    new TechnicalService {  Name="Samsung Servis" },
                    new TechnicalService {  Name="Teknik Destek" },
                    new TechnicalService {  Name="ASM Elektronik" },
                    new TechnicalService {  Name="Neutron G�venlik" },
                    new TechnicalService {  Name="Test" },
                    new TechnicalService {  Name="R2 Servis" },
                    new TechnicalService {  Name="Kazal Bili�im" },
                    new TechnicalService {  Name="Sembol Bili�im" },
                    new TechnicalService {  Name="Demir Bili�im" },
                    new TechnicalService {  Name="D 7/24 Bili�im" },
                    new TechnicalService {  Name="Akabe Bili�im" },
                    new TechnicalService {  Name="Letme Repair" },
                    new TechnicalService {  Name="Arbil Bilgisayar" }
                };

            _context.TechnicalServices.AddRangeAsync(services);
            _context.SaveChanges();

            /* Add desired features to the standard edition, if wanted... */

        }
    }

    //public class FaultSeed
    //{
    //    private readonly SupportDbContext _context;

    //    public FaultSeed(SupportDbContext context)
    //    {
    //        _context = context;
    //    }
    //    public void Create()
    //    {
    //        CreateEditions();
    //    }

    //    private void CreateEditions()
    //    {
    //        _context.Faults.RemoveRange();
    //        _context.SaveChanges();

    //        List<Fault> faults = new List<Fault>
    //            {

    //                new Fault { FaultNumber=31035,FormNumber="SKYOK" ,ProductName="THIN CLIENT",ProductModelName="T5540",SerialNumber="MXL5491RYN",ArrivalDate=System.DateTime.Now,Region="Antalya B�lge Md.",Branch="Konyaalt� Acente",FaultDescription="A�ILMIYOR.",Status="KAZAL B�L���M",Result="",OutgoingSerialNumber="",Type="Genel M�d�rl�k",OutgoingDate=System.DateTime.Now,Notes="SERV�STE",ConsolationNumber="",Counter=2, ReplacementSent="" }
    //            };

    //        _context.Faults.AddRangeAsync(faults);
    //        _context.SaveChanges();

    //        /* Add desired features to the standard edition, if wanted... */

    //    }
    //}

}

